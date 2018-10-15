using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using BlueBook.Common.Enums;
using BlueBook.Data;
using BlueBook.Data.Entities;
using BlueBook.Web.Models.ReleaseNotes;
using Microsoft.AspNetCore.Mvc;


namespace BlueBook.Web.Controllers
{
    public class ReleaseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReleaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Index Function
        public IActionResult Index()
        {
            var vm = new ListViewModel();
            vm.ReleaseNotes = _context.ReleaseNotes.Select(x => new ReleaseNoteDataModel
            {
                id = x.id,
                Name = x.Name,
                Date = x.Date,
                NumberOfTasks = x.Tasks.Count()
            }).ToList();
            return View(vm);
        }

        //Details Function
        public IActionResult Details(int id)
        {
            var vm = new DetailsViewModel();

            var releaseNote = _context.ReleaseNotes.FirstOrDefault(x => x.id == id);


            if (releaseNote == null)
            {
                return NotFound();
            }

            vm.Date = releaseNote.Date;
            vm.Name = releaseNote.Name;
            vm.NumberOfTasks = releaseNote.Tasks.Count();
 

            
            vm.Tasks = releaseNote.Tasks.Select(x => new TasksDataModel
            {
                  releasenote = x.ReleaseNoteid,
                  Application = x.Application,
                  TargetTaskType = x.TargetTaskType,
                  taskName = x.taskName,
                  taskNumber = x.taskNumber,
                  TaskDescriptions = x.TaskDescriptions.Select(y => new TaskDescriptionDataModel {
                        taskDescriptions = y.Description
                   }).ToList()
            }).ToList();

            return View(vm);
        }

        //Add Release View
        public IActionResult AddRelease()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddTasks (int id, [FromForm] BlueBook.Data.Entities.Task task)
        {
            var releaseNoteId = _context.ReleaseNotes.FirstOrDefault(x => x.id == id);
            var test = new TasksDataModel();
            try
            {
                if(ModelState.IsValid)
                {
                    task.ReleaseNoteid = 1003;
                    task.Application = (Application)1;
                    task.TargetTaskType = (TargetTaskType)1;

                    _context.Add(task);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }catch(DbUpdateException)
            {
                ModelState.AddModelError("", "unable to change changes");

            }
            return RedirectToAction(nameof(Index));
        }


        //Add Release function
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReleasePost([FromForm] ReleaseNote releaseNote)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _context.Add(releaseNote);
                    await _context.SaveChangesAsync();

                    //int id = releaseNote.id;
                    
                    return RedirectToAction("Details", new { releaseNote.id });
                }

            }catch(DbUpdateException)
            {
                ModelState.AddModelError("", "unable to change changes");
            }

            return View(releaseNote);

        }

        //Delete function
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            var releaseNote = _context.ReleaseNotes.FirstOrDefault(x => x.id == id);

            if (releaseNote == null)
            {
                return NotFound();
            }


            _context.ReleaseNotes.Remove(releaseNote);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));

        }


    }
}
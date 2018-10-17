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
    [Route("release")]
    public class ReleaseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReleaseController(ApplicationDbContext context)
        {
            _context = context;
        }


        //Index Function
        [HttpGet]
        [Route("")]
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
        [Route("Details/{releaseNoteId}")]
        public IActionResult Details(int releaseNoteId)
        {
            var vm = new DetailsViewModel();

            var releaseNote = _context.ReleaseNotes.FirstOrDefault(x => x.id == releaseNoteId);


            if (releaseNote == null)
            {
                return NotFound();
            }

            vm.Date = releaseNote.Date;
            vm.Name = releaseNote.Name;
            vm.NumberOfTasks = releaseNote.Tasks.Count();
            vm.ReleaseNotesid = releaseNote.id;

            
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
        [HttpGet]
        [Route("addRelease")]
        public IActionResult AddReleaseView()
        {
            return View();
        }


        [HttpPost]
        [Route("{releaseNoteId}/tasks/add")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddTasks ([FromRoute]int releaseNoteId, [FromForm] AddTaskViewModel model)
        {
            
            try
            {
                if(ModelState.IsValid)
                {
                    var task = new Tasks
                    {
                        Application = model.Application,
                        ReleaseNoteid = releaseNoteId,
                        TargetTaskType = model.TargetTaskType,
                        taskName = model.taskName,
                        taskNumber = model.taskNumber
                        
                    };

                    _context.Add(task);

                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details", new { releaseNoteId = releaseNoteId});
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
        [Route("add")]
        public async Task<IActionResult> AddRelease([FromForm] ReleaseNote releaseNote)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _context.Add(releaseNote);
                    await _context.SaveChangesAsync();
                    
                    
                    return RedirectToAction("Details" ,new { releaseNoteId = releaseNote.id    });
                }

            }catch(DbUpdateException)
            {
                ModelState.AddModelError("", "unable to change changes");
            }

            return View(releaseNote);

        }

        //Delete function
        [HttpGet]
        [Route("Delete/{releaseNoteId}")]
        public async Task<IActionResult> Delete(int releaseNoteId)
        {

            var releaseNote = _context.ReleaseNotes.FirstOrDefault(x => x.id == releaseNoteId);

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
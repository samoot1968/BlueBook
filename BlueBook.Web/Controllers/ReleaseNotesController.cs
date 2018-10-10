using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueBook.Data;
using BlueBook.Web.Models.ReleaseNotes;
using Microsoft.AspNetCore.Mvc;

namespace BlueBook.Web.Controllers
{
    public class ReleaseNotesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReleaseNotesController(ApplicationDbContext context)
        {
            _context = context;
        }

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

        public IActionResult Details(int id)
        {
            var vm = new DetailsViewMode();

            var releaseNote = _context.ReleaseNotes.FirstOrDefault(x => x.id == id); 


            if(releaseNote == null)
            {
                return NotFound();
            }

            vm.Date = releaseNote.Date;
            vm.Name = releaseNote.Name;
            vm.NumberOfTasks = releaseNote.Tasks.Count();


            vm.Tasks = releaseNote.Tasks.Select(x => new TasksDataModel
            {
                  Application = x.Application,
                  TargetTaskType = x.TargetTaskType,
                  taskName = x.taskName,
                  taskNumber = x.taskNumber,
                  TaskDescriptions = x.TaskDescriptions.Select(y => new TaskDescriptionDataModel {
                        taskDescription = y.Description
                   }).ToList()
            }).ToList();

            return View(vm);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BlueBook.Common.Enums;
using BlueBook.Data.Entities;

namespace BlueBook.Web.Models.ReleaseNotes
{
    public class DetailsViewModel
    {
        public int ReleaseNotesid { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int NumberOfTasks { get; set; }
        public List<TasksDataModel> Tasks { get; set; }
        public string taskNumber { get; set; }
        public string taskName { get; set; }
        public TargetTaskType TargetTaskType { get; set; }
        public Application Application { get; set; }
        public int releasenote;
        public int Id { get; set; }

    }
}

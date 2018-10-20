using BlueBook.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBook.Web.Models.ReleaseNotes
{
    public class AddTaskViewModel
    {
        public int releaseNoteId { get; set; }
        public string taskNumber { get; set; }
        public string taskName { get; set; }
        public TargetTaskType TargetTaskType { get; set; }
        public Application Application { get; set; }
        public string taskDescription { get; set; }
        public int TaskId { get; set; }
    }
}

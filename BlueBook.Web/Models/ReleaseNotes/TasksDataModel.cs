using BlueBook.Common.Enums;
using BlueBook.Data.Entities;
using System.Collections.Generic;

namespace BlueBook.Web.Models.ReleaseNotes
{
    public class TasksDataModel
    {
        public int Id { get; set; }
        public string taskNumber { get; set; }
        public string taskName { get; set; }
        public TargetTaskType TargetTaskType { get; set; }
        public Application Application { get; set; }
        public int releasenote { get; set; }
        public List<TaskDescriptionDataModel> TaskDescriptions { get; set; }
    }
}
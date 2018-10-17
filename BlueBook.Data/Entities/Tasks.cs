using BlueBook.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBook.Data.Entities
{
    public class Tasks
    {
        public int Id { get; set; }
        public string taskNumber { get; set; }
        public string taskName { get; set; }
        public TargetTaskType TargetTaskType { get; set; }
        public Application Application { get; set; }

        public int ReleaseNoteid { get; set; }
        public virtual ReleaseNote ReleaseNote {get; set;}

        public virtual ICollection<TaskDescription> TaskDescriptions { get; set; }
    }
}

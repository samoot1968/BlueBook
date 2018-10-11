using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBook.Web.Models.ReleaseNotes
{
    public class DetailsViewModel
    {

        public int id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int NumberOfTasks { get; set; }

        public List<TasksDataModel> Tasks { get; set; }
    }
}

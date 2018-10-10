using System;

namespace BlueBook.Web.Models.ReleaseNotes
{
    public class ReleaseNoteDataModel
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int NumberOfTasks { get; set; }
    }
}
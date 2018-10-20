using BlueBook.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq; 

namespace BlueBook.Data.Entities
{
    public class ReleaseNote
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}

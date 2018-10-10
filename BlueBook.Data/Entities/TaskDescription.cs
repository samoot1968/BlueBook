using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBook.Data.Entities
{
    public class TaskDescription
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual Task Task { get; set; }
    }
}

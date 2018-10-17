using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBook.Web.Models.ReleaseNotes
{
    public class ListViewModel
    {
        public int releaseNoteId { get; set; }
        public List<ReleaseNoteDataModel> ReleaseNotes { get; set; }
    }
}

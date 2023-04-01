using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotemanLibrary
{
    public class NoteModel
    {
        public string Title
        {
            get; set;
        }
        public string? Body
        {
            get; set;
        }
        public object? Attachment
        {
            get; set;
        }
        public DateTime Date
        {
            get; set;
        }
    }
}

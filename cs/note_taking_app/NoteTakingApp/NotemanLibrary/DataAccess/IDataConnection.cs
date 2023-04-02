using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotemanLibrary.Models;

namespace NotemanLibrary.DataAccess
{
    public interface IDataConnection
    {
        NoteModel CreateNote(NoteModel model);
    }
}

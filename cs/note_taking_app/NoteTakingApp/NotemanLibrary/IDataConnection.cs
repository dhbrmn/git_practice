using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotemanLibrary
{
    public interface IDataConnection
    {
        NoteModel CreateNote( NoteModel model );
    }
}

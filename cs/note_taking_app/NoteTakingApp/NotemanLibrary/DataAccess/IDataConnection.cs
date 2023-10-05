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
        NoteModel ReadNote(int id);
        NoteModel[] GetAllNotes();
        void DeleteNote( NoteModel model );
        int NotesNumber();
        void UpdateNote(NoteModel model );
        void StoreAttach( AttachmentModel attachment );
        AttachmentModel[] GetAllAttachments( );    
        void DeleteNoteWithAttachment (NoteModel model );
        AttachmentModel ReadAttachment( int id );
        int AttachmentNumber();
        void DeleteAttachment( AttachmentModel attachment );
        void CreateDb();
    }
}

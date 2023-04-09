using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotemanLibrary.Models
{
    public class AttachmentModel
    {
        /// <summary>
        /// Unique identifier for every attachment stored in database
        /// </summary>
        public int ID
        {
        get; set; 
        }
        /// <summary>
        /// Path to file stored as string
        /// </summary>
        public string Path
        {
        get; set; 
        }
        /// <summary>
        /// Fereign key identifier to link a note to an attachment
        /// </summary>
        public int NoteId
        {
        get; set; 
        }
        /// <summary>
        /// Date of storing attachment model in database
        /// </summary>
        public string Date
        {
            get; set;
        }
        /// <summary>
        /// Generic class setting method
        /// </summary>
        public AttachmentModel()
        {
        }
        /// <summary>
        /// Method to set a model linking the file path and NoteModel
        /// </summary>
        /// <param name="path">File path</param>
        /// <param name="note">NoteModel of the created note</param>
        public AttachmentModel( string path, NoteModel note )
        {
            Path = path;
            NoteId = note.ID;
            string date = DateTime.Now.ToString();
            Date = date;
        }
    }
}

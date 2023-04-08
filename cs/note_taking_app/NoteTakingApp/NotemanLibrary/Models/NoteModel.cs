using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotemanLibrary.Models
{
    public class NoteModel
    {
        /// <summary>
        /// Unique identifier for every note
        /// </summary>
        public int ID
        {
            get; set;
        }

        /// <summary>
        /// The title of the note
        /// </summary>
        public string Title
        {
            get; set;
        }

        /// <summary>
        /// The main text of the note
        /// </summary>
        public string? Body
        {
            get; set;
        }

        /// <summary>
        /// The date and time of creation or modification of a stored note
        /// </summary>
        public string Date
        {
            get; set;
        }
        public NoteModel()
        {
        }

        public NoteModel(string title)
        {
            Title = title;
            string date = DateTime.Now.ToString();
            Date = date;
        }

        public NoteModel(string title, string body)
        {
           Title = title;
           Body = body;
           string date = DateTime.Now.ToString();
           Date = date;
        }
    }
}

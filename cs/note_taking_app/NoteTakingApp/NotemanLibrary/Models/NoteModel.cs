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
        public int Id
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
        /// The list of attachments that are attached to a selected note
        /// </summary>
        //public List<object>? Attachment
        //{
        //    get; set;
        //}

        /// <summary>
        /// The date and time of creation or modification of a stored note
        /// </summary>
        //public string Date
        //{
        //    get; set;
        //}

        public NoteModel(string title/*, string date*/)
        {
            Title = title;
          //  Date = date;
        }

        public NoteModel(string title, string body/*, List<object> attachments, string date*/)
        {
           Title = title;
            Body = body;

            
        //     Attachment = attachments;
            
        //    Date = date;
        }
    }
}

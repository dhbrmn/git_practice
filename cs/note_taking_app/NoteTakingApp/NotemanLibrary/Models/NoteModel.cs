﻿using System;
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
        /// <summary>
        /// Generic NoteModel method
        /// </summary>
        public NoteModel()
        {
        }
        /// <summary>
        /// NoteModel method using the title
        /// </summary>
        /// <param name="title">String input used for the title</param>
        public NoteModel(string title)
        {
            Title = title;
            string date = DateTime.Now.ToString();
            Date = date;
        }
        /// <summary>
        /// NoteModel method that fully populates all fields
        /// </summary>
        /// <param name="title">String input used for the title</param>
        /// <param name="body">String input used for the body/content of the note</param>
        public NoteModel(string title, string body)
        {
           Title = title;
           Body = body;
           string date = DateTime.Now.ToString();
           Date = date;
        }
    }
}

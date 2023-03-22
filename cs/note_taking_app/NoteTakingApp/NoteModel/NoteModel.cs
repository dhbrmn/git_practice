﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public class NoteModel
    {
        public string Title
        {
            get; set;
        }

        public string? Note
        {
            get; set;
        }

        public object? Attachment
        {
            get; set;
        }

        public DateTime LastEdit
        {
            get; set; 
        }
    }
}

using NotemanLibrary;
using NotemanLibrary.DataAccess;
using NotemanLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class NewNoteForm : Form
    {
        public NewNoteForm()
        {
            InitializeComponent();
        }

        private void saveNoteButton_Click( object sender, EventArgs e )
        {
            if (ValidateForm())
            {
                string date = DateTime.UtcNow.ToString();
                NoteModel model = new(titleTextBox.Text, noteBodyTextBox.Text/*, attachListBox.Items, date*/);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateNote(model);
                }

                MessageBox.Show("Note saved.");

                titleTextBox.Text = "New Note";
                noteBodyTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("This note has no title. Please input a title.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (String.IsNullOrEmpty(titleTextBox.Text))
            {
                output = false;
            }

            return output;
        }

        private void cancelNewNoteButton_Click( object sender, EventArgs e )
        {
            Close();
        }

    }
}

using NotemanLibrary.DataAccess;
using NotemanLibrary;
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
    public partial class EditNoteForm : Form
    {
        public static NoteModel editModel = new NoteModel();
        public EditNoteForm()
        {
            InitializeComponent();
        }

        private void EditNoteForm_Load( object sender, EventArgs e )
        {
            editModel = MainForm.curentModel;
            titleTextBox.Text = editModel.Title;
            noteBodyTextBox.Text = editModel.Body;
        }

        private void cancelNewNoteButton_Click( object sender, EventArgs e )
        {
            DialogResult dr = MessageBox.Show("Close without saving?", "Are you sure?", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void saveNoteButton_Click( object sender, EventArgs e )
        {
            if (ValidateForm())
            {
                editModel.Title = titleTextBox.Text;
                editModel.Body = noteBodyTextBox.Text;
                string date = DateTime.Now.ToString();
                editModel.Date = date;
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.UpdateNote(editModel);
                }

                MessageBox.Show("Note edited.");
                Close();
            }
            else
            {
                MessageBox.Show("You haven't made any changes to the note.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            bool oldTitle = titleTextBox.Text == editModel.Title;
            bool oldBody = noteBodyTextBox.Text == editModel.Body;
            if (oldTitle && oldBody)
            {
                output = false;
            }
            return output;
        }
    }
}

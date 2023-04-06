using Microsoft.Data.Sqlite;
using NotemanLibrary;
using NotemanLibrary.DataAccess;
using NotemanLibrary.Models;
using System.Reflection;
using System.Linq;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newNoteButton_Click( object sender, EventArgs e )
        {
            NewNoteForm newNoteForm = new NewNoteForm();
            newNoteForm.ShowDialog();
        }

        private void editNoteButton_Click( object sender, EventArgs e )
        {
            EditNoteForm editNoteForm = new EditNoteForm();
            editNoteForm.ShowDialog();
        }

        private void selectNoteDropDown_DropDown( object sender, EventArgs e )
        {
            if (ValidateDatabase())
            {
                NoteModel[] notesArray = { };
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    notesArray = db.GetAllNotes();
                }
                selectNoteDropDown.DataSource = notesArray;
                selectNoteDropDown.DisplayMember = "Title";
            }
            else
            {
                MessageBox.Show("There are no saved notes to select.");
            }
        }

        private void selectNoteDropDown_SelectedIndexChanged( object sender, EventArgs e )
        {
            NoteModel model = (NoteModel)selectNoteDropDown.SelectedItem;
            titleTextBox.Text = model.Title;
            noteBodyTextBox.Text = model.Body;
            lastDateLabel.Text = model.Date;
        }

        private void deleteNoteButton_Click( object sender, EventArgs e )
        {
            NoteModel model = (NoteModel)selectNoteDropDown.SelectedItem;
            DialogResult dr = MessageBox.Show("Really delete note? It will be gone forever.", "Are you sure?", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    foreach (IDataConnection db in GlobalConfig.Connections)
                    {
                        db.DeleteNote(model);
                    }
                    titleTextBox.Clear();
                    noteBodyTextBox.Clear();
                    lastDateLabel.Text = "";
                    break;
                case DialogResult.No:
                    break;
            }

        }
        private bool ValidateDatabase()
        {
            bool output = true;
            int rows;
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                rows = db.RowsNumber();
                if (rows <= 0)
                {
                    output = false;
                }
            }
            return output;
        }

    }
}
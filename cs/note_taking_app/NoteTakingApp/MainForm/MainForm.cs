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
        public static NoteModel curentModel = new NoteModel();
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
                // TODO - make a custom method to populate dropdown datasource
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

        public void selectNoteDropDown_SelectedIndexChanged( object sender, EventArgs e )
        {
            curentModel = (NoteModel)selectNoteDropDown.SelectedItem;
            titleTextBox.Text = curentModel.Title;
            noteBodyTextBox.Text = curentModel.Body;
            lastDateLabel.Text = curentModel.Date;
        }

        private void deleteNoteButton_Click( object sender, EventArgs e )
        {
            DialogResult dr = MessageBox.Show("Really delete note? It will be gone forever.", "Are you sure?", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    NoteModel[] notesArray = { };
                    foreach (IDataConnection db in GlobalConfig.Connections)
                    {
                        db.DeleteNote(curentModel);
                        notesArray = db.GetAllNotes();
                    }
                    selectNoteDropDown.DataSource= notesArray;
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
                rows = db.NotesNumber();
                if (rows <= 0)
                {
                    output = false;
                }
            }
            return output;
        }

    }
}
using Microsoft.Data.Sqlite;
using NotemanLibrary;
using NotemanLibrary.DataAccess;
using NotemanLibrary.Models;
using System.Reflection;
using System.Linq;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;


namespace MainForm
{
    public partial class MainForm : Form
    {
        public static NoteModel curentModel = new NoteModel();
        public static AttachmentModel[] attachmentsArray = { };
        public static ObservableCollection<AttachmentModel> Attachments = new ObservableCollection<AttachmentModel>();
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
                    attachmentsArray = db.GetAllAttachments();

                }
                selectNoteDropDown.DataSource = notesArray;
                selectNoteDropDown.DisplayMember = "Title";
                Attachments.Clear();
                attachListBox.DataSource = null;
                titleTextBox.Text = null;
                noteBodyTextBox.Text = null;
                lastDateLabel.Text = null;
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
            foreach (AttachmentModel attachmentModel in attachmentsArray)
            {
                if (curentModel.ID == attachmentModel.NoteId)
                {
                    Attachments.Add(attachmentModel);
                }
            }
            attachListBox.DataSource = null;
            attachListBox.DataSource = Attachments;
            attachListBox.DisplayMember = "Name";
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
                    selectNoteDropDown.DataSource = notesArray;
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

        private void openAttachmentButton_Click( object sender, EventArgs e )
        {
            int attachIndex = attachListBox.SelectedIndex;
            AttachmentModel attachment = Attachments[attachIndex];
            string filePath = attachment.AttachmentPath;
            if(File.Exists(filePath))
            {
                Process.Start("explorer.exe",filePath);
            }
            else
            {
                MessageBox.Show("File does not exist.");
            }
        }
    }
}
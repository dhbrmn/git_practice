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
        /// <summary>
        /// Placeholder for note selection.
        /// </summary>
        public static NoteModel curentModel = new NoteModel();

        /// <summary>
        /// Placeholder for array of attachments read from the database.
        /// </summary>
        public static AttachmentModel[] attachmentsArray = { };

        /// <summary>
        /// Place holder for collection of attachments saved in buffer while viewing notes.
        /// </summary>
        public static ObservableCollection<AttachmentModel> Attachments = new ObservableCollection<AttachmentModel>();

        /// <summary>
        /// Opens the form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to clear out UI
        /// </summary>
        private void ClearUI()
        {
            Attachments.Clear();
            selectNoteDropDown.DataSource = null;
            attachListBox.DataSource = null;
            titleTextBox.Text = null;
            noteBodyTextBox.Text = null;
            lastDateLabel.Text = null;

        }
        /// <summary>
        /// When clicking the newNoteButton opens the NewNoteForm in a new window.
        /// </summary>
        private void newNoteButton_Click( object sender, EventArgs e )
        {
            NewNoteForm newNoteForm = new NewNoteForm();
            newNoteForm.ShowDialog();
            ClearUI();
        }

        /// <summary>
        /// When clicking the editNoteButton opens the EditNoteForm in a new window.
        /// </summary>
        private void editNoteButton_Click( object sender, EventArgs e )
        {
            //If function allows opening of form only if a note is selected in the dropdown.
            if (selectNoteDropDown.SelectedItem != null)
            {
                EditNoteForm editNoteForm = new EditNoteForm();
                editNoteForm.ShowDialog();
                ClearUI();
            }
            else
            {
                MessageBox.Show("You must select a note you wish to edit.");
            }
        }

        /// <summary>
        /// Populates the dropdown menu with an array.
        /// </summary>
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

                //Functions for UI behaviour
                ClearUI();
                selectNoteDropDown.DataSource = notesArray;
                selectNoteDropDown.DisplayMember = "Title";
            }
            else
            {
                MessageBox.Show("There are no saved notes to select.");
            }
        }

        /// <summary>
        /// Populates the UI with information based on the note selected in the dropdown menu.
        /// </summary>
        public void selectNoteDropDown_SelectionChangeCommited( object sender, EventArgs e )
        {
            if (ValidateDatabase())
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
            }

            //Functions for UI behaviour
            attachListBox.DataSource = null;
            attachListBox.DataSource = Attachments;
            attachListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Deletes the selected NoteModel and AttachmentModel/s (if there are any) upon clicking the deleteNoteButton.
        /// </summary>
        private void deleteNoteButton_Click( object sender, EventArgs e )
        {
            DialogResult dr = MessageBox.Show("Really delete note? It will be gone forever.", "Are you sure?", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    NoteModel[] notesArray = { };
                    if (Attachments.Count > 0)
                    {
                        foreach (IDataConnection db in GlobalConfig.Connections)
                        {
                            db.DeleteNoteWithAttachment(curentModel);
                            notesArray = db.GetAllNotes();
                        }
                    }
                    else
                    {
                        foreach (IDataConnection db in GlobalConfig.Connections)
                        {
                            db.DeleteNote(curentModel);
                            notesArray = db.GetAllNotes();
                        }
                    }
                    ClearUI();
                    break;

                case DialogResult.No:
                    break;
            }

        }

        /// <summary>
        /// Performs a database read check if there are any entries in the database.
        /// </summary>
        /// <returns>False indicator if there are no rows stored in the database.</returns>
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

        /// <summary>
        /// Opens selected attachment item via explorer.exe.
        /// </summary>
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
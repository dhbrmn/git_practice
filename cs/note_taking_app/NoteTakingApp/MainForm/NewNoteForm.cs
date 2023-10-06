using NotemanLibrary;
using NotemanLibrary.DataAccess;
using NotemanLibrary.Models;
using System.Collections.ObjectModel;

namespace MainForm
{
    public partial class NewNoteForm : Form
    {
        /// <summary>
        /// Placeholder for the Attachments Collection
        /// </summary>
        public static ObservableCollection<AttachmentModel> Attachments = new ObservableCollection<AttachmentModel>();
        /// <summary>
        /// Initializes the form
        /// </summary>
        public NewNoteForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Save button creates new entries for NoteModel and AttachmentModels in the database
        /// </summary>
        private void saveNoteButton_Click( object sender, EventArgs e )
        {
            if (ValidateForm())
            {
                var model = new NoteModel(titleTextBox.Text, noteBodyTextBox.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateNote(model);

                    if (Attachments?.Any() == true)
                    {
                        foreach (AttachmentModel attachment in Attachments)
                        {
                            attachment.NoteId = model.ID;
                            db.StoreAttach(attachment);
                        }
                    }
                }

                MessageBox.Show("Note saved.");
                Attachments.Clear();
                Close();

            }

            else
            {
                MessageBox.Show("This note has no title. Please input a title.");
            }
        }
        /// <summary>
        /// Validates if the input has minimum requirements to create a NoteModel which is a title
        /// </summary>
        /// <returns>Bool if a title has been inputed</returns>
        private bool ValidateForm()
        {
            return !string.IsNullOrWhiteSpace(titleTextBox.Text);
        }
        /// <summary>
        /// Cancel button closes the form without saving
        /// </summary>
        private void cancelNewNoteButton_Click( object sender, EventArgs e )
        {
            DialogResult dr = MessageBox.Show("Close without saving?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }
        /// <summary>
        /// Browse attachment button allows user to select files through file explorer and add them to the note
        /// </summary>
        private void browseAttachButton_Click( object sender, EventArgs e )
        {
            //File explorer to select file to add
            browseAttachDialog.InitialDirectory = "%USERPROFILE%";
            string path = "";
            if (browseAttachDialog.ShowDialog() == DialogResult.OK)
            {
                path = browseAttachDialog.FileName;
            }
            AttachmentModel attachment = new AttachmentModel(path);

            //Check for duplicates loop
            bool duplicate = false;
            foreach (AttachmentModel item in Attachments)
            {
                if (item.AttachmentPath == attachment.AttachmentPath)
                {
                    duplicate = true;
                    MessageBox.Show("You have already added this file to your note.");
                }
            }

            //Check if there is already 3 attachments
            bool attachmentsMaximum = Attachments.Count > 2;
            if (attachmentsMaximum)
            {
                MessageBox.Show("You can only add 3 files to a note.");
            }

            //Adds attachment to collection
            if (!duplicate && !attachmentsMaximum)
            {
                Attachments.Add(attachment);
            }

            //Reset UI
            attachListBox.DataSource = null;
            attachListBox.DataSource = Attachments;
            attachListBox.DisplayMember = "Name";
        }
        /// <summary>
        /// Remove attachment button removes the selected attachment from the Attachments Collection
        /// </summary>
        private void deleteAttachButton_Click( object sender, EventArgs e )
        {
            int attachIndex = attachListBox.SelectedIndex;
            Attachments.RemoveAt( attachIndex );
            attachListBox.DataSource = null;
            attachListBox.DataSource = Attachments;
            attachListBox.DisplayMember = "Name";
        }
    }
}

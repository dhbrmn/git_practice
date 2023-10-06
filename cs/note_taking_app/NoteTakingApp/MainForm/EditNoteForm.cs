using NotemanLibrary.DataAccess;
using NotemanLibrary;
using NotemanLibrary.Models;
using System.Collections.ObjectModel;

namespace MainForm
{
    public partial class EditNoteForm : Form
    {
        /// <summary>
        /// Placeholder for NoteModel to be edited
        /// </summary>
        public static NoteModel editModel = new NoteModel();
        /// <summary>
        /// Placeholder for changes made to the Attachments Collection
        /// </summary>
        public static ObservableCollection<AttachmentModel> Attachments = new ObservableCollection<AttachmentModel>();
        /// <summary>
        /// Placeholder for current Attachments Collection
        /// </summary>
        public static ObservableCollection<AttachmentModel> OldAttachments = new ObservableCollection<AttachmentModel>();
        /// <summary>
        /// Initializes Form
        /// </summary>
        public EditNoteForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Loads information from the main form to the edit form
        /// </summary>
        private void EditNoteForm_Load( object sender, EventArgs e )
        {
            editModel = MainForm.curentModel;
            titleTextBox.Text = editModel.Title;
            noteBodyTextBox.Text = editModel.Body;
            foreach (AttachmentModel attachment in MainForm.Attachments )
            {
                OldAttachments.Add( attachment );
                Attachments.Add( attachment );
            }
            attachListBox.DataSource = Attachments;
            attachListBox.DisplayMember = "Name";
        }
        /// <summary>
        /// Cancel button functions as exit without saving changes
        /// </summary>
        private void cancelNewNoteButton_Click( object sender, EventArgs e )
        {
            DialogResult dr = MessageBox.Show("Close without saving?", "Are you sure?", MessageBoxButtons.YesNo);
            if ( dr == DialogResult.Yes )
            {
                Close();
            }
        }
        /// <summary>
        /// Save button rewrites the NoteModel and AttachmentModels in the database
        /// </summary>
        private void saveNoteButton_Click( object sender, EventArgs e )
        {
            if (ValidateForm())
            {
                editModel.Title = titleTextBox.Text;
                editModel.Body = noteBodyTextBox.Text;
                editModel.Date = DateTime.Now.ToString();
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.UpdateNote(editModel);

                    if (!Attachments.SequenceEqual(OldAttachments))
                    {
                        foreach (AttachmentModel attachment in OldAttachments)
                        {
                            db.DeleteAttachment(attachment);
                        }
                        foreach (AttachmentModel attachment in Attachments)
                        {
                            attachment.NoteId = editModel.ID;
                            db.StoreAttach(attachment);
                        }
                    }
                }
                    MessageBox.Show("Note edited.");
                    OldAttachments.Clear();
                    Attachments.Clear();
                    Close();  
            }
            else
            {
                MessageBox.Show("You haven't made any changes to the note.");
            }
        }
        /// <summary>
        /// Validates if the NoteModel has changed
        /// </summary>
        /// <returns>Boolean if the NoteModel has changed</returns>
        private bool ValidateForm()
        {
            bool output = true;
            bool oldTitle = titleTextBox.Text == editModel.Title;
            bool oldBody = noteBodyTextBox.Text == editModel.Body;
            bool oldAttachments = Attachments.SequenceEqual(OldAttachments);
            if (oldTitle && oldBody && oldAttachments)
            {
                output = false;
            }
            return output;
        }
        /// <summary>
        /// Removes the selected attachment from the Attachments Collection
        /// </summary>
        private void deleteAttachButton_Click( object sender, EventArgs e )
        {
            int attachIndex = attachListBox.SelectedIndex;
            Attachments.RemoveAt(attachIndex);
            attachListBox.DataSource = null;
            attachListBox.DataSource = Attachments;
            attachListBox.DisplayMember = "Name";
        }
        /// <summary>
        /// Using file explorer the user can select files to add as attachments to the note
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
            if (!duplicate && !attachmentsMaximum )
            {
                Attachments.Add(attachment);
            }

            //Refresh the UI
            attachListBox.DataSource = null;
            attachListBox.DataSource = Attachments;
            attachListBox.DisplayMember = "Name";
        }
    }
}

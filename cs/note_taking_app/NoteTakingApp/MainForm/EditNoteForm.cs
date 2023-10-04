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
using System.Collections.ObjectModel;
using System.Reflection;

namespace MainForm
{
    public partial class EditNoteForm : Form
    {
        public static NoteModel editModel = new NoteModel();
        public static ObservableCollection<AttachmentModel> Attachments = new ObservableCollection<AttachmentModel>();
        public static ObservableCollection<AttachmentModel> OldAttachments = new ObservableCollection<AttachmentModel>();

        public EditNoteForm()
        {
            InitializeComponent();
        }

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
                if (OldAttachments != Attachments)
                {
                    foreach (AttachmentModel attachment in OldAttachments)
                    {
                        foreach (IDataConnection db in GlobalConfig.Connections)
                        {
                            db.DeleteAttachment(attachment);
                        }
                    }

                    foreach (AttachmentModel attachment in Attachments)
                    {
                        attachment.NoteId = editModel.ID;
                        foreach (IDataConnection db in GlobalConfig.Connections)
                        {
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

        private bool ValidateForm()
        {
            bool output = true;
            bool oldTitle = titleTextBox.Text == editModel.Title;
            bool oldBody = noteBodyTextBox.Text == editModel.Body;
            bool oldAttachments = Attachments == OldAttachments;
            if (oldTitle && oldBody && oldAttachments)
            {
                output = false;
            }
            return output;
        }

        private void deleteAttachButton_Click( object sender, EventArgs e )
        {
            int attachIndex = attachListBox.SelectedIndex;
            Attachments.RemoveAt(attachIndex);
            attachListBox.DataSource = null;
            attachListBox.DataSource = Attachments;
            attachListBox.DisplayMember = "Name";
        }

        private void browseAttachButton_Click( object sender, EventArgs e )
        {
            browseAttachDialog.InitialDirectory = "%USERPROFILE%";
            string path = "";
            string fileName = "";
            if (browseAttachDialog.ShowDialog() == DialogResult.OK)
            {
                path = browseAttachDialog.FileName;
            }
            AttachmentModel attachment = new AttachmentModel(path);
            Attachments.Add(attachment);
            attachListBox.DataSource = null;
            attachListBox.DataSource = Attachments;
            attachListBox.DisplayMember = "Name";
        }
    }
}

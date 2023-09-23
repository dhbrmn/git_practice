using NotemanLibrary;
using NotemanLibrary.DataAccess;
using NotemanLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class NewNoteForm : Form
    {
        public static ObservableCollection<AttachmentModel> Attachments = new ObservableCollection<AttachmentModel>();
        public NewNoteForm()
        {
            InitializeComponent();
        }

        private void saveNoteButton_Click( object sender, EventArgs e )
        {
            if (ValidateForm())
            {
                NoteModel model = new(titleTextBox.Text, noteBodyTextBox.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateNote(model);
                }
                if (Attachments?.Any() ?? false)
                {
                    foreach (AttachmentModel attachment in Attachments)
                    {
                        attachment.NoteId = model.ID;
                        foreach (IDataConnection db in GlobalConfig.Connections)
                        {
                            db.StoreAttach(attachment);
                        }
                    }
                }

                MessageBox.Show("Note saved.");
                Close();
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

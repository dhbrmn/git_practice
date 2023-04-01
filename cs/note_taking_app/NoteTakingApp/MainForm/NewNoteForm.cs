using NotemanLibrary;
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
                NoteModel model = new NoteModel(titleTextBox.Text, noteBodyTextBox.Text, /*attachListBox.Items,*/ DateTime.Now);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateNote(model);
                }
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

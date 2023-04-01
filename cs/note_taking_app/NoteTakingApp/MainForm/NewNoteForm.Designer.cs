namespace MainForm
{
    partial class NewNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNoteForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.noteBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.noteBodyLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addAttachLabel = new System.Windows.Forms.Label();
            this.attachListBox = new System.Windows.Forms.ListBox();
            this.browseAttachButton = new System.Windows.Forms.Button();
            this.cancelNewNoteButton = new System.Windows.Forms.Button();
            this.saveNoteButton = new System.Windows.Forms.Button();
            this.browseAttachDialog = new System.Windows.Forms.OpenFileDialog();
            this.deleteAttachButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(671, 65);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Noteman - Create a New Note";
            // 
            // noteBodyTextBox
            // 
            this.noteBodyTextBox.Location = new System.Drawing.Point(26, 142);
            this.noteBodyTextBox.Name = "noteBodyTextBox";
            this.noteBodyTextBox.Size = new System.Drawing.Size(387, 324);
            this.noteBodyTextBox.TabIndex = 10;
            this.noteBodyTextBox.Text = "";
            // 
            // noteBodyLabel
            // 
            this.noteBodyLabel.AutoSize = true;
            this.noteBodyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noteBodyLabel.ForeColor = System.Drawing.Color.Green;
            this.noteBodyLabel.Location = new System.Drawing.Point(26, 109);
            this.noteBodyLabel.Name = "noteBodyLabel";
            this.noteBodyLabel.Size = new System.Drawing.Size(66, 30);
            this.noteBodyLabel.TabIndex = 9;
            this.noteBodyLabel.Text = "Note:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(91, 71);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(598, 35);
            this.titleTextBox.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Green;
            this.titleLabel.Location = new System.Drawing.Point(26, 74);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 30);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title:";
            // 
            // addAttachLabel
            // 
            this.addAttachLabel.AutoSize = true;
            this.addAttachLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAttachLabel.ForeColor = System.Drawing.Color.Green;
            this.addAttachLabel.Location = new System.Drawing.Point(464, 142);
            this.addAttachLabel.Name = "addAttachLabel";
            this.addAttachLabel.Size = new System.Drawing.Size(178, 30);
            this.addAttachLabel.TabIndex = 11;
            this.addAttachLabel.Text = "Add Atachments:";
            // 
            // attachListBox
            // 
            this.attachListBox.FormattingEnabled = true;
            this.attachListBox.ItemHeight = 30;
            this.attachListBox.Location = new System.Drawing.Point(464, 175);
            this.attachListBox.Name = "attachListBox";
            this.attachListBox.Size = new System.Drawing.Size(225, 94);
            this.attachListBox.TabIndex = 13;
            // 
            // browseAttachButton
            // 
            this.browseAttachButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.browseAttachButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.browseAttachButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.browseAttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseAttachButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseAttachButton.ForeColor = System.Drawing.Color.Green;
            this.browseAttachButton.Location = new System.Drawing.Point(495, 275);
            this.browseAttachButton.Name = "browseAttachButton";
            this.browseAttachButton.Size = new System.Drawing.Size(163, 37);
            this.browseAttachButton.TabIndex = 14;
            this.browseAttachButton.Text = "Browse";
            this.browseAttachButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.browseAttachButton.UseVisualStyleBackColor = true;
            // 
            // cancelNewNoteButton
            // 
            this.cancelNewNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.cancelNewNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.cancelNewNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.cancelNewNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelNewNoteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelNewNoteButton.ForeColor = System.Drawing.Color.Green;
            this.cancelNewNoteButton.Location = new System.Drawing.Point(584, 399);
            this.cancelNewNoteButton.Name = "cancelNewNoteButton";
            this.cancelNewNoteButton.Size = new System.Drawing.Size(105, 67);
            this.cancelNewNoteButton.TabIndex = 16;
            this.cancelNewNoteButton.Text = "Cancel";
            this.cancelNewNoteButton.UseVisualStyleBackColor = true;
            // 
            // saveNoteButton
            // 
            this.saveNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.saveNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.saveNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.saveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNoteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveNoteButton.ForeColor = System.Drawing.Color.Green;
            this.saveNoteButton.Location = new System.Drawing.Point(464, 399);
            this.saveNoteButton.Name = "saveNoteButton";
            this.saveNoteButton.Size = new System.Drawing.Size(105, 67);
            this.saveNoteButton.TabIndex = 15;
            this.saveNoteButton.Text = "Save Note";
            this.saveNoteButton.UseVisualStyleBackColor = true;
            // 
            // browseAttachDialog
            // 
            this.browseAttachDialog.Filter = "All files|*.*";
            this.browseAttachDialog.InitialDirectory = "C:\\\\";
            // 
            // deleteAttachButton
            // 
            this.deleteAttachButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.deleteAttachButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.deleteAttachButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.deleteAttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAttachButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteAttachButton.ForeColor = System.Drawing.Color.Green;
            this.deleteAttachButton.Location = new System.Drawing.Point(495, 318);
            this.deleteAttachButton.Name = "deleteAttachButton";
            this.deleteAttachButton.Size = new System.Drawing.Size(163, 37);
            this.deleteAttachButton.TabIndex = 17;
            this.deleteAttachButton.Text = "Remove";
            this.deleteAttachButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.deleteAttachButton.UseVisualStyleBackColor = true;
            // 
            // NewNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.deleteAttachButton);
            this.Controls.Add(this.cancelNewNoteButton);
            this.Controls.Add(this.saveNoteButton);
            this.Controls.Add(this.browseAttachButton);
            this.Controls.Add(this.attachListBox);
            this.Controls.Add(this.addAttachLabel);
            this.Controls.Add(this.noteBodyTextBox);
            this.Controls.Add(this.noteBodyLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "NewNoteForm";
            this.Text = "Create New Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private RichTextBox noteBodyTextBox;
        private Label noteBodyLabel;
        private TextBox titleTextBox;
        private Label titleLabel;
        private Label addAttachLabel;
        private ListBox attachListBox;
        private Button browseAttachButton;
        private Button cancelNewNoteButton;
        private Button saveNoteButton;
        private OpenFileDialog browseAttachDialog;
        private Button deleteAttachButton;
    }
}
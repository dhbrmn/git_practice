namespace MainForm
{
    partial class EditNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNoteForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.deleteAttachButton = new System.Windows.Forms.Button();
            this.cancelNewNoteButton = new System.Windows.Forms.Button();
            this.saveNoteButton = new System.Windows.Forms.Button();
            this.browseAttachButton = new System.Windows.Forms.Button();
            this.attachListBox = new System.Windows.Forms.ListBox();
            this.addAttachLabel = new System.Windows.Forms.Label();
            this.noteBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.noteBodyLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.browseAttachDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(468, 65);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Noteman - Edit Note";
            // 
            // deleteAttachButton
            // 
            this.deleteAttachButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.deleteAttachButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.deleteAttachButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.deleteAttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAttachButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteAttachButton.ForeColor = System.Drawing.Color.Green;
            this.deleteAttachButton.Location = new System.Drawing.Point(497, 318);
            this.deleteAttachButton.Name = "deleteAttachButton";
            this.deleteAttachButton.Size = new System.Drawing.Size(163, 37);
            this.deleteAttachButton.TabIndex = 27;
            this.deleteAttachButton.Text = "Remove";
            this.deleteAttachButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.deleteAttachButton.UseVisualStyleBackColor = true;
            // 
            // cancelNewNoteButton
            // 
            this.cancelNewNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.cancelNewNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.cancelNewNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.cancelNewNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelNewNoteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelNewNoteButton.ForeColor = System.Drawing.Color.Green;
            this.cancelNewNoteButton.Location = new System.Drawing.Point(586, 399);
            this.cancelNewNoteButton.Name = "cancelNewNoteButton";
            this.cancelNewNoteButton.Size = new System.Drawing.Size(105, 67);
            this.cancelNewNoteButton.TabIndex = 26;
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
            this.saveNoteButton.Location = new System.Drawing.Point(466, 399);
            this.saveNoteButton.Name = "saveNoteButton";
            this.saveNoteButton.Size = new System.Drawing.Size(105, 67);
            this.saveNoteButton.TabIndex = 25;
            this.saveNoteButton.Text = "Save Note";
            this.saveNoteButton.UseVisualStyleBackColor = true;
            // 
            // browseAttachButton
            // 
            this.browseAttachButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.browseAttachButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.browseAttachButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.browseAttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseAttachButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseAttachButton.ForeColor = System.Drawing.Color.Green;
            this.browseAttachButton.Location = new System.Drawing.Point(497, 275);
            this.browseAttachButton.Name = "browseAttachButton";
            this.browseAttachButton.Size = new System.Drawing.Size(163, 37);
            this.browseAttachButton.TabIndex = 24;
            this.browseAttachButton.Text = "Browse";
            this.browseAttachButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.browseAttachButton.UseVisualStyleBackColor = true;
            // 
            // attachListBox
            // 
            this.attachListBox.FormattingEnabled = true;
            this.attachListBox.ItemHeight = 30;
            this.attachListBox.Location = new System.Drawing.Point(466, 175);
            this.attachListBox.Name = "attachListBox";
            this.attachListBox.Size = new System.Drawing.Size(225, 94);
            this.attachListBox.TabIndex = 23;
            // 
            // addAttachLabel
            // 
            this.addAttachLabel.AutoSize = true;
            this.addAttachLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAttachLabel.ForeColor = System.Drawing.Color.Green;
            this.addAttachLabel.Location = new System.Drawing.Point(466, 142);
            this.addAttachLabel.Name = "addAttachLabel";
            this.addAttachLabel.Size = new System.Drawing.Size(178, 30);
            this.addAttachLabel.TabIndex = 22;
            this.addAttachLabel.Text = "Add Atachments:";
            // 
            // noteBodyTextBox
            // 
            this.noteBodyTextBox.Location = new System.Drawing.Point(23, 142);
            this.noteBodyTextBox.Name = "noteBodyTextBox";
            this.noteBodyTextBox.Size = new System.Drawing.Size(387, 324);
            this.noteBodyTextBox.TabIndex = 21;
            this.noteBodyTextBox.Text = "";
            // 
            // noteBodyLabel
            // 
            this.noteBodyLabel.AutoSize = true;
            this.noteBodyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noteBodyLabel.ForeColor = System.Drawing.Color.Green;
            this.noteBodyLabel.Location = new System.Drawing.Point(23, 109);
            this.noteBodyLabel.Name = "noteBodyLabel";
            this.noteBodyLabel.Size = new System.Drawing.Size(66, 30);
            this.noteBodyLabel.TabIndex = 20;
            this.noteBodyLabel.Text = "Note:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(88, 71);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(603, 35);
            this.titleTextBox.TabIndex = 19;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Green;
            this.titleLabel.Location = new System.Drawing.Point(23, 74);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 30);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "Title:";
            // 
            // browseAttachDialog
            // 
            this.browseAttachDialog.Filter = "All files|*.*";
            this.browseAttachDialog.InitialDirectory = "c:\\\\";
            this.browseAttachDialog.Multiselect = true;
            // 
            // EditNoteForm
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
            this.Name = "EditNoteForm";
            this.Text = "Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Button deleteAttachButton;
        private Button cancelNewNoteButton;
        private Button saveNoteButton;
        private Button browseAttachButton;
        private ListBox attachListBox;
        private Label addAttachLabel;
        private RichTextBox noteBodyTextBox;
        private Label noteBodyLabel;
        private TextBox titleTextBox;
        private Label titleLabel;
        private OpenFileDialog browseAttachDialog;
    }
}
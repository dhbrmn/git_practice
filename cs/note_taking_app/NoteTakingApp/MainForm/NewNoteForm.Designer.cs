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
            headerLabel =  new Label() ;
            noteBodyTextBox =  new RichTextBox() ;
            noteBodyLabel =  new Label() ;
            titleTextBox =  new TextBox() ;
            titleLabel =  new Label() ;
            addAttachLabel =  new Label() ;
            attachListBox =  new ListBox() ;
            browseAttachButton =  new Button() ;
            cancelNewNoteButton =  new Button() ;
            saveNoteButton =  new Button() ;
            browseAttachDialog =  new OpenFileDialog() ;
            deleteAttachButton =  new Button() ;
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize =  true ;
            headerLabel.Font =  new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point) ;
            headerLabel.ForeColor =  Color.DarkGreen ;
            headerLabel.Location =  new Point(12, 9) ;
            headerLabel.Name =  "headerLabel" ;
            headerLabel.Size =  new Size(671, 65) ;
            headerLabel.TabIndex =  1 ;
            headerLabel.Text =  "Noteman - Create a New Note" ;
            // 
            // noteBodyTextBox
            // 
            noteBodyTextBox.Location =  new Point(26, 142) ;
            noteBodyTextBox.Name =  "noteBodyTextBox" ;
            noteBodyTextBox.Size =  new Size(387, 324) ;
            noteBodyTextBox.TabIndex =  10 ;
            noteBodyTextBox.Text =  "" ;
            // 
            // noteBodyLabel
            // 
            noteBodyLabel.AutoSize =  true ;
            noteBodyLabel.Font =  new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point) ;
            noteBodyLabel.ForeColor =  Color.Green ;
            noteBodyLabel.Location =  new Point(26, 109) ;
            noteBodyLabel.Name =  "noteBodyLabel" ;
            noteBodyLabel.Size =  new Size(66, 30) ;
            noteBodyLabel.TabIndex =  9 ;
            noteBodyLabel.Text =  "Note:" ;
            // 
            // titleTextBox
            // 
            titleTextBox.Location =  new Point(91, 71) ;
            titleTextBox.Name =  "titleTextBox" ;
            titleTextBox.Size =  new Size(598, 35) ;
            titleTextBox.TabIndex =  8 ;
            titleTextBox.Text =  "New Note" ;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize =  true ;
            titleLabel.Font =  new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point) ;
            titleLabel.ForeColor =  Color.Green ;
            titleLabel.Location =  new Point(26, 74) ;
            titleLabel.Name =  "titleLabel" ;
            titleLabel.Size =  new Size(59, 30) ;
            titleLabel.TabIndex =  7 ;
            titleLabel.Text =  "Title:" ;
            // 
            // addAttachLabel
            // 
            addAttachLabel.AutoSize =  true ;
            addAttachLabel.Font =  new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point) ;
            addAttachLabel.ForeColor =  Color.Green ;
            addAttachLabel.Location =  new Point(464, 142) ;
            addAttachLabel.Name =  "addAttachLabel" ;
            addAttachLabel.Size =  new Size(178, 30) ;
            addAttachLabel.TabIndex =  11 ;
            addAttachLabel.Text =  "Add Atachments:" ;
            // 
            // attachListBox
            // 
            attachListBox.FormattingEnabled =  true ;
            attachListBox.ItemHeight =  30 ;
            attachListBox.Location =  new Point(464, 175) ;
            attachListBox.Name =  "attachListBox" ;
            attachListBox.Size =  new Size(225, 94) ;
            attachListBox.TabIndex =  13 ;
            // 
            // browseAttachButton
            // 
            browseAttachButton.FlatAppearance.BorderColor =  Color.Green ;
            browseAttachButton.FlatAppearance.MouseDownBackColor =  Color.Green ;
            browseAttachButton.FlatAppearance.MouseOverBackColor =  Color.PaleGreen ;
            browseAttachButton.FlatStyle =  FlatStyle.Flat ;
            browseAttachButton.Font =  new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
            browseAttachButton.ForeColor =  Color.Green ;
            browseAttachButton.Location =  new Point(495, 275) ;
            browseAttachButton.Name =  "browseAttachButton" ;
            browseAttachButton.Size =  new Size(163, 37) ;
            browseAttachButton.TabIndex =  14 ;
            browseAttachButton.Text =  "Browse" ;
            browseAttachButton.TextImageRelation =  TextImageRelation.TextAboveImage ;
            browseAttachButton.UseVisualStyleBackColor =  true ;
            // 
            // cancelNewNoteButton
            // 
            cancelNewNoteButton.FlatAppearance.BorderColor =  Color.Green ;
            cancelNewNoteButton.FlatAppearance.MouseDownBackColor =  Color.Green ;
            cancelNewNoteButton.FlatAppearance.MouseOverBackColor =  Color.PaleGreen ;
            cancelNewNoteButton.FlatStyle =  FlatStyle.Flat ;
            cancelNewNoteButton.Font =  new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
            cancelNewNoteButton.ForeColor =  Color.Green ;
            cancelNewNoteButton.Location =  new Point(584, 399) ;
            cancelNewNoteButton.Name =  "cancelNewNoteButton" ;
            cancelNewNoteButton.Size =  new Size(105, 67) ;
            cancelNewNoteButton.TabIndex =  16 ;
            cancelNewNoteButton.Text =  "Cancel" ;
            cancelNewNoteButton.UseVisualStyleBackColor =  true ;
            cancelNewNoteButton.Click +=  cancelNewNoteButton_Click ;
            // 
            // saveNoteButton
            // 
            saveNoteButton.FlatAppearance.BorderColor =  Color.Green ;
            saveNoteButton.FlatAppearance.MouseDownBackColor =  Color.Green ;
            saveNoteButton.FlatAppearance.MouseOverBackColor =  Color.PaleGreen ;
            saveNoteButton.FlatStyle =  FlatStyle.Flat ;
            saveNoteButton.Font =  new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
            saveNoteButton.ForeColor =  Color.Green ;
            saveNoteButton.Location =  new Point(464, 399) ;
            saveNoteButton.Name =  "saveNoteButton" ;
            saveNoteButton.Size =  new Size(105, 67) ;
            saveNoteButton.TabIndex =  15 ;
            saveNoteButton.Text =  "Save Note" ;
            saveNoteButton.UseVisualStyleBackColor =  true ;
            saveNoteButton.Click +=  saveNoteButton_Click ;
            // 
            // browseAttachDialog
            // 
            browseAttachDialog.Filter =  "All files|*.*" ;
            browseAttachDialog.InitialDirectory =  "C:\\\\" ;
            // 
            // deleteAttachButton
            // 
            deleteAttachButton.FlatAppearance.BorderColor =  Color.Green ;
            deleteAttachButton.FlatAppearance.MouseDownBackColor =  Color.Green ;
            deleteAttachButton.FlatAppearance.MouseOverBackColor =  Color.PaleGreen ;
            deleteAttachButton.FlatStyle =  FlatStyle.Flat ;
            deleteAttachButton.Font =  new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
            deleteAttachButton.ForeColor =  Color.Green ;
            deleteAttachButton.Location =  new Point(495, 318) ;
            deleteAttachButton.Name =  "deleteAttachButton" ;
            deleteAttachButton.Size =  new Size(163, 37) ;
            deleteAttachButton.TabIndex =  17 ;
            deleteAttachButton.Text =  "Remove" ;
            deleteAttachButton.TextImageRelation =  TextImageRelation.TextAboveImage ;
            deleteAttachButton.UseVisualStyleBackColor =  true ;
            // 
            // NewNoteForm
            // 
            AutoScaleDimensions =  new SizeF(12F, 30F) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  Color.White ;
            ClientSize =  new Size(714, 491) ;
            Controls.Add(deleteAttachButton);
            Controls.Add(cancelNewNoteButton);
            Controls.Add(saveNoteButton);
            Controls.Add(browseAttachButton);
            Controls.Add(attachListBox);
            Controls.Add(addAttachLabel);
            Controls.Add(noteBodyTextBox);
            Controls.Add(noteBodyLabel);
            Controls.Add(titleTextBox);
            Controls.Add(titleLabel);
            Controls.Add(headerLabel);
            Font =  new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point) ;
            FormBorderStyle =  FormBorderStyle.FixedToolWindow ;
            Icon =  (Icon) resources.GetObject("$this.Icon")  ;
            Margin =  new Padding(5, 6, 5, 6) ;
            MaximizeBox =  false ;
            MdiChildrenMinimizedAnchorBottom =  false ;
            MinimizeBox =  false ;
            Name =  "NewNoteForm" ;
            Text =  "Create New Note" ;
            ResumeLayout(false);
            PerformLayout();
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
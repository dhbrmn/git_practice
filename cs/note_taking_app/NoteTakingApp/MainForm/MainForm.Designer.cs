using NotemanLibrary.Models;

namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            headerLabel =  new Label() ;
            selectNoteLabel =  new Label() ;
            selectNoteDropDown =  new ComboBox() ;
            titleLabel =  new Label() ;
            titleTextBox =  new TextBox() ;
            noteBodyLabel =  new Label() ;
            noteBodyTextBox =  new RichTextBox() ;
            attachLabel =  new Label() ;
            lastDateOnLabel =  new Label() ;
            lastDateLabel =  new Label() ;
            editNoteButton =  new Button() ;
            newNoteButton =  new Button() ;
            openAttachmentButton =  new Button() ;
            attachListBox =  new ListBox() ;
            deleteNoteButton =  new Button() ;
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize =  true ;
            headerLabel.Font =  new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point) ;
            headerLabel.ForeColor =  Color.DarkGreen ;
            headerLabel.Location =  new Point(6, 9) ;
            headerLabel.Name =  "headerLabel" ;
            headerLabel.Size =  new Size(713, 65) ;
            headerLabel.TabIndex =  0 ;
            headerLabel.Text =  "Noteman - The Note Taking App" ;
            // 
            // selectNoteLabel
            // 
            selectNoteLabel.AutoSize =  true ;
            selectNoteLabel.Font =  new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point) ;
            selectNoteLabel.ForeColor =  Color.Green ;
            selectNoteLabel.Location =  new Point(23, 74) ;
            selectNoteLabel.Name =  "selectNoteLabel" ;
            selectNoteLabel.Size =  new Size(174, 40) ;
            selectNoteLabel.TabIndex =  1 ;
            selectNoteLabel.Text =  "Select Note:" ;
            // 
            // selectNoteDropDown
            // 
            selectNoteDropDown.DropDownStyle =  ComboBoxStyle.DropDownList ;
            selectNoteDropDown.FormattingEnabled =  true ;
            selectNoteDropDown.Location =  new Point(190, 79) ;
            selectNoteDropDown.Name =  "selectNoteDropDown" ;
            selectNoteDropDown.Size =  new Size(337, 38) ;
            selectNoteDropDown.TabIndex =  2 ;
            selectNoteDropDown.DropDown +=  selectNoteDropDown_DropDown ;
            selectNoteDropDown.SelectionChangeCommitted +=  selectNoteDropDown_SelectionChangeCommited ;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize =  true ;
            titleLabel.Font =  new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point) ;
            titleLabel.ForeColor =  Color.Green ;
            titleLabel.Location =  new Point(23, 144) ;
            titleLabel.Name =  "titleLabel" ;
            titleLabel.Size =  new Size(59, 30) ;
            titleLabel.TabIndex =  3 ;
            titleLabel.Text =  "Title:" ;
            // 
            // titleTextBox
            // 
            titleTextBox.Location =  new Point(88, 139) ;
            titleTextBox.Name =  "titleTextBox" ;
            titleTextBox.ReadOnly =  true ;
            titleTextBox.Size =  new Size(355, 35) ;
            titleTextBox.TabIndex =  4 ;
            // 
            // noteBodyLabel
            // 
            noteBodyLabel.AutoSize =  true ;
            noteBodyLabel.Font =  new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point) ;
            noteBodyLabel.ForeColor =  Color.Green ;
            noteBodyLabel.Location =  new Point(23, 189) ;
            noteBodyLabel.Name =  "noteBodyLabel" ;
            noteBodyLabel.Size =  new Size(66, 30) ;
            noteBodyLabel.TabIndex =  5 ;
            noteBodyLabel.Text =  "Note:" ;
            // 
            // noteBodyTextBox
            // 
            noteBodyTextBox.Location =  new Point(23, 222) ;
            noteBodyTextBox.Name =  "noteBodyTextBox" ;
            noteBodyTextBox.ReadOnly =  true ;
            noteBodyTextBox.Size =  new Size(420, 248) ;
            noteBodyTextBox.TabIndex =  6 ;
            noteBodyTextBox.Text =  "" ;
            // 
            // attachLabel
            // 
            attachLabel.AutoSize =  true ;
            attachLabel.Font =  new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point) ;
            attachLabel.ForeColor =  Color.Green ;
            attachLabel.Location =  new Point(468, 142) ;
            attachLabel.Name =  "attachLabel" ;
            attachLabel.Size =  new Size(140, 30) ;
            attachLabel.TabIndex =  7 ;
            attachLabel.Text =  "Attachments:" ;
            // 
            // lastDateOnLabel
            // 
            lastDateOnLabel.AutoSize =  true ;
            lastDateOnLabel.Font =  new Font("Segoe UI Semibold", 13.75F, FontStyle.Bold, GraphicsUnit.Point) ;
            lastDateOnLabel.ForeColor =  Color.Green ;
            lastDateOnLabel.Location =  new Point(468, 333) ;
            lastDateOnLabel.Name =  "lastDateOnLabel" ;
            lastDateOnLabel.Size =  new Size(137, 25) ;
            lastDateOnLabel.TabIndex =  10 ;
            lastDateOnLabel.Text =  "Last edited on:" ;
            // 
            // lastDateLabel
            // 
            lastDateLabel.AutoSize =  true ;
            lastDateLabel.Font =  new Font("Segoe UI Semibold", 13.75F, FontStyle.Regular, GraphicsUnit.Point) ;
            lastDateLabel.ForeColor =  Color.Green ;
            lastDateLabel.Location =  new Point(468, 358) ;
            lastDateLabel.Name =  "lastDateLabel" ;
            lastDateLabel.Size =  new Size(0, 25) ;
            lastDateLabel.TabIndex =  11 ;
            // 
            // editNoteButton
            // 
            editNoteButton.FlatAppearance.BorderColor =  Color.Green ;
            editNoteButton.FlatAppearance.MouseDownBackColor =  Color.Green ;
            editNoteButton.FlatAppearance.MouseOverBackColor =  Color.PaleGreen ;
            editNoteButton.FlatStyle =  FlatStyle.Flat ;
            editNoteButton.Font =  new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
            editNoteButton.ForeColor =  Color.Green ;
            editNoteButton.Location =  new Point(468, 403) ;
            editNoteButton.Name =  "editNoteButton" ;
            editNoteButton.Size =  new Size(105, 67) ;
            editNoteButton.TabIndex =  12 ;
            editNoteButton.Text =  "Edit Note" ;
            editNoteButton.UseVisualStyleBackColor =  true ;
            editNoteButton.Click +=  editNoteButton_Click ;
            // 
            // newNoteButton
            // 
            newNoteButton.FlatAppearance.BorderColor =  Color.Green ;
            newNoteButton.FlatAppearance.MouseDownBackColor =  Color.Green ;
            newNoteButton.FlatAppearance.MouseOverBackColor =  Color.PaleGreen ;
            newNoteButton.FlatStyle =  FlatStyle.Flat ;
            newNoteButton.Font =  new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
            newNoteButton.ForeColor =  Color.Green ;
            newNoteButton.Location =  new Point(591, 403) ;
            newNoteButton.Name =  "newNoteButton" ;
            newNoteButton.Size =  new Size(105, 67) ;
            newNoteButton.TabIndex =  13 ;
            newNoteButton.Text =  "New Note" ;
            newNoteButton.UseVisualStyleBackColor =  true ;
            newNoteButton.Click +=  newNoteButton_Click ;
            // 
            // openAttachmentButton
            // 
            openAttachmentButton.FlatAppearance.BorderColor =  Color.Green ;
            openAttachmentButton.FlatAppearance.MouseDownBackColor =  Color.Green ;
            openAttachmentButton.FlatAppearance.MouseOverBackColor =  Color.PaleGreen ;
            openAttachmentButton.FlatStyle =  FlatStyle.Flat ;
            openAttachmentButton.Font =  new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
            openAttachmentButton.ForeColor =  Color.Green ;
            openAttachmentButton.Location =  new Point(501, 275) ;
            openAttachmentButton.Name =  "Open Attachment Button" ;
            openAttachmentButton.Size =  new Size(163, 37) ;
            openAttachmentButton.TabIndex =  9 ;
            openAttachmentButton.Text =  "Open Selected" ;
            openAttachmentButton.UseVisualStyleBackColor =  true ;
            openAttachmentButton.Click += openAttachmentButton_Click;
            // 
            // attachListBox
            // 
            attachListBox.FormattingEnabled =  true ;
            attachListBox.ItemHeight =  30 ;
            attachListBox.Location =  new Point(468, 175) ;
            attachListBox.Name =  "attachListBox" ;
            attachListBox.Size =  new Size(228, 94) ;
            attachListBox.TabIndex =  14 ;
            // 
            // deleteNoteButton
            // 
            deleteNoteButton.FlatAppearance.BorderColor =  Color.Green ;
            deleteNoteButton.FlatAppearance.MouseDownBackColor =  Color.Green ;
            deleteNoteButton.FlatAppearance.MouseOverBackColor =  Color.PaleGreen ;
            deleteNoteButton.FlatStyle =  FlatStyle.Flat ;
            deleteNoteButton.Font =  new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
            deleteNoteButton.ForeColor =  Color.Green ;
            deleteNoteButton.Location =  new Point(533, 80) ;
            deleteNoteButton.Name =  "deleteNoteButton" ;
            deleteNoteButton.Size =  new Size(163, 37) ;
            deleteNoteButton.TabIndex =  15 ;
            deleteNoteButton.TabStop =  false ;
            deleteNoteButton.Text =  "Delete Note" ;
            deleteNoteButton.UseVisualStyleBackColor =  true ;
            deleteNoteButton.Click +=  deleteNoteButton_Click ;
            // 
            // MainForm
            // 
            AutoScaleDimensions =  new SizeF(12F, 30F) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  Color.White ;
            ClientSize =  new Size(714, 491) ;
            Controls.Add(deleteNoteButton);
            Controls.Add(attachListBox);
            Controls.Add(newNoteButton);
            Controls.Add(editNoteButton);
            Controls.Add(lastDateLabel);
            Controls.Add(lastDateOnLabel);
            Controls.Add(openAttachmentButton);
            Controls.Add(attachLabel);
            Controls.Add(noteBodyTextBox);
            Controls.Add(noteBodyLabel);
            Controls.Add(titleTextBox);
            Controls.Add(titleLabel);
            Controls.Add(selectNoteDropDown);
            Controls.Add(selectNoteLabel);
            Controls.Add(headerLabel);
            Font =  new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point) ;
            FormBorderStyle =  FormBorderStyle.FixedToolWindow ;
            Icon =  (Icon) resources.GetObject("$this.Icon")  ;
            Margin =  new Padding(5, 6, 5, 6) ;
            MaximizeBox =  false ;
            MdiChildrenMinimizedAnchorBottom =  false ;
            MinimizeBox =  false ;
            Name =  "MainForm" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "Noteman" ;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label selectNoteLabel;
        private ComboBox selectNoteDropDown;
        private Label titleLabel;
        private TextBox titleTextBox;
        private Label noteBodyLabel;
        private RichTextBox noteBodyTextBox;
        private Label attachLabel;
        private Label lastDateOnLabel;
        private Label lastDateLabel;
        private Button editNoteButton;
        private Button newNoteButton;
        private Button openAttachmentButton;
        private ListBox attachListBox;
        private Button deleteNoteButton;
    }
}
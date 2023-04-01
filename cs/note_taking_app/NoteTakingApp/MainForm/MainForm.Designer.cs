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
            this.headerLabel = new System.Windows.Forms.Label();
            this.selectNoteLabel = new System.Windows.Forms.Label();
            this.selectNoteDropDown = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.noteBodyLabel = new System.Windows.Forms.Label();
            this.noteBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.attachLabel = new System.Windows.Forms.Label();
            this.lastDateOnLabel = new System.Windows.Forms.Label();
            this.lastDateLabel = new System.Windows.Forms.Label();
            this.editNoteButton = new System.Windows.Forms.Button();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.attachListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.headerLabel.Location = new System.Drawing.Point(6, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(713, 65);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Noteman - The Note Taking App";
            // 
            // selectNoteLabel
            // 
            this.selectNoteLabel.AutoSize = true;
            this.selectNoteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectNoteLabel.ForeColor = System.Drawing.Color.Green;
            this.selectNoteLabel.Location = new System.Drawing.Point(23, 74);
            this.selectNoteLabel.Name = "selectNoteLabel";
            this.selectNoteLabel.Size = new System.Drawing.Size(174, 40);
            this.selectNoteLabel.TabIndex = 1;
            this.selectNoteLabel.Text = "Select Note:";
            // 
            // selectNoteDropDown
            // 
            this.selectNoteDropDown.FormattingEnabled = true;
            this.selectNoteDropDown.Location = new System.Drawing.Point(190, 79);
            this.selectNoteDropDown.Name = "selectNoteDropDown";
            this.selectNoteDropDown.Size = new System.Drawing.Size(506, 38);
            this.selectNoteDropDown.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Green;
            this.titleLabel.Location = new System.Drawing.Point(23, 144);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 30);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(88, 139);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(355, 35);
            this.titleTextBox.TabIndex = 4;
            // 
            // noteBodyLabel
            // 
            this.noteBodyLabel.AutoSize = true;
            this.noteBodyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noteBodyLabel.ForeColor = System.Drawing.Color.Green;
            this.noteBodyLabel.Location = new System.Drawing.Point(23, 189);
            this.noteBodyLabel.Name = "noteBodyLabel";
            this.noteBodyLabel.Size = new System.Drawing.Size(66, 30);
            this.noteBodyLabel.TabIndex = 5;
            this.noteBodyLabel.Text = "Note:";
            // 
            // noteBodyTextBox
            // 
            this.noteBodyTextBox.Location = new System.Drawing.Point(23, 222);
            this.noteBodyTextBox.Name = "noteBodyTextBox";
            this.noteBodyTextBox.Size = new System.Drawing.Size(420, 248);
            this.noteBodyTextBox.TabIndex = 6;
            this.noteBodyTextBox.Text = "";
            // 
            // attachLabel
            // 
            this.attachLabel.AutoSize = true;
            this.attachLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.attachLabel.ForeColor = System.Drawing.Color.Green;
            this.attachLabel.Location = new System.Drawing.Point(468, 142);
            this.attachLabel.Name = "attachLabel";
            this.attachLabel.Size = new System.Drawing.Size(140, 30);
            this.attachLabel.TabIndex = 7;
            this.attachLabel.Text = "Attachments:";
            // 
            // lastDateOnLabel
            // 
            this.lastDateOnLabel.AutoSize = true;
            this.lastDateOnLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastDateOnLabel.ForeColor = System.Drawing.Color.Green;
            this.lastDateOnLabel.Location = new System.Drawing.Point(468, 333);
            this.lastDateOnLabel.Name = "lastDateOnLabel";
            this.lastDateOnLabel.Size = new System.Drawing.Size(137, 25);
            this.lastDateOnLabel.TabIndex = 10;
            this.lastDateOnLabel.Text = "Last edited on:";
            // 
            // lastDateLabel
            // 
            this.lastDateLabel.AutoSize = true;
            this.lastDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastDateLabel.ForeColor = System.Drawing.Color.Green;
            this.lastDateLabel.Location = new System.Drawing.Point(468, 358);
            this.lastDateLabel.Name = "lastDateLabel";
            this.lastDateLabel.Size = new System.Drawing.Size(219, 25);
            this.lastDateLabel.TabIndex = 11;
            this.lastDateLabel.Text = "<yyyy/mm/dd hh/mm>";
            // 
            // editNoteButton
            // 
            this.editNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.editNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.editNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.editNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editNoteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editNoteButton.ForeColor = System.Drawing.Color.Green;
            this.editNoteButton.Location = new System.Drawing.Point(468, 403);
            this.editNoteButton.Name = "editNoteButton";
            this.editNoteButton.Size = new System.Drawing.Size(105, 67);
            this.editNoteButton.TabIndex = 12;
            this.editNoteButton.Text = "Edit Note";
            this.editNoteButton.UseVisualStyleBackColor = true;
            // 
            // newNoteButton
            // 
            this.newNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.newNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.newNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.newNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newNoteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newNoteButton.ForeColor = System.Drawing.Color.Green;
            this.newNoteButton.Location = new System.Drawing.Point(591, 403);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(105, 67);
            this.newNoteButton.TabIndex = 13;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(501, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Open Selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // attachListBox
            // 
            this.attachListBox.FormattingEnabled = true;
            this.attachListBox.ItemHeight = 30;
            this.attachListBox.Location = new System.Drawing.Point(468, 175);
            this.attachListBox.Name = "attachListBox";
            this.attachListBox.Size = new System.Drawing.Size(228, 94);
            this.attachListBox.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.attachListBox);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.editNoteButton);
            this.Controls.Add(this.lastDateLabel);
            this.Controls.Add(this.lastDateOnLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.attachLabel);
            this.Controls.Add(this.noteBodyTextBox);
            this.Controls.Add(this.noteBodyLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.selectNoteDropDown);
            this.Controls.Add(this.selectNoteLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Noteman";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button button1;
        private ListBox attachListBox;
    }
}
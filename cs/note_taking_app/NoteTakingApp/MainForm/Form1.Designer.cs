namespace MainForm
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.selectNoteLabel = new System.Windows.Forms.Label();
            this.selectNoteDropDown = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.noteBodyLabel = new System.Windows.Forms.Label();
            this.noteBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
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
            this.selectNoteLabel.Location = new System.Drawing.Point(39, 90);
            this.selectNoteLabel.Name = "selectNoteLabel";
            this.selectNoteLabel.Size = new System.Drawing.Size(174, 40);
            this.selectNoteLabel.TabIndex = 1;
            this.selectNoteLabel.Text = "Select Note:";
            this.selectNoteLabel.Click += new System.EventHandler(this.selectNoteLabel_Click);
            // 
            // selectNoteDropDown
            // 
            this.selectNoteDropDown.FormattingEnabled = true;
            this.selectNoteDropDown.Location = new System.Drawing.Point(219, 95);
            this.selectNoteDropDown.Name = "selectNoteDropDown";
            this.selectNoteDropDown.Size = new System.Drawing.Size(347, 38);
            this.selectNoteDropDown.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Green;
            this.titleLabel.Location = new System.Drawing.Point(39, 166);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 30);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(104, 166);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(355, 35);
            this.titleTextBox.TabIndex = 4;
            // 
            // noteBodyLabel
            // 
            this.noteBodyLabel.AutoSize = true;
            this.noteBodyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noteBodyLabel.ForeColor = System.Drawing.Color.Green;
            this.noteBodyLabel.Location = new System.Drawing.Point(39, 218);
            this.noteBodyLabel.Name = "noteBodyLabel";
            this.noteBodyLabel.Size = new System.Drawing.Size(66, 30);
            this.noteBodyLabel.TabIndex = 5;
            this.noteBodyLabel.Text = "Note:";
            // 
            // noteBodyTextBox
            // 
            this.noteBodyTextBox.Location = new System.Drawing.Point(39, 251);
            this.noteBodyTextBox.Name = "noteBodyTextBox";
            this.noteBodyTextBox.Size = new System.Drawing.Size(420, 231);
            this.noteBodyTextBox.TabIndex = 6;
            this.noteBodyTextBox.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.noteBodyTextBox);
            this.Controls.Add(this.noteBodyLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.selectNoteDropDown);
            this.Controls.Add(this.selectNoteLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "mainForm";
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
    }
}
namespace FitnessTrackers
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.uniqueButtons1 = new FitnessTrackers.UniqueButtons();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rjTextBox1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(204, 474);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(580, 35);
            this.rjTextBox1.TabIndex = 0;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            
            // 
            // uniqueButtons1
            // 
            this.uniqueButtons1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uniqueButtons1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.uniqueButtons1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.uniqueButtons1.BorderRadius = 20;
            this.uniqueButtons1.BorderSize = 0;
            this.uniqueButtons1.FlatAppearance.BorderSize = 0;
            this.uniqueButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uniqueButtons1.ForeColor = System.Drawing.Color.Black;
            this.uniqueButtons1.Location = new System.Drawing.Point(803, 469);
            this.uniqueButtons1.Name = "uniqueButtons1";
            this.uniqueButtons1.Size = new System.Drawing.Size(92, 40);
            this.uniqueButtons1.TabIndex = 1;
            this.uniqueButtons1.Text = "Send";
            this.uniqueButtons1.TextColor = System.Drawing.Color.Black;
            this.uniqueButtons1.UseVisualStyleBackColor = false;
            this.uniqueButtons1.Click += new System.EventHandler(this.uniqueButtons1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(204, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(680, 436);
            this.listBox1.TabIndex = 2;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(923, 534);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.uniqueButtons1);
            this.Controls.Add(this.rjTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private UniqueButtons uniqueButtons1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
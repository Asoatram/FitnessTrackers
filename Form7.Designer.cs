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
            this.components = new System.ComponentModel.Container();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.uniqueButtons1 = new FitnessTrackers.UniqueButtons();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.exitButton1 = new FitnessTrackers.Resources.ExitButton();
            this.minimizeButton1 = new FitnessTrackers.Resources.MinimizeButton();
            this.SuspendLayout();
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rjTextBox1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.White;
            this.rjTextBox1.Location = new System.Drawing.Point(113, 472);
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
            this.rjTextBox1._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // uniqueButtons1
            // 
            this.uniqueButtons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.uniqueButtons1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.uniqueButtons1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uniqueButtons1.BorderRadius = 20;
            this.uniqueButtons1.BorderSize = 0;
            this.uniqueButtons1.FlatAppearance.BorderSize = 0;
            this.uniqueButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uniqueButtons1.ForeColor = System.Drawing.Color.Black;
            this.uniqueButtons1.Location = new System.Drawing.Point(712, 467);
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
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(113, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(680, 436);
            this.listBox1.TabIndex = 2;
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 5000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // exitButton1
            // 
            this.exitButton1.BackColor = System.Drawing.Color.Transparent;
            this.exitButton1.Location = new System.Drawing.Point(870, 0);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(50, 50);
            this.exitButton1.TabIndex = 3;
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton1.Location = new System.Drawing.Point(823, 0);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(50, 50);
            this.minimizeButton1.TabIndex = 4;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(923, 534);
            this.Controls.Add(this.minimizeButton1);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.uniqueButtons1);
            this.Controls.Add(this.rjTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form7_FormClosed);
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private UniqueButtons uniqueButtons1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer updateTimer;
        private Resources.ExitButton exitButton1;
        private Resources.MinimizeButton minimizeButton1;
    }
}
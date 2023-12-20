namespace FitnessTrackers
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitButton1 = new FitnessTrackers.Resources.ExitButton();
            this.minimizeButton1 = new FitnessTrackers.Resources.MinimizeButton();
            this.uniqueButtons1 = new FitnessTrackers.UniqueButtons();
            this.uniqueButtons2 = new FitnessTrackers.UniqueButtons();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Plan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // exitButton1
            // 
            this.exitButton1.BackColor = System.Drawing.Color.Transparent;
            this.exitButton1.Location = new System.Drawing.Point(660, 10);
            this.exitButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(38, 33);
            this.exitButton1.TabIndex = 5;
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton1.Location = new System.Drawing.Point(632, 10);
            this.minimizeButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(38, 41);
            this.minimizeButton1.TabIndex = 6;
            // 
            // uniqueButtons1
            // 
            this.uniqueButtons1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.uniqueButtons1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.uniqueButtons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.uniqueButtons1.BorderRadius = 20;
            this.uniqueButtons1.BorderSize = 0;
            this.uniqueButtons1.FlatAppearance.BorderSize = 0;
            this.uniqueButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uniqueButtons1.ForeColor = System.Drawing.Color.White;
            this.uniqueButtons1.Location = new System.Drawing.Point(164, 244);
            this.uniqueButtons1.Name = "uniqueButtons1";
            this.uniqueButtons1.Size = new System.Drawing.Size(150, 40);
            this.uniqueButtons1.TabIndex = 7;
            this.uniqueButtons1.Text = "Weight Loss";
            this.uniqueButtons1.TextColor = System.Drawing.Color.White;
            this.uniqueButtons1.UseVisualStyleBackColor = false;
            this.uniqueButtons1.Click += new System.EventHandler(this.uniqueButtons1_Click);
            // 
            // uniqueButtons2
            // 
            this.uniqueButtons2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.uniqueButtons2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.uniqueButtons2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.uniqueButtons2.BorderRadius = 20;
            this.uniqueButtons2.BorderSize = 0;
            this.uniqueButtons2.FlatAppearance.BorderSize = 0;
            this.uniqueButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uniqueButtons2.ForeColor = System.Drawing.Color.White;
            this.uniqueButtons2.Location = new System.Drawing.Point(409, 244);
            this.uniqueButtons2.Name = "uniqueButtons2";
            this.uniqueButtons2.Size = new System.Drawing.Size(150, 40);
            this.uniqueButtons2.TabIndex = 8;
            this.uniqueButtons2.Text = "Gain Muscle";
            this.uniqueButtons2.TextColor = System.Drawing.Color.White;
            this.uniqueButtons2.UseVisualStyleBackColor = false;
            this.uniqueButtons2.Click += new System.EventHandler(this.uniqueButtons2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(706, 405);
            this.Controls.Add(this.uniqueButtons2);
            this.Controls.Add(this.uniqueButtons1);
            this.Controls.Add(this.minimizeButton1);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Resources.ExitButton exitButton1;
        private Resources.MinimizeButton minimizeButton1;
        private UniqueButtons uniqueButtons1;
        private UniqueButtons uniqueButtons2;
    }
}
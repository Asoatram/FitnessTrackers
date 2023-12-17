namespace FitnessTrackers
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uniqueButtons1 = new FitnessTrackers.UniqueButtons();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fitness Tracker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Jadwal Harian";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Menu Diet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "BMI Calculator";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // uniqueButtons1
            // 
            this.uniqueButtons1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.uniqueButtons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.uniqueButtons1.BorderRadius = 20;
            this.uniqueButtons1.BorderSize = 0;
            this.uniqueButtons1.FlatAppearance.BorderSize = 0;
            this.uniqueButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uniqueButtons1.ForeColor = System.Drawing.Color.White;
            this.uniqueButtons1.Location = new System.Drawing.Point(632, 187);
            this.uniqueButtons1.Name = "uniqueButtons1";
            this.uniqueButtons1.Size = new System.Drawing.Size(156, 71);
            this.uniqueButtons1.TabIndex = 5;
            this.uniqueButtons1.Text = "uniqueButtons1";
            this.uniqueButtons1.TextColor = System.Drawing.Color.White;
            this.uniqueButtons1.UseVisualStyleBackColor = false;
            this.uniqueButtons1.Click += new System.EventHandler(this.uniqueButtons1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uniqueButtons1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private UniqueButtons uniqueButtons1;
    }
}


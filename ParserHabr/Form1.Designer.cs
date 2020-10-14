namespace ParserHabr
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericAbort = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(495, 494);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "List Titles";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(568, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Point";
            // 
            // NumericStart
            // 
            this.NumericStart.Location = new System.Drawing.Point(568, 45);
            this.NumericStart.Multiline = true;
            this.NumericStart.Name = "NumericStart";
            this.NumericStart.Size = new System.Drawing.Size(100, 20);
            this.NumericStart.TabIndex = 2;
            this.NumericStart.Text = "1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(568, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Point";
            // 
            // NumericAbort
            // 
            this.NumericAbort.Location = new System.Drawing.Point(568, 117);
            this.NumericAbort.Multiline = true;
            this.NumericAbort.Name = "NumericAbort";
            this.NumericAbort.Size = new System.Drawing.Size(100, 20);
            this.NumericAbort.TabIndex = 4;
            this.NumericAbort.Text = "2";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(571, 173);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(97, 33);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start\r\n";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abort
            // 
            this.Abort.Location = new System.Drawing.Point(571, 212);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(97, 33);
            this.Abort.TabIndex = 6;
            this.Abort.Text = "Abort";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 494);
            this.Controls.Add(this.Abort);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.NumericAbort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "HabrParser";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox NumericAbort;

        private System.Windows.Forms.TextBox NumericStart;

        private System.Windows.Forms.Button Abort;
        private System.Windows.Forms.Button Start;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}
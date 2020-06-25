namespace Assignment_6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblhours = new System.Windows.Forms.Label();
            this.lblminutes = new System.Windows.Forms.Label();
            this.lblseconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seconds :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate Time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhours
            // 
            this.lblhours.AutoSize = true;
            this.lblhours.Location = new System.Drawing.Point(48, 193);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(46, 17);
            this.lblhours.TabIndex = 3;
            this.lblhours.Text = "Hours";
            // 
            // lblminutes
            // 
            this.lblminutes.AutoSize = true;
            this.lblminutes.Location = new System.Drawing.Point(125, 193);
            this.lblminutes.Name = "lblminutes";
            this.lblminutes.Size = new System.Drawing.Size(57, 17);
            this.lblminutes.TabIndex = 4;
            this.lblminutes.Text = "Minutes";
            // 
            // lblseconds
            // 
            this.lblseconds.AutoSize = true;
            this.lblseconds.Location = new System.Drawing.Point(207, 193);
            this.lblseconds.Name = "lblseconds";
            this.lblseconds.Size = new System.Drawing.Size(63, 17);
            this.lblseconds.TabIndex = 5;
            this.lblseconds.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblseconds);
            this.Controls.Add(this.lblminutes);
            this.Controls.Add(this.lblhours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.Label lblminutes;
        private System.Windows.Forms.Label lblseconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


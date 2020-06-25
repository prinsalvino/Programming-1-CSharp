namespace Assignment_5
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
            this.lblnmr1 = new System.Windows.Forms.Label();
            this.lblnmr2 = new System.Windows.Forms.Label();
            this.lblnmr3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lblavg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnmr1
            // 
            this.lblnmr1.AutoSize = true;
            this.lblnmr1.Location = new System.Drawing.Point(71, 53);
            this.lblnmr1.Name = "lblnmr1";
            this.lblnmr1.Size = new System.Drawing.Size(78, 17);
            this.lblnmr1.TabIndex = 0;
            this.lblnmr1.Text = "Number 1 :";
            // 
            // lblnmr2
            // 
            this.lblnmr2.AutoSize = true;
            this.lblnmr2.Location = new System.Drawing.Point(71, 114);
            this.lblnmr2.Name = "lblnmr2";
            this.lblnmr2.Size = new System.Drawing.Size(78, 17);
            this.lblnmr2.TabIndex = 1;
            this.lblnmr2.Text = "Number 2 :";
            // 
            // lblnmr3
            // 
            this.lblnmr3.AutoSize = true;
            this.lblnmr3.Location = new System.Drawing.Point(71, 174);
            this.lblnmr3.Name = "lblnmr3";
            this.lblnmr3.Size = new System.Drawing.Size(70, 17);
            this.lblnmr3.TabIndex = 2;
            this.lblnmr3.Text = "Number 3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 22);
            this.textBox3.TabIndex = 5;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(166, 238);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(285, 39);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "Calculate Average";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(71, 310);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 17);
            this.label.TabIndex = 7;
            this.label.Text = "Average";
            // 
            // lblavg
            // 
            this.lblavg.AutoSize = true;
            this.lblavg.Location = new System.Drawing.Point(163, 310);
            this.lblavg.Name = "lblavg";
            this.lblavg.Size = new System.Drawing.Size(31, 17);
            this.lblavg.TabIndex = 8;
            this.lblavg.Text = "avg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblavg);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblnmr3);
            this.Controls.Add(this.lblnmr2);
            this.Controls.Add(this.lblnmr1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnmr1;
        private System.Windows.Forms.Label lblnmr2;
        private System.Windows.Forms.Label lblnmr3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblavg;
    }
}


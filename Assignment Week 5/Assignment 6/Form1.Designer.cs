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
            this.lblbefore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblafter = new System.Windows.Forms.Label();
            this.btncompare = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Content Table (before)";
            // 
            // lblbefore
            // 
            this.lblbefore.Location = new System.Drawing.Point(35, 54);
            this.lblbefore.Name = "lblbefore";
            this.lblbefore.Size = new System.Drawing.Size(194, 321);
            this.lblbefore.TabIndex = 1;
            this.lblbefore.Text = "    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Content Table (after)";
            // 
            // lblafter
            // 
            this.lblafter.Location = new System.Drawing.Point(290, 54);
            this.lblafter.Name = "lblafter";
            this.lblafter.Size = new System.Drawing.Size(263, 321);
            this.lblafter.TabIndex = 3;
            this.lblafter.Text = "     ";
            // 
            // btncompare
            // 
            this.btncompare.Location = new System.Drawing.Point(355, 384);
            this.btncompare.Name = "btncompare";
            this.btncompare.Size = new System.Drawing.Size(138, 31);
            this.btncompare.TabIndex = 4;
            this.btncompare.Text = "Compare";
            this.btncompare.UseVisualStyleBackColor = true;
            this.btncompare.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comparison Number";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(224, 391);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(87, 22);
            this.txtinput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncompare);
            this.Controls.Add(this.lblafter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblbefore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblafter;
        private System.Windows.Forms.Button btncompare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtinput;
    }
}


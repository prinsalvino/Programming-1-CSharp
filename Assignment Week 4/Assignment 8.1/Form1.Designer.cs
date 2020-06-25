namespace Assignment_8._1
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btncompare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresults = new System.Windows.Forms.Label();
            this.lblcompare = new System.Windows.Forms.Label();
            this.lblprint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number:";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(205, 44);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(165, 22);
            this.txtinput.TabIndex = 1;
            // 
            // btncompare
            // 
            this.btncompare.Location = new System.Drawing.Point(83, 109);
            this.btncompare.Name = "btncompare";
            this.btncompare.Size = new System.Drawing.Size(243, 38);
            this.btncompare.TabIndex = 2;
            this.btncompare.Text = "Compare";
            this.btncompare.UseVisualStyleBackColor = true;
            this.btncompare.Click += new System.EventHandler(this.btncompare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sum = 1 + 2 +...+ n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sum = n*(n+1)/2";
            // 
            // lblresults
            // 
            this.lblresults.AutoSize = true;
            this.lblresults.Location = new System.Drawing.Point(305, 187);
            this.lblresults.Name = "lblresults";
            this.lblresults.Size = new System.Drawing.Size(46, 17);
            this.lblresults.TabIndex = 5;
            this.lblresults.Text = "label4";
            // 
            // lblcompare
            // 
            this.lblcompare.AutoSize = true;
            this.lblcompare.Location = new System.Drawing.Point(305, 258);
            this.lblcompare.Name = "lblcompare";
            this.lblcompare.Size = new System.Drawing.Size(46, 17);
            this.lblcompare.TabIndex = 6;
            this.lblcompare.Text = "label5";
            // 
            // lblprint
            // 
            this.lblprint.AutoSize = true;
            this.lblprint.Location = new System.Drawing.Point(64, 340);
            this.lblprint.Name = "lblprint";
            this.lblprint.Size = new System.Drawing.Size(46, 17);
            this.lblprint.TabIndex = 7;
            this.lblprint.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblprint);
            this.Controls.Add(this.lblcompare);
            this.Controls.Add(this.lblresults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncompare);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btncompare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresults;
        private System.Windows.Forms.Label lblcompare;
        private System.Windows.Forms.Label lblprint;
    }
}


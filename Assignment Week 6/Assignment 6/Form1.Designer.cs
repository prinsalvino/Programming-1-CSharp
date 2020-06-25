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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnreference = new System.Windows.Forms.Button();
            this.btnreferenceout = new System.Windows.Forms.Button();
            this.btnvalue = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(184, 55);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(143, 22);
            this.txtinput.TabIndex = 1;
            // 
            // btnreference
            // 
            this.btnreference.Location = new System.Drawing.Point(95, 133);
            this.btnreference.Name = "btnreference";
            this.btnreference.Size = new System.Drawing.Size(196, 28);
            this.btnreference.TabIndex = 2;
            this.btnreference.Text = "Square by reference";
            this.btnreference.UseVisualStyleBackColor = true;
            this.btnreference.Click += new System.EventHandler(this.btnreference_Click);
            // 
            // btnreferenceout
            // 
            this.btnreferenceout.Location = new System.Drawing.Point(95, 213);
            this.btnreferenceout.Name = "btnreferenceout";
            this.btnreferenceout.Size = new System.Drawing.Size(196, 28);
            this.btnreferenceout.TabIndex = 3;
            this.btnreferenceout.Text = "Square by Reference Out";
            this.btnreferenceout.UseVisualStyleBackColor = true;
            this.btnreferenceout.Click += new System.EventHandler(this.btnreferenceout_Click);
            // 
            // btnvalue
            // 
            this.btnvalue.Location = new System.Drawing.Point(95, 288);
            this.btnvalue.Name = "btnvalue";
            this.btnvalue.Size = new System.Drawing.Size(196, 28);
            this.btnvalue.TabIndex = 4;
            this.btnvalue.Text = "Square by value";
            this.btnvalue.UseVisualStyleBackColor = true;
            this.btnvalue.Click += new System.EventHandler(this.btnvalue_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(47, 360);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(48, 17);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Result";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(191, 360);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(20, 17);
            this.lblresult.TabIndex = 6;
            this.lblresult.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnvalue);
            this.Controls.Add(this.btnreferenceout);
            this.Controls.Add(this.btnreference);
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
        private System.Windows.Forms.Button btnreference;
        private System.Windows.Forms.Button btnreferenceout;
        private System.Windows.Forms.Button btnvalue;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblresult;
    }
}


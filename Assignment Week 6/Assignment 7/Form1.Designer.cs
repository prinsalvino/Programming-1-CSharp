namespace Assignment_7
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
            this.label2 = new System.Windows.Forms.Label();
            this.radioctok = new System.Windows.Forms.RadioButton();
            this.radioctof = new System.Windows.Forms.RadioButton();
            this.radioftoc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degrees";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(191, 57);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(156, 22);
            this.txtinput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conversion";
            // 
            // radioctok
            // 
            this.radioctok.AutoSize = true;
            this.radioctok.Location = new System.Drawing.Point(92, 175);
            this.radioctok.Name = "radioctok";
            this.radioctok.Size = new System.Drawing.Size(132, 21);
            this.radioctok.TabIndex = 3;
            this.radioctok.TabStop = true;
            this.radioctok.Text = "Celcius to Kelvin";
            this.radioctok.UseVisualStyleBackColor = true;
            // 
            // radioctof
            // 
            this.radioctof.AutoSize = true;
            this.radioctof.Location = new System.Drawing.Point(92, 216);
            this.radioctof.Name = "radioctof";
            this.radioctof.Size = new System.Drawing.Size(162, 21);
            this.radioctof.TabIndex = 4;
            this.radioctof.TabStop = true;
            this.radioctof.Text = "Celcius to Fahrenheit";
            this.radioctof.UseVisualStyleBackColor = true;
            // 
            // radioftoc
            // 
            this.radioftoc.AutoSize = true;
            this.radioftoc.Location = new System.Drawing.Point(92, 262);
            this.radioftoc.Name = "radioftoc";
            this.radioftoc.Size = new System.Drawing.Size(162, 21);
            this.radioftoc.TabIndex = 5;
            this.radioftoc.TabStop = true;
            this.radioftoc.Text = "Fahrenheit to Celcius";
            this.radioftoc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Converted Degrees";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(247, 399);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(20, 17);
            this.lblresult.TabIndex = 8;
            this.lblresult.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioftoc);
            this.Controls.Add(this.radioctof);
            this.Controls.Add(this.radioctok);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioctok;
        private System.Windows.Forms.RadioButton radioctof;
        private System.Windows.Forms.RadioButton radioftoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresult;
    }
}


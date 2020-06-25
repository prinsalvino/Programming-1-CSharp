namespace Assignment_6._1
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
            this.btncalculate = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Amount :";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(136, 44);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(169, 22);
            this.txtinput.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(64, 97);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(191, 33);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "Calculate Final Capital";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(32, 167);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(89, 17);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Final Capital ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(209, 167);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(16, 17);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btncalculate);
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
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbltotal;
    }
}


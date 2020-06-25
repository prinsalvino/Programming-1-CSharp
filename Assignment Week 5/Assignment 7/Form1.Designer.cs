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
            this.lblprint = new System.Windows.Forms.Label();
            this.btnthrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprint
            // 
            this.lblprint.Location = new System.Drawing.Point(87, 70);
            this.lblprint.Name = "lblprint";
            this.lblprint.Size = new System.Drawing.Size(342, 219);
            this.lblprint.TabIndex = 0;
            this.lblprint.Text = " ";
            // 
            // btnthrow
            // 
            this.btnthrow.Location = new System.Drawing.Point(157, 312);
            this.btnthrow.Name = "btnthrow";
            this.btnthrow.Size = new System.Drawing.Size(198, 57);
            this.btnthrow.TabIndex = 1;
            this.btnthrow.Text = "Throw";
            this.btnthrow.UseVisualStyleBackColor = true;
            this.btnthrow.Click += new System.EventHandler(this.btnthrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 390);
            this.Controls.Add(this.btnthrow);
            this.Controls.Add(this.lblprint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblprint;
        private System.Windows.Forms.Button btnthrow;
    }
}


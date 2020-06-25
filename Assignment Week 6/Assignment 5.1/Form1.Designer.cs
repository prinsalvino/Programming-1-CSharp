namespace Assignment_5._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmultiple = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(207, 75);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(170, 22);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(207, 131);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(170, 22);
            this.txt2.TabIndex = 3;
            // 
            // btnplus
            // 
            this.btnplus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnplus.Image = ((System.Drawing.Image)(resources.GetObject("btnplus.Image")));
            this.btnplus.Location = new System.Drawing.Point(68, 209);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(151, 95);
            this.btnplus.TabIndex = 4;
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Image = ((System.Drawing.Image)(resources.GetObject("btnminus.Image")));
            this.btnminus.Location = new System.Drawing.Point(235, 209);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(151, 95);
            this.btnminus.TabIndex = 5;
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnmultiple
            // 
            this.btnmultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiple.Location = new System.Drawing.Point(392, 209);
            this.btnmultiple.Name = "btnmultiple";
            this.btnmultiple.Size = new System.Drawing.Size(151, 95);
            this.btnmultiple.TabIndex = 6;
            this.btnmultiple.Text = "X";
            this.btnmultiple.UseVisualStyleBackColor = true;
            this.btnmultiple.Click += new System.EventHandler(this.btnmultiple_Click);
            // 
            // btndivide
            // 
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(560, 209);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(151, 95);
            this.btndivide.TabIndex = 7;
            this.btndivide.Text = ":";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(204, 371);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(46, 17);
            this.lblresult.TabIndex = 9;
            this.lblresult.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnmultiple);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmultiple;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresult;
    }
}


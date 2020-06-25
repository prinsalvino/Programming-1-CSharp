namespace Exercise_7
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstart = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prcexc = new System.Windows.Forms.Label();
            this.prcvat = new System.Windows.Forms.Label();
            this.prcinc = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start KM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "End KM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price /  KM :";
            // 
            // txtstart
            // 
            this.txtstart.Location = new System.Drawing.Point(131, 37);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(179, 22);
            this.txtstart.TabIndex = 3;
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(131, 79);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(179, 22);
            this.txtend.TabIndex = 4;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(131, 123);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(179, 22);
            this.txtprice.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price exc VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price inc VAT";
            // 
            // prcexc
            // 
            this.prcexc.AutoSize = true;
            this.prcexc.Location = new System.Drawing.Point(34, 293);
            this.prcexc.Name = "prcexc";
            this.prcexc.Size = new System.Drawing.Size(51, 17);
            this.prcexc.TabIndex = 10;
            this.prcexc.Text = "price 1";
            // 
            // prcvat
            // 
            this.prcvat.AutoSize = true;
            this.prcvat.Location = new System.Drawing.Point(224, 293);
            this.prcvat.Name = "prcvat";
            this.prcvat.Size = new System.Drawing.Size(51, 17);
            this.prcvat.TabIndex = 11;
            this.prcvat.Text = "price 2";
            // 
            // prcinc
            // 
            this.prcinc.AutoSize = true;
            this.prcinc.Location = new System.Drawing.Point(349, 293);
            this.prcinc.Name = "prcinc";
            this.prcinc.Size = new System.Drawing.Size(51, 17);
            this.prcinc.TabIndex = 12;
            this.prcinc.Text = "price 3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(37, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 1);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prcinc);
            this.Controls.Add(this.prcvat);
            this.Controls.Add(this.prcexc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txtstart);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstart;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label prcexc;
        private System.Windows.Forms.Label prcvat;
        private System.Windows.Forms.Label prcinc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


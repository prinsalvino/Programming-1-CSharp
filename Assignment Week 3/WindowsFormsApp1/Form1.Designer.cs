namespace WindowsFormsApp1
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
            this.lblsport = new System.Windows.Forms.Label();
            this.rbfootball = new System.Windows.Forms.RadioButton();
            this.rbhandball = new System.Windows.Forms.RadioButton();
            this.lblage = new System.Windows.Forms.Label();
            this.lblmember = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtmember = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblfee = new System.Windows.Forms.Label();
            this.labelfee = new System.Windows.Forms.Label();
            this.lbleuro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsport
            // 
            this.lblsport.AutoSize = true;
            this.lblsport.Location = new System.Drawing.Point(40, 47);
            this.lblsport.Name = "lblsport";
            this.lblsport.Size = new System.Drawing.Size(42, 17);
            this.lblsport.TabIndex = 0;
            this.lblsport.Text = "Sport";
            // 
            // rbfootball
            // 
            this.rbfootball.AutoSize = true;
            this.rbfootball.Location = new System.Drawing.Point(245, 47);
            this.rbfootball.Name = "rbfootball";
            this.rbfootball.Size = new System.Drawing.Size(79, 21);
            this.rbfootball.TabIndex = 3;
            this.rbfootball.TabStop = true;
            this.rbfootball.Text = "Football";
            this.rbfootball.UseVisualStyleBackColor = true;
            // 
            // rbhandball
            // 
            this.rbhandball.AutoSize = true;
            this.rbhandball.Location = new System.Drawing.Point(245, 83);
            this.rbhandball.Name = "rbhandball";
            this.rbhandball.Size = new System.Drawing.Size(85, 21);
            this.rbhandball.TabIndex = 4;
            this.rbhandball.TabStop = true;
            this.rbhandball.Text = "Handball";
            this.rbhandball.UseVisualStyleBackColor = true;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(40, 157);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(33, 17);
            this.lblage.TabIndex = 5;
            this.lblage.Text = "Age";
            // 
            // lblmember
            // 
            this.lblmember.AutoSize = true;
            this.lblmember.Location = new System.Drawing.Point(40, 206);
            this.lblmember.Name = "lblmember";
            this.lblmember.Size = new System.Drawing.Size(143, 17);
            this.lblmember.TabIndex = 6;
            this.lblmember.Text = "Membership Duration";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(245, 157);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(141, 22);
            this.txtage.TabIndex = 7;
            // 
            // txtmember
            // 
            this.txtmember.Location = new System.Drawing.Point(245, 206);
            this.txtmember.Name = "txtmember";
            this.txtmember.Size = new System.Drawing.Size(141, 22);
            this.txtmember.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate Fee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblfee
            // 
            this.lblfee.AutoSize = true;
            this.lblfee.Location = new System.Drawing.Point(40, 362);
            this.lblfee.Name = "lblfee";
            this.lblfee.Size = new System.Drawing.Size(107, 17);
            this.lblfee.TabIndex = 10;
            this.lblfee.Text = "Fee to be paid :";
            // 
            // labelfee
            // 
            this.labelfee.AutoSize = true;
            this.labelfee.Location = new System.Drawing.Point(212, 362);
            this.labelfee.Name = "labelfee";
            this.labelfee.Size = new System.Drawing.Size(46, 17);
            this.labelfee.TabIndex = 11;
            this.labelfee.Text = "label5";
            // 
            // lbleuro
            // 
            this.lbleuro.AutoSize = true;
            this.lbleuro.Location = new System.Drawing.Point(190, 362);
            this.lbleuro.Name = "lbleuro";
            this.lbleuro.Size = new System.Drawing.Size(16, 17);
            this.lbleuro.TabIndex = 12;
            this.lbleuro.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbleuro);
            this.Controls.Add(this.labelfee);
            this.Controls.Add(this.lblfee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmember);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblmember);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.rbhandball);
            this.Controls.Add(this.rbfootball);
            this.Controls.Add(this.lblsport);
            this.Name = "Form1";
            this.Text = "Assignment 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsport;
        private System.Windows.Forms.RadioButton rbfootball;
        private System.Windows.Forms.RadioButton rbhandball;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblmember;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtmember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblfee;
        private System.Windows.Forms.Label labelfee;
        private System.Windows.Forms.Label lbleuro;
    }
}


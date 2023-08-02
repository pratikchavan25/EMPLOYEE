namespace EMPLOYEE
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
            this.lblempid = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lblgrosssalary = new System.Windows.Forms.Label();
            this.lblempdept = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textsalary = new System.Windows.Forms.TextBox();
            this.texthra = new System.Windows.Forms.TextBox();
            this.lblbtn1 = new System.Windows.Forms.Button();
            this.lblbtn2 = new System.Windows.Forms.Button();
            this.lblhra = new System.Windows.Forms.Label();
            this.lblta = new System.Windows.Forms.Label();
            this.lblda = new System.Windows.Forms.Label();
            this.textta = new System.Windows.Forms.TextBox();
            this.textgrosssalary = new System.Windows.Forms.TextBox();
            this.lblpf = new System.Windows.Forms.Label();
            this.textda = new System.Windows.Forms.TextBox();
            this.textpf = new System.Windows.Forms.TextBox();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblempid.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblempid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblempid.Location = new System.Drawing.Point(52, 54);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(123, 24);
            this.lblempid.TabIndex = 0;
            this.lblempid.Text = "Employee Id";
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblempname.Location = new System.Drawing.Point(54, 117);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(158, 24);
            this.lblempname.TabIndex = 1;
            this.lblempname.Text = "Employee Name";
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblsalary.Location = new System.Drawing.Point(52, 229);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(126, 24);
            this.lblsalary.TabIndex = 2;
            this.lblsalary.Text = "Basic Salary";
            this.lblsalary.Click += new System.EventHandler(this.lblsalary_Click);
            // 
            // lblgrosssalary
            // 
            this.lblgrosssalary.AutoSize = true;
            this.lblgrosssalary.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblgrosssalary.Location = new System.Drawing.Point(47, 513);
            this.lblgrosssalary.Name = "lblgrosssalary";
            this.lblgrosssalary.Size = new System.Drawing.Size(31, 24);
            this.lblgrosssalary.TabIndex = 6;
            this.lblgrosssalary.Text = "gs";
            this.lblgrosssalary.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblempdept
            // 
            this.lblempdept.AutoSize = true;
            this.lblempdept.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblempdept.Location = new System.Drawing.Point(55, 177);
            this.lblempdept.Name = "lblempdept";
            this.lblempdept.Size = new System.Drawing.Size(148, 24);
            this.lblempdept.TabIndex = 7;
            this.lblempdept.Text = "Employee Dept";
            // 
            // textid
            // 
            this.textid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textid.Location = new System.Drawing.Point(322, 56);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(310, 22);
            this.textid.TabIndex = 8;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(322, 120);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(310, 22);
            this.textname.TabIndex = 9;
            // 
            // textsalary
            // 
            this.textsalary.Location = new System.Drawing.Point(322, 232);
            this.textsalary.Name = "textsalary";
            this.textsalary.Size = new System.Drawing.Size(310, 22);
            this.textsalary.TabIndex = 10;
            // 
            // texthra
            // 
            this.texthra.Location = new System.Drawing.Point(322, 285);
            this.texthra.Name = "texthra";
            this.texthra.Size = new System.Drawing.Size(144, 22);
            this.texthra.TabIndex = 11;
            // 
            // lblbtn1
            // 
            this.lblbtn1.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.lblbtn1.Location = new System.Drawing.Point(750, 40);
            this.lblbtn1.Name = "lblbtn1";
            this.lblbtn1.Size = new System.Drawing.Size(125, 38);
            this.lblbtn1.TabIndex = 13;
            this.lblbtn1.Text = "CALCULATE";
            this.lblbtn1.UseVisualStyleBackColor = true;
            this.lblbtn1.Click += new System.EventHandler(this.lblbtn1_Click);
            // 
            // lblbtn2
            // 
            this.lblbtn2.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.lblbtn2.Location = new System.Drawing.Point(951, 40);
            this.lblbtn2.Name = "lblbtn2";
            this.lblbtn2.Size = new System.Drawing.Size(107, 38);
            this.lblbtn2.TabIndex = 14;
            this.lblbtn2.Text = "CLEAR";
            this.lblbtn2.UseVisualStyleBackColor = true;
            // 
            // lblhra
            // 
            this.lblhra.AutoSize = true;
            this.lblhra.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblhra.Location = new System.Drawing.Point(57, 283);
            this.lblhra.Name = "lblhra";
            this.lblhra.Size = new System.Drawing.Size(50, 24);
            this.lblhra.TabIndex = 15;
            this.lblhra.Text = "HRA";
            // 
            // lblta
            // 
            this.lblta.AutoSize = true;
            this.lblta.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblta.Location = new System.Drawing.Point(57, 337);
            this.lblta.Name = "lblta";
            this.lblta.Size = new System.Drawing.Size(34, 24);
            this.lblta.TabIndex = 16;
            this.lblta.Text = "TA";
            // 
            // lblda
            // 
            this.lblda.AutoSize = true;
            this.lblda.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblda.Location = new System.Drawing.Point(55, 396);
            this.lblda.Name = "lblda";
            this.lblda.Size = new System.Drawing.Size(35, 24);
            this.lblda.TabIndex = 17;
            this.lblda.Text = "DA";
            this.lblda.Click += new System.EventHandler(this.label3_Click);
            // 
            // textta
            // 
            this.textta.Location = new System.Drawing.Point(322, 337);
            this.textta.Name = "textta";
            this.textta.Size = new System.Drawing.Size(144, 22);
            this.textta.TabIndex = 18;
            // 
            // textgrosssalary
            // 
            this.textgrosssalary.Location = new System.Drawing.Point(322, 516);
            this.textgrosssalary.Name = "textgrosssalary";
            this.textgrosssalary.Size = new System.Drawing.Size(310, 22);
            this.textgrosssalary.TabIndex = 19;
            // 
            // lblpf
            // 
            this.lblpf.AutoSize = true;
            this.lblpf.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblpf.Location = new System.Drawing.Point(57, 445);
            this.lblpf.Name = "lblpf";
            this.lblpf.Size = new System.Drawing.Size(33, 24);
            this.lblpf.TabIndex = 20;
            this.lblpf.Text = "PF";
            // 
            // textda
            // 
            this.textda.Location = new System.Drawing.Point(322, 396);
            this.textda.Name = "textda";
            this.textda.Size = new System.Drawing.Size(144, 22);
            this.textda.TabIndex = 22;
            // 
            // textpf
            // 
            this.textpf.Location = new System.Drawing.Point(322, 448);
            this.textpf.Name = "textpf";
            this.textpf.Size = new System.Drawing.Size(144, 22);
            this.textpf.TabIndex = 23;
            // 
            // cmbdept
            // 
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Location = new System.Drawing.Point(322, 180);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(310, 24);
            this.cmbdept.TabIndex = 24;
            // 
            // btndisplay
            // 
            this.btndisplay.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btndisplay.Location = new System.Drawing.Point(750, 131);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(125, 73);
            this.btndisplay.TabIndex = 25;
            this.btndisplay.Text = "DISPLAY";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.lblbtn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1245, 607);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.cmbdept);
            this.Controls.Add(this.textpf);
            this.Controls.Add(this.textda);
            this.Controls.Add(this.lblpf);
            this.Controls.Add(this.textgrosssalary);
            this.Controls.Add(this.textta);
            this.Controls.Add(this.lblda);
            this.Controls.Add(this.lblta);
            this.Controls.Add(this.lblhra);
            this.Controls.Add(this.lblbtn2);
            this.Controls.Add(this.lblbtn1);
            this.Controls.Add(this.texthra);
            this.Controls.Add(this.textsalary);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.lblempdept);
            this.Controls.Add(this.lblgrosssalary);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.lblempid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lblgrosssalary;
        private System.Windows.Forms.Label lblempdept;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textsalary;
        private System.Windows.Forms.TextBox texthra;
        private System.Windows.Forms.Button lblbtn1;
        private System.Windows.Forms.Button lblbtn2;
        private System.Windows.Forms.Label lblhra;
        private System.Windows.Forms.Label lblta;
        private System.Windows.Forms.Label lblda;
        private System.Windows.Forms.TextBox textta;
        private System.Windows.Forms.TextBox textgrosssalary;
        private System.Windows.Forms.Label lblpf;
        private System.Windows.Forms.TextBox textda;
        private System.Windows.Forms.TextBox textpf;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.Button btndisplay;
    }
}


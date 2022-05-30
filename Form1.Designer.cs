
namespace Payroll_Computation
{
    partial class PayrollComputation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.sss_txtbox = new System.Windows.Forms.TextBox();
            this.hourlypr_txtbox = new System.Windows.Forms.TextBox();
            this.hoursworked_txtbox = new System.Windows.Forms.TextBox();
            this.gross_txtbox = new System.Windows.Forms.TextBox();
            this.federal_txtbox = new System.Windows.Forms.TextBox();
            this.state_txtbox = new System.Windows.Forms.TextBox();
            this.netpay_txtbox = new System.Windows.Forms.TextBox();
            this.enter_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.hoursworked_txtbox);
            this.groupBox1.Controls.Add(this.hourlypr_txtbox);
            this.groupBox1.Controls.Add(this.sss_txtbox);
            this.groupBox1.Controls.Add(this.name_txtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter correct information:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.netpay_txtbox);
            this.groupBox2.Controls.Add(this.state_txtbox);
            this.groupBox2.Controls.Add(this.federal_txtbox);
            this.groupBox2.Controls.Add(this.gross_txtbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Social Security Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourly Pay Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Hours Worked:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gross Pay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Federal Withholding Tax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "State Withholding Tax:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Net Pay:";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(156, 37);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(100, 20);
            this.name_txtbox.TabIndex = 4;
            // 
            // sss_txtbox
            // 
            this.sss_txtbox.Location = new System.Drawing.Point(156, 93);
            this.sss_txtbox.Name = "sss_txtbox";
            this.sss_txtbox.Size = new System.Drawing.Size(100, 20);
            this.sss_txtbox.TabIndex = 5;
            // 
            // hourlypr_txtbox
            // 
            this.hourlypr_txtbox.Location = new System.Drawing.Point(156, 152);
            this.hourlypr_txtbox.Name = "hourlypr_txtbox";
            this.hourlypr_txtbox.Size = new System.Drawing.Size(100, 20);
            this.hourlypr_txtbox.TabIndex = 6;
            // 
            // hoursworked_txtbox
            // 
            this.hoursworked_txtbox.Location = new System.Drawing.Point(156, 216);
            this.hoursworked_txtbox.Name = "hoursworked_txtbox";
            this.hoursworked_txtbox.Size = new System.Drawing.Size(100, 20);
            this.hoursworked_txtbox.TabIndex = 7;
            // 
            // gross_txtbox
            // 
            this.gross_txtbox.Location = new System.Drawing.Point(157, 37);
            this.gross_txtbox.Name = "gross_txtbox";
            this.gross_txtbox.Size = new System.Drawing.Size(100, 20);
            this.gross_txtbox.TabIndex = 6;
            // 
            // federal_txtbox
            // 
            this.federal_txtbox.Location = new System.Drawing.Point(157, 93);
            this.federal_txtbox.Name = "federal_txtbox";
            this.federal_txtbox.Size = new System.Drawing.Size(100, 20);
            this.federal_txtbox.TabIndex = 7;
            // 
            // state_txtbox
            // 
            this.state_txtbox.Location = new System.Drawing.Point(157, 152);
            this.state_txtbox.Name = "state_txtbox";
            this.state_txtbox.Size = new System.Drawing.Size(100, 20);
            this.state_txtbox.TabIndex = 8;
            // 
            // netpay_txtbox
            // 
            this.netpay_txtbox.Location = new System.Drawing.Point(157, 216);
            this.netpay_txtbox.Name = "netpay_txtbox";
            this.netpay_txtbox.Size = new System.Drawing.Size(100, 20);
            this.netpay_txtbox.TabIndex = 9;
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(92, 296);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 47);
            this.enter_btn.TabIndex = 2;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(254, 296);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 47);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(413, 296);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 47);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // PayrollComputation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(578, 378);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PayrollComputation";
            this.Text = "Payroll Computation";
            this.Load += new System.EventHandler(this.PayrollComputation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hoursworked_txtbox;
        private System.Windows.Forms.TextBox hourlypr_txtbox;
        private System.Windows.Forms.TextBox sss_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox netpay_txtbox;
        private System.Windows.Forms.TextBox state_txtbox;
        private System.Windows.Forms.TextBox federal_txtbox;
        private System.Windows.Forms.TextBox gross_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}


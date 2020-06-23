namespace Hospital_System
{
    partial class ShowExaminationRequestDetailsForm
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.PatientEmailLabel = new System.Windows.Forms.Label();
            this.PatientPhoneLabel = new System.Windows.Forms.Label();
            this.PatientStreetNumberLabel = new System.Windows.Forms.Label();
            this.PatientCityLabel = new System.Windows.Forms.Label();
            this.PatientStreetLabel = new System.Windows.Forms.Label();
            this.ExaminationTimeLabel = new System.Windows.Forms.Label();
            this.ExaminationDateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.ErrorLabel.Location = new System.Drawing.Point(105, 100);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(536, 38);
            this.ErrorLabel.TabIndex = 79;
            this.ErrorLabel.Text = "Thre are no examination requests";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(68, 156);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(605, 548);
            this.listView1.TabIndex = 80;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(133, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 81;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(133, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 82;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(133, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 83;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Turquoise;
            this.label4.Location = new System.Drawing.Point(133, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 84;
            this.label4.Text = "Street:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Turquoise;
            this.label5.Location = new System.Drawing.Point(133, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 85;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Turquoise;
            this.label6.Location = new System.Drawing.Point(133, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 86;
            this.label6.Text = "Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Turquoise;
            this.label7.Location = new System.Drawing.Point(133, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 29);
            this.label7.TabIndex = 87;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Turquoise;
            this.label8.Location = new System.Drawing.Point(136, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 29);
            this.label8.TabIndex = 88;
            this.label8.Text = "Email:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(112, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 42);
            this.button1.TabIndex = 89;
            this.button1.Text = "Approve";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Turquoise;
            this.button2.Location = new System.Drawing.Point(395, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 42);
            this.button2.TabIndex = 90;
            this.button2.Text = "Reject";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientNameLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.PatientNameLabel.Location = new System.Drawing.Point(262, 201);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(93, 29);
            this.PatientNameLabel.TabIndex = 91;
            this.PatientNameLabel.Text = "Name:";
            // 
            // PatientEmailLabel
            // 
            this.PatientEmailLabel.AutoSize = true;
            this.PatientEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientEmailLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.PatientEmailLabel.Location = new System.Drawing.Point(265, 567);
            this.PatientEmailLabel.Name = "PatientEmailLabel";
            this.PatientEmailLabel.Size = new System.Drawing.Size(91, 29);
            this.PatientEmailLabel.TabIndex = 98;
            this.PatientEmailLabel.Text = "Email:";
            // 
            // PatientPhoneLabel
            // 
            this.PatientPhoneLabel.AutoSize = true;
            this.PatientPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientPhoneLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.PatientPhoneLabel.Location = new System.Drawing.Point(262, 518);
            this.PatientPhoneLabel.Name = "PatientPhoneLabel";
            this.PatientPhoneLabel.Size = new System.Drawing.Size(99, 29);
            this.PatientPhoneLabel.TabIndex = 97;
            this.PatientPhoneLabel.Text = "Phone:";
            // 
            // PatientStreetNumberLabel
            // 
            this.PatientStreetNumberLabel.AutoSize = true;
            this.PatientStreetNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientStreetNumberLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.PatientStreetNumberLabel.Location = new System.Drawing.Point(262, 361);
            this.PatientStreetNumberLabel.Name = "PatientStreetNumberLabel";
            this.PatientStreetNumberLabel.Size = new System.Drawing.Size(117, 29);
            this.PatientStreetNumberLabel.TabIndex = 96;
            this.PatientStreetNumberLabel.Text = "Number:";
            // 
            // PatientCityLabel
            // 
            this.PatientCityLabel.AutoSize = true;
            this.PatientCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientCityLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.PatientCityLabel.Location = new System.Drawing.Point(262, 257);
            this.PatientCityLabel.Name = "PatientCityLabel";
            this.PatientCityLabel.Size = new System.Drawing.Size(69, 29);
            this.PatientCityLabel.TabIndex = 95;
            this.PatientCityLabel.Text = "City:";
            // 
            // PatientStreetLabel
            // 
            this.PatientStreetLabel.AutoSize = true;
            this.PatientStreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientStreetLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.PatientStreetLabel.Location = new System.Drawing.Point(262, 309);
            this.PatientStreetLabel.Name = "PatientStreetLabel";
            this.PatientStreetLabel.Size = new System.Drawing.Size(94, 29);
            this.PatientStreetLabel.TabIndex = 94;
            this.PatientStreetLabel.Text = "Street:";
            // 
            // ExaminationTimeLabel
            // 
            this.ExaminationTimeLabel.AutoSize = true;
            this.ExaminationTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationTimeLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.ExaminationTimeLabel.Location = new System.Drawing.Point(262, 471);
            this.ExaminationTimeLabel.Name = "ExaminationTimeLabel";
            this.ExaminationTimeLabel.Size = new System.Drawing.Size(82, 29);
            this.ExaminationTimeLabel.TabIndex = 93;
            this.ExaminationTimeLabel.Text = "Time:";
            // 
            // ExaminationDateLabel
            // 
            this.ExaminationDateLabel.AutoSize = true;
            this.ExaminationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationDateLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.ExaminationDateLabel.Location = new System.Drawing.Point(262, 415);
            this.ExaminationDateLabel.Name = "ExaminationDateLabel";
            this.ExaminationDateLabel.Size = new System.Drawing.Size(78, 29);
            this.ExaminationDateLabel.TabIndex = 92;
            this.ExaminationDateLabel.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Turquoise;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(16, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 37);
            this.label9.TabIndex = 124;
            this.label9.Text = "YHN Hospital";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.Turquoise;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(733, 71);
            this.listView2.TabIndex = 123;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // ShowExaminationRequestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 733);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.PatientEmailLabel);
            this.Controls.Add(this.PatientPhoneLabel);
            this.Controls.Add(this.PatientStreetNumberLabel);
            this.Controls.Add(this.PatientCityLabel);
            this.Controls.Add(this.PatientStreetLabel);
            this.Controls.Add(this.ExaminationTimeLabel);
            this.Controls.Add(this.ExaminationDateLabel);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ErrorLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(751, 780);
            this.MinimumSize = new System.Drawing.Size(751, 780);
            this.Name = "ShowExaminationRequestDetailsForm";
            this.Text = "ShowExaminationRequestDetaolsForm";
            this.Load += new System.EventHandler(this.ShowExaminationRequestDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label PatientEmailLabel;
        private System.Windows.Forms.Label PatientPhoneLabel;
        private System.Windows.Forms.Label PatientStreetNumberLabel;
        private System.Windows.Forms.Label PatientCityLabel;
        private System.Windows.Forms.Label PatientStreetLabel;
        private System.Windows.Forms.Label ExaminationTimeLabel;
        private System.Windows.Forms.Label ExaminationDateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView2;
    }
}
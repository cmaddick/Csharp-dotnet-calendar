namespace Calendar
{
    partial class RecurringAppointmentForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.cboStartTime = new System.Windows.Forms.ComboBox();
            this.cboLength = new System.Windows.Forms.ComboBox();
            this.cboFrequency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numRepeats = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Length:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(75, 12);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(166, 20);
            this.txtSubject.TabIndex = 5;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(75, 47);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(166, 20);
            this.txtLocation.TabIndex = 6;
            // 
            // cboDay
            // 
            this.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cboDay.Location = new System.Drawing.Point(75, 85);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(41, 21);
            this.cboDay.TabIndex = 7;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cboMonth.Location = new System.Drawing.Point(122, 85);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(41, 21);
            this.cboMonth.TabIndex = 8;
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(169, 86);
            this.numYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(72, 20);
            this.numYear.TabIndex = 9;
            this.numYear.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // cboStartTime
            // 
            this.cboStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartTime.FormattingEnabled = true;
            this.cboStartTime.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.cboStartTime.Location = new System.Drawing.Point(75, 121);
            this.cboStartTime.Name = "cboStartTime";
            this.cboStartTime.Size = new System.Drawing.Size(88, 21);
            this.cboStartTime.TabIndex = 10;
            // 
            // cboLength
            // 
            this.cboLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLength.FormattingEnabled = true;
            this.cboLength.Items.AddRange(new object[] {
            "30 minutes",
            "1 hour",
            "1 hour, 30 minutes",
            "2 hours",
            "2 hours, 30 minutes",
            "3 hours",
            "3 hours, 30 minutes",
            "4 hours",
            "4 hours, 30 minutes",
            "5 hours",
            "5 hours, 30 minutes",
            "6 hours",
            "6 hours, 30 minutes",
            "7 hours",
            "7 hours, 30 minutes",
            "8 hours",
            "8 hours, 30 minutes",
            "9 hours",
            "9 hours, 30 minutes",
            "10 hours",
            "10 hours, 30 minutes",
            "11 hours",
            "11 hours, 30 minutes",
            "12 hours",
            "12 hours, 30 minutes",
            "13 hours",
            "13 hours, 30 minutes",
            "14 hours",
            "14 hours, 30 minutes",
            "15 hours",
            "15 hours, 30 minutes",
            "16 hours",
            "16 hours, 30 minutes",
            "17 hours",
            "17 hours, 30 minutes",
            "18 hours",
            "18 hours, 30 minutes",
            "19 hours",
            "19 hours, 30 minutes",
            "20 hours",
            "20 hours, 30 minutes",
            "21 hours",
            "21 hours, 30 minutes",
            "22 hours",
            "22 hours, 30 minutes",
            "23 hours",
            "23 hours, 30 minutes"});
            this.cboLength.Location = new System.Drawing.Point(75, 157);
            this.cboLength.Name = "cboLength";
            this.cboLength.Size = new System.Drawing.Size(116, 21);
            this.cboLength.TabIndex = 11;
            // 
            // cboFrequency
            // 
            this.cboFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrequency.FormattingEnabled = true;
            this.cboFrequency.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Fortnightly",
            "Monthly",
            "Yearly"});
            this.cboFrequency.Location = new System.Drawing.Point(75, 193);
            this.cboFrequency.Name = "cboFrequency";
            this.cboFrequency.Size = new System.Drawing.Size(116, 21);
            this.cboFrequency.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Frequency:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Times to repeat:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(166, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(85, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numRepeats
            // 
            this.numRepeats.Location = new System.Drawing.Point(101, 224);
            this.numRepeats.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numRepeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRepeats.Name = "numRepeats";
            this.numRepeats.Size = new System.Drawing.Size(49, 20);
            this.numRepeats.TabIndex = 18;
            this.numRepeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RecurringAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 291);
            this.Controls.Add(this.numRepeats);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboFrequency);
            this.Controls.Add(this.cboLength);
            this.Controls.Add(this.cboStartTime);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboDay);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RecurringAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Reccuring Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.ComboBox cboStartTime;
        private System.Windows.Forms.ComboBox cboLength;
        private System.Windows.Forms.ComboBox cboFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numRepeats;
    }
}
namespace HumanResourcesApp
{
    partial class frmAddFireEmployee
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPersonalCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.dateEmploy = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateLayOff = new System.Windows.Forms.DateTimePicker();
            this.cmbEmplStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 455);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 19);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(185, 455);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(62, 19);
            this.btnConfirm.TabIndex = 41;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 362);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Uwagi";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(117, 362);
            this.rtbComments.Margin = new System.Windows.Forms.Padding(2);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(130, 79);
            this.rtbComments.TabIndex = 39;
            this.rtbComments.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ulica";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(117, 177);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(2);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(130, 20);
            this.tbStreet.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Pesel";
            // 
            // tbPersonalCode
            // 
            this.tbPersonalCode.Location = new System.Drawing.Point(117, 115);
            this.tbPersonalCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbPersonalCode.Name = "tbPersonalCode";
            this.tbPersonalCode.Size = new System.Drawing.Size(130, 20);
            this.tbPersonalCode.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kod pocztowy";
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(117, 145);
            this.tbZipCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(130, 20);
            this.tbZipCode.TabIndex = 29;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(39, 93);
            this.lbLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(53, 13);
            this.lbLastName.TabIndex = 28;
            this.lbLastName.Text = "Nazwisko";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(117, 90);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(130, 20);
            this.tbLastName.TabIndex = 27;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(39, 61);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(26, 13);
            this.lbName.TabIndex = 26;
            this.lbName.Text = "Imie";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(117, 58);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(130, 20);
            this.tbFirstName.TabIndex = 25;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(39, 28);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 47;
            this.lbId.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(117, 26);
            this.tbId.Margin = new System.Windows.Forms.Padding(2);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(130, 20);
            this.tbId.TabIndex = 46;
            // 
            // dateEmploy
            // 
            this.dateEmploy.Location = new System.Drawing.Point(117, 271);
            this.dateEmploy.Margin = new System.Windows.Forms.Padding(2);
            this.dateEmploy.Name = "dateEmploy";
            this.dateEmploy.Size = new System.Drawing.Size(130, 20);
            this.dateEmploy.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Data zatrudnienia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Data urodzenia";
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.Location = new System.Drawing.Point(117, 239);
            this.dateBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Size = new System.Drawing.Size(130, 20);
            this.dateBirthDate.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Miasto";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(117, 210);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(130, 20);
            this.tbCity.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 301);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Data zwolnienia";
            // 
            // dateLayOff
            // 
            this.dateLayOff.Location = new System.Drawing.Point(117, 301);
            this.dateLayOff.Margin = new System.Windows.Forms.Padding(2);
            this.dateLayOff.Name = "dateLayOff";
            this.dateLayOff.Size = new System.Drawing.Size(130, 20);
            this.dateLayOff.TabIndex = 34;
            // 
            // cmbEmplStatus
            // 
            this.cmbEmplStatus.FormattingEnabled = true;
            this.cmbEmplStatus.Location = new System.Drawing.Point(117, 327);
            this.cmbEmplStatus.Name = "cmbEmplStatus";
            this.cmbEmplStatus.Size = new System.Drawing.Size(130, 21);
            this.cmbEmplStatus.TabIndex = 56;
            this.cmbEmplStatus.SelectedIndexChanged += new System.EventHandler(this.cmbEmplStatus_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 327);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Status pracy";
            // 
            // frmAddFireEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 500);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEmplStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateLayOff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateBirthDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEmploy);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPersonalCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbFirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddFireEmployee";
            this.Text = "Dane pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPersonalCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.DateTimePicker dateEmploy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateBirthDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateLayOff;
        private System.Windows.Forms.ComboBox cmbEmplStatus;
        private System.Windows.Forms.Label label9;
    }
}
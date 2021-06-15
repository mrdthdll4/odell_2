namespace Odell_2
{
    partial class languageArtsInstituteEnrollmentApplicationForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.termInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.termYearComboBox = new System.Windows.Forms.ComboBox();
            this.springTermRadioButton = new System.Windows.Forms.RadioButton();
            this.fallTermRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.studentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.studentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.outOfStateRadioButton = new System.Windows.Forms.RadioButton();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courseOrderInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.spanishCheckBox = new System.Windows.Forms.CheckBox();
            this.russianCheckBox = new System.Windows.Forms.CheckBox();
            this.italianCheckBox = new System.Windows.Forms.CheckBox();
            this.germanCheckBox = new System.Windows.Forms.CheckBox();
            this.frenchCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.expirationDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cardNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.masterCardRadioButton = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.paymentSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.pricePerCourseLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.priceOfCoursesLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numberOfCoursesLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.courseSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.coursesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.termInformationGroupBox.SuspendLayout();
            this.studentInformationGroupBox.SuspendLayout();
            this.courseOrderInformationGroupBox.SuspendLayout();
            this.paymentInformationGroupBox.SuspendLayout();
            this.paymentSummaryGroupBox.SuspendLayout();
            this.courseSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::Odell_2.Properties.Resources.download;
            this.pictureBox.Location = new System.Drawing.Point(176, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(261, 184);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // termInformationGroupBox
            // 
            this.termInformationGroupBox.Controls.Add(this.label2);
            this.termInformationGroupBox.Controls.Add(this.termYearComboBox);
            this.termInformationGroupBox.Controls.Add(this.springTermRadioButton);
            this.termInformationGroupBox.Controls.Add(this.fallTermRadioButton);
            this.termInformationGroupBox.Controls.Add(this.label1);
            this.termInformationGroupBox.Location = new System.Drawing.Point(12, 210);
            this.termInformationGroupBox.Name = "termInformationGroupBox";
            this.termInformationGroupBox.Size = new System.Drawing.Size(242, 79);
            this.termInformationGroupBox.TabIndex = 1;
            this.termInformationGroupBox.TabStop = false;
            this.termInformationGroupBox.Text = "Term Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Your Year:";
            // 
            // termYearComboBox
            // 
            this.termYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termYearComboBox.FormattingEnabled = true;
            this.termYearComboBox.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.termYearComboBox.Location = new System.Drawing.Point(105, 41);
            this.termYearComboBox.Name = "termYearComboBox";
            this.termYearComboBox.Size = new System.Drawing.Size(121, 21);
            this.termYearComboBox.TabIndex = 3;
            // 
            // springTermRadioButton
            // 
            this.springTermRadioButton.AutoSize = true;
            this.springTermRadioButton.Location = new System.Drawing.Point(152, 18);
            this.springTermRadioButton.Name = "springTermRadioButton";
            this.springTermRadioButton.Size = new System.Drawing.Size(55, 17);
            this.springTermRadioButton.TabIndex = 2;
            this.springTermRadioButton.TabStop = true;
            this.springTermRadioButton.Text = "Spring";
            this.springTermRadioButton.UseVisualStyleBackColor = true;
            // 
            // fallTermRadioButton
            // 
            this.fallTermRadioButton.AutoSize = true;
            this.fallTermRadioButton.Checked = true;
            this.fallTermRadioButton.Location = new System.Drawing.Point(105, 18);
            this.fallTermRadioButton.Name = "fallTermRadioButton";
            this.fallTermRadioButton.Size = new System.Drawing.Size(41, 17);
            this.fallTermRadioButton.TabIndex = 1;
            this.fallTermRadioButton.TabStop = true;
            this.fallTermRadioButton.Text = "Fall";
            this.fallTermRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Term:";
            // 
            // studentInformationGroupBox
            // 
            this.studentInformationGroupBox.Controls.Add(this.studentIDMaskedTextBox);
            this.studentInformationGroupBox.Controls.Add(this.outOfStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.label7);
            this.studentInformationGroupBox.Controls.Add(this.emailAddressTextBox);
            this.studentInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.label6);
            this.studentInformationGroupBox.Controls.Add(this.label5);
            this.studentInformationGroupBox.Controls.Add(this.label4);
            this.studentInformationGroupBox.Controls.Add(this.label3);
            this.studentInformationGroupBox.Location = new System.Drawing.Point(260, 210);
            this.studentInformationGroupBox.Name = "studentInformationGroupBox";
            this.studentInformationGroupBox.Size = new System.Drawing.Size(338, 154);
            this.studentInformationGroupBox.TabIndex = 2;
            this.studentInformationGroupBox.TabStop = false;
            this.studentInformationGroupBox.Text = "Student Information";
            // 
            // studentIDMaskedTextBox
            // 
            this.studentIDMaskedTextBox.Location = new System.Drawing.Point(90, 16);
            this.studentIDMaskedTextBox.Mask = "000-00-0000";
            this.studentIDMaskedTextBox.Name = "studentIDMaskedTextBox";
            this.studentIDMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDMaskedTextBox.TabIndex = 4;
            // 
            // outOfStateRadioButton
            // 
            this.outOfStateRadioButton.AutoSize = true;
            this.outOfStateRadioButton.Location = new System.Drawing.Point(238, 124);
            this.outOfStateRadioButton.Name = "outOfStateRadioButton";
            this.outOfStateRadioButton.Size = new System.Drawing.Size(84, 17);
            this.outOfStateRadioButton.TabIndex = 10;
            this.outOfStateRadioButton.TabStop = true;
            this.outOfStateRadioButton.Text = "Out-Of-State";
            this.outOfStateRadioButton.UseVisualStyleBackColor = true;
            this.outOfStateRadioButton.CheckedChanged += new System.EventHandler(this.OutOfStateRadioButton_CheckedChanged);
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.AutoSize = true;
            this.inStateRadioButton.Checked = true;
            this.inStateRadioButton.Location = new System.Drawing.Point(167, 124);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(65, 17);
            this.inStateRadioButton.TabIndex = 9;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In-State ";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            this.inStateRadioButton.CheckedChanged += new System.EventHandler(this.InStateRadioButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Select Your Residency Status:";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(90, 93);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailAddressTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(90, 67);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(90, 41);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student ID:";
            // 
            // courseOrderInformationGroupBox
            // 
            this.courseOrderInformationGroupBox.Controls.Add(this.spanishCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.russianCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.italianCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.germanCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.frenchCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.label8);
            this.courseOrderInformationGroupBox.Location = new System.Drawing.Point(12, 295);
            this.courseOrderInformationGroupBox.Name = "courseOrderInformationGroupBox";
            this.courseOrderInformationGroupBox.Size = new System.Drawing.Size(242, 156);
            this.courseOrderInformationGroupBox.TabIndex = 3;
            this.courseOrderInformationGroupBox.TabStop = false;
            this.courseOrderInformationGroupBox.Text = "Course Order Information";
            // 
            // spanishCheckBox
            // 
            this.spanishCheckBox.AutoSize = true;
            this.spanishCheckBox.Location = new System.Drawing.Point(19, 131);
            this.spanishCheckBox.Name = "spanishCheckBox";
            this.spanishCheckBox.Size = new System.Drawing.Size(150, 17);
            this.spanishCheckBox.TabIndex = 5;
            this.spanishCheckBox.Text = "Beginning Spanish Course";
            this.spanishCheckBox.UseVisualStyleBackColor = true;
            this.spanishCheckBox.CheckedChanged += new System.EventHandler(this.SpanishCheckBox_CheckedChanged);
            // 
            // russianCheckBox
            // 
            this.russianCheckBox.AutoSize = true;
            this.russianCheckBox.Location = new System.Drawing.Point(19, 109);
            this.russianCheckBox.Name = "russianCheckBox";
            this.russianCheckBox.Size = new System.Drawing.Size(150, 17);
            this.russianCheckBox.TabIndex = 4;
            this.russianCheckBox.Text = "Beginning Russian Course";
            this.russianCheckBox.UseVisualStyleBackColor = true;
            this.russianCheckBox.CheckedChanged += new System.EventHandler(this.RussianCheckBox_CheckedChanged);
            // 
            // italianCheckBox
            // 
            this.italianCheckBox.AutoSize = true;
            this.italianCheckBox.Location = new System.Drawing.Point(19, 87);
            this.italianCheckBox.Name = "italianCheckBox";
            this.italianCheckBox.Size = new System.Drawing.Size(140, 17);
            this.italianCheckBox.TabIndex = 3;
            this.italianCheckBox.Text = "Beginning Italian Course";
            this.italianCheckBox.UseVisualStyleBackColor = true;
            this.italianCheckBox.CheckedChanged += new System.EventHandler(this.ItalianCheckBox_CheckedChanged);
            // 
            // germanCheckBox
            // 
            this.germanCheckBox.AutoSize = true;
            this.germanCheckBox.Location = new System.Drawing.Point(19, 65);
            this.germanCheckBox.Name = "germanCheckBox";
            this.germanCheckBox.Size = new System.Drawing.Size(149, 17);
            this.germanCheckBox.TabIndex = 2;
            this.germanCheckBox.Text = "Beginning German Course";
            this.germanCheckBox.UseVisualStyleBackColor = true;
            this.germanCheckBox.CheckedChanged += new System.EventHandler(this.GermanCheckBox_CheckedChanged);
            // 
            // frenchCheckBox
            // 
            this.frenchCheckBox.AutoSize = true;
            this.frenchCheckBox.Location = new System.Drawing.Point(19, 41);
            this.frenchCheckBox.Name = "frenchCheckBox";
            this.frenchCheckBox.Size = new System.Drawing.Size(145, 17);
            this.frenchCheckBox.TabIndex = 1;
            this.frenchCheckBox.Text = "Beginning French Course";
            this.frenchCheckBox.UseVisualStyleBackColor = true;
            this.frenchCheckBox.CheckedChanged += new System.EventHandler(this.FrenchCheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Choose Up To 3 Courses:";
            // 
            // paymentInformationGroupBox
            // 
            this.paymentInformationGroupBox.Controls.Add(this.expirationDateMaskedTextBox);
            this.paymentInformationGroupBox.Controls.Add(this.label11);
            this.paymentInformationGroupBox.Controls.Add(this.label10);
            this.paymentInformationGroupBox.Controls.Add(this.cardNumberMaskedTextBox);
            this.paymentInformationGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentInformationGroupBox.Controls.Add(this.masterCardRadioButton);
            this.paymentInformationGroupBox.Controls.Add(this.label9);
            this.paymentInformationGroupBox.Location = new System.Drawing.Point(12, 457);
            this.paymentInformationGroupBox.Name = "paymentInformationGroupBox";
            this.paymentInformationGroupBox.Size = new System.Drawing.Size(242, 109);
            this.paymentInformationGroupBox.TabIndex = 4;
            this.paymentInformationGroupBox.TabStop = false;
            this.paymentInformationGroupBox.Text = "Payment Information";
            // 
            // expirationDateMaskedTextBox
            // 
            this.expirationDateMaskedTextBox.Location = new System.Drawing.Point(105, 69);
            this.expirationDateMaskedTextBox.Mask = "00/00/0000";
            this.expirationDateMaskedTextBox.Name = "expirationDateMaskedTextBox";
            this.expirationDateMaskedTextBox.Size = new System.Drawing.Size(79, 20);
            this.expirationDateMaskedTextBox.TabIndex = 6;
            this.expirationDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.expirationDateMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ExpirationDateMaskedTextBox_MaskInputRejected);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Expiration Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Card Number:";
            // 
            // cardNumberMaskedTextBox
            // 
            this.cardNumberMaskedTextBox.Location = new System.Drawing.Point(105, 41);
            this.cardNumberMaskedTextBox.Mask = "0000-0000-0000-0000";
            this.cardNumberMaskedTextBox.Name = "cardNumberMaskedTextBox";
            this.cardNumberMaskedTextBox.Size = new System.Drawing.Size(130, 20);
            this.cardNumberMaskedTextBox.TabIndex = 3;
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(190, 18);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(45, 17);
            this.visaRadioButton.TabIndex = 2;
            this.visaRadioButton.TabStop = true;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // masterCardRadioButton
            // 
            this.masterCardRadioButton.AutoSize = true;
            this.masterCardRadioButton.Checked = true;
            this.masterCardRadioButton.Location = new System.Drawing.Point(105, 18);
            this.masterCardRadioButton.Name = "masterCardRadioButton";
            this.masterCardRadioButton.Size = new System.Drawing.Size(79, 17);
            this.masterCardRadioButton.TabIndex = 1;
            this.masterCardRadioButton.TabStop = true;
            this.masterCardRadioButton.Text = "MasterCard";
            this.masterCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Payment Method:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(77, 581);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(251, 581);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Cl&ear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(448, 581);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // paymentSummaryGroupBox
            // 
            this.paymentSummaryGroupBox.Controls.Add(this.pricePerCourseLabel);
            this.paymentSummaryGroupBox.Controls.Add(this.label16);
            this.paymentSummaryGroupBox.Controls.Add(this.priceOfCoursesLabel);
            this.paymentSummaryGroupBox.Controls.Add(this.label14);
            this.paymentSummaryGroupBox.Controls.Add(this.numberOfCoursesLabel);
            this.paymentSummaryGroupBox.Controls.Add(this.label12);
            this.paymentSummaryGroupBox.Location = new System.Drawing.Point(260, 370);
            this.paymentSummaryGroupBox.Name = "paymentSummaryGroupBox";
            this.paymentSummaryGroupBox.Size = new System.Drawing.Size(338, 92);
            this.paymentSummaryGroupBox.TabIndex = 8;
            this.paymentSummaryGroupBox.TabStop = false;
            this.paymentSummaryGroupBox.Text = "Payment Summary";
            // 
            // pricePerCourseLabel
            // 
            this.pricePerCourseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePerCourseLabel.Location = new System.Drawing.Point(144, 59);
            this.pricePerCourseLabel.Name = "pricePerCourseLabel";
            this.pricePerCourseLabel.Size = new System.Drawing.Size(88, 18);
            this.pricePerCourseLabel.TabIndex = 5;
            this.pricePerCourseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Current Price Per Course:";
            // 
            // priceOfCoursesLabel
            // 
            this.priceOfCoursesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceOfCoursesLabel.Location = new System.Drawing.Point(139, 37);
            this.priceOfCoursesLabel.Name = "priceOfCoursesLabel";
            this.priceOfCoursesLabel.Size = new System.Drawing.Size(88, 18);
            this.priceOfCoursesLabel.TabIndex = 3;
            this.priceOfCoursesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total Price of Purchase:";
            // 
            // numberOfCoursesLabel
            // 
            this.numberOfCoursesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfCoursesLabel.Location = new System.Drawing.Point(199, 15);
            this.numberOfCoursesLabel.Name = "numberOfCoursesLabel";
            this.numberOfCoursesLabel.Size = new System.Drawing.Size(88, 18);
            this.numberOfCoursesLabel.TabIndex = 1;
            this.numberOfCoursesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total Number of Courses Purchased:";
            // 
            // courseSummaryGroupBox
            // 
            this.courseSummaryGroupBox.Controls.Add(this.coursesListBox);
            this.courseSummaryGroupBox.Location = new System.Drawing.Point(260, 468);
            this.courseSummaryGroupBox.Name = "courseSummaryGroupBox";
            this.courseSummaryGroupBox.Size = new System.Drawing.Size(338, 98);
            this.courseSummaryGroupBox.TabIndex = 9;
            this.courseSummaryGroupBox.TabStop = false;
            this.courseSummaryGroupBox.Text = "Course Summary";
            // 
            // coursesListBox
            // 
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.Location = new System.Drawing.Point(15, 22);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(178, 56);
            this.coursesListBox.TabIndex = 0;
            // 
            // languageArtsInstituteEnrollmentApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 618);
            this.Controls.Add(this.courseSummaryGroupBox);
            this.Controls.Add(this.paymentSummaryGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.paymentInformationGroupBox);
            this.Controls.Add(this.courseOrderInformationGroupBox);
            this.Controls.Add(this.studentInformationGroupBox);
            this.Controls.Add(this.termInformationGroupBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "languageArtsInstituteEnrollmentApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Arts Institute Enrollment Application";
            this.Load += new System.EventHandler(this.LanguageArtsInstituteEnrollmentApplicationForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.termInformationGroupBox.ResumeLayout(false);
            this.termInformationGroupBox.PerformLayout();
            this.studentInformationGroupBox.ResumeLayout(false);
            this.studentInformationGroupBox.PerformLayout();
            this.courseOrderInformationGroupBox.ResumeLayout(false);
            this.courseOrderInformationGroupBox.PerformLayout();
            this.paymentInformationGroupBox.ResumeLayout(false);
            this.paymentInformationGroupBox.PerformLayout();
            this.paymentSummaryGroupBox.ResumeLayout(false);
            this.paymentSummaryGroupBox.PerformLayout();
            this.courseSummaryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox termInformationGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox termYearComboBox;
        private System.Windows.Forms.RadioButton springTermRadioButton;
        private System.Windows.Forms.RadioButton fallTermRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox studentInformationGroupBox;
        private System.Windows.Forms.RadioButton outOfStateRadioButton;
        private System.Windows.Forms.RadioButton inStateRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox courseOrderInformationGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox paymentInformationGroupBox;
        private System.Windows.Forms.MaskedTextBox expirationDateMaskedTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox cardNumberMaskedTextBox;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton masterCardRadioButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox paymentSummaryGroupBox;
        private System.Windows.Forms.Label numberOfCoursesLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox courseSummaryGroupBox;
        private System.Windows.Forms.Label pricePerCourseLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label priceOfCoursesLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.MaskedTextBox studentIDMaskedTextBox;
        private System.Windows.Forms.CheckBox spanishCheckBox;
        private System.Windows.Forms.CheckBox russianCheckBox;
        private System.Windows.Forms.CheckBox italianCheckBox;
        private System.Windows.Forms.CheckBox germanCheckBox;
        private System.Windows.Forms.CheckBox frenchCheckBox;
    }
}


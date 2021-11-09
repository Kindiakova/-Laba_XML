
namespace Laba_xml
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
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxInDate = new System.Windows.Forms.CheckBox();
            this.checkBoxOutDate = new System.Windows.Forms.CheckBox();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.checkBoxFaculty = new System.Windows.Forms.CheckBox();
            this.checkBoxCathedra = new System.Windows.Forms.CheckBox();
            this.checkBoxDormNumber = new System.Windows.Forms.CheckBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxPatronymic = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.comboBoxCathedra = new System.Windows.Forms.ComboBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.comboBoxInDate = new System.Windows.Forms.ComboBox();
            this.comboBoxOutDate = new System.Windows.Forms.ComboBox();
            this.comboBoxDormNumber = new System.Windows.Forms.ComboBox();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.radioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.comboBoxSurname = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(18, 28);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(57, 24);
            this.checkBoxName.TabIndex = 0;
            this.checkBoxName.Text = "Ім\'я";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxRoom
            // 
            this.checkBoxRoom.AutoSize = true;
            this.checkBoxRoom.Location = new System.Drawing.Point(19, 256);
            this.checkBoxRoom.Name = "checkBoxRoom";
            this.checkBoxRoom.Size = new System.Drawing.Size(86, 24);
            this.checkBoxRoom.TabIndex = 3;
            this.checkBoxRoom.Text = "Кімната";
            this.checkBoxRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxInDate
            // 
            this.checkBoxInDate.AutoSize = true;
            this.checkBoxInDate.Location = new System.Drawing.Point(19, 294);
            this.checkBoxInDate.Name = "checkBoxInDate";
            this.checkBoxInDate.Size = new System.Drawing.Size(139, 24);
            this.checkBoxInDate.TabIndex = 5;
            this.checkBoxInDate.Text = "Дата заселення";
            this.checkBoxInDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxOutDate
            // 
            this.checkBoxOutDate.AutoSize = true;
            this.checkBoxOutDate.Location = new System.Drawing.Point(19, 333);
            this.checkBoxOutDate.Name = "checkBoxOutDate";
            this.checkBoxOutDate.Size = new System.Drawing.Size(143, 24);
            this.checkBoxOutDate.TabIndex = 6;
            this.checkBoxOutDate.Text = "Дата выселення";
            this.checkBoxOutDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxYear
            // 
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Location = new System.Drawing.Point(18, 141);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(63, 24);
            this.checkBoxYear.TabIndex = 7;
            this.checkBoxYear.Text = "Курс";
            this.checkBoxYear.UseVisualStyleBackColor = true;
            this.checkBoxYear.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // checkBoxFaculty
            // 
            this.checkBoxFaculty.AutoSize = true;
            this.checkBoxFaculty.Location = new System.Drawing.Point(18, 180);
            this.checkBoxFaculty.Name = "checkBoxFaculty";
            this.checkBoxFaculty.Size = new System.Drawing.Size(100, 24);
            this.checkBoxFaculty.TabIndex = 8;
            this.checkBoxFaculty.Text = "Факультет";
            this.checkBoxFaculty.UseVisualStyleBackColor = true;
            // 
            // checkBoxCathedra
            // 
            this.checkBoxCathedra.AutoSize = true;
            this.checkBoxCathedra.Location = new System.Drawing.Point(18, 220);
            this.checkBoxCathedra.Name = "checkBoxCathedra";
            this.checkBoxCathedra.Size = new System.Drawing.Size(91, 24);
            this.checkBoxCathedra.TabIndex = 9;
            this.checkBoxCathedra.Text = "Кафедра";
            this.checkBoxCathedra.UseVisualStyleBackColor = true;
            // 
            // checkBoxDormNumber
            // 
            this.checkBoxDormNumber.AutoSize = true;
            this.checkBoxDormNumber.Location = new System.Drawing.Point(19, 377);
            this.checkBoxDormNumber.Name = "checkBoxDormNumber";
            this.checkBoxDormNumber.Size = new System.Drawing.Size(160, 24);
            this.checkBoxDormNumber.TabIndex = 10;
            this.checkBoxDormNumber.Text = "Номер гуртожитку";
            this.checkBoxDormNumber.UseVisualStyleBackColor = true;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Items.AddRange(new object[] {
            ""});
            this.comboBoxName.Location = new System.Drawing.Point(185, 26);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(151, 28);
            this.comboBoxName.Sorted = true;
            this.comboBoxName.TabIndex = 11;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxPatronymic
            // 
            this.comboBoxPatronymic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatronymic.FormattingEnabled = true;
            this.comboBoxPatronymic.Items.AddRange(new object[] {
            ""});
            this.comboBoxPatronymic.Location = new System.Drawing.Point(185, 96);
            this.comboBoxPatronymic.Name = "comboBoxPatronymic";
            this.comboBoxPatronymic.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPatronymic.Sorted = true;
            this.comboBoxPatronymic.TabIndex = 12;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "",
            "1 бакалавр",
            "1 магістр",
            "2 бакалавр",
            "2 магістр",
            "3 бакалавр",
            "4 бакалавр"});
            this.comboBoxYear.Location = new System.Drawing.Point(185, 139);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(151, 28);
            this.comboBoxYear.Sorted = true;
            this.comboBoxYear.TabIndex = 13;
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Items.AddRange(new object[] {
            "",
            "Географічний",
            "Економічний",
            "Інформаційних технологій",
            "Історичний",
            "Комп\'ютерних наук та кібернетики",
            "Механіко-математичний",
            "Психології",
            "Радіофізики, електроніки та комп’ютерних систем",
            "Соціології",
            "Фізичний",
            "Філософський",
            "Хімічний"});
            this.comboBoxFaculty.Location = new System.Drawing.Point(185, 178);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFaculty.Sorted = true;
            this.comboBoxFaculty.TabIndex = 14;
            // 
            // comboBoxCathedra
            // 
            this.comboBoxCathedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCathedra.FormattingEnabled = true;
            this.comboBoxCathedra.Items.AddRange(new object[] {
            ""});
            this.comboBoxCathedra.Location = new System.Drawing.Point(185, 220);
            this.comboBoxCathedra.Name = "comboBoxCathedra";
            this.comboBoxCathedra.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCathedra.Sorted = true;
            this.comboBoxCathedra.TabIndex = 15;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            ""});
            this.comboBoxRoom.Location = new System.Drawing.Point(185, 254);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(151, 28);
            this.comboBoxRoom.Sorted = true;
            this.comboBoxRoom.TabIndex = 16;
            // 
            // comboBoxInDate
            // 
            this.comboBoxInDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInDate.FormattingEnabled = true;
            this.comboBoxInDate.Items.AddRange(new object[] {
            ""});
            this.comboBoxInDate.Location = new System.Drawing.Point(185, 294);
            this.comboBoxInDate.Name = "comboBoxInDate";
            this.comboBoxInDate.Size = new System.Drawing.Size(151, 28);
            this.comboBoxInDate.Sorted = true;
            this.comboBoxInDate.TabIndex = 17;
            // 
            // comboBoxOutDate
            // 
            this.comboBoxOutDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutDate.FormattingEnabled = true;
            this.comboBoxOutDate.Items.AddRange(new object[] {
            ""});
            this.comboBoxOutDate.Location = new System.Drawing.Point(185, 333);
            this.comboBoxOutDate.Name = "comboBoxOutDate";
            this.comboBoxOutDate.Size = new System.Drawing.Size(151, 28);
            this.comboBoxOutDate.Sorted = true;
            this.comboBoxOutDate.TabIndex = 18;
            // 
            // comboBoxDormNumber
            // 
            this.comboBoxDormNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDormNumber.FormattingEnabled = true;
            this.comboBoxDormNumber.Items.AddRange(new object[] {
            "",
            "1",
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
            "2",
            "20",
            "21",
            "22",
            "23",
            "24",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxDormNumber.Location = new System.Drawing.Point(185, 377);
            this.comboBoxDormNumber.Name = "comboBoxDormNumber";
            this.comboBoxDormNumber.Size = new System.Drawing.Size(151, 28);
            this.comboBoxDormNumber.Sorted = true;
            this.comboBoxDormNumber.TabIndex = 19;
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Checked = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(44, 436);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(65, 24);
            this.radioButtonDOM.TabIndex = 20;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            this.radioButtonDOM.Click += new System.EventHandler(this.radioButtonDOM_Click);
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(129, 436);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(57, 24);
            this.radioButtonSAX.TabIndex = 21;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            this.radioButtonSAX.Click += new System.EventHandler(this.radioButtonSAX_Click);
            // 
            // radioButtonLINQ
            // 
            this.radioButtonLINQ.AutoSize = true;
            this.radioButtonLINQ.Location = new System.Drawing.Point(212, 436);
            this.radioButtonLINQ.Name = "radioButtonLINQ";
            this.radioButtonLINQ.Size = new System.Drawing.Size(114, 24);
            this.radioButtonLINQ.TabIndex = 22;
            this.radioButtonLINQ.TabStop = true;
            this.radioButtonLINQ.Text = "LINQ to XML";
            this.radioButtonLINQ.UseVisualStyleBackColor = true;
            this.radioButtonLINQ.Click += new System.EventHandler(this.radioButtonLINQ_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "Конвертувати в HTML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ConvertToHTML);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "Очистити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 42);
            this.button3.TabIndex = 25;
            this.button3.Text = "Пошук";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Search);
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(393, 12);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(562, 549);
            this.Results.TabIndex = 26;
            this.Results.Text = "";
            // 
            // comboBoxSurname
            // 
            this.comboBoxSurname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSurname.FormattingEnabled = true;
            this.comboBoxSurname.Items.AddRange(new object[] {
            ""});
            this.comboBoxSurname.Location = new System.Drawing.Point(185, 62);
            this.comboBoxSurname.Name = "comboBoxSurname";
            this.comboBoxSurname.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSurname.Sorted = true;
            this.comboBoxSurname.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(92, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "Прізвище:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(92, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 20);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "Ім\'я:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(92, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(87, 20);
            this.textBox3.TabIndex = 30;
            this.textBox3.Text = "По-батькові:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 573);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxSurname);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonLINQ);
            this.Controls.Add(this.radioButtonSAX);
            this.Controls.Add(this.radioButtonDOM);
            this.Controls.Add(this.comboBoxDormNumber);
            this.Controls.Add(this.comboBoxOutDate);
            this.Controls.Add(this.comboBoxInDate);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.comboBoxCathedra);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxPatronymic);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.checkBoxDormNumber);
            this.Controls.Add(this.checkBoxCathedra);
            this.Controls.Add(this.checkBoxFaculty);
            this.Controls.Add(this.checkBoxYear);
            this.Controls.Add(this.checkBoxOutDate);
            this.Controls.Add(this.checkBoxInDate);
            this.Controls.Add(this.checkBoxRoom);
            this.Controls.Add(this.checkBoxName);
            this.Name = "Form1";
            this.Text = "XmlDormsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxRoom;
        private System.Windows.Forms.CheckBox checkBoxInDate;
        private System.Windows.Forms.CheckBox checkBoxOutDate;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.CheckBox checkBoxFaculty;
        private System.Windows.Forms.CheckBox checkBoxCathedra;
        private System.Windows.Forms.CheckBox checkBoxDormNumber;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxPatronymic;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.ComboBox comboBoxCathedra;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.ComboBox comboBoxInDate;
        private System.Windows.Forms.ComboBox comboBoxOutDate;
        private System.Windows.Forms.ComboBox comboBoxDormNumber;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.RadioButton radioButtonLINQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.ComboBox comboBoxSurname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
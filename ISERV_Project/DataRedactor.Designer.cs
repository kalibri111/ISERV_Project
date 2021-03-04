
namespace ISERV_Project
{
    partial class DataRedactor
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
            this.components = new System.ComponentModel.Container();
            this.data_edit_tab = new System.Windows.Forms.TabControl();
            this.student_update_tab = new System.Windows.Forms.TabPage();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.delete_id_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.classletter_box = new System.Windows.Forms.TextBox();
            this.classnumber_box = new System.Windows.Forms.TextBox();
            this.age_box = new System.Windows.Forms.TextBox();
            this.surname_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.lesson_update_tab = new System.Windows.Forms.TabPage();
            this.lesson_id_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lesson_delete_button = new System.Windows.Forms.Button();
            this.lesson_update_button = new System.Windows.Forms.Button();
            this.lesson_add_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lesson_name_textbox = new System.Windows.Forms.TextBox();
            this.attendance_update_tab = new System.Windows.Forms.TabPage();
            this.mark_attendance_button = new System.Windows.Forms.Button();
            this.choice_class_button = new System.Windows.Forms.Button();
            this.lesson_listbox = new System.Windows.Forms.ListBox();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSERVDataSet = new ISERV_Project.ISERVDataSet();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.student_listbox = new System.Windows.Forms.ListBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.studentTableAdapter = new ISERV_Project.ISERVDataSetTableAdapters.StudentTableAdapter();
            this.classTableAdapter = new ISERV_Project.ISERVDataSetTableAdapters.ClassTableAdapter();
            this.lessonTableAdapter = new ISERV_Project.ISERVDataSetTableAdapters.LessonTableAdapter();
            this.attendance_select_class_number = new System.Windows.Forms.TextBox();
            this.attendance_select_class_letter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.data_edit_tab.SuspendLayout();
            this.student_update_tab.SuspendLayout();
            this.lesson_update_tab.SuspendLayout();
            this.attendance_update_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSERVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // data_edit_tab
            // 
            this.data_edit_tab.Controls.Add(this.student_update_tab);
            this.data_edit_tab.Controls.Add(this.lesson_update_tab);
            this.data_edit_tab.Controls.Add(this.attendance_update_tab);
            this.data_edit_tab.Location = new System.Drawing.Point(12, -8);
            this.data_edit_tab.Name = "data_edit_tab";
            this.data_edit_tab.SelectedIndex = 0;
            this.data_edit_tab.Size = new System.Drawing.Size(1715, 1280);
            this.data_edit_tab.TabIndex = 19;
            // 
            // student_update_tab
            // 
            this.student_update_tab.Controls.Add(this.id_box);
            this.student_update_tab.Controls.Add(this.label10);
            this.student_update_tab.Controls.Add(this.button1);
            this.student_update_tab.Controls.Add(this.update_button);
            this.student_update_tab.Controls.Add(this.insert_button);
            this.student_update_tab.Controls.Add(this.delete_id_box);
            this.student_update_tab.Controls.Add(this.label11);
            this.student_update_tab.Controls.Add(this.label12);
            this.student_update_tab.Controls.Add(this.label13);
            this.student_update_tab.Controls.Add(this.label14);
            this.student_update_tab.Controls.Add(this.label15);
            this.student_update_tab.Controls.Add(this.label16);
            this.student_update_tab.Controls.Add(this.label17);
            this.student_update_tab.Controls.Add(this.label18);
            this.student_update_tab.Controls.Add(this.classletter_box);
            this.student_update_tab.Controls.Add(this.classnumber_box);
            this.student_update_tab.Controls.Add(this.age_box);
            this.student_update_tab.Controls.Add(this.surname_box);
            this.student_update_tab.Controls.Add(this.name_box);
            this.student_update_tab.Location = new System.Drawing.Point(8, 39);
            this.student_update_tab.Name = "student_update_tab";
            this.student_update_tab.Padding = new System.Windows.Forms.Padding(3);
            this.student_update_tab.Size = new System.Drawing.Size(1699, 1233);
            this.student_update_tab.TabIndex = 0;
            this.student_update_tab.Text = "Students Update";
            this.student_update_tab.UseVisualStyleBackColor = true;
            // 
            // id_box
            // 
            this.id_box.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial;
            this.id_box.Location = new System.Drawing.Point(206, 570);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 31);
            this.id_box.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 570);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1120, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 56);
            this.button1.TabIndex = 35;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(326, 799);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(104, 54);
            this.update_button.TabIndex = 34;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(15, 800);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(115, 53);
            this.insert_button.TabIndex = 33;
            this.insert_button.Text = "Add";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete_id_box
            // 
            this.delete_id_box.Location = new System.Drawing.Point(1120, 215);
            this.delete_id_box.Name = "delete_id_box";
            this.delete_id_box.Size = new System.Drawing.Size(100, 31);
            this.delete_id_box.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(930, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(930, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "Delete";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "Add or Update";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(382, 651);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Class Letter";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 654);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "Class Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 468);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 25);
            this.label16.TabIndex = 26;
            this.label16.Text = "Age";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 351);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 25);
            this.label17.TabIndex = 25;
            this.label17.Text = "Surname";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 222);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 25);
            this.label18.TabIndex = 24;
            this.label18.Text = "Name";
            // 
            // classletter_box
            // 
            this.classletter_box.Location = new System.Drawing.Point(600, 645);
            this.classletter_box.Name = "classletter_box";
            this.classletter_box.Size = new System.Drawing.Size(100, 31);
            this.classletter_box.TabIndex = 23;
            // 
            // classnumber_box
            // 
            this.classnumber_box.Location = new System.Drawing.Point(206, 648);
            this.classnumber_box.Name = "classnumber_box";
            this.classnumber_box.Size = new System.Drawing.Size(100, 31);
            this.classnumber_box.TabIndex = 22;
            // 
            // age_box
            // 
            this.age_box.Location = new System.Drawing.Point(206, 468);
            this.age_box.Name = "age_box";
            this.age_box.Size = new System.Drawing.Size(100, 31);
            this.age_box.TabIndex = 21;
            // 
            // surname_box
            // 
            this.surname_box.Location = new System.Drawing.Point(206, 345);
            this.surname_box.Name = "surname_box";
            this.surname_box.Size = new System.Drawing.Size(100, 31);
            this.surname_box.TabIndex = 20;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(206, 219);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 31);
            this.name_box.TabIndex = 19;
            this.name_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // lesson_update_tab
            // 
            this.lesson_update_tab.Controls.Add(this.lesson_id_textbox);
            this.lesson_update_tab.Controls.Add(this.label1);
            this.lesson_update_tab.Controls.Add(this.lesson_delete_button);
            this.lesson_update_tab.Controls.Add(this.lesson_update_button);
            this.lesson_update_tab.Controls.Add(this.lesson_add_button);
            this.lesson_update_tab.Controls.Add(this.label4);
            this.lesson_update_tab.Controls.Add(this.label9);
            this.lesson_update_tab.Controls.Add(this.lesson_name_textbox);
            this.lesson_update_tab.Location = new System.Drawing.Point(8, 39);
            this.lesson_update_tab.Name = "lesson_update_tab";
            this.lesson_update_tab.Padding = new System.Windows.Forms.Padding(3);
            this.lesson_update_tab.Size = new System.Drawing.Size(1699, 1233);
            this.lesson_update_tab.TabIndex = 1;
            this.lesson_update_tab.Text = "Lesson Update";
            this.lesson_update_tab.UseVisualStyleBackColor = true;
            // 
            // lesson_id_textbox
            // 
            this.lesson_id_textbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial;
            this.lesson_id_textbox.Location = new System.Drawing.Point(234, 261);
            this.lesson_id_textbox.Name = "lesson_id_textbox";
            this.lesson_id_textbox.Size = new System.Drawing.Size(100, 31);
            this.lesson_id_textbox.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Id";
            // 
            // lesson_delete_button
            // 
            this.lesson_delete_button.Location = new System.Drawing.Point(554, 361);
            this.lesson_delete_button.Name = "lesson_delete_button";
            this.lesson_delete_button.Size = new System.Drawing.Size(104, 56);
            this.lesson_delete_button.TabIndex = 54;
            this.lesson_delete_button.Text = "Delete";
            this.lesson_delete_button.UseVisualStyleBackColor = true;
            this.lesson_delete_button.Click += new System.EventHandler(this.lesson_delete_button_Click);
            // 
            // lesson_update_button
            // 
            this.lesson_update_button.Location = new System.Drawing.Point(312, 362);
            this.lesson_update_button.Name = "lesson_update_button";
            this.lesson_update_button.Size = new System.Drawing.Size(104, 54);
            this.lesson_update_button.TabIndex = 53;
            this.lesson_update_button.Text = "Update";
            this.lesson_update_button.UseVisualStyleBackColor = true;
            this.lesson_update_button.Click += new System.EventHandler(this.lesson_update_button_Click);
            // 
            // lesson_add_button
            // 
            this.lesson_add_button.Location = new System.Drawing.Point(69, 363);
            this.lesson_add_button.Name = "lesson_add_button";
            this.lesson_add_button.Size = new System.Drawing.Size(115, 53);
            this.lesson_add_button.TabIndex = 52;
            this.lesson_add_button.Text = "Add";
            this.lesson_add_button.UseVisualStyleBackColor = true;
            this.lesson_add_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Add or Update";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Lesson";
            // 
            // lesson_name_textbox
            // 
            this.lesson_name_textbox.Location = new System.Drawing.Point(234, 172);
            this.lesson_name_textbox.Name = "lesson_name_textbox";
            this.lesson_name_textbox.Size = new System.Drawing.Size(100, 31);
            this.lesson_name_textbox.TabIndex = 38;
            // 
            // attendance_update_tab
            // 
            this.attendance_update_tab.Controls.Add(this.label8);
            this.attendance_update_tab.Controls.Add(this.label7);
            this.attendance_update_tab.Controls.Add(this.attendance_select_class_letter);
            this.attendance_update_tab.Controls.Add(this.attendance_select_class_number);
            this.attendance_update_tab.Controls.Add(this.mark_attendance_button);
            this.attendance_update_tab.Controls.Add(this.choice_class_button);
            this.attendance_update_tab.Controls.Add(this.lesson_listbox);
            this.attendance_update_tab.Controls.Add(this.label6);
            this.attendance_update_tab.Controls.Add(this.label5);
            this.attendance_update_tab.Controls.Add(this.label3);
            this.attendance_update_tab.Controls.Add(this.label2);
            this.attendance_update_tab.Controls.Add(this.student_listbox);
            this.attendance_update_tab.Controls.Add(this.dateTimePicker1);
            this.attendance_update_tab.Location = new System.Drawing.Point(8, 39);
            this.attendance_update_tab.Name = "attendance_update_tab";
            this.attendance_update_tab.Padding = new System.Windows.Forms.Padding(3);
            this.attendance_update_tab.Size = new System.Drawing.Size(1699, 1233);
            this.attendance_update_tab.TabIndex = 3;
            this.attendance_update_tab.Text = "Attendance Update";
            this.attendance_update_tab.UseVisualStyleBackColor = true;
            this.attendance_update_tab.Click += new System.EventHandler(this.attendance_update_tab_Click);
            // 
            // mark_attendance_button
            // 
            this.mark_attendance_button.Location = new System.Drawing.Point(1188, 377);
            this.mark_attendance_button.Name = "mark_attendance_button";
            this.mark_attendance_button.Size = new System.Drawing.Size(211, 67);
            this.mark_attendance_button.TabIndex = 9;
            this.mark_attendance_button.Text = "Mark Attendance";
            this.mark_attendance_button.UseVisualStyleBackColor = true;
            this.mark_attendance_button.Click += new System.EventHandler(this.mark_attendance_button_Click);
            // 
            // choice_class_button
            // 
            this.choice_class_button.Location = new System.Drawing.Point(74, 595);
            this.choice_class_button.Name = "choice_class_button";
            this.choice_class_button.Size = new System.Drawing.Size(147, 81);
            this.choice_class_button.TabIndex = 8;
            this.choice_class_button.Text = "Choose Class";
            this.choice_class_button.UseVisualStyleBackColor = true;
            this.choice_class_button.Click += new System.EventHandler(this.choice_class_button_Click);
            // 
            // lesson_listbox
            // 
            this.lesson_listbox.DataSource = this.lessonBindingSource;
            this.lesson_listbox.DisplayMember = "LessonName";
            this.lesson_listbox.FormattingEnabled = true;
            this.lesson_listbox.ItemHeight = 25;
            this.lesson_listbox.Location = new System.Drawing.Point(781, 163);
            this.lesson_listbox.Name = "lesson_listbox";
            this.lesson_listbox.Size = new System.Drawing.Size(260, 354);
            this.lesson_listbox.TabIndex = 7;
            this.lesson_listbox.ValueMember = "LessonName";
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "Lesson";
            this.lessonBindingSource.DataSource = this.iSERVDataSet;
            // 
            // iSERVDataSet
            // 
            this.iSERVDataSet.DataSetName = "ISERVDataSet";
            this.iSERVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.iSERVDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1183, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Attendance Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lesson";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class";
            // 
            // student_listbox
            // 
            this.student_listbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "StudentName", true));
            this.student_listbox.FormattingEnabled = true;
            this.student_listbox.ItemHeight = 25;
            this.student_listbox.Location = new System.Drawing.Point(375, 163);
            this.student_listbox.Name = "student_listbox";
            this.student_listbox.Size = new System.Drawing.Size(248, 354);
            this.student_listbox.TabIndex = 1;
            this.student_listbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.iSERVDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1188, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(406, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // attendance_select_class_number
            // 
            this.attendance_select_class_number.Location = new System.Drawing.Point(74, 236);
            this.attendance_select_class_number.Name = "attendance_select_class_number";
            this.attendance_select_class_number.Size = new System.Drawing.Size(147, 31);
            this.attendance_select_class_number.TabIndex = 10;
            // 
            // attendance_select_class_letter
            // 
            this.attendance_select_class_letter.Location = new System.Drawing.Point(74, 377);
            this.attendance_select_class_letter.Name = "attendance_select_class_letter";
            this.attendance_select_class_letter.Size = new System.Drawing.Size(147, 31);
            this.attendance_select_class_letter.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Letter";
            // 
            // DataRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 1280);
            this.Controls.Add(this.data_edit_tab);
            this.Name = "DataRedactor";
            this.Text = "DataRedactor";
            this.Load += new System.EventHandler(this.DataRedactor_Load);
            this.data_edit_tab.ResumeLayout(false);
            this.student_update_tab.ResumeLayout(false);
            this.student_update_tab.PerformLayout();
            this.lesson_update_tab.ResumeLayout(false);
            this.lesson_update_tab.PerformLayout();
            this.attendance_update_tab.ResumeLayout(false);
            this.attendance_update_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSERVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl data_edit_tab;
        private System.Windows.Forms.TabPage student_update_tab;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.TextBox delete_id_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox classletter_box;
        private System.Windows.Forms.TextBox classnumber_box;
        private System.Windows.Forms.TextBox age_box;
        private System.Windows.Forms.TextBox surname_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TabPage lesson_update_tab;
        private System.Windows.Forms.TextBox lesson_id_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lesson_delete_button;
        private System.Windows.Forms.Button lesson_update_button;
        private System.Windows.Forms.Button lesson_add_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lesson_name_textbox;
        private System.Windows.Forms.TabPage attendance_update_tab;
        private System.Windows.Forms.ListBox student_listbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ISERVDataSet iSERVDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ISERVDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lesson_listbox;
        private System.Windows.Forms.BindingSource classBindingSource;
        private ISERVDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private ISERVDataSetTableAdapters.LessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.Button choice_class_button;
        private System.Windows.Forms.Button mark_attendance_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox attendance_select_class_letter;
        private System.Windows.Forms.TextBox attendance_select_class_number;
    }
}
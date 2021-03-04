using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;



namespace ISERV_Project
{
    public partial class DataRedactor : Form
    {
        private int selected_student_id = 0;
        private bool loading_flag = true;  // flag for listBox.SelectedIndexChanged

        public DataRedactor()
        {
            InitializeComponent();
        }

        private bool is_loading()
        {
            // check if listbox initializing now
            if (loading_flag)
            {
                loading_flag = false;
                return true;
            } else
            {
                return false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void DataRedactor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSERVDataSet.Lesson' table. You can move, or remove it, as needed.
            this.lessonTableAdapter.Fill(this.iSERVDataSet.Lesson);
            // TODO: This line of code loads data into the 'iSERVDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.iSERVDataSet.Class);
            // TODO: This line of code loads data into the 'iSERVDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.iSERVDataSet.Student);

            // Load Class listbox with class letter and class number

            try
            { 
                // initialize custom lesson listbox view
                var lesson_listbox_output = (from row in iSERVDataSet.Lesson.AsEnumerable()
                                            select new
                                            {
                                                LessonId   = row.Field<int>("Id"),
                                                LessonName = row.Field<string>("LessonName")
                                            }).ToList();

                lesson_listbox.DataSource    = lesson_listbox_output;
                lesson_listbox.DisplayMember = "LessonName";
                lesson_listbox.ValueMember   = "LessonId";
            } catch (InvalidOperationException opexp)
            {
                MessageBox.Show("Loading interrupted by\n" + opexp.Message);
            }
            

        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void attendance_update_tab_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // insert student with class information

            string add_command = $"INSERT INTO Student (StudentName, Surname, Age) VALUES (@Name, @Surname, @Age);";
            string add_to_class = $"INSERT INTO Class (Number, Letter, Studen_id) VALUES (@Number, @Letter, @StudentId);";

            try
            {
                SqlCommand insert_command       = new SqlCommand(add_command, Form1.connection);
                SqlCommand class_insert_command = new SqlCommand(add_to_class, Form1.connection);

                insert_command.Parameters.AddWithValue("@Name", name_box.Text);
                insert_command.Parameters.AddWithValue("@Surname", surname_box.Text);
                insert_command.Parameters.AddWithValue("@Age", System.Convert.ToInt32(age_box.Text));

                insert_command.ExecuteNonQuery();

                SqlCommand last_id_command = new SqlCommand("SELECT TOP 1 Id FROM Student ORDER BY Id DESC", Form1.connection);

                SqlDataReader reader = last_id_command.ExecuteReader();
                reader.Read();
                Int32 last_student_id = reader.GetInt32(0);
                reader.Close();
                
                class_insert_command.Parameters.AddWithValue("@Number", System.Convert.ToInt32(classnumber_box.Text));
                class_insert_command.Parameters.AddWithValue("@Letter", classletter_box.Text);
                class_insert_command.Parameters.AddWithValue("@StudentId", last_student_id);

                class_insert_command.ExecuteNonQuery();

                MessageBox.Show("Successfully added");
            }
            catch (SqlException insert_exception)
            {
                MessageBox.Show("Insertion was interrupted by this error: \n " + insert_exception.Message);
            }

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            // update students property by id

            SqlCommand update_command = new SqlCommand();

            update_command.Connection = Form1.connection;

            string update_value_string = "";

            try
            {
                if (name_box.Text.Length > 0)
                {
                    update_value_string = $"UPDATE Student SET StudentName = {name_box.Text} WHERE Id = {id_box.Text}";
                    update_command.CommandText = update_value_string;
                    update_command.ExecuteNonQuery();
                }
                else if (surname_box.Text.Length > 0)
                {
                    update_value_string = $"UPDATE Student SET Surname = {surname_box.Text} WHERE Id = {id_box.Text}";
                    update_command.CommandText = update_value_string;
                    update_command.ExecuteNonQuery();
                }
                else if (age_box.Text.Length > 0)
                {
                    update_value_string = $"UPDATE Student SET Age = {age_box.Text} WHERE Id = {id_box.Text}";
                    update_command.CommandText = update_value_string;
                    update_command.ExecuteNonQuery();
                }

                MessageBox.Show("Successfullu updated");
            }
            catch (SqlException insert_exception)
            {
                MessageBox.Show("Update was failure because of\n" + insert_exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // delete student by id

            string delete_command_string = $"DELETE FROM Student WHERE Id = {delete_id_box.Text}";
            SqlCommand delete_command = new SqlCommand(delete_command_string, Form1.connection);

            try
            {
                delete_command.ExecuteNonQuery();
            }
            catch (SqlException delete_exception)
            {
                MessageBox.Show("Error during delete");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // save last selection
            if (!is_loading())
            {
                // aftef pressing mark_attendance_button selectvalue become null for some reason
                // lets save last selection with kolhoz method becouse of strange selectedvalue form
                selected_student_id = ToInt.GetInt(student_listbox.SelectedValue.ToString());  
            }
        }

        private void choice_class_button_Click(object sender, EventArgs e)
        {
            // load students in choosen class

            int class_number    = System.Convert.ToInt32(attendance_select_class_number.Text);
            string class_letter = attendance_select_class_letter.Text;

            var students_class = (from class_student in iSERVDataSet.Class.AsEnumerable()
                                  where (int)class_student.Number == class_number && class_student.Letter == class_letter
                                  join student in iSERVDataSet.Student.AsEnumerable() on class_student.Studen_id equals student.Id
                                  select new
                                  {
                                      StudentId   = student.Field<int>("Id"),
                                      StudentName = student.Field<string>("StudentName") + " " + student.Field<string>("Surname")
                                  }).ToList();

            student_listbox.DataSource = null;
            student_listbox.DataSource = students_class;  // update listbox with new datasource

            student_listbox.DisplayMember = "StudentName";
            student_listbox.ValueMember = "StudentId";
        }

        private void mark_attendance_button_Click(object sender, EventArgs e)
        {
            // create row in Attendance table it means that student was on lesson

            DateTime attendance_date = dateTimePicker1.Value.Date;
            string insert_attendance_string = $"INSERT INTO [Attendance] (Student_id, Lesson_id, Datetime) VALUES (@StudentId, @LessonId, @DateTime);";

            SqlCommand insert_attendance = new SqlCommand(insert_attendance_string, Form1.connection);

            if (selected_student_id != 0)
            {
                insert_attendance.Parameters.AddWithValue("@StudentId", selected_student_id);
            }
            else
            {
                MessageBox.Show("Choose student before");
                return;
            }

            if (lesson_listbox.SelectedValue != null)
            {
                string ss = lesson_listbox.SelectedValue.ToString();
                insert_attendance.Parameters.AddWithValue("@LessonId", System.Convert.ToInt32(lesson_listbox.SelectedValue.ToString()));
            }
            else
            {
                MessageBox.Show("Choose lesson before");
                return;
            }
            
            insert_attendance.Parameters.AddWithValue("@DateTime", attendance_date);

            insert_attendance.ExecuteNonQuery();
        }

        private void lesson_update_button_Click(object sender, EventArgs e)
        {
            // update lesson by id

            try
            {
                SqlCommand update_lesson_command = new SqlCommand(
                $"UPDATE [Lesson] SET LessonName = @LessonName WHERE Id = @LessonId;",
                Form1.connection
                );
                update_lesson_command.Parameters.AddWithValue("@LessonName", lesson_name_textbox.Text);
                update_lesson_command.Parameters.AddWithValue("@Lessonid"  , System.Convert.ToInt32(lesson_id_textbox.Text));
                 
                
                update_lesson_command.ExecuteNonQuery();
            } catch (SqlException lesson_update_e)
            {
                MessageBox.Show(lesson_update_e.Message);
            }
            
        }

        private void lesson_delete_button_Click(object sender, EventArgs e)
        {
            // delete lesson by id

            try
            {
                SqlCommand delete_lesson_command = new SqlCommand(
                $"DELETE FROM [Lesson] WHERE Id = @LessonId;",
                Form1.connection
                );
                delete_lesson_command.Parameters.AddWithValue("@LessonId", System.Convert.ToInt32(lesson_id_textbox.Text));
                delete_lesson_command.ExecuteNonQuery();
            } catch (SqlException lesson_delete_e)
            {
                MessageBox.Show(lesson_delete_e.Message);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // add new lesson

            try
            {
                SqlCommand insert_lesson_command = new SqlCommand(
                $"INSERT INTO [Lesson] VALUES (@Name);",
                Form1.connection
                );
                insert_lesson_command.Parameters.AddWithValue("@Name", lesson_name_textbox.Text);
                insert_lesson_command.ExecuteNonQuery();
            } catch (SqlException insert_lesson_e)
            {
                MessageBox.Show(insert_lesson_e.Message);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISERV_Project
{
    public partial class Form1 : Form
    {
        public static SqlConnection connection;
        private static int rows_offset = 0;
        private static int rows_limit = 10;
        private static int class_number = 0;
        private static string class_letter = "";
        private static String connectionString = "Data Source=localhost;Initial Catalog=ISERV;Integrated Security=True";

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        ~Form1()
        {
            connection.Close();
        }

        private string GetPaginationSelect()
        {
            // get row_limits row with actual arguments

            return $"WITH " +
                   $"Class_Id    AS (SELECT Studen_id FROM [Class] WHERE Class.Number = {class_number} AND Class.Letter = \'{class_letter}\'), " +
                   $"Student_CTE AS (SELECT * FROM [Student]) , " +
                   $"Result_CTE  AS (SELECT *, row_number() OVER (ORDER BY Student_CTE.Id) AS NewId FROM Student_CTE INNER JOIN Class_Id ON (Student_CTE.Id = Class_Id.Studen_id)) " +
                   $"SELECT * FROM Result_CTE WHERE Result_CTE.NewId <= {rows_offset + rows_limit} AND Result_CTE.NewId >= {rows_offset};";
          
        }

        private void GetData(string selectCommand)
        {
            // fill datagridview with values from sql select query

            try
            {

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                dataGridView1.DataSource = null;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.Refresh();

            }
            catch (SqlException load_e)
            {
                MessageBox.Show("Loading data from database failed \n" + load_e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSERVDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.iSERVDataSet.Attendance);
            // TODO: This line of code loads data into the 'iSERVDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.iSERVDataSet.Student);
            // TODO: This line of code loads data into the 'iSERVDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.iSERVDataSet.Class);

            connection = new SqlConnection("Data Source=localhost;Initial Catalog=ISERV;Integrated Security=True");
            connection.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // fill datagridview with next batch of rows

            rows_offset += rows_limit;
            GetData(GetPaginationSelect());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // fill datagridview with previous batch of rows

            if (rows_offset - rows_limit >= 0)
            {
                rows_offset -= rows_limit;
            }
            
             GetData(GetPaginationSelect());
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRedactor redactor_form = new DataRedactor();
            redactor_form.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            // update with actual values

            GetData(GetPaginationSelect());
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            // load students information in this class

            class_number = System.Convert.ToInt32(class_number_box.Text);
            class_letter = class_letter_box.Text;
            dataGridView1.DataSource = bindingSource1;
            GetData(GetPaginationSelect());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close connection
            connection.Close();
            this.Close();
        }
    }
}

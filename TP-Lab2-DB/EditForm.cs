using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Lab2_DB
{
    public partial class EditForm : Form
    {
        Student student;
        int state;
        int oldId;

        public EditForm()
        {
            state = 0;
            InitializeComponent();
            student = new  Student();

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Form1.connectionString))
            {
                connection.Open();
                string sqlExpression = "select StudentTask from Table_StudentTask";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            foreach (DataRow VAR in dataTable.Rows)
            {
                cbST.Items.Add(VAR[0].ToString().TrimEnd());
            }
            cbST.SelectedIndex = 0;
        }
        public EditForm(Student student)
        {
            this.student = student;
            state = 1;
            oldId = student.Id;
            InitializeComponent();
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Form1.connectionString))
            {
                connection.Open();
                string sqlExpression = "select StudentTask from Table_StudentTask";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            foreach (DataRow VAR in dataTable.Rows)
            {
                cbST.Items.Add(VAR[0].ToString().TrimEnd());
            }
            ndId.Value = student.Id;
            tbSN.Text = student.StudentName.TrimEnd();
            ndMrk.Value = (decimal)student.Mark;
            tbL.Text = student.Lesson.TrimEnd();
            cbST.SelectedItem = student.StudentTask.TaskName.ToString();


        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (tbSN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите ФИО ученика!", "Ой-ой!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSN.BackColor = Color.Red;
            }
            else student.StudentName = tbSN.Text;

            if (tbL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите урок ученика!", "Ой-ой!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbL.BackColor = Color.Red;
            }
            else student.Lesson = tbL.Text;

            student.Id = (int)ndId.Value;
            student.Mark = (double)ndMrk.Value;
            student.StudentTask = StudentTask.FindTask(cbST.SelectedItem.ToString());
            if (tbSN.Text.Trim().Length != 0 && tbL.Text.Trim().Length != 0)
            {
                if (state == 0) student.Add();
                else student.Update(oldId);
                DialogResult = DialogResult.OK;
            }
        }

        private void btCan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void ndId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

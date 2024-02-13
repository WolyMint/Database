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
    public partial class Form1 : Form
    {
        public static string connectionString = "Server = (localdb)\\TestDB; Database = StudentsDB; Trusted_Connection = True; TrustServerCertificate = True;";

        public Form1()
        {
            InitializeComponent();
            Update();
        }
        public void Update()
        {
            using (SqlConnection connection = new SqlConnection(Form1.connectionString))
            {
                connection.Open();
                string sqlExpression = "select * from Table_Student";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        public object Cell(int index)
        {
            return dataGridView1.SelectedRows[0].Cells[index].Value;
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            Update();


        }

        private void ProcBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string SqlExpression = "exec MaxMark";
                SqlCommand command = new SqlCommand(SqlExpression, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student((int)Cell(0), Cell(1).ToString(), (double)Cell(2), Cell(3).ToString(), StudentTask.FindTask(Cell(4).ToString()));
            EditForm ef = new EditForm(student);
            if (ef.ShowDialog() == DialogResult.OK) Update();
            }
            catch
            {
                MessageBox.Show("Не выбрана строка для изменения", "Ой-ой", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Student student = new Student();
            EditForm ef = new EditForm();
            if (ef.ShowDialog() == DialogResult.OK) Update();

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student((int)Cell(0), Cell(1).ToString(), (double)Cell(2), Cell(3).ToString(), StudentTask.FindTask(Cell(4).ToString()));
                student.Delete(student.Id);
                Update();
            }
            catch
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ой-ой", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm pf = new SearchForm(0);
            if (pf.ShowDialog() == DialogResult.OK)
                dataGridView1.DataSource = pf.Dt;
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm pf = new SearchForm(1);
            if (pf.ShowDialog() == DialogResult.OK)
                dataGridView1.DataSource = pf.Dt;
        }

        private void lessonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm pf = new SearchForm(2);
            if (pf.ShowDialog() == DialogResult.OK)
                dataGridView1.DataSource = pf.Dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class SearchForm : Form
    {
        string str;
        int index;

        public DataTable Dt { get; set; }

        public SearchForm(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;
            using (SqlConnection connection = new SqlConnection(Form1.connectionString))
            {
                Dt = new DataTable();
                connection.Open();
                SqlCommand command = null;
                string sqlExpression = "";
                if (index == 0)
                {
                    sqlExpression = $"select * from table_Student where Id = @str";
                    command = new SqlCommand(sqlExpression, connection);
                    command.Parameters.AddWithValue("@str", str);
                }
                else if (index == 1)
                {
                    sqlExpression = $"select * from table_Student where StudentName = @str";
                    command = new SqlCommand(sqlExpression, connection);
                    command.Parameters.AddWithValue("@str", str);
                }
                else if (index == 2)
                {
                    sqlExpression = $"select * from table_Student where Lesson = @str";
                    command = new SqlCommand(sqlExpression, connection);
                    command.Parameters.AddWithValue("@str", str);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(Dt);
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}

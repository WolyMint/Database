using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab2_DB
{
    public class StudentTask
    {
        string taskName;
        int id;

        public string TaskName { get => taskName; set => taskName = value; }
        public int Id { get => id; set => id = value; }

        public StudentTask(string taskName, int id)
        {
            TaskName = taskName;
            Id = id;
        }

        public static StudentTask FindTask(string taskName)
        {
            StudentTask task = null;
            using (SqlConnection connection = new SqlConnection(Form1.connectionString))
            {
                connection.Open();
                string sqlExpression = $"select * from Table_StudentTask where StudentTask = '{taskName}'";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                task = new StudentTask(dataTable.Rows[0][0].ToString(), (int)dataTable.Rows[0][1]);
            }
            return task;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Lab2_DB
{
    public class Student
    {
        int id;
        string studentName;
        double mark;
        string lesson;
        StudentTask studentTask;

        public int Id { get => id; set => id = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public double Mark { get => mark; set => mark = value; }
        public string Lesson { get => lesson; set => lesson = value; }
        public StudentTask StudentTask { get => studentTask; set => studentTask = value; }

        public Student()
        {
        }

        public Student(int id, string studentName, double mark, string lesson, StudentTask studentTask)
        {
        
            Id = id;
            StudentName = studentName;
            Mark = mark;
            Lesson = lesson;
            StudentTask = studentTask;
        }

        public void Add()
        {
            using (SqlConnection connection = new SqlConnection(Form1.connectionString))
            {
                connection.Open();
                string sqlExpression = $"Insert into Table_Student Values(@Id, @StudentName, @Mark, @Lesson, @StudentTask)";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@StudentName", StudentName);
                command.Parameters.AddWithValue("@Mark", Mark);
                command.Parameters.AddWithValue("@Lesson", Lesson);
                command.Parameters.AddWithValue("@StudentTask", StudentTask.TaskName);

                try
                {
                    command.ExecuteNonQuery();

                }
                catch
                {
                    MessageBox.Show("Студент с таким ID уже существует", "Опа-чки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                }

            }

        public void Update(int tmpId)
        {
            using (SqlConnection connection = new SqlConnection(Form1.connectionString))
            {
                connection.Open();
                string sqlExpression = $"Update Table_Student set Id = @Id, StudentName = @StudentName, Mark = @Mark, Lesson = @Lesson, StudentTask = @StudentTask where Id = @tmpId";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@tmpId", tmpId);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@StudentName", StudentName);
                command.Parameters.AddWithValue("@Mark", Mark);
                command.Parameters.AddWithValue("@Lesson", Lesson);
                command.Parameters.AddWithValue("@StudentTask", StudentTask.TaskName);
                command.ExecuteNonQuery();

            }
        }
        public void Delete(int tmpId)
        {
            using (SqlConnection connection = new SqlConnection(Form1.connectionString))
            {
                connection.Open();
                string sqlExpression = $"delete from Table_Student where Id = @tmpId";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@tmpId", tmpId);
                command.ExecuteNonQuery();
            }
        }
    }
}

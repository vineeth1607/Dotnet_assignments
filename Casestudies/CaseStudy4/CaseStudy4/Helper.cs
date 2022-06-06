using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CaseStudy4
{
    public class Helper : StudentInterface
    {
        string connectionString = "Server=ADMW46ZLPC1572\\SQLEXPRESS;Initial Catalog=Student;" +"Integrated Security=true;";


        public int DeleteStudent(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Delete  from Studentdetails where StudentId=@id", con);
                command.Parameters.AddWithValue("@id", id);
                con.Open();
                int res = command.ExecuteNonQuery();
                con.Close();
                return res;
            }

        }

        public List<student> Details()
        {
            List<student> l = new List<student>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Studentdetails", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    student s = new student();
                    s.studentId = Convert.ToInt32(reader["StudentId"]);
                    s.name = reader["Name"].ToString();
                    s.age = Convert.ToInt32(reader["age"]);
                    l.Add(s);
                }
                con.Close();
            }
            return l;
        }

        public student GetDetails(int id)
        {
            student student = new student();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Studentdetails where StudentId=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    student.studentId = Convert.ToInt32(reader["StudentId"]);
                    student.name = Convert.ToString(reader["Name"]);
                    student.age = Convert.ToInt32(reader["age"]);

                }
                con.Close();
            }
            return student;
        }

        public int InsertStudent(student student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Insert into Studentdetails(StudentId,Name,age)  Values(@StudentId,@Name,@age)", con);
                cmd.Parameters.AddWithValue("@StudentId", student.studentId);
                cmd.Parameters.AddWithValue("@Name", student.name);
                cmd.Parameters.AddWithValue("@age", student.age);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
                return res;
            }

        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Linq;
using System.Data.SqlClient;
using ConfigurationManager = System.Configuration.ConfigurationManager;
using StudentData.Models;

namespace StudentData.DAL
{
    public class Student
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ToString();
        // Get Student Details
       public List<StudentModel> GetStudentDetail()
        {
            List<StudentModel> studentsList = new List<StudentModel>();
            SqlConnection connection=new SqlConnection(ConnectionString);
            using (connection)
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SelectAllStudentDetails";
                SqlDataAdapter adapter=new SqlDataAdapter(command);

                DataTable studentDetails=new DataTable();
                connection.Open();

                adapter.Fill(studentDetails);
                connection.Close();
                foreach(DataRow datarow in studentDetails.Rows)
                {
                    studentsList.Add(new StudentModel
                    {

                        StudentId = (int)datarow["StudentID"],
                        FirstName = (string)datarow["FirstName"],
                        LastName = (string)datarow["LastName"],
                        StudentAddress = (string)datarow["StudentAddress"],
                        StudentPassword = (string)datarow["StudentPassword"],
                        StudentUserName = (string)datarow["StudentUserName"],
                        City = (string)datarow["City"],
                        ContactNumber = (string)datarow["ContactNumber"],
                        FathersName = (string)datarow["FathersName"],
                        DateOfbirth = (DateTime)datarow["DOB"],
                        DateOfJoining = (DateTime)datarow["DateOfJoining"]
                    });
                }

            }

            return studentsList;
        }

    }
}

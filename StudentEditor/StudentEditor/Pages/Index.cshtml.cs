using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using StudentEditor.Model;

namespace StudentEditor.Pages {
    public class IndexModel : PageModel {
        private const string CONNECTION_STRING = "Data Source=JERASUS\\SQLEXPRESS;Initial Catalog=classroom;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly ILogger<IndexModel> _logger;
        public List<Student> Students = new List<Student>();

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void refreshStudents() {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
            SqlCommand getStudents = new SqlCommand("SELECT fullname, age, republic_credits FROM Students", conn);

            SqlDataReader reader = getStudents.ExecuteReader();

            while (reader.Read()) {
                Students.Add(new Student {
                    fullname = reader.GetString(0),
                    age = reader.GetInt32(1),
                    republic_credits = reader.GetInt32(2)
                });
            }
            conn.Close();
         }

        public void OnGet() {
            refreshStudents();
        }

        public void OnPost() {
            var fullname = Request.Form["fullname"];
            var age = Request.Form["age"];
            var credits = Request.Form["credits"];

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();

            SqlCommand insertStudent = new SqlCommand($"INSERT INTO Students (fullname, age, republic_credits) VALUES ('{fullname}', {age}, {credits})", conn);

            insertStudent.ExecuteNonQuery();

            conn.Close();
            refreshStudents();
        }
    }
}

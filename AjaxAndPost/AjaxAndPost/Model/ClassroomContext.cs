using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentEditor.Model;

namespace AjaxAndPost.Model {
    public class ClassroomContext : DbContext {
        private const string CONNECTION_STRING = "Data Source=JERASUS\\SQLEXPRESS;Initial Catalog=classroom;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DbSet<Individual> Person { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
    }
}

using Final_Exam_Practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Exam_Practice.Data
{
    public class DataDbContext : DbContext
    {
        internal object std;

        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {


        }

        public DbSet<Student> Students { get; set; }


    }
}
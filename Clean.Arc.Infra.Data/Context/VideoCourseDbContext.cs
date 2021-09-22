using Clean.Arc.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Arc.Infra.Data.Context
{
    public class VideoCourseDbContext: DbContext 
    {

        public VideoCourseDbContext(DbContextOptions options): base(options) { }
    
         public DbSet<Course> Courses { get; set; }
    }

}

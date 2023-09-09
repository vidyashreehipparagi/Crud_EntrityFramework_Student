﻿using Microsoft.EntityFrameworkCore;


namespace Crud_EntrityFramework_Student.Models
{
    public class ApplicationDbContext:DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

            }
        public DbSet<Student> Students { get; set; }

        
            
        
    }
}

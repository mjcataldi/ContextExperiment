using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ContextExperiment.Models;

namespace ContextExperiment.Data
{
    public class ExperimentContext : DbContext
    {
        public ExperimentContext(DbContextOptions<ExperimentContext> options) : base(options) 
        { }

        public DbSet<Contact> Contacts { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class JobPortalContext : DbContext
    {
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<Job> Job { get; set; }
        //public DbSet<AppliedJob> AppliedJob { get; set; }
    }
}
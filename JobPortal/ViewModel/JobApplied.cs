using JobPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal.ViewModel
{
    public class JobApplied
    {

        public List<Applicant> applicant { get; set; }
        public Job job { get; set; }
        }
}

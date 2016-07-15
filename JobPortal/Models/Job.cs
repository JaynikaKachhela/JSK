using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class Job
    {
        [Required]
        [Key]
        public int JobId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NoOfPositions { get; set; }
        public int ApplicantId { get; set; }
        public ICollection<Applicant> applicant{ get; set; }
    }
}
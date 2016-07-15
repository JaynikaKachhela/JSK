using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class AppliedJob
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        [ForeignKey("ApplicantId")]
        public virtual Applicant Applicant { get; set; }
        public int JobId { get; set; }
        [ForeignKey("JobId")]
        public virtual Job Job { get; set; }
    }
}
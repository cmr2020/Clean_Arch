using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models
{
   public class Education
    {
        public int EducationId { get; set; }

        public string EducationTiltle { get; set; }

        public string NameSchool { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }


    }
}

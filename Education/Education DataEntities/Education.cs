using System;
using System.Collections.Generic;
using System.Text;

namespace Education_DataEntities
{
    public class Education
    {
        public int EducationId { get; set; }
        public string? StudentName { get; set; }
        public string? CourseName { get; set; }
        public string? InstituteName { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public double? Fees { get; set; }
    }
}
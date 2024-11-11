using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfLoadfilejson_BusinessObject
{
    public class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Major { get; set; }
        public int AcademicYear { get; set; }
    }
}


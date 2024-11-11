using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLoadfilejson_BusinessObject;
using WpfLoadfilejson_Repo;

namespace WpfLoadfilejson_Service
{
    public class StudentService
    {
        private readonly StudentRepo _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepo();
        }

        public List<Student> GetAllStudents(string filePath)
        {
            return _studentRepository.GetAllStudents(filePath);
        }
    }
}
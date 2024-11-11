using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.Generic;
using WpfLoadfilejson_DAO;
using WpfLoadfilejson_BusinessObject;


namespace WpfLoadfilejson_Repo
{

    public class StudentRepo
    {
        private readonly StudentDAO _studentDAO;

        public StudentRepo()
        {
            _studentDAO = new StudentDAO();
        }

        public List<Student> GetAllStudents(string filePath)
        {
            return _studentDAO.LoadStudentsFromFile(filePath);
        }
    }

}

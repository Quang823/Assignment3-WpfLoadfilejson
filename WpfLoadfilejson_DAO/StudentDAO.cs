using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using WpfLoadfilejson_BusinessObject;
namespace WpfLoadfilejson_DAO
{
    public class StudentDAO
    {
        public List<Student> LoadStudentsFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Student>>(json);
            }
            return new List<Student>();
        }
    }

}

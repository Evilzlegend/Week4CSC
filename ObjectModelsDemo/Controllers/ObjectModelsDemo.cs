using Microsoft.AspNetCore.Mvc;

namespace ObjectModelsDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ObjectModelDemo : ControllerBase
    {
        [HttpPost(Name = "ObjectModelDemo")]
        public ActionResult<List<Student>> Post([FromBody]List<Student> students)
        {
            try
            {
                foreach(var student in students)
                {
                    System.Console.WriteLine(LogObject(student.studID));
                    System.Console.WriteLine(LogObject(student.fname));
                    System.Console.WriteLine(LogObject(student.lname));
                    System.Console.WriteLine(LogObject(student.major));
                }
                // Returning students
                return Accepted(students);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
        
        string LogObject(string students)
        {
            System.Diagnostics.Debug.WriteLine(students);
            return students;
        }
    }
}

public class Student
{
    public string studID { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
    public string major { get; set; }
}

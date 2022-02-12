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
                    Console.WriteLine(student.fname, student.lname, student.major);
                }
                // Returning students
                return Accepted(students);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
    }
}

public class Student
{
    public int studID { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
    public string major { get; set; }
}
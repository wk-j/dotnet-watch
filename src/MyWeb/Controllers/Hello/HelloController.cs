using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers.Hello;

public class StudentRequest {
    /// <summary>
    /// Reable name
    /// </summary>
    [Required]
    public string Name { set; get; }
}

public class Student {
    public string Name { set; get; }
    public int Age { set; get; }
}

/// <summary>
/// Xml document
/// </summary>
[ApiController]
[Route("api/hello")]
[Tags("01. Hello")]
public class HelloController : ControllerBase {

    /// <summary>
    /// Hello, world!
    /// </summary>
    /// <returns></returns>
    [HttpGet("hello")]
    public string Hello() => "Hello";

    /// <summary>
    /// Get students
    /// </summary>
    /// <returns></returns>
    [HttpGet("get-students")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public List<Student> GetStudents([FromBody] StudentRequest request) {
        return new List<Student> {
            new Student { }
        };
    }
}
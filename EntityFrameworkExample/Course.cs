using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    [Table("course")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }

        public CourseImage ImageCourse { get; set; }

        public List<Student> EnrolledStudents { get; set; }
    }
}

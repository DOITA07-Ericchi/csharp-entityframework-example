using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    [Table("course_image")]
    public class CourseImage
    {
        [Key]
        public int CourseImageId { get; set; }
        public string ImageRoute { get; set; }
        public string Caption { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}

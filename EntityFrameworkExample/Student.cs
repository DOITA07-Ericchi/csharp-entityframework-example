using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkExample {
	[Table ("students")]
	[Index (nameof (Email), IsUnique = true)]
	public class Student {
		[Key] // Non serve se alla fine c'è scritto Id, come in questo caso.
		public int StudentId { get; set; }
		[Required]
		[Column("nome")]
		public string Name { get; set; }
		[Required]
		[Column("cognome")]
		public string Surname { get; set; }
		[Column("student_email")]
		public string Email { get; set; }
	}
}
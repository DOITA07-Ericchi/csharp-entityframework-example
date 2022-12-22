// See https://aka.ms/new-console-template for more information
using EntityFrameworkExample;

Console.WriteLine ("Hello, World!");

using (SchoolContext db = new SchoolContext ()) {
	Student francescoPippo = new Student { Name = "Francesco", Surname = "Pippo", Email = "francescopippo@ericchi.moe" };

	//db.Add (francescoPippo);
	//db.SaveChanges ();

	CourseImage immaginePerIlCorso = new CourseImage() { Caption="Corso per diventare aspiranti informatici..", ImageRoute="/Users/ericchi/test.jpg" };
	Course corsoNuovo = new Course() { ImageCourse = immaginePerIlCorso, Name="Corso di informatica" };

	//db.Add(immaginePerIlCorso);
	//db.Add(corsoNuovo);
	//db.SaveChanges();

}
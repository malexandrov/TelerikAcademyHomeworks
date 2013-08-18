using System;

namespace _1.SchoolHierarchy
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Student joro = new Student("Joro", 19877);
            Student pesho = new Student("Petur", 19878);
            Student gosho = new Student("Ivo", 19879);

            Discipline physics = new Discipline("Physics", 50, 7);
            Discipline biology = new Discipline("Biology", 7, 3);

            // Teacher
            Teacher kaspichanov = new Teacher("Kaspichanov");
            kaspichanov.AddDiscipline(physics);
            kaspichanov.AddDiscipline(biology);

            //Make a class with students and teacher
            Class schoolClass = new Class("10 G");
            schoolClass.AddStudent(joro);
            schoolClass.AddStudent(pesho);
            schoolClass.AddStudent(gosho);
            schoolClass.AddTeacher(kaspichanov);

            School osnovnoUchilishte = new School("123-to OY");
            osnovnoUchilishte.AddClass(schoolClass);
      
            //Add and show some comments
            physics.Comment = "Nov komentar za disciplina.";
            physics.ShowComment();

            kaspichanov.Comment = "Nov komentar za uchitel.";
            kaspichanov.ShowComment();
        }
    }
}
using college_management_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace college_management_back.DAL
{
    public class UniversityInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            var courses = new List<Course>
            {
                new Course{ CourseID=1, Description="Medicine" },
                new Course{ CourseID=2, Description="Computer Science" },
                new Course{ CourseID=3, Description="Biology" },
            };
            courses.ForEach(course => context.Courses.Add(course));
            context.SaveChanges();

            var teachers = new List<Teacher>
            {
                new Teacher{ TeacherID=1, Name="Leonardo",  Birthday=new Domain.Person.Birthday(DateTime.Parse("1999-10-29")), Salary=30000m},
                new Teacher{ TeacherID=2, Name="Roberta",  Birthday=new Domain.Person.Birthday(DateTime.Parse("2000-05-20")), Salary=32500m},
                new Teacher{ TeacherID=3, Name="Márcia", Birthday=new Domain.Person.Birthday(DateTime.Parse("1970-11-29")), Salary=32560m},
                new Teacher{ TeacherID=4, Name="Augusto", Birthday=new Domain.Person.Birthday(DateTime.Parse("1983-02-16")), Salary=40000m},
                new Teacher{ TeacherID=5, Name="Luiz", Birthday=new Domain.Person.Birthday(DateTime.Parse("1965-09-16")), Salary=33000m},
                new Teacher{ TeacherID=6, Name="Gytis", Birthday=new Domain.Person.Birthday(DateTime.Parse("1974-06-04")), Salary=30000m},
                new Teacher{ TeacherID=7, Name="Yan", Birthday=new Domain.Person.Birthday(DateTime.Parse("1970-10-22")), Salary=23500m},
                new Teacher{ TeacherID=8, Name="Peggy", Birthday=new Domain.Person.Birthday(DateTime.Parse("1995-03-03")), Salary=32560m},
                new Teacher{ TeacherID=9, Name="Laura", Birthday=new Domain.Person.Birthday(DateTime.Parse("1984-04-11")), Salary=32560m},
                new Teacher{ TeacherID=10, Name="Nino", Birthday=new Domain.Person.Birthday(DateTime.Parse("1999-11-29")), Salary=45000m}
            };
            teachers.ForEach(teacher => context.Teachers.Add(teacher));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
                new Subject{ SubjectID=1, Description="MD Discipline 1", Course=courses.Single(course => course.Description == "Medicine"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 1) },
                new Subject{ SubjectID=2, Description="MD Discipline 2", Course=courses.Single(course => course.Description == "Medicine"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 2) },
                new Subject{ SubjectID=3, Description="MD Discipline 3", Course=courses.Single(course => course.Description == "Medicine"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 3) },
                new Subject{ SubjectID=4, Description="MD Discipline 4", Course=courses.Single(course => course.Description == "Medicine"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 3) },
                new Subject{ SubjectID=5, Description="CS Discipline 1", Course=courses.Single(course => course.Description == "Computer Science"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 5) },
                new Subject{ SubjectID=6, Description="CS Discipline 2", Course=courses.Single(course => course.Description == "Computer Science"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 7) },
                new Subject{ SubjectID=7, Description="CS Discipline 3", Course=courses.Single(course => course.Description == "Computer Science"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 10) },
                new Subject{ SubjectID=8, Description="CS Discipline 4", Course=courses.Single(course => course.Description == "Computer Science"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 9) },
                new Subject{ SubjectID=9, Description="Bio Discipline 1", Course=courses.Single(course => course.Description == "Biology"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 8) },
                new Subject{ SubjectID=10, Description="Bio Discipline 2", Course=courses.Single(course => course.Description == "Biology"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 10) },
                new Subject{ SubjectID=11, Description="Bio Discipline 3", Course=courses.Single(course => course.Description == "Biology"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 4) },
                new Subject{ SubjectID=12, Description="Bio Discipline 4", Course=courses.Single(course => course.Description == "Biology"), Teacher=context.Teachers.Single(teacher => teacher.TeacherID == 6) },
            };
            subjects.ForEach(subject => context.Subjects.Add(subject));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student{
                    StudentID=1, Name="Jose", RegistrationNumber="0000001", Birthday=new Domain.Person.Birthday(DateTime.Parse("1999-11-29")), Subjects=new List<Subject>{
                        context.Subjects.Single(subject => subject.SubjectID == 1),
                        context.Subjects.Single(subject => subject.SubjectID == 2),
                        context.Subjects.Single(subject => subject.SubjectID == 3),
                        context.Subjects.Single(subject => subject.SubjectID == 4),
                    }
                },

               new Student{
                    StudentID=2, Name="Maria", RegistrationNumber="0000002", Birthday=new Domain.Person.Birthday(DateTime.Parse("2000-06-25")), Subjects=new List<Subject>{
                        context.Subjects.Single(subject => subject.SubjectID == 2),
                        context.Subjects.Single(subject => subject.SubjectID == 4),
                    }
               },
               new Student{
                    StudentID=3, Name="Anderson", RegistrationNumber="0000003", Birthday=new Domain.Person.Birthday(DateTime.Parse("1996-02-29")), Subjects=new List<Subject>{
                        context.Subjects.Single(subject => subject.SubjectID == 6),
                        context.Subjects.Single(subject => subject.SubjectID == 5),
                        context.Subjects.Single(subject => subject.SubjectID == 8),
                    }
               },
               new Student{
                    StudentID=4, Name="Carlos", RegistrationNumber="0000004", Birthday=new Domain.Person.Birthday(DateTime.Parse("1980-03-18")), Subjects=new List<Subject>{
                        context.Subjects.Single(subject => subject.SubjectID == 10),
                    }
               }
            };
            students.ForEach(student => context.Students.Add(student));
            context.SaveChanges();

            var grades = new List<Grade>
            {
                new Grade{ StudentID=1, SubjectID=1, Value=10m },
                new Grade{ StudentID=1, SubjectID=2, Value=9.5m },
                new Grade{ StudentID=1, SubjectID=3, Value=4.75m },
                new Grade{ StudentID=1, SubjectID=4, Value=7.67m },
                new Grade{ StudentID=2, SubjectID=2, Value=6.99m },
                new Grade{ StudentID=2, SubjectID=4, Value=10m },
                new Grade{ StudentID=3, SubjectID=6, Value=9.87m },
                new Grade{ StudentID=3, SubjectID=5, Value=7.23m },
                new Grade{ StudentID=3, SubjectID=8, Value=9m },
                new Grade{ StudentID=4, SubjectID=10, Value=8.19m },
            };
            grades.ForEach(grade => context.Grades.Add(grade));
            context.SaveChanges();
        }
    }
}
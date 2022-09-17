using OOP7Dz.Entity;
using OOP7Dz.Model;

namespace OOP7Dz.View
{
    public class Print
    {
        public static void PrintListTeacher(List<Teacher> list)
        {
            foreach (Teacher teacher in list)
            {
                teacher.printSkill();
            }
        }
        public static void PrintListStudent(List<Student> list)
        {
            foreach(Student student in list)
            {
                student.printSkill();
            }
        }
        public static void PrintClassLesson(ClassLesson classLesson)
        {
            Console.WriteLine(" Придмет класса - " + PrintLesson(classLesson.Lesson) + " Учитель - " + classLesson.Teacher.Name + "\n Учиники: ");
            foreach (Student student in classLesson.Students)
            {                
                student.printSkill();
            }
        }

        public static string PrintLesson(Lesson lesson )
        {
            switch (lesson)
            {
                case (Lesson)1:
                    return "Математика";
                case (Lesson)2:
                    return "Русский";
                case (Lesson)3:
                    return "Гимнастика";
                case (Lesson)4:
                    return "История";
                case (Lesson)5:
                    return "География";

               default: return "Не присовен придмет";
            }
           

            

        }
    }
}

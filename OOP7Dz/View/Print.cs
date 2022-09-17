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
            Console.WriteLine(classLesson + " Учитель - " + classLesson.Teacher.Name + " Придмет - " + classLesson.Lesson.ToString() + "\n Учиники: ");
            foreach (Student student in classLesson.Students)
            {
                Console.WriteLine("Имя = "+ student.Name + " Лет" + student.Age + student.printSkill);
            }
        }
    }
}

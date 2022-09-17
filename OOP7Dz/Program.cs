// See https://aka.ms/new-console-template for more information
//        Создать информационную систему позволяющую работать с сотрудниками некой компании
//        \ студентами вуза \ учениками школы

using OOP7Dz.Entity;
using OOP7Dz.Model;
using OOP7Dz.View;

Teacher Ivan = new Teacher("Ivan", 34, Lesson.Mathematics);

Teacher Den = new Teacher("Den", 34, Lesson.Gymnastics);

Teacher Oleg = new Teacher("Oleg", 34, Lesson.History);

Teacher Dima = new Teacher("Dima", 34, Lesson.Geography);

Teacher Sergey = new Teacher("Sergey", 34, Lesson.Russian);

List<Teacher> teacherList = new List<Teacher>() { Ivan, Den, Oleg, Dima, Sergey };
Console.WriteLine("____________________Учетиля_______________________");
Print.PrintListTeacher(teacherList);

Student _dimaS = new Student("_Dima", 15);
Student _olegS = new Student("_Oleg", 15);
Student _denS = new Student("_Den", 15);
Student _ivanS = new Student("_Ivan", 15);
Student _olgaS = new Student("_Olga", 15);

List<Student> studentList = new List<Student>() { _ivanS, _olegS , _denS, _dimaS };


Console.WriteLine("____________________Студенты_______________________");
Print.PrintListStudent(studentList);

Console.WriteLine("___________________________________________________");
ClassLesson classMath = new ClassLesson(Ivan, Lesson.Mathematics, studentList);
Print.PrintClassLesson(classMath);
Console.WriteLine("___________________________________________________");


classMath.Students.Remove(_ivanS);
classMath.Students.Add(_olgaS);
Print.PrintClassLesson(classMath);
    



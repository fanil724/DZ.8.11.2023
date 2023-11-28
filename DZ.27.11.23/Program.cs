using DZ._27._11._23;
using Microsoft.EntityFrameworkCore;

//using (ApplicationContext db = new ApplicationContext())
//{
//    Student s1 = new Student() { Name = "Petr", Surname = "Petrov", Rating = 2 };
//    Student s2 = new Student() { Name = "Sema", Surname = "Sidorov", Rating = 3 };
//    Student s3 = new Student() { Name = "Ivan", Surname = "Ivanov", Rating = 4 };
//    Student s4 = new Student() { Name = "Boris", Surname = "Pupkin", Rating = 1 };

//    Gruops g1 = new Gruops() { Name = "pv211", Year = 2 };
//    Gruops g2 = new Gruops() { Name = "pv213", Year = 1 };


//    GroupsStudents students1 = new GroupsStudents() { student = s1, gruops = g1 };
//    GroupsStudents students2 = new GroupsStudents() { student = s2, gruops = g1 };
//    GroupsStudents students3 = new GroupsStudents() { student = s3, gruops = g2 };
//    GroupsStudents students4 = new GroupsStudents() { student = s4, gruops = g2 };
//    db.AddRange(students1, students2, students3, students4);
//    db.SaveChanges();

//}

using (ApplicationContext db = new ApplicationContext())
{
    foreach (var g in db.gruops.ToList())
    {
        Console.WriteLine($"{g.Id}.{g.Name} - {g.Year}");
        foreach (var gs in db.groupsStudents.Where(gss => gss.GroupsID == g.Id).Include(s=>s.student))
        {
            Console.WriteLine($"        {gs.student.Id}.{gs.student.Name} - {gs.student.Surname} - {gs.student.Rating}");
        }
    }
}

using DZ._17._11._2023;
using Microsoft.EntityFrameworkCore;

using (ApplicationContext db = new ApplicationContext())
{
    Department d1 = new Department() { Name = "Advertising department" };
    Department d2 = new Department() { Name = "Purchase department" };
    Department d3 = new Department() { Name = "Directorate" };
    Department d4 = new Department() { Name = "Accounting" };
    Department d5 = new Department() { Name = "Training part" };
    Department d6 = new Department() { Name = "Dining room" };
    Department d7 = new Department() { Name = "Technical department" };

    Human h1 = new Human() { Surname = "Соколов", Name = "Александр", BirthDay = "07.09.1975" };
    Human h2 = new Human() { Surname = "Белых", Name = "Алексей", BirthDay = "23.03.1965" };
    Human h3 = new Human() { Surname = "Мухин", Name = "Антон", BirthDay = "24.05.1961" };
    Human h4 = new Human() { Surname = "Ильина", Name = "Анна", BirthDay = "16.10.1983" };
    Human h5 = new Human() { Surname = "Плужников", Name = "Дмитрий", BirthDay = "15.05.1956" };
    Human h6 = new Human() { Surname = "Андреева", Name = "Елена", BirthDay = "05.01.1961" };
    Human h7 = new Human() { Surname = "Бортникова", Name = "Алла", BirthDay = "23.12.1960" };


    Firma f1 = new Firma() { Name = "Техно IT", department = d1, human = h1 };
    Firma f2 = new Firma() { Name = "ИнфиниTEK", department = d2, human = h2 };
    Firma f3 = new Firma() { Name = "DevMagik", department = d3, human = h3 };
    Firma f4 = new Firma() { Name = "Нексус", department = d4, human = h4 };
    Firma f5 = new Firma() { Name = "Dev-Тек", department = d5, human = h5 };
    Firma f6 = new Firma() { Name = "Pro Soft", department = d6, human = h6 };
    Firma f7 = new Firma() { Name = "СмартТроникс", department = d7, human = h7 };

    //db.AddRange(new[] { f1, f2, f3, f4, f5, f6, f7 });
    //db.SaveChanges();

    var fir = db.firma.Include(f => f.department).Include(f => f.human).ToList();
    foreach (var f in fir)
    {
        Console.WriteLine($"{f.Id}.{f.Name} - {f.human.Name} - {f.human.Surname} - {f.human.BirthDay} - {f.department.Name}");
    }

}

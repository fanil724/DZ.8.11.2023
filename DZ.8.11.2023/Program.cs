
using DZ._8._11._2023;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
using (ApplicationContext db = new ApplicationContext())
{
    //Groups g1 = new Groups() { Name = "pv211", Year = 2022 };
    //Groups g2 = new Groups() { Name = "pv213", Year = 2021 };
    //Groups g3 = new Groups() { Name = "pv221", Year = 2020 };
    //Groups g4 = new Groups() { Name = "pv111", Year = 2010 };

    //db.groups.AddRange(new List<Groups> { g1, g2, g3 });

    //Curators c1 = new Curators() { Name = "Petrov" };
    //c1.groups.Add(g1);
    //c1.groups.Add(g2);
    //Curators c2 = new Curators() { Name = "Sidorov" };
    //c2.groups.Add(g3);
    //c2.groups.Add(g4);

    //db.curators.Add(c1);
    //db.curators.Add(c2);

    //Departments d1 = new Departments() { Name = "Software Development", Financing = 56000 };
    //Departments d2 = new Departments() { Name = "Heat Engines Language", Financing = 23000 };

    //g1.Departments = d1;
    //g2.Departments = d2;
    //g3.Departments = d2;
    //g4.Departments = d1;

    //Faculties f1 = new Faculties() { Name = "Computer Science", Financing = 764512 };
    //Faculties f2 = new Faculties() { Name = "Economics and Management", Financing = 561200 };

    //d1.Faculties = f2;
    //d2.Faculties = f1;
    //db.SaveChanges();
    //Console.WriteLine("Обьекты успешно сохранены");

    Console.WriteLine("Список обьектов");
    foreach (var g in db.groups.Include(g => g.curators))
    {
        Console.WriteLine("{0} - {1} - {2}", g.id, g.Name, g.Year);
        foreach (var c in g.curators)
        {
            Console.WriteLine($"{c.id} - {c.Name}");
        }
    }
    Console.WriteLine();

    foreach (var g in db.curators.Include(c => c.groups))
    {
        Console.WriteLine($"{g.id} - {g.Name}");
        foreach (var c in g.groups)
        {
            Console.WriteLine($"{c.id} - {c.Name} - {c.Year}");
        }
    }
    Console.WriteLine();

    foreach (var d in db.departments.Include(d => d.groups))
    {
        Console.WriteLine($"{d.id} - {d.Name} - {d.Financing}");
        foreach (var c in d.groups)
        {
            Console.WriteLine($"{c.id} - {c.Name} - {c.Year}");
        }
    }
    Console.WriteLine();

    foreach (var f in db.faculties.Include(f=>f.departments)) {
        Console.WriteLine($"{f.id} - {f.Name} - {f.Financing}");
        foreach (var c in f.departments)
        {
            Console.WriteLine($"{c.id} - {c.Name} - {c.Financing}");
        }
    }
}
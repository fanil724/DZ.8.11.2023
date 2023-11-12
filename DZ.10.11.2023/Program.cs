using DZ._10._11._2023;
using Microsoft.EntityFrameworkCore;

//using (ApplicationContext app = new ApplicationContext())
//{
//    Car car1 = new Car() { Brand = "BMW", Model = "M5 F90", YearOfIssue = 2020, Power = 545.6, EngineCapacity = 4.5 };
//    Car car2 = new Car() { Brand = "Porshe", Model = "Carera", YearOfIssue = 2021, Power = 505.6, EngineCapacity = 5.5 };
//    Car car3 = new Car() { Brand = "Mercedes-Benz", Model = "GLB", YearOfIssue = 2019, Power = 440.5, EngineCapacity = 3.5 };
//    Car car4 = new Car() { Brand = "Toyota", Model = "Camry", YearOfIssue = 2016, Power = 167.6, EngineCapacity = 2.4 };
//    Car car5 = new Car() { Brand = "Ford", Model = "GT40", YearOfIssue = 2021, Power = 655.6, EngineCapacity = 5.5 };
//    Car car6 = new Car() { Brand = "Bugatti", Model = "Shiron", YearOfIssue = 2021, Power = 1500.6, EngineCapacity = 10.5 };

//    app.Add(car1);
//    app.Add(car2);
//    app.Add(car3);
//    app.Add(car4);
//    app.Add(car5);
//    app.Add(car6);
//    app.SaveChanges();
//}


using (ApplicationContext app = new ApplicationContext())
{

    var Cars = app.car.ToList();
    foreach (var car in Cars)
    {
        Console.WriteLine($"{car.Id}.{car.Brand} - {car.Model} - {car.YearOfIssue} - {car.Power} - {car.EngineCapacity}");
    }
    Console.WriteLine();

}

//using (ApplicationContext app = new ApplicationContext())
//{
//    var Cars = app.car.ToList();
//    Cars[6].Model = "M5 G82";
//    Cars[8].Model = "amg gle 53";
//    Cars[7].Model = "ponamera";
//    Cars[10].Model = "focus";
//    Cars[10].Power = 150;
//    Cars[10].EngineCapacity = 2.0;
//    Cars[11].Model = "Veiron";
//    Cars[11].Power = 1000.1;
//    app.SaveChanges();


//    var Carss = app.car.ToList();
//    foreach (var car in Carss)
//    {
//        Console.WriteLine($"{car.Id}.{car.Brand} - {car.Model} - {car.YearOfIssue} - {car.Power} - {car.EngineCapacity}");
//    }

//}

using (ApplicationContext app = new ApplicationContext())
{

    Car car = app.car.ToList().FirstOrDefault(car => car.Model == "GLB");

    if (car != null)
    {
        app.Remove(car);
        app.SaveChanges();
    }


    var Cars = app.car.ToList();
    foreach (var c in Cars)
    {
        Console.WriteLine($"{c.Id}.{c.Brand} - {c.Model} - {c.YearOfIssue} - {c.Power} - {c.EngineCapacity}");
    }
}
using _13._11._2023;

using (ApplicationContext db = new ApplicationContext("DefaultConnection"))
{
    Customer c1 = new Customer() { Age = 33, FirstName = "Petr", LastName = "Petrov", Address = "Lenina 89", Email = "pter@mail.ru", Phone = "8907567523" };
    Customer c2 = new Customer() { Age = 22, FirstName = "Sema", LastName = "Sidorov", Address = "Pushkina 29", Email = "sem@mail.ru", Phone = "8907567523" };
    Customer c3 = new Customer() { Age = 21, FirstName = "Volodya", LastName = "Ivanov", Address = "Ostrovckovo 9", Email = "vovo@mail.ru", Phone = "8902134132" };
    Customer c4 = new Customer() { Age = 23, FirstName = "Ivan", LastName = "Petrov", Address = "Lenina 39", Email = "ivann@mail.ru", Phone = "8976345423" };
    Customer c5 = new Customer() { Age = 42, FirstName = "Dima", LastName = "Puprin", Address = "Chulman 89", Email = "pter@mail.ru", Phone = "8923545423" };

    db.Add(c1);
    db.Add(c2);
    db.Add(c3);
    db.Add(c4);
    db.Add(c5);
    db.SaveChanges();

    var cus = db.customers.ToList();
    foreach (var c in cus)
    {
        c.print();
    }
}
Console.WriteLine();

using (ApplicationContext db = new ApplicationContext("MSSQLSERVERConnection"))
{
    Customer c1 = new Customer() { Age = 33, FirstName = "Petr", LastName = "Petrov", Address = "Lenina 89", Email = "pter@mail.ru", Phone = "8907567523" };
    Customer c2 = new Customer() { Age = 22, FirstName = "Sema", LastName = "Sidorov", Address = "Pushkina 29", Email = "sem@mail.ru", Phone = "8907567523" };
    Customer c3 = new Customer() { Age = 21, FirstName = "Volodya", LastName = "Ivanov", Address = "Ostrovckovo 9", Email = "vovo@mail.ru", Phone = "8902134132" };
    Customer c4 = new Customer() { Age = 23, FirstName = "Ivan", LastName = "Petrov", Address = "Lenina 39", Email = "ivann@mail.ru", Phone = "8976345423" };
    Customer c5 = new Customer() { Age = 42, FirstName = "Dima", LastName = "Puprin", Address = "Chulman 89", Email = "pter@mail.ru", Phone = "8923545423" };

    db.Add(c1);
    db.Add(c2);
    db.Add(c3);
    db.Add(c4);
    db.Add(c5);
    db.SaveChanges();

    var cus = db.customers.ToList();
    foreach (var c in cus)
    {
        c.print();
    }
}



namespace DZ._17._11._2023
{
    public class Human
    {
        public int Id { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? BirthDay { get; set; }
    }

    public class Firma
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Human human { get; set; }
        public Department department { get; set; }

    }


    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}

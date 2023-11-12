namespace DZ._8._11._2023
{
    public class Faculties
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Financing { get; set; }


        public ICollection<Departments> departments { get; set; }
        public Faculties()
        {
            departments = new List<Departments>();
        }
    }

    public class Departments
    {
        public int id { get; set; }
        public int Financing { get; set; }
        public string Name { get; set; }


        public ICollection<Groups> groups { get; set; }
        public Departments()
        {
            groups = new List<Groups>();
        }


        public int? FacultiesID { get; set; }
        public Faculties Faculties { get; set; }
    }

    public class Groups
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public ICollection<Curators> curators { get; set; }
        public Groups()
        {
            curators = new List<Curators>();
        }
        public int? DepartamentID { get; set; }
        public Departments Departments { get; set; }
    }



    public class Curators
    {
        public int id { get; set; }
        public string Name { get; set; }
        public ICollection<Groups> groups { get; set; }
        public Curators()
        {
            groups = new List<Groups>();
        }
    }
}

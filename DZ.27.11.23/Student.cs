using System.ComponentModel.DataAnnotations.Schema;

namespace DZ._27._11._23
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Rating { get; set; }
    }

    public class Gruops
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }

    public class GroupsStudents
    {
        public int Id { get; set; }

        public int? StudentsID { get; set; }
        [ForeignKey("StudentsID")]
        public Student student { get; set; }

        public int? GroupsID { get; set; }
        [ForeignKey("GroupsID")]
        public Gruops gruops { get; set; }
    }
}

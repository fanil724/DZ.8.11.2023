namespace _13._11._2023
{
    internal class Customer
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public void print()
        {
            Console.WriteLine($"{Id}.{FirstName} - {LastName} - {Age} - {Address} - {Email} - {Phone}");
        }
    }
}

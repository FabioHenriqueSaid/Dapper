namespace Dapper.Domain.StoreContext.Entities
{
    public class Customer
    {
        public Customer(
            string firstName,
            string lastName,
            string phone,
            string document,
            string address
            )
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Document = document;
            Address = address;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string Document { get; private set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
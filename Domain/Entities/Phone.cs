namespace Domain.Entities
{
    public class Phone
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
    }
}

using System.Collections.Generic;

namespace Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }        
        public IEnumerable<Phone> Phones { get; set; }
    }
}

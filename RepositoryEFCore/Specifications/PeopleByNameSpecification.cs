using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.Specifications
{
    public class PeopleByNameSpecification : BaseSpecifcation<Person>
    {
        public PeopleByNameSpecification(string name) : base(x=>x.Name.Contains(name))
        {
            AddOrderByDescending(x => x.Id);
        }
    }
}

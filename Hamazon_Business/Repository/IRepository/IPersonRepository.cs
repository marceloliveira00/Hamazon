using Hamazon_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamazon_Business.Repository.IRepository
{
    public interface IPersonRepository
    {
        public PersonDTO Create(PersonDTO objDTO);
        public PersonDTO Update(PersonDTO objDTO);
        public PersonDTO Get(int id);
        public int Delete(int id);
        public IEnumerable<PersonDTO> GetAll();
    }
}

using AutoMapper;
using Hamazon_Business.Repository.IRepository;
using Hamazon_DataAccess;
using Hamazon_DataAccess.Data;
using Hamazon_Models;

namespace Hamazon_Business.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly HamazonDbContext _db;
        private readonly IMapper _mapper;

        public PersonRepository(HamazonDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public PersonDTO Create(PersonDTO objDTO)
        {
            Person obj = _mapper.Map<PersonDTO, Person>(objDTO);
            obj.CreatedDate = DateTime.Now;
            obj.UpdatedDate = DateTime.Now;

            var addedObj = _db.People.Add(obj);
            _db.SaveChanges();

            return _mapper.Map<Person, PersonDTO>(addedObj.Entity);
        }

        public int Delete(int id)
        {
            Person obj = _db.People.FirstOrDefault(x => x.Id == id);

            if (obj == null) return 0;

            _db.People.Remove(obj);
            return _db.SaveChanges();
        }

        public PersonDTO Get(int id)
        {
            Person obj = _db.People.FirstOrDefault(x => x.Id == id);

            if (obj == null) return new PersonDTO();

            return _mapper.Map<Person, PersonDTO>(obj);
        }

        public IEnumerable<PersonDTO> GetAll() => _mapper.Map<IEnumerable<Person>, IEnumerable<PersonDTO>>(_db.People);

        public PersonDTO Update(PersonDTO objDTO)
        {
            Person objFromDb = _db.People.FirstOrDefault(x => x.Id == objDTO.Id);

            if (objFromDb != null)
            {
                objFromDb.Name = string.IsNullOrEmpty(objDTO.Name) ? objFromDb.Name : objFromDb.Name = objDTO.Name;
                objFromDb.TimesInstallments = objDTO.TimesInstallments == 0 ? objFromDb.TimesInstallments : objDTO.TimesInstallments;
                objFromDb.PaidInstallments = objDTO.PaidInstallments == 0 ? objFromDb.PaidInstallments : objDTO.PaidInstallments;
                objFromDb.Cash = string.IsNullOrEmpty(objDTO.Cash) ? objFromDb.Cash : objDTO.Cash;
                objFromDb.UpdatedDate = DateTime.Now;

                _db.People.Update(objFromDb);
                _db.SaveChanges();

                return _mapper.Map<Person, PersonDTO>(objFromDb);
            }

            return objDTO;
        }
    }
}

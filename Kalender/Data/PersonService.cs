using Kalender.Context;
using Microsoft.EntityFrameworkCore;

namespace Kalender.Data
{
    public class PersonService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public PersonService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get all Persons List
        public async Task<List<Person>> GetAllPersons()
        {
            return await _applicationDbContext.Person.ToListAsync();
        }

        //Add New Person Record
        public async Task<bool> AddNewPerson(Person person)
        {
            await _applicationDbContext.Person.AddAsync(person);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get Person by Id
        public async Task<Person> GetPersonById(int id)
        {
            Person person = await _applicationDbContext.Person.FirstOrDefaultAsync(x => x.Id == id);
            return person;
        }

        //Update Person Data
        public async Task<bool> UpdatePersonDetails(Person person)
        {
            _applicationDbContext.Person.Update(person);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete Person Data
        public async Task<bool> DeletePerson(Person person)
        {
            _applicationDbContext.Person.Remove(person);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

    }
}

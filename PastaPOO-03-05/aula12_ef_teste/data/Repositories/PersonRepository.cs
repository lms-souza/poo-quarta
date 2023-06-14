using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Data;
using Domain.Entities;

namespace Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext context;
        public PersonRepository(DataContext context)
        {
            this.context = context;
        }
        public IList<Person> GetAll()
        {
            return context.People.ToList();
        }
        public void Save(Person entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            var person = GetById(entityId);
            context.Remove(person);
            context.SaveChanges();
            return true;
        }



        public Person GetById(int entityId)
        {
            return context.People.SingleOrDefault(x=>x.Id == entityId);
        }



        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
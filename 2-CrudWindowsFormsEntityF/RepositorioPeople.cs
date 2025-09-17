using System.Collections.Generic;
using System.Linq;
using _2_CrudWindowsFormsEntityF.Models;

namespace _2_CrudWindowsFormsEntityF
{
    public class RepositorioPeople
    {
        public bool Ok()
        {
            try
            {
                using var db = new CrudContext();
                return db.Database.CanConnect();
            }
            catch
            {
                return false;
            }
        }

        public List<Person> Get()
        {
            using var db = new CrudContext();
            return db.People.ToList();
        }

        public Person? Get(int? id)
        {
            if (id == null) return null;
            using var db = new CrudContext();
            return db.People.FirstOrDefault(p => p.Id == id);
        }

        public void Add(string name, int age)
        {
            using var db = new CrudContext();
            var person = new Person { Name = name, Age = age };
            db.People.Add(person);
            db.SaveChanges();
        }

        public void Update(string name, int age, int id)
        {
            using var db = new CrudContext();
            var person = db.People.Find(id);
            if (person != null)
            {
                person.Name = name;
                person.Age = age;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using var db = new CrudContext();
            var person = db.People.Find(id);
            if (person != null)
            {
                db.People.Remove(person);
                db.SaveChanges();
            }
        }
    }
}
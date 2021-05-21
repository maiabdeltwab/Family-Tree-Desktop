using FamilyTree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.BAO
{
    public class PersonBao
    {
        private readonly FamilyTreeEntities context
            = new FamilyTreeEntities();

        public List<Person> GetAll()
        {
            return context.People.ToList();
        }

        public List<PersonVM> GetFemales()
        {
            return (from p in context.People
                    where p.Gender == false
                    select new PersonVM
                    {
                        Id = p.Id,
                        FullName = p.FatherID != null ?
                        p.FirstName + " " + p.LastName
                        + " " + p.Father.LastName
                        : p.FirstName + " " + p.LastName,
                        IsMarriage = p.MarriageFrom != null
                    }
                ).ToList();
        }

        public List<PersonVM> GetMales()
        {
            return (from p in context.People
                    where p.Gender == true
                    select new PersonVM
                    {
                        Id = p.Id,
                        FullName = p.FatherID != null ?
                        p.FirstName + " " + p.LastName
                        + " " + p.Father.LastName
                        : p.FirstName + " " + p.LastName,
                        IsMarriage = p.MarriageFrom != null
                    }
                ).ToList();
        }

        public bool Create(Person person)
        {
            try
            {
                context.People.Add(person);

                if (person.MarriageFrom != null)
                {
                    var partner = context.People.Find(person.MarriageFrom);
                    partner.MarriageFrom = person.Id;
                }
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Person person)
        {
            try
            {
                var person2 = context.People.Find(person.Id);

                person2.FirstName = person.FirstName;
                person2.LastName = person.LastName;
                person2.Birthdate = person.Birthdate;
                person2.Gender = person.Gender;
                person2.ImagePath = person.ImagePath;

                person2.FatherID = person.FatherID;
                person2.MotherId = person.MotherId;
                person2.MarriageFrom = person.MarriageFrom;

                if (person2.MarriageFrom != null)
                {
                    var partner = context.People.Find(person2.MarriageFrom);
                    partner.MarriageFrom = person2.Id;
                }

                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Person person)
        {
            try
            {
                var person2 = context.People.Find(person.Id);

                var relate = context.People.Where(p => p.FatherID == person2.Id
                             || p.MotherId == person2.Id).ToList();

                if (relate.Count == 0)
                {
                    if (person2.MarriageFrom != null)
                    {
                        var partner = context.People.Find(person2.MarriageFrom);
                        partner.MarriageFrom = null;
                    }

                    context.People.Remove(person2);

                    context.SaveChanges();
                }
                else
                    throw new Exception();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Person> Parents()
        {
            var parents = context.People
                .Where(p => (p.FatherID == null && p.MotherId == null)
                 && (p.MarraigeFrom.MotherId == null && p.MarraigeFrom.FatherID == null))
                .ToList();

            return parents;
        }
    }
}
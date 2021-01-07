using EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.MyMigration
{
    public class CRUDOperations
    {
        public void InserPersonDetails()
        {
            using (var context = new CRUDOperationContext())
            {
                var person = new Person();
                Console.WriteLine("Insert Person details");
                Console.WriteLine("PersonID:");
                person.PersonId = int.Parse(Console.ReadLine());
                Console.WriteLine("FirstName:");
                person.FirstName = Console.ReadLine();
                Console.WriteLine("LastName:");
                person.LastName = Console.ReadLine();
                Console.WriteLine("Age:");
                person.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Gender:");
                person.Gender = Console.ReadLine();
                Console.WriteLine("Mobile:");
                person.Mobile = long.Parse(Console.ReadLine());
                context.persons.Add(person);
                context.SaveChanges();
                Console.WriteLine("Records successfully installed into Person table.....");
            }
        }

        public void InsertJobDetails()
        {
            using (var context = new CRUDOperationContext())
            {
                var job = new Job();
                Console.WriteLine("Insert Job details");
                Console.WriteLine("Job Id:");
                job.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Job Role:");
                job.Role = Console.ReadLine();
                Console.WriteLine("Job PersonId:");
                job.PersonId = int.Parse(Console.ReadLine());
                context.jobs.Add(job);
                context.SaveChanges();
                Console.WriteLine("Records successfully installed into Job table.....");
            }
        }
    }
}

using EntityFramework.MyMigration;
using System;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            new CRUDOperations().InserPersonDetails();
            new CRUDOperations().InsertJobDetails();
        }
    }
}

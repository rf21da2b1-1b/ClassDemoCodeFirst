using System;
using System.Linq;
using ClassDemoCodeFirst.model;

namespace ClassDemoCodeFirst
{
    public class AWorker
    {
        public AWorker()
        {
        }

        public void Start()
        {
            PersonDBContext db = new PersonDBContext();

            var personer = db.Personer.ToList();

            foreach (Person p in personer)
            {
                Console.WriteLine(p);
            }


        }
    }
}
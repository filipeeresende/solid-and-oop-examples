using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public abstract class BaseRepository
    {
        public virtual void GetById()
        {
            // search by id
        }
        public void Update()
        {
            // update in the database
        }
        public void Insert()
        {
            // insert in the database
        }
    }
}

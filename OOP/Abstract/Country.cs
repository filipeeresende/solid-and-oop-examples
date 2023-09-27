using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstract
{
    public abstract class Country
    {
        public int Name { get; set; }
        public int Id { get; set; }

        public abstract void WriteNationalAnthem();
        public virtual void ValidateContinent()
        {

        }
    }
}


//We can see that with the abstract method I force the classes
//that are inheriting from the Country class to implement the
//WriteNationalAnthem method, however each class can have its validation for this method
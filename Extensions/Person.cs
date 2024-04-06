using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal class Person
    {
        public string FullName;
        public double Cash;
        private static int _id;
        public int Id;
        private static sbyte _age;
        public sbyte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value<0 || value > 125)
                {
                    Console.WriteLine("yanlisdir");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public Person(string fullName,sbyte age,double cash)
        {
            _id++;
            Id = _id;
            FullName = fullName;
            Age = age;
            Cash = cash;

        }

        public override string ToString()
        {
            return $"{FullName}  {Age}  {Id}  {Cash}";
        }



    }
}

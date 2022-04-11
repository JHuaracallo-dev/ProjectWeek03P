using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana03P.Entities
{
    public class Person
    {
        public int DNI { get; set; }
        public string Surnane { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        //Constructor
        public Person()
        {
        }

        /// Autor: John Huaracallo
        /// Date: 10-04-2022
        /// <summary>
        /// Overloaded constructor method 
        /// </summary>
        /// <param name="DNI"></param>
        /// <param name="Surname"></param>
        /// <param name="Name"></param>
        /// <param name="Age"></param>
        /// <param name="email"></param>
        public Person(int DNI, string Surname, string Name, int Age, string email)
        {
            this.DNI = DNI;
            this.Surnane = Surname;
            this.Name = Name;
            this.Age = Age;
            this.Email = email;
        }

    }
}

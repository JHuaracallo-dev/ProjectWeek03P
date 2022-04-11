using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana03P.Entities
{   
    /// Autor: John Huaracallo
    /// Date: 10-04-2022
    /// <summary>
    /// Creation Class, properties and Constructor
    /// </summary>
    public class Client: Person
    {

        //Constructor
        public Client() { }

        //Constructor overloaded
        public Client(int DNI, string Surname, string Name, int Age, string Email)
        {
            this.DNI = DNI;
            this.Surnane = Surname;
            this.Name = Name;
            this.Age = Age;
            this.Email = Email;
        }

        public void ClientUpdate(string Surname, string Name, int Age, string Email)
        {
            this.Surnane = Surname;
            this.Name = Name;
            this.Age = Age;
            this.Email = Email;
        }
    }
}

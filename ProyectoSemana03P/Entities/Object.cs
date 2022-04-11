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
    /// Creation class, properties and constructor overloaded
    /// </summary>
    public class Object
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Constructor
        public Object() { }

        //Constructor Overloaded
        public Object(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}

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
    /// Create Class, properties and Constructor
    /// </summary>
    public class Product : Object
    {
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int State { get; set; }

        //Constructor
        public Product() { }
    }
}

using System;
using System.Collections.Generic;
using SchoolType;

namespace Coreschool.Entities
{
    public class School
    {
        public string UniqueId { get; private set;} = Guid.NewGuid().ToString();
        string name;

        public List<Course> Courses {get; set;}
        public string Name
        {
            //Retorna valor de name con prefijo "Copia"
            get { return "Copia: " + name; }
            //Recibe y cambia valor de name pasandolo a mayus
            set { name = value.ToUpper(); }

        }

        public int Year { get; set; }
        public string Country { get; set; }

        public string City { get; set; }
        
        /* public SchoolTypes SchoolType { get; set} */

        //public School(string intoname, int intoyear)
        //{
        //this.name = intoname;
        //Year = intoyear;
        //}
        public School(string name, int year, SchedulesType type) => (Name, Year) = (name, year);

        public School(string name, int year, SchedulesType type, string country = "", string city = "")
        {
            //asignación de tuplas
            (Name, Year) = (name, year);
            Country = country;
            this.City = city;
        }

        //asigna country y ciudad vacio, lo que no hace necesario que se le ingrese al llamar al metodo
        //Se llama firma a el valor que devuelve, valor que recibe y nombre
/*  */

        //Llevar infromación de objeto cuando se declare en  Console.WriteLine
/*         public override string ToString()
        {
            // Se agrega \ para ingresar comilla
            // System.Environment.NewLine: Salto de linea en todos los sistemas operativos
            return $"Name: \"{Name}\", Type: {SchoolType} {System.Environment.NewLine}, Country: {Country}, City: {City}";
        } */

        
    }


}
using System.Collections.Generic;
using SchoolType;

namespace Coreschool.Entities
{
    class School
    {
        string name;
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
        public SchoolTypes SchoolType;

        //public School(string intoname, int intoyear)
        //{
        //this.name = intoname;
        //Year = intoyear;
        //}

        public School(string name, int year) => (Name, Year) = (name, year);

        //asigna country y ciudad vacio, lo que no hace necesario que se le ingrese al llamar al metodo
        //Se llama firma a el valor que devuelve, valor que recibe y nombre
        public School(string name, int year, SchoolTypes type, string country = "", string city = "")
        {
            //asignación de tuplas
            (Name, Year) = (name, year);
            Country = country;
            this.City = city;
        }

        //Llevar infromación de objeto cuando se declare en  Console.WriteLine
        public override string ToString()
        {
            // Se agrega \ para ingresar comilla
            // System.Environment.NewLine: Salto de linea en todos los sistemas operativos
            return $"Name: \"{Name}\", Type: {SchoolType} {System.Environment.NewLine}, Country: {Country}, City: {City}";
        }

        public List<Course> Courses {get; set;}
    }


}
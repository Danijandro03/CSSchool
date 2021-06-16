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

        //Llevar infromación de objeto cuando se declare en  Console.WriteLine
        public override string ToString()
        {
            return $"Name: {Name}, Type: {SchoolType} \n Country: {Country}, City: {City}";
        }
    }


}
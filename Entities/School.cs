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

        public int Year{ get; set; }
        public string Country { get; set; }

        public string City { get; set; }
        public int SchoolType;

        //public School(string intoname, int intoyear)
        //{
            //this.name = intoname;
            //Year = intoyear;
        //}

        public School (string name, int year) => (Name, Year) = (name, year);
    }


}
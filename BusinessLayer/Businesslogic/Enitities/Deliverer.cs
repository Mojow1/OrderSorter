namespace orderSorter.Businesslogic.Business.Staff
{
    public class Deliverer : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; }
        public string Function { get;  }
        public bool Availability { get; set; }
        public bool DriversLicenceA { get;  }
        public bool DriversLicenceB { get;  }


        public Deliverer(string name, string function, bool availability, bool driversLicenceA, bool driversLicenceB)
        {
            Name = name;
            Function = function;
            Availability = availability;
            DriversLicenceA = driversLicenceA;
            DriversLicenceB = driversLicenceB;
        }

        public Deliverer(int id, string name, string function, bool availability, bool driversLicenceA, bool driversLicenceB)
        {
            Id = id;
            Name = name;
            Function = function;
            Availability = availability;
            DriversLicenceA = driversLicenceA;
            DriversLicenceB = driversLicenceB;
        }
    }
}
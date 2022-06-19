namespace orderSorter.Businesslogic.Business.Staff
{
    public class Deliverer
    {
        public int Id { get; set; }
        public string Name { get;  }
        public bool Employed { get; set; }
        public bool DriversLicenceA { get;  }
        public bool DriversLicenceB { get;  }


        public Deliverer(int id, string name, bool employed, bool driversLicenceA, bool driversLicenceB)
        {
            Id = id;
            Name = name;
            Employed = employed;
            DriversLicenceA = driversLicenceA;
            DriversLicenceB = driversLicenceB;
        }
    }
}
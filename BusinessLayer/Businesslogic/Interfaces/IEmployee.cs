
using System;
using Org.BouncyCastle.Asn1.X509;

namespace orderSorter.Businesslogic.Business.Staff
{
    public interface IEmployee
    {
        public int Id { get; set; }
        public string Name { get;  }
        public string Function { get;  }
        public bool Employed { get; set; }
        public bool DriversLicenceA { get;  }
        public bool DriversLicenceB { get;  }




    }
}
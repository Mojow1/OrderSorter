using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.Businesslogic.Interfaces
{
    public interface IOrder
    {
        public int Id { get;  }
        public DateTime OrderDate { get; }
        public DateTime AllowedEndTime { get;  }
        public bool Priority { get;  }
        public bool OrderAccepted { get; set; }
        public int OrderWeight { get;  }
        public List<IProduct> Products { get;  }
    }
}
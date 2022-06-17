using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;
using Org.BouncyCastle.Asn1.X509.Qualified;

namespace orderSorter.Businesslogic.Business.Staff
{
    public class Staff
    {
        private List<Deliverer> _deliverers;

        public Staff(List<Deliverer> deliverers) // Constructor
        {
            _deliverers = deliverers;
        }

        public void AddDeliverer(Deliverer deliverer)
        {
            int id = _deliverers.Count + 1;
            Deliverer newDeliverer = new Deliverer(id, deliverer.Name, deliverer.Employed,deliverer.LicenceA, deliverer.LicenceB);
            _deliverers.Add(newDeliverer);

        }
        
        public Deliverer FetchDeliverer(int id) // Fetch deliverer by ID
        {
            return _deliverers.Find(x => x.Id == id);
        }

        
        public List<Deliverer> FetchAllDeliverers()
        {
            return _deliverers;
        }

        
        public void RemoveDeliverer(int id) // De bezorger wordt niet volledig verwijderd krijgt een employed. Dit in verband met id nummering.
        {
            Deliverer delivererToRemove = _deliverers.Find(x => x.Id == id);

            if (delivererToRemove != null) // Check expression for null
            {
                Deliverer notEmployed = new Deliverer(delivererToRemove.Id, delivererToRemove.Name, false,
                    delivererToRemove.LicenceA, delivererToRemove.LicenceB);
            
                int index = _deliverers.FindIndex(x => x == delivererToRemove);
                _deliverers[index] = notEmployed;
            }
        }
    }
}
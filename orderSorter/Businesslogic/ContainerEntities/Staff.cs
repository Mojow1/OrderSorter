using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;
using Org.BouncyCastle.Asn1.X509.Qualified;

namespace orderSorter.Businesslogic.Business.Staff
{
    public class Staff
    {
        private List<IEmployee> _employees;

        public Staff(List<IEmployee> employees)
        {
            _employees = employees;
        }

        public void AddEmployee(IEmployee employee)
        {
            _employees.Add();
        }

        public IEmployee FetchEmployee(int id)
        {
            
        }

        public List<IEmployee> FetchAllEmployees()
        {
            return _employees;
        }

        public void RemoveEmployee(int id)
        {
            
        }
    }
}
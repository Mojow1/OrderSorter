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
            int id = _employees.Count + 1;
            employee.Id = id;
            _employees.Add(employee);

        }

        public IEmployee FetchEmployee(int id)
        {
            int index = _employees.FindIndex(x => x.Id == id);
            return _employees[index];
        }

        public List<IEmployee> FetchAllEmployees()
        {
            return _employees;
        }

        public void RemoveEmployee(int id)
        {
            int index = _employees.FindIndex(x => x.Id == id);
            _employees[index].Availability = false;
        }
    }
}
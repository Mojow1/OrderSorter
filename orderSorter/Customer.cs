namespace orderSorter
{
    public class Customer
    {

        private int _id;
        private string _firstName;
        private string _surName;
        private string _StreetName;
        private int _houseNumber;
        private string _zipCode;
        private string _city;

        public Customer(int id, string firstName, string surName, string streetName, int houseNumber, string zipCode, string city)
        {
            _id = id;
            _firstName = firstName;
            _surName = surName;
            _StreetName = streetName;
            _houseNumber = houseNumber;
            _zipCode = zipCode;
            _city = city;
        }
    }
}
namespace orderSorter.Businesslogic.Business.Staff
{
    public class Deliverer
    {
        public int _id;
        public string _name;
        public bool _employed;
        public bool _licenceA;
        public bool _licenceB;
        

        public Deliverer(string name, bool employed, bool licenceA, bool licenceB)
        {
            _name = name;
            _employed = employed;
            _licenceA = licenceA;
            _licenceB = licenceB;
        }
        
        public Deliverer(int id, string name, bool employed, bool licenceA, bool licenceB)
        {
            _id = id;
            _name = name;
            _employed = employed;
            _licenceA = licenceA;
            _licenceB = licenceB;
        }

        public int Id => _id;

        public string Name => _name;

        public bool Employed => _employed;

        public bool LicenceA => _licenceA;

        public bool LicenceB => _licenceB;
    }
}
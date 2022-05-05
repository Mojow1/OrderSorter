namespace orderSorter
{
    public class Bicycle // Child class of Vehicle
    {
        
        private double _maxloadingVolume;
        private double _maxDistance;
        private bool _usability;
        private bool _availability;
        private Deliverer _deliverer;


        public Bicycle(double maxloadingVolume, double maxDistance, bool usability, bool availability, Deliverer deliverer)
        {
            _maxloadingVolume = maxloadingVolume;
            _maxDistance = maxDistance;
            _usability = usability;
            _availability = availability;
            _deliverer = deliverer;
        }

        public bool checkUsability()
        {
            if (_usability == true)
            {
                return true;
            }

            return false;
        }

        public bool checkAvailability()
        {
            if (_availability == true)
            {
                return true;
            }
            return false;
        }
    }
}
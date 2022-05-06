namespace orderSorter
{
    public class Vehicle
    {
        private double _maxloadingVolume;
        private double _maxDistance;
        private bool _usability;
        private bool _availability;
        private Deliverer _deliverer;

        public Vehicle(double maxloadingVolume, double maxDistance, bool usability, bool availability, Deliverer deliverer)
        {
            _maxloadingVolume = maxloadingVolume;
            _maxDistance = maxDistance;
            _usability = usability;
            _availability = availability;
            _deliverer = deliverer;
        }
    }
}
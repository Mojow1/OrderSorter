namespace orderSorter
{
    public class DeliveryZone
    {
        private int _zone;
        
        private int _minutesNormalDeliveryBicycle;
        private int _minutesNormalDeliveryScooter;
        private int _minutesNormalDeliveryVan;

        private int _minutesExtraTimeBicycleMuchTraffic;
        private int _minutesExtraTimeScooterMuchTraffic;
        private int _minutesExtraTimeVanMuchTraffic;
        
        public DeliveryZone(int zone, int minutesNormalDeliveryBicycle, int minutesNormalDeliveryScooter, int minutesNormalDeliveryVan, int minutesExtraTimeBicycleMuchTraffic, int minutesExtraTimeScooterMuchTraffic, int minutesExtraTimeVanMuchTraffic)
        {
            _zone = zone;
            _minutesNormalDeliveryBicycle = minutesNormalDeliveryBicycle;
            _minutesNormalDeliveryScooter = minutesNormalDeliveryScooter;
            _minutesNormalDeliveryVan = minutesNormalDeliveryVan;
            _minutesExtraTimeBicycleMuchTraffic = minutesExtraTimeBicycleMuchTraffic;
            _minutesExtraTimeScooterMuchTraffic = minutesExtraTimeScooterMuchTraffic;
            _minutesExtraTimeVanMuchTraffic = minutesExtraTimeVanMuchTraffic;
        }

        public int Zone => _zone;

        public int MinutesNormalDeliveryBicycle => _minutesNormalDeliveryBicycle;

        public int MinutesNormalDeliveryScooter => _minutesNormalDeliveryScooter;

        public int MinutesNormalDeliveryVan => _minutesNormalDeliveryVan;

        public int MinutesExtraTimeBicycleMuchTraffic => _minutesExtraTimeBicycleMuchTraffic;

        public int MinutesExtraTimeScooterMuchTraffic => _minutesExtraTimeScooterMuchTraffic;

        public int MinutesExtraTimeVanMuchTraffic => _minutesExtraTimeVanMuchTraffic;
    }
}
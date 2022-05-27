using System.Xml.Serialization;

namespace orderSorter
{
    public interface IDeliver
    {
        public int Capacity { get; set; }
        public void Deliver();



    }
}
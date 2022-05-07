namespace orderSorter.Businesslogic.Algoritme
{
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            
            strategy.Execute();
        }
       
    }
}
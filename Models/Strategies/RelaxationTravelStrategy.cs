namespace Models.Strategies
{
    public class RelaxationTravelStrategy : ITravelStrategy
    {
        public void Plan()
        {
            Console.WriteLine("Estrategia para un viaje de relajación: planificando un itinerario sereno con tratamiento de spa.");
        }
    }
}
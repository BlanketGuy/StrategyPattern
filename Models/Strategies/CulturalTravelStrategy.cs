namespace Models.Strategies
{
    public class CulturalTravelStrategy : ITravelStrategy
    {
        public void Plan()
        {
            Console.WriteLine("Estrategia para un viaje cultural: planificando un itinerario cultural, con visitas a sitios históricos y artísticos.");
        }
    }
}
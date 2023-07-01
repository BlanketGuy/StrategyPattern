using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Strategies;

namespace Models
{
    public class TravelPlanner
    {
        private ITravelStrategy _travelStrategy;

        public void SetTravelStrategy(ITravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }

        public void PlanTravel()
        {
            Console.WriteLine("Comenzando la planificación de viaje...");
            _travelStrategy.Plan();
            Console.WriteLine("¡Itinerario terminado!");
        }
    }

}

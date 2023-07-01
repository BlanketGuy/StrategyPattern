using Models;
using Models.Strategies;

TravelPlanner travelPlanner = new();

Console.Write("Ingresar un número del 1 al 3, siendo:\n1. Viaje de aventura\n2. Viaje de relajación\n3. Viaje cultural\n");
int tipoViaje = int.Parse(Console.ReadLine());
bool opcionCorrecta = false;
while (tipoViaje != 0)
{
    switch (tipoViaje)
    {
        case 1:
            travelPlanner.SetTravelStrategy(new AdventureTravelStrategy());
            opcionCorrecta = true;
            break;
        case 2:
            travelPlanner.SetTravelStrategy(new RelaxationTravelStrategy());
            opcionCorrecta = true;
            break;
        case 3:
            travelPlanner.SetTravelStrategy(new CulturalTravelStrategy());
            opcionCorrecta = true;
            break;
        default:
            Console.WriteLine("Elija una opción válida. ");
            opcionCorrecta = false;
            break;
    }
    if (opcionCorrecta)
        travelPlanner.PlanTravel();
    Console.Write("Ingresar un número del 1 al 3, siendo:\n1. Viaje de aventura\n2. Viaje de relajación\n3. Viaje cultural\n");
    tipoViaje = int.Parse(Console.ReadLine());
}

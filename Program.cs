using System;

namespace Tiempo_de_viaje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duracion Tramo: ");
            int Tramo = Convert.ToInt32(Console.ReadLine());
            int hora = 60;
            int tiempoTotalViaje= 0;
            while (Tramo != 0)
            {
                tiempoTotalViaje += Tramo;
                Console.WriteLine("Duracion Tramo: ");
                Tramo = Convert.ToInt32(Console.ReadLine());
            }
            
            int horasdeViaje= tiempoTotalViaje / hora;
            int minutosdeViaje= tiempoTotalViaje % hora;
            Console.WriteLine("Tiempo total de viaje: " + horasdeViaje + " :" + minutosdeViaje);

            
            
        }

    }
}

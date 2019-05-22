using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{

    class AirTransport : Transport
    {
        public AirTransport(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
            : base(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers)
        { }

        public override void Delivery()
        {
            Console.WriteLine("\nГруз воздушным транспортом доставлен!\n");
        }
        public override void ShowInformation()
        {
            Console.WriteLine("\nИнформация о транспорте.\nВоздушный транспорт\nСкорость: " + Speed + " Км/ч\nГрузоподъёмность: " + LoadCapacity + " Кг\nМарка: " + TransportMark + "\nПерсонал: " + NumberOfStaff + "\nПассажиры: " + NumberOfPassengers + "\n");
        }
    }

    class  Aircraft : AirTransport
    {
        public Aircraft(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
            : base(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers)
        { }
    }

    class Helicopter : AirTransport
    {
        public Helicopter(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
            : base(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers)
        { }
    }
}

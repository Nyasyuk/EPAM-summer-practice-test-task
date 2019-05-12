using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{

    class GroundTransport : Transport
    {
        public GroundTransport(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
            : base(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers)
        { }

        public override void Delivery()
        {
            Console.WriteLine("\nГруз наземным транспортом доставлен!\n");
        }
        public override void ShowInformation()
        {
            Console.WriteLine("\nИнформация о транспорте.\nНаземный транспорт\nСкорость: " + Speed+ " Км/ч\nГрузоподъёмность: "+ LoadCapacity + " Кг\nМарка: " + TransportMark + "\nПерсонал: " + NumberOfStaff + "\nПассажиры: " + NumberOfPassengers + "\n");
        }
    }

    class Car : GroundTransport
    {
        public Car(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
            : base(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers)
        { }
    }

    class Train : GroundTransport
    {
        public Train(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
            : base(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers)
        { }
    }

    class Truck : GroundTransport
    {
        public Truck(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
            : base(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers)
        { }
    }
}

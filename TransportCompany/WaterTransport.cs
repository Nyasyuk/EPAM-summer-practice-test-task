using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{

    class WaterTransport : Transport
    {
        public WaterTransport(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
            : base(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers)
        { }

        public override void Delivery()
        {
            Console.WriteLine("\nГруз водным транспортом доставлен!\n");
        }
        public override void ShowInformation()
        {
            Console.WriteLine("\nИнформация о транспорте.\nВодный транспорт\nСкорость: " + Speed + " Км/ч\nГрузоподъёмность: " + LoadCapacity + " Кг\nМарка: " + TransportMark + "\nПерсонал: " + NumberOfStaff + "\nПассажиры: " + NumberOfPassengers+ "\n");
        }
    }

    class Liner : WaterTransport
    {
        public Liner(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
            : base(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers)
        { }
    }

    class Tanker : WaterTransport
    {
        public Tanker(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
            : base(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers)
        { }
    }
}

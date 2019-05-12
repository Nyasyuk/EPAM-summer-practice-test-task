using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Program
    {
        static void Main()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Главное меню\n1)Создать транспорт\n2)Завершить программу");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    choice = 0;
                }
                switch(choice)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        return;
                    default:
                        Console.WriteLine("Введите корректное число!");
                        break;
                }
            }
        }

        static void Create()
        {
            int idTransport;
            while (true)
            {
                Console.WriteLine("Выберите вид транспорта\n1)Наземный, автомобиль\n2)Наземный, поезд\n3)Наземный, грузовик\n4)Воздушный, самолёт\n5)Воздушный, вертолёт\n6)Водный, лайнер\n7)Водный, танкер");
                try
                {
                    idTransport = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    idTransport = 0;
                }
                if (idTransport >= 1 && idTransport <= 7)
                {
                    break;
                }
                else
                    Console.WriteLine("Введите корректное число!");
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите скорость транспорта (Км/ч) (целое число):");
                    int speed = Convert.ToInt32(Console.ReadLine());
                    if (speed <= 0) throw new Exception();
                    Console.WriteLine("Введите грузоподъёмность транспорта (Кг) (целое число):");
                    int loadCapacity = Convert.ToInt32(Console.ReadLine());
                    if (loadCapacity <= 0) throw new Exception();
                    Console.WriteLine("Введите марку транспорта:");
                    string transportMark = Console.ReadLine();
                    Console.WriteLine("Введите количество персонала транспорта:");
                    int numberOfStaff = Convert.ToInt32(Console.ReadLine());
                    if (numberOfStaff < 0) throw new Exception();
                    Console.WriteLine("Введите количество пассажров транспорта:");
                    int numberOfPassengers = Convert.ToInt32(Console.ReadLine());
                    if (numberOfPassengers <= 0) throw new Exception();
                    switch (idTransport)
                    {
                        case 1:
                            GroundTransport car = new Car(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers);
                            car.ShowInformation();
                            car.Delivery();
                            break;
                        case 2:
                            GroundTransport train = new Train(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers);
                            train.ShowInformation();
                            train.Delivery();
                            break;
                        case 3:
                            GroundTransport truck = new Truck(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers);
                            truck.ShowInformation();
                            truck.Delivery();
                            break;
                        case 4:
                            AirTransport aircraft = new Aircraft(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers);
                            aircraft.ShowInformation();
                            aircraft.Delivery();
                            break;
                        case 5:
                            AirTransport helicopter = new Helicopter(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers);
                            helicopter.ShowInformation();
                            helicopter.Delivery();
                            break;
                        case 6:
                            WaterTransport liner = new Liner(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers);
                            liner.ShowInformation();
                            liner.Delivery();
                            break;
                        case 7:
                            WaterTransport tanker = new Tanker(speed, loadCapacity, transportMark, numberOfStaff, numberOfPassengers);
                            tanker.ShowInformation();
                            tanker.Delivery();
                            break;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Введён некорректный параметр!");
                }

            }
        }
    }
}

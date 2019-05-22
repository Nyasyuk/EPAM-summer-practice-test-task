using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    
    abstract class Transport
    {
        int speed;
        int loadCapacity;
        string transportMark;
        int numberOfStaff;
        int numberOfPassengers;

        public abstract void Delivery();
        public abstract void ShowInformation();

        public Transport(int speed, int loadCapacity, string transportMark, int numberOfStaff, int numberOfPassengers)
        {
            Speed = speed;
            LoadCapacity = loadCapacity;
            TransportMark = transportMark;
            NumberOfStaff = numberOfStaff;
            NumberOfPassengers = numberOfPassengers;
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                //Исключение ввода некорректных данных
                if(value > 0)
                    speed = value;
            }
        }

        public int LoadCapacity
        {
            get
            {
                return loadCapacity;
            }
            set
            {
                //Исключение ввода некорректных данных
                if (value > 0)
                    loadCapacity = value;
            }
        }

        public string TransportMark
        {
            get
            {
                return transportMark;
            }
            set
            {
                    transportMark = value;
            }
        }

        public int NumberOfStaff
        {
            get
            {
                return numberOfStaff;
            }
            set
            {
                //Исключение ввода некорректных данных
                if (value > 0)
                    numberOfStaff = value;
            }
        }

        public int NumberOfPassengers
        {
            get
            {
                return numberOfPassengers;
            }
            set
            {
                //Исключение ввода некорректных данных
                if (value > 0)
                    numberOfPassengers = value;
            }
        }
    }
}

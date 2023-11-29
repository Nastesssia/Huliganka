using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_kab
{
    // абстрактные классы для различных типов автомобилей
    abstract class Car
    {
        public abstract string Drive();
        public abstract string Stop();
    }

    class Sedan : Car
    {
        public override string Drive()
        {
            return "Движение на седане";
        }

        public override string Stop()
        {
            return "Остановка седана";
        }
    }

    class SUV : Car
    {
        public override string Drive()
        {
            return "Движение на внедорожнике";
        }

        public override string Stop()
        {
            return "Остановка внедорожника";
        }
    }

    // абстрактные заводы для производства автомобилей
    abstract class CarFactory
    {
        public abstract Sedan ProduceSedan();
        public abstract SUV ProduceSUV();
    }

    // заводы для производства конкретных типов автомобилей
    class FordFactory : CarFactory
    {
        public override Sedan ProduceSedan()
        {
            return new Sedan();
        }

        public override SUV ProduceSUV()
        {
            return new SUV();
        }
    }

    class ToyotaFactory : CarFactory
    {
        public override Sedan ProduceSedan()
        {
            return new Sedan();
        }

        public override SUV ProduceSUV()
        {
            return new SUV();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // создание заводов
            CarFactory fordFactory = new FordFactory();
            CarFactory toyotaFactory = new ToyotaFactory();

            // производство автомобилей различных типов
            Sedan fordSedan = fordFactory.ProduceSedan();
            SUV fordSUV = fordFactory.ProduceSUV();

            Sedan toyotaSedan = toyotaFactory.ProduceSedan();
            SUV toyotaSUV = toyotaFactory.ProduceSUV();

            // проверка работы автомобилей
            Console.WriteLine(fordSedan.Drive());
            Console.WriteLine(fordSUV.Drive());

            Console.WriteLine(toyotaSedan.Drive());
            Console.WriteLine(toyotaSUV.Drive());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp12
{

    public class Spacee
    {
        public static Random rnd = new Random();

        public int RemotFromTheEarth = 0; // удаленность от земли
        public virtual String GetInfo()
        {
            var str = String.Format("\nУдаленность от земли (км): {0}", this.RemotFromTheEarth);
            return str;
        }
    }


    // планеты
    public class Planet : Spacee
    {
        public int Radius = 0; // радиус планеты
        public int ForceOfGravity = 0; // сила притяжения
        public bool Atmosphere = false; //наличие атмосферы

        // переопределили метод
        public override String GetInfo()
        {
            var str = "Планета";
            str += base.GetInfo();
            str += String.Format("\nРадиус планеты (км): {0}", this.Radius);
            str += String.Format("\nСила притяжения (g): {0}", this.ForceOfGravity);
            str += String.Format("\nНаличие атмосферы: {0}", this.Atmosphere);
            return str;
        }

        // добавили статический метод генерации случайных дпнных планеты
        public static Planet Generate()
        {
            return new Planet
            {
                RemotFromTheEarth = rnd.Next() % 1000000,
                Radius = rnd.Next() % 30000,
                ForceOfGravity = 1 + rnd.Next() % 8,
                Atmosphere = rnd.Next() % 2 == 0
            };
        }
    }

    // цвета звезд
    public enum StarsColor { blue, yellow, red };
    // звезды
    public class Star : Spacee
    {
        public int Density = 0; // плотность
        public StarsColor type = StarsColor.blue; // цвет звезды
        public int Temperature = 0; // температура (K)

        // переопределили метод
        public override String GetInfo()
        {
            var str = "Звезда";
            str += base.GetInfo();
            str += String.Format("\nПлотность (мг/м^3): {0}", this.Density);
            str += String.Format("\nЦвет звезды: {0}", this.type);
            str += String.Format("\nтемпература (K): {0}", this.Temperature);
            return str;
        }

        // добавили статический метод генерации случайных дпнных звезды
        public static Star Generate()
        {
            return new Star
            {
                RemotFromTheEarth = rnd.Next() % 1000000,
                Density = 1 + rnd.Next() % 20,
                type = (StarsColor)rnd.Next(3),
                Temperature = 2000 + rnd.Next() % 60000
            };
        }

    }

    // названия комет
    public enum CometName { Tempely, Hallea, Donati };
    // комета
    public class Comet : Spacee
    {
        public int PassageThroughTheSolarSystem = 0; // период прохождения через солнечную систему
        public CometName type = CometName.Donati; // название кометы

        // переопределили метод
        public override String GetInfo()
        {
            var str = "Комета";
            str += base.GetInfo();
            str += String.Format("\nПериод прохождения через солнечную систему (лет): {0}", this.PassageThroughTheSolarSystem);
            str += String.Format("\nНазвание кометы: {0}", this.type);
            return str;
        }

        // добавили статический метод генерации случайных дпнных комет
        public static Comet Generate()
        {
            return new Comet
            {
                RemotFromTheEarth = rnd.Next() % 1000000,
                PassageThroughTheSolarSystem = 3 + rnd.Next() % 300,
                type = (CometName)rnd.Next(3)
            };
        }
    }
}
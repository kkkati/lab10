using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Ugol ugol = new Ugol(36,54,50);
            ugol.znachenie();
            ugol.ToRadians();

            Console.ReadKey();
            

        }
    }

    class Ugol
    {
        private int gradus;
        private int min;
        private int sec;


        //свойства класса
        public int Gradus
        {
            set
            {
                if (value>0 && value<360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Неверно задано значение градусов");
                }
            }
            get
            {
                return gradus;
            }
        }

        public int Min
        {
            set
            {
                if (value > 0 && value<60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Неверно задано значение минут");
                }
            }
            get
            {
                return min;
            }
        }

        public int Sec
        {
            set
            {
                if (value > 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Неверно задано значение секунд");
                }
            }
            get
            {
                return sec;
            }
        }

        //конструктор заполнения свойств
        public Ugol(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        
        public void znachenie()
        {
            Console.WriteLine("Угол равен {0}° {1}' {2}''", Gradus, Min, Sec);
        }

        //метод конвертации величин
        public void ToRadians()
        {
            double radian = ((Gradus * Math.PI) / 180) + ((Min * Math.PI) / (180 * 60)) + ((Sec * Math.PI) / (180 * 180));
            Console.WriteLine("Угол в радианах равен {0}", radian);
        }

    }
}

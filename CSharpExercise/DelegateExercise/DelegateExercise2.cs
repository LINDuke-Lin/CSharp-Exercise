using System;
using System.Collections.Generic;

namespace CSharpExercise.DelegateExercise
{
    public class DelegateExercise2
    {
        /// <summary>
        /// 主程式
        /// </summary>
        public void Main()
        {
            List<Animal> deleAnimal = new List<Animal>()
            {
                new Animal(Dog),
                new Animal(Cat),
                new Animal(Duck),
                new Animal(Chicken)
            };


            foreach(var animalFunc in deleAnimal)
            {
                RunCircus(animalFunc);
            }
        }


        /// <summary>
        /// 定義委派
        /// </summary>
        private delegate void Animal();

        /// <summary>
        /// 定義函式
        /// </summary>
        /// <param name="animal">動物的委派</param>
        private static void RunCircus(Animal animal)
        {
            animal();
        }

        /// <summary>
        /// 小狗函式
        /// </summary>
        private static void Dog()
        {
            Console.WriteLine($"汪汪!");
        }

        /// <summary>
        /// 貓
        /// </summary>
        public static void Cat()
        {
            Console.WriteLine($"喵喵!");
        }

        /// <summary>
        /// 鴨
        /// </summary>
        public static void Duck()
        {
            Console.WriteLine($"呱呱!");
        }

        /// <summary>
        /// 雞
        /// </summary>
        public static void Chicken()
        {
            Console.WriteLine($"咕咕!");
        }
    }
}

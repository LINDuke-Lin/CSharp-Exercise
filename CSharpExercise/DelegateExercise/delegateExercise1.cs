using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercise.EventDemo
{
    public class DelegateExercise1
    {
        /// <summary>
        /// 主程式
        /// </summary>
        public void Main()
        {
            Animal deleDog = new Animal(Dog);

            RunCircus(deleDog, "小狗");

        }


        /// <summary>
        /// 定義委派
        /// </summary>
        /// <param name="name">姓名</param>
        private delegate void Animal(string name);

        /// <summary>
        /// 定義函式
        /// </summary>
        /// <param name="animal">動物的委派</param>
        /// <param name="name">動物名字</param>
        private static void RunCircus(Animal animal, string name)
        {
            animal(name);
        }

        /// <summary>
        /// 小狗函式
        /// </summary>
        /// <param name="name">姓名</param>
        private static void Dog(string name)
        {
            Console.WriteLine($"汪汪! 我是{name}");
        }


    }
}

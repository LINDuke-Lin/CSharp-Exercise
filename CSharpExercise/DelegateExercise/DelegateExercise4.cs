using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercise.DelegateExercise
{
    public class DelegateExercise4
    {
        /// <summary>
        /// 主程式
        /// </summary>
        public void Main()
        {
            RunCircus(Dog);
        }


        /// <summary>
        /// 定義函式
        /// </summary>
        /// <param name="animal">動物的委派</param>
        private static void RunCircus(Action animal)
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
    }
}
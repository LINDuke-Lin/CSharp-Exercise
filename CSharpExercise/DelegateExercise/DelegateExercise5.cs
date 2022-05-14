using System;

namespace CSharpExercise.DelegateExercise
{
    public class DelegateExercise5
    {
        /// <summary>
        /// 主程式
        /// </summary>
        public void Main()
        {
            RunCircus(Dog, "狗狗");
        }


        /// <summary>
        /// 定義函式
        /// </summary>
        /// <param name="animal">動物的委派</param>
        private static void RunCircus(Action<string> animal, string name)
        {
            animal(name);
        }

        /// <summary>
        /// 小狗函式
        /// </summary>
        private static void Dog(string name)
        {
            Console.WriteLine($"汪汪!我是{name}");
        }
    }
}

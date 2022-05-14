using System;

namespace CSharpExercise.DelegateExercise
{
    public class DelegateExercise6
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
        private static void RunCircus(Func<string> animal)
        {
            string sound = animal();
            Console.WriteLine(sound);
        }

        /// <summary>
        /// 小狗函式
        /// </summary>
        /// <returns></returns>
        private static string Dog()
        {
            return "汪汪!";
        }
    }
}

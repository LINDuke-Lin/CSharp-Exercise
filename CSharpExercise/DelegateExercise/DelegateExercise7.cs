using System;

namespace CSharpExercise.DelegateExercise
{
    public class DelegateExercise7
    {

        /// <summary>
        /// 主程式
        /// </summary>
        public void Main()
        {
            RunCircus(Dog, 5);
        }


        /// <summary>
        /// 定義函式
        /// </summary>
        /// <param name="animal">動物的委派</param>
        private static void RunCircus(Func<int, string> animal, int age)
        {
            string sound = animal(age);
            Console.WriteLine(sound);
        }

        /// <summary>
        /// 小狗函式
        /// </summary>
        /// <returns></returns>
        private static string Dog(int age)
        {
            return $"汪汪!{age.ToString()} 歲";
        }
    }
}

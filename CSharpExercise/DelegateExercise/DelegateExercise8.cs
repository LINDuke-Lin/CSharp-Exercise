using System;

namespace CSharpExercise.DelegateExercise
{
    public class DelegateExercise8
    {

        /// <summary>
        /// 主程式
        /// </summary>
        public void Main()
        {
            Func<int, string> Dog = (int age) => { return $"汪汪!{age.ToString()} 歲"; };

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
    }
}

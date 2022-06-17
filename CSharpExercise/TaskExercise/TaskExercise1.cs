using System;
using System.Threading.Tasks;

namespace CSharpExercise.TaskExercise
{
    internal class TaskExercise1
    {
        public void Main()
        {
            //先執行任務一
            Task.Run(() => Task1());
            Console.WriteLine("開始任務二");
            //不等任務一完成就開始任務二
            Task.Run(() => Task2());
        }
        /// <summary>
        /// 任務一: 500個印星星
        /// </summary>
        private void Task1()
        {
            for (int i = 0; i < 500; i++)
                Console.Write("*");
        }
        /// <summary>
        /// 任務二: 1500個印+
        /// </summary>
        private void Task2()
        {
            for (int i = 0; i < 500; i++)
                Console.Write("+");
        }

    }
}

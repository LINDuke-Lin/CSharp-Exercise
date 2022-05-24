using System;

namespace CSharpExercise.EventDemo
{
    public class EventExercise2
    {
        public void Main()
        {
            Cat cat = new Cat();
            CatHost catHost = new CatHost(cat);

            cat.OnAlarm();
        }
    }

    public class Cat
    {
        /// <summary>
        /// 貓咪泛型事件
        /// </summary>
        public event Action AnimalEventHandler;

        /// <summary>
        /// 貓咪函式
        /// </summary>
        public void OnAlarm()
        {
            Console.WriteLine("喵喵");
            AnimalEventHandler?.Invoke();
        }
    }

    public class CatHost
    {
        /// <summary>
        /// 建構子注入貓咪 並註冊事件
        /// </summary>
        /// <param name="cat"></param>
        public CatHost(Cat cat)
        {
            cat.AnimalEventHandler += new Action(AlarmHandler);
        }

        /// <summary>
        /// 事件處理
        /// </summary>
        public void AlarmHandler()
        {
            Console.WriteLine("貓來了");
        }
    }
}

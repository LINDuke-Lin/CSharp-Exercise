using System;

namespace CSharpExercise.EventDemo
{
    public class EventExercise3
    {
        public void Main()
        {
            Duck duck = new Duck();
            DuckHost DuckHost = new DuckHost(duck);

            duck.OnAlarm();
        }
    }


    public class Duck
    {
        /// <summary>
        /// 宣告鴨子泛型事件
        /// </summary>
        public event Action AnimalEventHandler;

        /// <summary>
        /// 觸發事件
        /// </summary>
        public void OnAlarm()
        {
            Console.WriteLine("呱呱");

            AnimalEventHandler?.Invoke();
        }
    }


    public class DuckHost
    {
        /// <summary>
        /// 以建構子注入鴨類別，並以匿名函式實作
        /// </summary>
        /// <param name="duck"></param>
        public DuckHost(Duck duck)
        {
            //此處使用匿名函數
            duck.AnimalEventHandler += new Action(() => { Console.WriteLine("變烤鴨了"); });
        }
    }
}

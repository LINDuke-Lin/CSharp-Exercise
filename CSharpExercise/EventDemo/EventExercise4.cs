using System;
using System.Collections.Generic;

namespace CSharpExercise.EventDemo
{
    public class EventExercise4
    {
        public void Main()
        {
            Chicken chicken = new Chicken();

            ChickenHost host = new ChickenHost(chicken);

            chicken.OnAlarm();
        }
    }


    public class Chicken
    {
        /// <summary>
        /// 宣告一號雞泛型事件
        /// </summary>
        public event Func<string> Chicken1EventHandler;
        /// <summary>
        /// 宣告二號雞泛型事件
        /// </summary>
        public event Func<string> Chicken2EventHandler;

        /// <summary>
        /// 觸發事件
        /// </summary>
        public void OnAlarm()
        {
            Console.WriteLine("咕咕");

            List<string> chickenNameList = new List<string>();

            //執行事件
            chickenNameList.Add(Chicken1EventHandler?.Invoke());
            chickenNameList.Add(Chicken2EventHandler?.Invoke());

            Console.WriteLine("點名!");

            foreach (var name in chickenNameList)
            {
                Console.WriteLine($"我是 {name}");
            }
        }
    }


    public class ChickenHost
    {
        public ChickenHost(Chicken chicken)
        {
            chicken.Chicken1EventHandler += new Func<string>(() => { return "一號雞"; });
            chicken.Chicken2EventHandler += new Func<string>(() => { return "二號雞"; });
        }
    }


}

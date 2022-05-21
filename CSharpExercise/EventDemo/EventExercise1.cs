using System;

namespace CSharpExercise.EventDemo
{
    public class EventExercise1
    {
        /// <summary>
        /// 主程式
        /// </summary>
        public void Main()
        {
            // 1. 實例化 狗類別
            Dog dog = new Dog();
            // 2. 實例化 事件接收者
            Host host = new Host(dog);

            // 3. 事件觸發
            dog.OnAlarm();
        }

    }


    public class Dog
    {
        /// <summary>
        /// 事件委派
        /// </summary>
        /// <param name="sander"></param>
        /// <param name="e"></param>
        public delegate void AnimalEventHandler(object sander, EventArgs e);

        /// <summary>
        /// 定義事件
        /// </summary>
        public event AnimalEventHandler Alarm;

        /// <summary>
        /// 觸發事件
        /// </summary>
        public void OnAlarm()
        {
            if (this.Alarm != null)
            {
                Console.WriteLine("汪汪!");
                this.Alarm(this, new EventArgs());
            }
        }
    }


    public class Host
    {
        /// <summary>
        /// 事件處理
        /// </summary>
        /// <param name="sander"></param>
        /// <param name="e"></param>
        public void HostHandleAlam(object sander, EventArgs e)
        {
            Console.WriteLine("抓住小偷了!");
        }

        /// <summary>
        /// 註冊事件
        /// </summary>
        /// <param name="dog"></param>
        public Host(Dog dog)
        {
            dog.Alarm += new Dog.AnimalEventHandler(HostHandleAlam);
        }
    }
}

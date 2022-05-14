using CSharpExercise.DelegateExercise;
using CSharpExercise.EventDemo;
using CSharpExercise.PrintHello;
using System;

namespace CSharpExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("題目:");
            Console.WriteLine("1. 輸入n 印出 Hello 圖型 第一版");

            Console.WriteLine("-- 委派 --");
            Console.WriteLine("2. 委派練習1 - 馬戲團");
            Console.WriteLine("3. 委派練習2 - 馬戲團(多隻動物版)");
            Console.WriteLine("4. 委派練習3(多點傳送委派) - 馬戲團(多隻動物版)");
            Console.WriteLine("5. 委派練習4(Action 委派) - 馬戲團");
            Console.WriteLine("6. 委派練習5(Action 委派(傳參數)) - 馬戲團");
            Console.WriteLine("7. 委派練習6(Func 委派) - 馬戲團");
            Console.WriteLine("8. 委派練習7(Func 委派(傳參數)) - 馬戲團");


            Console.WriteLine("請選擇題目:");

            string whitchOne = Console.ReadLine();

            switch (whitchOne)
            {
                case "1":
                    Console.WriteLine("題目1 start ...");
                    Console.WriteLine("請輸入 n :");

                    int num1 = Convert.ToInt32(Console.ReadLine());
                    PrintHello1 printHello = new PrintHello1();
                    printHello.Main(num1);
                    break;
                case "2":
                    Console.WriteLine("題目2 start ...");

                    DelegateExercise1 delegateExercise1 = new DelegateExercise1();
                    delegateExercise1.Main();
                    break;
                case "3":
                    Console.WriteLine("題目3 start ...");

                    DelegateExercise2 delegateExercise2 = new DelegateExercise2();
                    delegateExercise2.Main();
                    break;
                case "4":
                    Console.WriteLine("題目4 start ...");

                    DelegateExercise3 delegateExercise3 = new DelegateExercise3();
                    delegateExercise3.Main();
                    break;
                case "5":
                    Console.WriteLine("題目5 start ...");

                    DelegateExercise4 delegateExercise4 = new DelegateExercise4();
                    delegateExercise4.Main();
                    break;
                case "6":
                    Console.WriteLine("題目6 start ...");

                    DelegateExercise5 delegateExercise5 = new DelegateExercise5();
                    delegateExercise5.Main();
                    break;
                case "7":
                    Console.WriteLine("題目7 start ...");

                    DelegateExercise6 delegateExercise6 = new DelegateExercise6();
                    delegateExercise6.Main();
                    break;
                case "8":
                    Console.WriteLine("題目8 start ...");

                    DelegateExercise7 delegateExercise7 = new DelegateExercise7();
                    delegateExercise7.Main();
                    break;
            }

            Console.ReadKey();
        }
    }
}

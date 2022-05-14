using System;

namespace CSharpExercise.PrintHello
{
    /// <summary>
    /// 印出hello第一版
    /// </summary>
    public class PrintHello1
    {
        // 定義要印的陣列
        private string[] StrAry = new string[] { "H", "e", "l", "l", "o" };

        /// <summary>
        /// 主程式
        /// </summary>
        public void Main(int n)
        {
            // 計算 n + 5
            int total = n + 5;

            // 紀錄當前的數字
            int tempCount = 0;

            // 開始排序
            for (int i = total; i > 5; i--)
            {
                // 印出每行的文字
                for (int j = 0; j < i; j++)
                {
                    //取餘
                    Console.Write(StrAry[tempCount % 5]);
                    tempCount++;
                }
                // 換下一行
                Console.WriteLine();
            }
        }
    }
}

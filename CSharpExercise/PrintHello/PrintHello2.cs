using System;

namespace CSharpExercise.PrintHello
{
    public class PrintHello2
    {
        /// <summary>
        /// 主程式
        /// </summary>
        public void Main(int n)
        {
            Graphics graphics = new Graphics("Hello");
            graphics.Display(n);
        }
    }

    /// <summary>
    /// 繪製圖形
    /// </summary>
    public class Graphics
    {
        private readonly char[] chrAry;

        public Graphics(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new Exception("請設定正確文字");

            chrAry = word.ToCharArray();
        }
        /// <summary>
        /// 取餘回傳字串
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private string GetString(int num)
        {
            return chrAry[num % 5].ToString();
        }

        /// <summary>
        /// 印出圖形
        /// </summary>
        /// <param name="n"></param>
        public void Display(int n)
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
                    Console.Write(GetString(tempCount));
                    tempCount++;
                }
                // 換下一行
                Console.WriteLine();
            }
        }
    }
}

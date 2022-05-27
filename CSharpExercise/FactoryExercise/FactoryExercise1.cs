using System;

namespace CSharpExercise.FactoryExercise
{
    public class FactoryExercise1
    {
        public void Main()
        {
            //1. 建立使用者名稱與密碼的會員
            Console.WriteLine(" 建立使用者名稱與密碼的會員");
            var mb1 = Member.MemberByNamePassword("我是一號會員", "A1234");

            mb1.Dump();
            
            //2. 建立信箱與密碼的會員
            Console.WriteLine(" 建立信箱與密碼的會員");
            var mb2 = Member.MemberByEmailPassword("Member@gmail.com", "ABCDE112");

            mb2.Dump();
        }
    }


    internal class Member
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 信箱
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// 工廠 - 建立使用者與密碼
        /// </summary>
        /// <param name="name">使用者名稱</param>
        /// <param name="password">密碼</param>
        /// <returns></returns>
        public static Member MemberByNamePassword(string name, string password)
        {
            return new Member() { Name = name, Password = password };
        }

        /// <summary>
        /// 工廠 - 建立使用者信箱與密碼
        /// </summary>
        /// <param name="email">信箱</param>
        /// <param name="password">密碼</param>
        /// <returns></returns>
        public static Member MemberByEmailPassword(string email, string password)
        {
            return new Member() { Email = email, Password = password };
        }

        /// <summary>
        /// 印出結果
        /// </summary>
        public void Dump()
        {
            Console.WriteLine($"使用者名稱: {Name}, 密碼: {Password}, 信箱: {Email}");
        }
    }
}

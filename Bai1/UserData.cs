using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public static class UserData
    {
        public static string ID;
        public static string UserName;
        public static float Gold;
        public static int Point;

        static UserData()
        {
            ID = "PD11351";
            UserName = "Tran Nguyen Hai Truong";
            Gold = 9999;
            Point = 100;
        }

        public static void showData()
        {
            Console.WriteLine("ID: " + UserData.ID);
            Console.WriteLine("UserName: " + UserData.UserName);
            Console.WriteLine("Gold: " + UserData.Gold);
            Console.WriteLine("Point: " + UserData.Point);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Maps
    {
        public string ID;
        public string Name;
        public static string _inGame = "Lien Minh Huyen Thoai";

        public Maps(string id, string name)
        {
            ID = id;
            Name = name;
        }

        public Maps()
        {
        }

        public string ShowData()
        {
            return "ID: " + ID + " |Name: " + Name + " |_inGame: " + _inGame;
        }
    }
}

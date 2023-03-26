using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeWeek4
{
    // class Team
    public class Team
    {
        public string teamName;
        public string teamCountry;
        public string teamCity;
        public List<Player> Players = new List<Player>();
        public void AddPlayer(Player p)
        {
            Players.Add(p);
        }
    }
    // class Player
    public class Player
    {
        public string playerName;
        public string playerNum;
        public string playerPos;
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
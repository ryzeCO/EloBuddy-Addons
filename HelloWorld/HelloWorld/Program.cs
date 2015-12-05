using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using SharpDX;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Start program when the game loading is complete
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Start;
        }
    
        /// <summary>
        /// Print Hello World! to Chat
        /// </summary>
        /// <param name="args"></param>
        private static void Start(EventArgs args){ 
            Chat.Print("Hello World!");
        }
    }
}

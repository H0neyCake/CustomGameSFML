using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGameSFML
{
    class Program
    {
        static RenderWindow win;

        static void Main(string[] args)
        {
            RenderWindow win = new RenderWindow(new SFML.Window.VideoMode(800, 600), "Custom Game");
            win.SetVerticalSyncEnabled(true);

            win.Closed += Win_Closed;
            
            while (win.IsOpen)
            {
                win.DispatchEvents();

                win.Clear(Color.Black);

                win.Display();
            }
        }

        private static void Win_Closed(object sender, EventArgs e)
        {
            win.Close();
        }
    }
}

﻿using SFML.Graphics;
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

        public static RenderWindow Window { get { return win; } }
        public static Game Game { private set; get; }

        static void Main(string[] args)
        {
            RenderWindow win = new RenderWindow(new SFML.Window.VideoMode(800, 600), "Custom Game");
            win.SetVerticalSyncEnabled(true);

            win.Closed += Win_Closed;

            Content.Load();

            Game = new Game();

            while (win.IsOpen)
            {
                win.DispatchEvents();

                Game.Update();

                win.Clear(Color.Black);

                Game.Draw();

                win.Display();
            }
        }

        private static void Win_Closed(object sender, EventArgs e)
        {
            win.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SpaceChickens
{
    class GameScreenManager : IDisposable
    {
        public Graphics graphics { get; private set; }
        public int width { get; private set; }
        public int height { get; private set; }
        private Stack<GameScreen> screens { get; set; }

        public GameScreenManager(Graphics g, int w, int h)
        {
            graphics = g;
            screens = new Stack<GameScreen>();
            width = w;
            height = h;
        }

        public void Push(GameScreen screen)
        {
            screens.Push(screen);
        }

        public void Set(GameScreen screen)
        {
            screens.Pop().Dispose();
            screens.Push(screen);
        }

        public bool Update(float deltaTime)
        {
            if (screens.Count > 0)
            {
                screens.Peek().Update(deltaTime);
                return true;
            }
            else
                return false;
        }

        public void Render()
        {
            screens.Peek().Render();
        }

        public void Dispose()
        {
            foreach (GameScreen screen in screens)
            {
                screen.Dispose();
            }
        }
    }
}

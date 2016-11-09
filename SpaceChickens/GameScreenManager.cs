using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SpaceChickens
{
    class GameScreenManager : IDisposable
    {
        public Graphics graphics { get; private set; }
        private Stack<GameScreen> screens { get; set; }

        public GameScreenManager(Graphics g)
        {
            graphics = g;
            screens = new Stack<GameScreen>();
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

        public void Update()
        {
            screens.Peek().Update();
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

            // Graphics is passed in, disposed at another time.
        }
    }
}

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
        public Stack<GameScreen> screens { get; private set; }

        public GameScreenManager(Graphics g)
        {
            graphics = g;
            screens = new Stack<GameScreen>();
        }

        public void push(GameScreen screen)
        {
            screens.Push(screen);
        }

        public GameScreen top()
        {
            return screens.Peek();
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

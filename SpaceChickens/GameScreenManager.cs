using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SpaceChickens
{
    class GameScreenManager
    {
        public Graphics graphics { get; private set; }
        public Stack<IGameScreen> screens { get; private set; }

        public GameScreenManager(Graphics g)
        {
            graphics = g;
        }

        public void push(IGameScreen screen)
        {
            screens.Push(screen);
        }

        public IGameScreen top()
        {
            return screens.Peek();
        }
    }
}

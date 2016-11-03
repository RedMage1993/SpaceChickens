using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceChickens
{
    abstract class GameScreen : IDisposable
    {
        public GameScreenManager gsm { get; protected set; }
        public static int gsCount { get; private set; }

        static GameScreen()
        {
            gsCount = 0;
        }

        public GameScreen(GameScreenManager _gsm)
        {
            gsm = _gsm;

            gsCount++;
        }

        public abstract void Update();
        public abstract void Render();
        public abstract void Dispose();
    }
}

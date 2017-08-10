using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpaceChickens
{
    class StartMenu : GameScreen
    {
        public Bitmap background { get; private set; }

        public StartMenu(GameScreenManager _gsm) : base(_gsm)
        {
            background = new Bitmap(@"Media\Sprites\background01.png");
        }

        public override void Update(float dt)
        {
            // Make Character class.
            // Chicken and UFO subclasses.
            // Check Input.
            // Perform actions (and transformations) and check collisions on characters' sprites.
        }

        public override void Render()
        {
            // Call gsm.graphics.DrawImage on all Characters.
            gsm.graphics.DrawImage(background, new Point(-(gsm.width >> 1), -(gsm.height >> 1)));
        }

        public override void Dispose()
        {
            background.Dispose();
        }
    }
}

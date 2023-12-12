using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOpdracht4
{
    internal class GameScreen
    {
        private string[] screenLines;

        public GameScreen(string[] screenLines)
        {
            this.screenLines = screenLines;
        }

        public string[] GetScreenLines()
        {
            return screenLines;
        }
    }
}

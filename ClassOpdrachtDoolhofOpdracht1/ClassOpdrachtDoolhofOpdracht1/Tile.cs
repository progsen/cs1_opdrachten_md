using System;

namespace ClassOpdrachtDoolhofOpdracht1
{
    class Tile
    {
        internal int x, y;
        internal char graphic;
        internal ConsoleColor color = ConsoleColor.Green;
        internal Room teleport;
        internal Tile teleportTile;
        internal Tile(int x, int y, char graphic)
        {
            //vergeet this niet te gebruiken!
            //geef hier de waarde van x aan class variable x
            this.x = x;
            //geef hier de waarde van y aan class variable y
            this.y = y;
            //geef hier de waarde van graphic aan class variable graphic 
            this.graphic = graphic;
        }
    }
}


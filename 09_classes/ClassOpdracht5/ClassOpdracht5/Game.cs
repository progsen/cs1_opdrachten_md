using System;

namespace ClassOpdracht5
{
    partial class Program
    {
        internal class Game
        {

            //maak hier een class variable aan (access= private, type=Tile, name=player)
          ???
            //maak hier een class variable aan (access= private, type=Room, name=room)

            internal Game()
            {
                room = new Room();

                player = new Tile(2, 2,'P');
            }

            internal void RenderWithConsole()
            {
                Console.SetCursorPosition(0, 0);//reset cursor without clear, no flickering screen
                for (int i = 0; i < room.tiles.Length; i++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine();
                for (int i = 0; i < room.tiles.Length; i++)
                {
                    Tile[] rowTiles = room.tiles[i];
                    for (int i2 = 0; i2 < rowTiles.Length; i2++)
                    {
                        if (i2 == player.x && i == player.y)//teken de speler
                        {
                            RenderPlayer();
                        }
                        else
                        {
                            Tile tile = rowTiles[i2];
                            RenderTile(tile);
                        }
                    }
                    Console.WriteLine();
                }
            }

            private void RenderPlayer()
            {
                Console.ForegroundColor = player.color;
                Console.Write(player.graphic);
            }

            private static void RenderTile(Tile tile)
            {
                char graphic = tile.graphic;
                Console.ForegroundColor = tile.color;
                Console.Write(graphic);
            }

            Tile GetNextTile(int newx, int newy)
            {
                for (int i = 0; i < room.tiles.Length; i++)
                {
                    for (int i2 = 0; i2 < room.tiles[i].Length; i2++)
                    {
                        Tile t = room.tiles[i][i2];
                        if (t.x == newx && t.y == newy)
                        {
                            return t;
                        }
                    }
                }
                return null;
            }
            internal void MovePlayer(int dx, int dy)
            {
                int newx = player.x + dx;
                int newy = player.y + dy;

                Tile next = GetNextTile(newx, newy);

                if (next != null)
                {
                    if (next.graphic != '#')
                    {

                        player.x = newx;
                        player.y = newy;
                    }

                }
            }

        }
    }
}
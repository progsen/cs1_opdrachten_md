using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace ClassOpdrachtDoolhofOpdracht1
{
    internal class Game
    {

        //maak hier een class variable aan (access= private, type=Tile, name=player)
        private readonly Tile player;
        //maak hier een class variable aan (access= private, type=Room, name=room)
        private Room room;
        private List<Room> rooms = new List<Room>();
        Random rand = new Random();
        internal Game()
        {
            Room start = new Room("start", -1);
            rooms.Add(start);
            RandoRoom(start);
            GenerateMazeRoom(0, start);

            List<Room> exits = rooms.Where(i => i.depth == 9).ToList();
            Room setExit = exits[rand.Next(exits.Count)];
            Tile[] exittiles = setExit.tiles.SelectMany(i => i.Where(i2 => i2.graphic == '.')).ToArray();
            Tile exitTile = exittiles[rand.Next(exittiles.Length)];
            exitTile.graphic = '$';
            exitTile.color = ConsoleColor.Green;

            room = rooms[0];

            player = new Tile(2, 2, 'P');
        }

        public void GenerateMazeRoom(int depth, Room start)
        {
            if (depth == 10)
            {
                return;
            }
            for (int i = 0; i < rand.Next(2, 3); i++)
            {
                Room r = new Room("depth " + depth, depth);
                rooms.Add(r);
                RandoRoom(r);
                LinkRooms(start, r);

                GenerateMazeRoom(depth + 1, r);

            }
        }

        private void RandoRoom(Room r)
        {
            List<ConsoleColor> colors = Enum.GetValues<ConsoleColor>().ToList();
            colors.Remove(ConsoleColor.Black);
            colors.Remove(ConsoleColor.DarkBlue);
            colors.Remove(ConsoleColor.Green);
            colors.Remove(ConsoleColor.Cyan);
            r.color = colors[rand.Next(0, colors.Count)];


            string[] template = RoomData.Get(rand);
            r.SetTemplate(template);
            List<Tile> walls = r.tiles.SelectMany(i => i.Where(i2 => i2.graphic == '#')).ToList();
            List<Tile> rest = r.tiles.SelectMany(i => i.Where(i2 => i2.graphic != '#')).ToList();
            walls.ForEach(i => i.color = r.color);
            rest.ForEach(i => i.color = ConsoleColor.Yellow);
        }

        private void LinkRooms(Room start, Room r)
        {
            List<Tile> startrest = start.tiles.SelectMany(i => i.Where(i2 => i2.graphic == '.')).ToList();
            List<Tile> rest = r.tiles.SelectMany(i => i.Where(i2 => i2.graphic == '.')).ToList();

           List<Tile> picks= rest.Where(i=>startrest.Any(o=>i.x==o.x && i.y==o.y)).ToList();

            Tile pick = picks[rand.Next(0, picks.Count)];
            int x = pick.x;
            int y = pick.y;

            Tile from = start.tiles[y][x];
            from.graphic = '*';
            from.color = ConsoleColor.DarkCyan;

            Tile to = r.tiles[y][x];
            to.graphic = '*';
            to.color = ConsoleColor.Cyan;

            from.teleport = r;
            from.teleportTile = to;
            to.teleport = start;
            to.teleportTile = from;
        }

        internal void RenderWithConsole()
        {
            Console.SetCursorPosition(0, 0);//reset cursor without clear, no flickering screen
            for (int i = 0; i < room.tiles.Length; i++)
            {
                Console.Write(' ');
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(room.name);
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

        private void RenderTile(Tile tile)
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
                Debug.WriteLine("next " + next.graphic);
                if (next.graphic == '*')
                {
                    room = next.teleport;
                    player.x = next.teleportTile.x;
                    player.y = next.teleportTile.y;
                    Debug.WriteLine("teleport " + room + " " + player.x + " " + player.y);
                }
                else if (next.graphic != '#')
                {

                    player.x = newx;
                    player.y = newy;
                }
            }
        }

    }
}
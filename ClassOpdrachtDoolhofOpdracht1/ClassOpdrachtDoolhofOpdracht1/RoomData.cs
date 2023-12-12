using System;
using System.Collections.Generic;

namespace ClassOpdrachtDoolhofOpdracht1
{
    internal static class RoomData
    {

        internal static List<string[]> roomTemplates = new List<string[]>() {

            new string[]{
        "##########",
        "#........#",
        "#........#",
        "#........#",
        "#...##...#",
        "#..##....#",
        "#........#",
        "#........#",
        "#........#",
        "##########"
            }
            ,new string[]{
        "##########",
        "#........#",
        "#........#",
        "#........#",
        "#..####..#",
        "#..####..#",
        "#...##...#",
        "#...##...#",
        "#........#",
        "##########"
            },new string[]{
        "##########",
        "#........#",
        "#.######.#",
        "#........#",
        "#..####..#",
        "#..####..#",
        "#........#",
        "#.######.#",
        "#........#",
        "##########"
            }

        };

        internal static string[] Get(Random rand)
        {
            return roomTemplates[rand.Next(0, roomTemplates.Count)];
        }
    }
}


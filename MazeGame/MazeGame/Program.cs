using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class Program
    {
        static void Main(string[] args)
        {
           

            DrawMap();

            while (true)
            {


                string key = Console.ReadLine();

                MovePlayer(key);


                DrawMap();

                if (CheckGoal())
                {
                    break;
                }

            }
            Console.WriteLine("ゲームクリア");
        }

        static char[] map =
        {
            '#','#','#','#','#',
            '#',' ',' ',' ','#',
            '#',' ','#',' ','#',
            '#',' ','#',' ','#',
            '#','P','#','G','#',
            '#','#','#','#','#',
        };

        static void DrawMap()
        {
            for ( int i = 0; i < map.Length; i++)
            {
                Console.Write(map[i]);

                if((i + 1) % 5 == 0)
                {
                    Console.Write(System.Environment.NewLine);
                }
            }

            Console.WriteLine("-------------------------------------------");
        }

        static void MovePlayer(string key)
        {

            int playerPos = Array.IndexOf(map, 'P');

            int playerNextPos = 0;

            switch (key)
            {
                case "a":
                    playerNextPos = playerPos - 1;

                    break;
                case "d":
                    playerNextPos = playerPos + 1;
                    break;
                case "w":
                    playerNextPos = playerPos - 5;
                    break;
                case "s":
                    playerNextPos = playerPos + 5;
                    break;
                default:
                    return;

            }

            
            if(map[playerNextPos] != '#')
            {

            map[playerNextPos] = 'P';
            map[playerPos] = ' ';
            playerPos = playerNextPos;
            }
        }
        static bool CheckGoal()
        {
            if(Array.IndexOf(map,'G') < 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}

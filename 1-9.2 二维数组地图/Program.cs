using System;

namespace _1_9._2_二维数组地图
{
    /*#################
     *#               #
     *#               #
     *#               #
     *#               #
     *#               #
     *#               #
     *#               #
     *#               #
     *#################
     */
   

    class Program
    {
        static void PrintArray2d(char[,] a2d)
        {
            for (int i = 0; i < a2d.GetLength(0); i++)
            {
                for (int j = 0; j < a2d.GetLength(1); j++)
                {
                    Console.Write(a2d[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string s = ""
                + "#################\n"
                + "#               #\n"
                + "#    ~~~     H  #\n"
                + "#      ~~~      #\n"
                + "#        ~~~    #\n"
                + "#    C    ~~~   #\n"
                + "#     D  C  ~~~ #\n"
                + "#               #\n"
                + "#               #\n"
                + "#################\n";

            Console.Write(s);

            char c = s[0];        // char代表字符

            char[,] map = new char[10, 17];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = s[i * (map.GetLength(1)+1) + j];   // 把s的每一个元素装到map里去,这里之所写成(map.GetLength(1)+1),是因为\n也算一个字符
                }
            }


            map[1, 1] = 'X';

            while (true)
            {
                Console.Clear();    // 按一下就会刷新一次界面
                PrintArray2d(map);
              
                Console.ReadKey();
            }

          

            Console.ReadKey();
        }
    }
}

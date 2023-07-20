using System;
using System.Collections;
using System.Collections.Generic;

namespace main
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("SOAL 1");
            Console.WriteLine("-----------------------");
            // Soal 1
            Console.WriteLine("input:");
            Console.WriteLine("7");
            Console.WriteLine("output:");
            Console.WriteLine(Soal1.DeretSlouanesOEISToN(7));
            Console.WriteLine();
            Console.WriteLine("input:");
            Console.WriteLine("10");
            Console.WriteLine("output:");
            Console.WriteLine(Soal1.DeretSlouanesOEISToN(10));
            Console.WriteLine();
            Console.WriteLine("input:");
            Console.WriteLine("25");
            Console.WriteLine("output:");
            Console.WriteLine(Soal1.DeretSlouanesOEISToN(40));
            Console.WriteLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("SOAL 2");
            Console.WriteLine("-----------------------");

            // Soal 2
            List<int> currentRank = new List<int> { 100, 80, 80, 70 };
            List<int> currentRank2 = new List<int> { 100, 100, 50, 40, 40, 20, 10 };
            List<int> currentRank3 = new List<int> { 100, 100, 74, 74, 73, 65, 60, 50, 30, 20, 15 };
            List<int> gitsScore = new List<int> { 60, 70, 100 };
            List<int> gitsScore2 = new List<int> { 5, 25, 50, 120 };
            List<int> gitsScore3 = new List<int> { 200, 150, 200, 100, 70, 89, 60, 55, 8 };

            Console.WriteLine("input:");
            Console.WriteLine(currentRank.Count);
            currentRank.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            Console.WriteLine(gitsScore.Count);
            gitsScore.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();

            Console.WriteLine("output:");
            Soal2.GITSRank(currentRank, gitsScore).ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("input:");
            Console.WriteLine(currentRank2.Count);
            currentRank2.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            Console.WriteLine(gitsScore2.Count);
            gitsScore2.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();

            Console.WriteLine("output:");
            Soal2.GITSRank(currentRank2, gitsScore2).ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("input:");
            Console.WriteLine(currentRank3.Count);
            currentRank3.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            Console.WriteLine(gitsScore3.Count);
            gitsScore3.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();

            Console.WriteLine("output:");
            Soal2.GITSRank(currentRank3, gitsScore3).ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            Console.WriteLine();

            // soal 3

            Console.WriteLine("-----------------------");
            Console.WriteLine("SOAL 3");
            Console.WriteLine("-----------------------");
            Console.WriteLine("input: { [ ( ) ] }");
            Console.WriteLine("output:");
            Console.WriteLine(Soal3.BalancedBracket("{ [ ( ) ] }"));
            Console.WriteLine();
            Console.WriteLine("input: { [ ( ] ) }");
            Console.WriteLine("output:");
            Console.WriteLine(Soal3.BalancedBracket("{ [ ( ] ) }"));
            Console.WriteLine();
            Console.WriteLine("input: { ( ( [ ] ) [ ] ) [ ] }");
            Console.WriteLine("output:");
            Console.WriteLine(Soal3.BalancedBracket("{ ( ( [ ] ) [ ] ) [ ] }"));
        }
    }
}
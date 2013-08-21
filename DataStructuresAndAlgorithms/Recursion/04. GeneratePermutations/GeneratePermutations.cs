using System;
using System.Collections.Generic;

class GeneratePermutations
{
    static SortedSet<string> result = new SortedSet<string>();

    static void Main()
    {
        List<Tuple<int,int>> frames = new List<Tuple<int,int>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            Tuple<int, int> frame = new Tuple<int, int>(int.Parse(line[0]), int.Parse(line[1]));
            frames.Add(frame);

        }

        GenPermutations(frames, 0);
        PrintResult();
    }

    private static void GenPermutations(List<Tuple<int,int>> frames,  int k)
    {
        if (k == frames.Count)
        {
           result.Add(String.Join(" | ", frames));
           return;
        }

        else
        {
            for (int i = k; i < frames.Count; i++)
            {
                Swap(frames, k, i);
                GenPermutations(frames, k + 1);
                frames[k] = new Tuple<int, int>(frames[k].Item2, frames[k].Item1);
                GenPermutations(frames, k + 1);
                frames[k] = new Tuple<int, int>(frames[k].Item1, frames[k].Item2);
                Swap(frames, k, i);
            }
        }
    }
  
    private static void PrintResult()
    {
        Console.WriteLine(result.Count);
        foreach (var frame in result)
        {
            Console.WriteLine(frame);
        }
    }

    private static void Swap(List<Tuple<int, int>> frames, int k, int i)
    {
        var temp = frames[i];
        frames[i] = frames[k];
        frames[k] = temp;
    }
}

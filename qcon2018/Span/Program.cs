using System;
using System.IO;

namespace Span
{
    class Program1
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\jaredpar\code\demos\qcon2018\Span\TextFile1.txt";
            using (var stream = new StreamReader(filePath))
            {
                do
                {
                    var line = stream.ReadLine();
                    if (line is null)
                    {
                        continue;
                    }

                    var (x, y) = Parse(line);
                    Console.WriteLine($"{x} - {y}");
                } while (true);
            }

        }

static (int, int) Parse(string line)
{
    var index = line.IndexOf(',');
    var x = int.Parse(line.Substring(0, index));
    var y = int.Parse(line.Substring(index + 1));
    return (x, y);
}
    }

class Program2
    {
        static void Main2(string[] args)
        {
            var filePath = @"C:\Users\jaredpar\code\demos\qcon2018\Span\TextFile1.txt";
            using (var stream = new StreamReader(filePath))
            {
                do
                {
                    var line = stream.ReadLine();
                    if (line is null)
                    {
                        continue;
                    }

                    var (x, y) = Parse(line);
                    Console.WriteLine($"{x} - {y}");
                } while (true);
            }

        }

static (int, int) Parse(ReadOnlySpan<char> line)
{
    var index = line.IndexOf(',');
    var x = int.Parse(line.Slice(0, index));
    var y = int.Parse(line.Slice(index + 1));
    return (x, y);
}
    }

    void Example()
    {
        Span<int> span = new int[42];
        span[0] = 13;
        Console.WriteLine(span.Length);
    }
}

class Arena
{

    void m() { 
Arena arena = new Arena();
using (arena.Activate())
{
	// allocations now go into the arena
	…
	using (Arena.GCHeap.Activate())
	{
		// allocations go to GC Heap
	}
	// allocate from arena again
}

// allocate from GC heap again
Arena.Dispose(); // delete the arena

}

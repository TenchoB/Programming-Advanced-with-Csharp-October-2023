
Stack<int> worms = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
Queue<int> holes = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));

int matches = 0;
int wormsCount = worms.Count;

while (worms.Count > 0 && holes.Count > 0)
{
    int worm = worms.Peek();
    int hole = holes.Peek();

    if (worm == hole)
    {
        worms.Pop();
        holes.Dequeue();
        matches++;
        continue;
    }

    holes.Dequeue();
    worms.Push(worms.Pop() - 3);

    if (worms.Peek() < 1)
    {
        worms.Pop();
    }
}

if (matches == 0)
{
    Console.WriteLine($"There are no matches.");
}
else
{
    Console.WriteLine($"Matches: {matches}");
}

if (worms.Count == 0 && matches == wormsCount)
{
    Console.WriteLine("Every worm found a suitable hole!");
}
else if (worms.Count == 0)
{
    Console.WriteLine($"Worms left: none");
}
else
{
    Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
}

if (holes.Count == 0)
{
    Console.WriteLine($"Holes left: none");
}
else
{
    Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
}


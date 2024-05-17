

//Queue<int> evenNumbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Where(i => i % 2 == 0));

//Console.WriteLine(string.Join(", ", evenNumbers));

int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Queue<int> queue = new Queue<int>(numbers);
int count = queue.Count();
for (int i = 0; i < count; i++)
{
    if (queue.Peek() % 2 == 1)
    {
        queue.Dequeue();
    }
    else
    {
        queue.Enqueue(queue.Dequeue());
    }

}
Console.WriteLine(string.Join(", ", queue));


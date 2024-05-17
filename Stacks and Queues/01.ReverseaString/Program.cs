//Stack<int> stack = new Stack<int>();
//stack.Push(1);
//stack.Push(2);
//stack.Push(3);
//stack.Push(4);
//stack.Push(5);

//Console.WriteLine(stack.Pop());
//Console.WriteLine(stack.Pop());
//int element = stack.Pop();
//Console.WriteLine(element);
//Console.WriteLine(stack.Peek());
//Console.WriteLine(stack.Peek());
//Console.WriteLine(stack.Peek());

////foreach (var items in stack)
//// Console.WriteLine(items);
//while (stack.Count > 0)
//{
//    Console.WriteLine(stack.Pop());
//}

string input = Console.ReadLine();
Stack<char> stack = new Stack<char>();
foreach (var character in input)
{
    stack.Push(character);
}

while (stack.Count > 0)
{
    Console.Write(stack.Pop());
}
//Queue<int> monsters = new Queue<int>(Console.ReadLine().Split(",").Select(int.Parse));
//Stack<int> strikes = new Stack<int>(Console.ReadLine().Split(",").Select(int.Parse));
//int killedMonsters = 0;

//while (monsters.Any() && strikes.Any())
//{
//    int armour = monsters.Peek();
//    int strike = strikes.Peek();

//    if (strike >= armour)
//    {
//        killedMonsters++;
//        strike -= armour;

//        if (strike == 0)
//        {
//            strikes.Pop();
//            monsters.Dequeue();
//        }
//        else
//        {
//            monsters.Dequeue();
//            if (strikes.Count == 1)
//            {
//                strikes.Pop();
//                strikes.Push(strike);
//                continue;
//            }
//            else
//            {
//                strikes.Pop();
//                int tempStrike = strike;
//                strikes.Push(strikes.Pop() + tempStrike);
//            }
//        }
//    }
//    else
//    {
//        armour -= strike;
//        strikes.Pop();
//        monsters.Dequeue();
//        monsters.Enqueue(armour);
//    }
//}

//if (!monsters.Any())
//{
//    Console.WriteLine("All monsters have been killed!");
//}
//if (!strikes.Any())
//{
//    Console.WriteLine("The soldier has been defeated.");
//}

//Console.WriteLine($"Total monsters killed: {killedMonsters}");




using System.Text;

StringBuilder sb = new StringBuilder();
sb.Append("Hello ");
sb.AppendLine("World!");
sb.AppendLine("Hello C#");
Console.WriteLine(sb);
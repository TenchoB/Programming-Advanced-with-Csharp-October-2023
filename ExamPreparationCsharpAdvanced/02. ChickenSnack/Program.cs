
Stack<int> amountmoney = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> foodprice = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int food = 0;
while (amountmoney.Count > 0 && foodprice.Count > 0 )
{
    int money = amountmoney.Peek();
    int price = foodprice.Peek();
  
    if (money == price)
    {
        food++;
        amountmoney.Pop();
        foodprice.Dequeue();
    }
    else if (money > price)
    {
        food++;
        int pocket = money - price;
        amountmoney.Pop();
        if (amountmoney.Count > 0)
        {
            int nextMoney = amountmoney.Pop() + pocket;
            amountmoney.Push(nextMoney);
        }
        foodprice.Dequeue() ;
    }
    else
    {
        amountmoney.Pop();
        foodprice.Dequeue() ;
    }

}
if (food >= 4)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {food} foods.");
}

else if (food > 1)
{
    Console.WriteLine($"Henry ate: {food} foods."); 
}
else if (food == 1)
{
    Console.WriteLine($"Henry ate: {food} food."); 
}
else
{
    Console.WriteLine("Henry remained hungry. He will try next weekend again.");
}
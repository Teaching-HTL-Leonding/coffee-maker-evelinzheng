Console.WriteLine("Please enter the amount of money that you fed into the machine (multiple of 0.5€): ");
double money = double.Parse(Console.ReadLine()!);

int Products = 0;

do
{
    Console.WriteLine("Which products you want to? 1)Cappuccino(3.5), 2)tea(1.5), 3)cacao(2.5) or 4)nothing_else: ");
    Products = int.Parse(Console.ReadLine()!);

    if (money < 1.5)
    {
        System.Console.WriteLine("You don't have enough money");
    }

    switch (Products)
    {
        case 1:
            money -= 3.50;
            break;

        case 2:
            money -= 1.50;
            break;

        case 3:
            money -= 2.50;
            break;

        case 4:
            System.Console.WriteLine("Your rest_money is:  " + money);
            break;
    }
}
while (Products != 4);

double money3 = Math.Floor (money  / 2);
if (money3 < 0)
{
    Console.WriteLine($"You get 0 x 2 pieces.");
}
else
{
    Console.WriteLine($"You get { money3} x 2 pieces.");
}



double money4 = Math.Floor (money % 2   / 1 ) ;
if (money4 < 0)
{
    Console.WriteLine($"You get 0 x 1 pieces.");
}
else
{
    Console.WriteLine($"You get { money4} x 1 pieces.");
}



double money5 = Math.Floor (money % 2 % 1 / 0.5 ) ;
if (money5 < 0)
{
    Console.WriteLine($"You get 0 x 0.5 pieces.");
}
else
{
    Console.WriteLine($"You get { money5} x 0.5 pieces.");
}

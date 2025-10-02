int num1, num2, num3;
Console.WriteLine("Em que ano você nasceu");
num1 = int.Parse(Console.ReadLine()!);
num2 = 2025;
num3 = (num1 - num2);
if (num3 >= 18)
{
    Console.WriteLine("Você é obrigado a votar");

}
if (num3 >= 16)
{
    Console.WriteLine("Você não pode votar");


}
else if (num3 >= 16 || num3 >= 17)
{
    Console.WriteLine("Você é facutativo");
}





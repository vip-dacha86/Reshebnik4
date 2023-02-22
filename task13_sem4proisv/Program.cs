// Напишите программу которая принимет на вход число N и выдаетпроизведение чисел от 1 до N.
// 4->24  5->120=1*2*3*4*5
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetProizv(num)}");
int GetProizv(int n)
{
    int result = 1;
    for (int i =2; i <= n; i++)
    {
    result*=i;
    }
    return result;
    
}
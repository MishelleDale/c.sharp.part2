Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();

int number1 = Convert.ToInt32(number);

void polintop (int number1)
{
    if (number1 >= 0)
    {
        if (number[0]==number[4] && number[1]==number[3]) Console.WriteLine(number + " является политропом");
        else
    {
        Console.WriteLine(number + " не является политропом");
    }
    }
    if (number1 <0)
    {
        if (number[1]==number[5] && number[2]==number[4]) Console.WriteLine(number + " является политропом");
        else
    {
        Console.WriteLine(number + " не является политропом");
    }
    }
}

polintop (number1);
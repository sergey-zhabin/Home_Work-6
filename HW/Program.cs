void Zadacha41()
{
    Console.WriteLine("Сколько чисел вы хотите ввести? ");
    int size = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    while( size > 0)
    {   
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
            if( number> 0) count++;
        size--;    
    }     
    Console.WriteLine($"введеных положительных чисел: {count} ");
    Console.WriteLine();
            
}    
Zadacha41();

void Zadacha43()
{
    Console.WriteLine("Введите значения переменной b1: ");
    double numderB1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значения переменной k1: ");
    double numberK1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значения переменной b2: ");
    double numberB2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значения переменной k2: ");
    double numberK2 = Convert.ToInt32(Console.ReadLine());
    double numberX = 0;
    double numberY= 0;

    //numberK1 * numberX + numderB1 = numberK2 * numberX + numberB2;
    numberX=(numberB2-numderB1)/(numberK1-numberK2);
    numberY=numberK1 * numberX + numderB1;
    
    Console.WriteLine($" Координаты точки пересечения двух прямых А[ {numberX};{numberY}]");
    
}
Zadacha43();

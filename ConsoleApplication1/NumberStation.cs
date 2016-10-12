using System;
namespace ConsoleApplication1
{
    public class NumberStation
    {
        public int NumSt()
        {
            int numberOfWStation;
            int i = 0;
            do
            {
                Console.WriteLine("Введите количество станций: ");
                numberOfWStation = int.Parse(Console.ReadLine());
                if (numberOfWStation < 1 || numberOfWStation > 20)
                {
                    Console.WriteLine("Неверное значение, введите пожалуйста от 1 до 20");
                }
                else
                {
                    break;
                }
            } while (i<10);
            return numberOfWStation;
        }
        
    }
}
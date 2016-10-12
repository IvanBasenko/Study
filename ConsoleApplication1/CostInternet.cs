using System;

namespace ConsoleApplication1
{
    public class CostInternet
    {
        public decimal CostInt()
        {
            decimal costOfInternetPerWStation;
            int i = 0;
            do
            {
                Console.WriteLine("Введите стоимость подключения интернета на одну станцию: ");
                costOfInternetPerWStation = decimal.Parse(Console.ReadLine());
                if (costOfInternetPerWStation < 100 || costOfInternetPerWStation > 1000)
                {
                    Console.WriteLine("Неверное значение введите пожалуйста от 100 до 1000");
                }
                else
                {
                    break;
                }
                i++;
            } while (i<10);
            return costOfInternetPerWStation;
        }
    }
}
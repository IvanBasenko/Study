using System;
namespace ConsoleApplication1
{
    public class CostPower
    {
        public decimal CostPwt()
        {
            decimal costOfPowerPerWStation;
            int i = 0;
            do
            {
                Console.WriteLine("Введите стоимость подключения питания на одну станцию: ");
                costOfPowerPerWStation = decimal.Parse(Console.ReadLine());
                if (costOfPowerPerWStation < 50 || costOfPowerPerWStation > 500)
                {
                    Console.WriteLine("Неверное значение введите пожалуйста от 50 до 500");
                }
                else
                {
                    break;
                }
                i++;

            } while (i < 10);
            return costOfPowerPerWStation;
        }
    }
}
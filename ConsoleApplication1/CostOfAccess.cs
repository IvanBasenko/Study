using System;
namespace ConsoleApplication1
{
    public class CostOfAccess
    {
        public void CostOfAcc(decimal costOfInternetPerWStation, decimal costOfPowerPerWStation, int numberOfWStation)
        {
            decimal costOfAccess;
            costOfAccess= (costOfInternetPerWStation + costOfPowerPerWStation) * numberOfWStation;
            Console.WriteLine("Стоимость подключения интренета: " + costOfAccess);
        }
    }
}
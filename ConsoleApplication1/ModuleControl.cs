using System;

namespace ConsoleApplication1
{
    class ModuleControl
    {
        public void Go()
        {
            CostPower power = new CostPower();
            CostInternet internet = new CostInternet();
            NumberStation station = new NumberStation();
            CostOfAccess access = new CostOfAccess();
            access.CostOfAcc(power.CostPwt(), internet.CostInt(), station.NumSt());
        }
    }
}

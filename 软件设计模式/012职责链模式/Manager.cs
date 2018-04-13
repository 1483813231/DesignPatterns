using System;

namespace _012职责链模式
{
    public class Manager:Leader
    {
        public Manager(string name):base(name)
        {
        }

        public override void HandleRequest(LeaverRequest leaverRequest)
        {
            if (leaverRequest.LeaverDay >10)
            {
                if (successor != null)
                {
                    successor.HandleRequest(leaverRequest);
                }
            }
            else
            {
                Console.WriteLine("经理"+this.name+"批准了"+leaverRequest.LeaverName+"的"+leaverRequest.LeaverDay+"假期");
            }
        }
    }
}
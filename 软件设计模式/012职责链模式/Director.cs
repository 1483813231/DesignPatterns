using System;
using Microsoft.SqlServer.Server;

namespace _012职责链模式
{
    public class Director:Leader
    {
        public Director(string name):base(name)
        {
        }

        public override void HandleRequest(LeaverRequest leaverRequest)
        {
            if (leaverRequest.LeaverDay > 3)
            {
                if (successor != null)
                {
                    successor.HandleRequest(leaverRequest);
                }
                else
                {
                    Console.WriteLine("无法批准假期");
                }
            }
            else
            {
                Console.WriteLine("主管"+this.name+"批准了"+leaverRequest.LeaverName+"的"+leaverRequest.LeaverDay+"假期");
            }
        }
    }
}
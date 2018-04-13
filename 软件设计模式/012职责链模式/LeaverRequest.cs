using System.Security.Cryptography.X509Certificates;

namespace _012职责链模式
{
    public class LeaverRequest
    {
        private string leavername;
        private int leaverday;

        public string LeaverName
        {
            get { return leavername; }
        }

        public int LeaverDay
        {
            get { return leaverday; }
        }

        public LeaverRequest(string leacername,int leaverday)
        {
            this.leavername = leacername;
            this.leaverday = leaverday;
        }
    }
}
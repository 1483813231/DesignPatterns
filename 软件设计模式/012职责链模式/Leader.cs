namespace _012职责链模式
{
    public abstract class Leader
    {
        protected string name;
        protected Leader successor;

        public Leader(string name)
        {
            this.name = name;
            //this.successor = successor;
        }

        public Leader Successor
        {
            set { successor = value; }
            get { return successor; }
        }

        public abstract void HandleRequest(LeaverRequest leaverRequest);

    }
}
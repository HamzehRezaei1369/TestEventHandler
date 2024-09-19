namespace TestEventHandler
{
    public class HubCenter
    {
        public event EventHandler Onchange;
        public event EventHandler<int> Onreceive;
        public async Task CallHub()
        {
            Onchange.Invoke(this, EventArgs.Empty);
        }
        public async Task CallHub2(int id)
        {
            Onreceive.Invoke(this,id);
        }
    }
}

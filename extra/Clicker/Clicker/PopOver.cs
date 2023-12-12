namespace Clicker
{

    internal class PopOver
    {
        internal int x;
        internal int y;
        internal readonly PopOverType popOverType;
        internal readonly DateTime time;

        public PopOver(int x, int y, PopOverType popOverType)
        {
            this.x = x;
            this.y = y;
            this.popOverType = popOverType;


            int liveTime=300 + new Random().Next(0,200);
            time = DateTime.Now.AddMilliseconds(liveTime);
        }
    }
}
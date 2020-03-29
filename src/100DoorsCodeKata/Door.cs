namespace HundredDoorsCodeKata
{
    public class Door
    {
        public bool IsOpen { get; set; }

        public override string ToString()
        {
            return IsOpen ? "@" : "#";
        }
    }
}
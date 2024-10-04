namespace MouseMovement.Data
{
    public class MouseMovement
    {
        public int Id { get; set; }
        public List<(int X, int Y, DateTime Time)> Coordinates { get; set; } = new List<(int X, int Y, DateTime Time)>();
    }
}

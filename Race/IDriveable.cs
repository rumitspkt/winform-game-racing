namespace Race
{
    interface IDriveable
    {
        void Acceleration(params object[] car_objs);
        void Turn(params object[] car_objs);
        int X { get; set; }
        int Y { get; set; }
    }
    enum Direction : byte
    { Up, Down, Left, Right }
    public enum Levels : byte
    { Easy = 1, Medium, Hard }
    public delegate void RivalControl(params object[] objs);
}
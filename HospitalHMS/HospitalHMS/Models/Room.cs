public enum RoomType { Single, Double, VIP }

public class Room
{
    public int RoomNumber { get; set; }
    public RoomType Type { get; set; }
    public bool IsOccupied { get; set; } = false;

    public Room(int number, RoomType type)
    {
        RoomNumber = number;
        Type = type;
    }
    public override string ToString() {
      return $"Room {RoomNumber} ({Type}) - {(IsOccupied ? "Occupied" : "Available")}";
    } 
}
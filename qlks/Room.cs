using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlks
{
    public abstract class Room
    {
        public int RoomNumber { get; set; }
        public double RoomPrice { get; set; }
        public bool IsOccupied { get; set; }

        public abstract void DisplayInfo();
        public abstract void CheckOut();
    }

    public class SingleRoom : Room
    {
        public SingleRoom(int roomNumber, double roomPrice)
        {
            RoomNumber = roomNumber;
            RoomPrice = roomPrice;
            IsOccupied = false; // Ban đầu, phòng không được thuê
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Single Room number {RoomNumber} - Price: {RoomPrice} USD/night - {(IsOccupied ? "Occupied" : "Vacant")}");
        }

        public override void CheckOut()
        {
            IsOccupied = false; // Trả phòng, phòng trở thành trống
        }
    }
    public class DoubleRoom : Room
    {
        public DoubleRoom(int roomNumber, double roomPrice)
        {
            RoomNumber = roomNumber;
            RoomPrice = roomPrice;
            IsOccupied = false; // Set to false by default
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Double Room number {RoomNumber} - Price: {RoomPrice} USD/night - {(IsOccupied ? "Occupied" : "Vacant")}");
        }

        public override void CheckOut()
        {
            IsOccupied = false; // Set IsOccupied to false to indicate that the room is vacant after check-out
        }
    }

}

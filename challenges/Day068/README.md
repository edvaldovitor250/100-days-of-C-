# Day 68

## Desafio:

Implemente um sistema em C# para gerenciar um hotel, com funcionalidades para reserva de quartos, check-in e check-out.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

namespace HotelManagementSystem
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }
    }

    public class Reservation
    {
        public int ReservationId { get; set; }
        public int RoomNumber { get; set; }
        public string GuestName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool IsCheckedIn { get; set; } = false;

        public Reservation(int reservationId, int roomNumber, string guestName, DateTime checkInDate, DateTime checkOutDate)
        {
            ReservationId = reservationId;
            RoomNumber = roomNumber;
            GuestName = guestName;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
    }

    public class HotelManager
    {
        private List<Room> rooms = new List<Room>();
        private List<Reservation> reservations = new List<Reservation>();
        private int reservationCounter = 1;

        public void AddRoom(int roomNumber)
        {
            rooms.Add(new Room(roomNumber));
        }

        public Reservation MakeReservation(int roomNumber, string guestName, DateTime checkInDate, DateTime checkOutDate)
        {
            Room room = rooms.Find(r => r.RoomNumber == roomNumber && r.IsAvailable);
            if (room == null)
            {
                Console.WriteLine($"Room {roomNumber} is not available for reservation.");
                return null;
            }

            Reservation reservation = new Reservation(reservationCounter++, roomNumber, guestName, checkInDate, checkOutDate);
            reservations.Add(reservation);
            room.IsAvailable = false;

            Console.WriteLine($"Reservation {reservation.ReservationId} made for {guestName} in Room {roomNumber}.");
            return reservation;
        }

        public void CheckIn(int reservationId)
        {
            Reservation reservation = reservations.Find(r => r.ReservationId == reservationId);
            if (reservation == null || reservation.IsCheckedIn)
            {
                Console.WriteLine("Invalid reservation for check-in.");
                return;
            }

            reservation.IsCheckedIn = true;
            Console.WriteLine($"Check-in successful for Reservation {reservation.ReservationId}, Guest: {reservation.GuestName}.");
        }

        public void CheckOut(int reservationId)
        {
            Reservation reservation = reservations.Find(r => r.ReservationId == reservationId);
            if (reservation == null || !reservation.IsCheckedIn)
            {
                Console.WriteLine("Invalid reservation for check-out.");
                return;
            }

            reservation.IsCheckedIn = false;
            Room room = rooms.Find(r => r.RoomNumber == reservation.RoomNumber);
            if (room != null)
            {
                room.IsAvailable = true;
            }

            Console.WriteLine($"Check-out successful for Reservation {reservation.ReservationId}, Guest: {reservation.GuestName}.");
        }

        public void ListRooms()
        {
            Console.WriteLine("Room Status:");
            foreach (var room in rooms)
            {
                Console.WriteLine($"Room {room.RoomNumber}: {(room.IsAvailable ? "Available" : "Occupied")}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HotelManager hotelManager = new HotelManager();
            hotelManager.AddRoom(101);
            hotelManager.AddRoom(102);
            hotelManager.AddRoom(103);

            Reservation reservation1 = hotelManager.MakeReservation(101, "Alice", DateTime.Now, DateTime.Now.AddDays(3));
            hotelManager.ListRooms();

            if (reservation1 != null)
            {
                hotelManager.CheckIn(reservation1.ReservationId);
            }
            hotelManager.ListRooms();

            if (reservation1 != null)
            {
                hotelManager.CheckOut(reservation1.ReservationId);
            }
            hotelManager.ListRooms();
        }
    }
}

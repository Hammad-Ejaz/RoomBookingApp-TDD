using BookYourRoom.Domain;
using System;
using System.Collections.Generic;

namespace BookYourRoom.Core.DataServices
{
    public interface IRoomBookingService
    {
        void SaveBooking(RoomBooking roomBooking);

        IEnumerable<Room> GetAvailableRooms(DateTime date);
        IEnumerable<Room> GetRooms();
    }
}

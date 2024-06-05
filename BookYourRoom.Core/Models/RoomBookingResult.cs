using BookYourRoom.Core.Enums;
using BookYourRoom.Domain.BaseModels;

namespace BookYourRoom.Core.Models
{
    public class RoomBookingResult : RoomBookingBase
    {
        public BookingResultFlag Flag { get; set; }
        public int? RoomBookingId { get; set; }
    }
}
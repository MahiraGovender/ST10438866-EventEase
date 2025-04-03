using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Display(Name = "Booking Date")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
        public int? VenueId { get; set; }
        public int? EventId { get; set; }

        //Navigation properties
        public Venue? Venue { get; set; }
        public Event? Event { get; set; }
    }
}

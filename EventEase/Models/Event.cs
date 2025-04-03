using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Display(Name = "Event Name")]
        public string EventName { get; set; }
        public string Description { get; set; }

        [Display(Name = "Event Date")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        // Navigation property
        public List<Booking>? Booking { get; set; }
    }
}

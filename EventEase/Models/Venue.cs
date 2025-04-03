using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Venue
    {
        [Key]
        public int VenueID { get; set; }

        [Display(Name = "Venue Name")]
        public string VenueName { get; set; }
        public string Location { get; set; }
        public string Capacity { get; set; }

        [Display(Name = "Image")]
        public string ImageURL { get; set; }

        // Navigation property
        public List<Booking>? Booking { get; set; }
    }
}

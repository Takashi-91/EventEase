namespace EventEase.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        [Required]
        [StringLength(100)]
        public string VenueName { get; set; }

        [Required]
        [StringLength(150)]
        public string Location { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        [StringLength(500)]
        public string ImageUrl { get; set; }
    }

}

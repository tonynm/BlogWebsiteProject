using System.ComponentModel.DataAnnotations;

namespace BlogWebsiteProject.Models.Entities
{
    public class SDFoodBankVolunteerData
    {
        [Required]
        public int VolunteerId { get; set; }

        public DateTime VolunteerDate { get; set; }

        public int VolunteerHours { get; set; }

        [Required]
        public string VolunteerName { get; set; }

        public string VolunteerTask { get; set; }
    }
}

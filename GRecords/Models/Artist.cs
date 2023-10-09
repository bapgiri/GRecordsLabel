using System.ComponentModel.DataAnnotations;

namespace GRecords.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        public string ProfielPicture { get; set; }

        public string ArtistName { get; set;}

        public string Biography { get; set;}
    }
}

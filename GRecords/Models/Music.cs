using System.ComponentModel.DataAnnotations;

namespace GRecords.Models
{
    public class Music
    {
        [Key]
        public int Id { get; set; }
        public string MusicPicture { get; set; }

        public string MusicName { get; set; }

        public string MusicCredits { get; set; }
    }
}

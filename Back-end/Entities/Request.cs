using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Back_end.Common;

namespace Back_end.Entities
{
    public class Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        public User Requestby { get; set; }

        public DateTime RequestAt { get; set; }

        public Status Status { get; set; }

        public string Note { get; set; }

        public DateTime LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }
    }
}
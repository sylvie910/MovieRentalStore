using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class MembershipType
    {
        //必须有个key，对应对应table的主键
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 0;

    }
}
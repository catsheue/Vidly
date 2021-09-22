namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SingUpFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}
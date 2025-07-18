namespace GraduationProj.Models
{
    public class PaymentInfoView
    {
        public float SupTotal { get; set; }
        public float Tax { get; set; }
        public float Total { get; set; }
        public List<CartItem> CartItems { get; set; }
        public ShippingInfo shippingInfo { get; set; }
        public Address address { get; set; }
    }
}

namespace CouponApi.Models;

public class Coupon
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Percentage { get; set; }
    public bool IsActive { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
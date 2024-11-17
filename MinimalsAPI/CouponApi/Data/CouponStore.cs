using CouponApi.Models;

namespace CouponApi.Data;

public static class CouponStore
{
    public static List<Coupon> coupons = new List<Coupon>
    {
        new Coupon { Id = 1, Name = "100FF", Percentage = 10, IsActive = true },
        new Coupon { Id = 2, Name = "200FF", Percentage = 20, IsActive = false },
    };
}
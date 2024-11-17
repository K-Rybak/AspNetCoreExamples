using CouponApi.Data;
using CouponApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/coupons", () => CouponStore.coupons);

app.MapGet("/api/coupons/{id:int}", (int id) => 
    CouponStore.coupons.FirstOrDefault(x => x.Id == id));

app.MapGet("/api/coupons/{isActive:bool}", GetIsActiveCoupons);

app.Run();

List<Coupon> GetIsActiveCoupons(bool isActive)
{
    return CouponStore.coupons.Where(x => x.IsActive == isActive).ToList();
}
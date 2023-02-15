using AutoDealer.Repositories;
using AutoDealer.Repositories.Interfaces;
using AutoDealer.Repositories.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<IContactRequestRepository, ContactRequestRepository>();  
builder.Services.AddScoped<ICustomerRecordRepository, CustomerRecordRepository>();  
builder.Services.AddScoped<IExteriorColorRepository, ExteriorColorRepository>();    
builder.Services.AddScoped<IInteriorColorRepository, InteriorColorRepository>();   
builder.Services.AddScoped<IModelTypeRepository, ModelTypeRepository>();
builder.Services.AddScoped<IPurchaseRecordRepository, PurchaseRecordRepository>();
builder.Services.AddScoped<ISpecialRepository, SpecialRepository>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AutoDealerDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:AutoDealerDbContextConnection"]);
});

var app = builder.Build();

#region MiddleWare Components

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute();//endpoint middleware.
DBInitializer.Seed(app);
#endregion
app.Run();

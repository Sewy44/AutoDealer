using AutoDealer.Repositories;
using AutoDealer.Repositories.Interfaces;
using AutoDealer.Repositories.MockRepositories;
using AutoDealer.Repositories.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBrandNameRepository, BrandNameRepository>();
builder.Services.AddScoped<IContactRequestRepository, ContactRequestRepository>();  
builder.Services.AddScoped<ICustomerRecordRepository, CustomerRecordRepository>();  
builder.Services.AddScoped<IExteriorColorTypeRepository, ExteriorColorTypeRepository>();    
builder.Services.AddScoped<IInteriorColorTypeRepository, InteriorColorTypeRepository>();   
builder.Services.AddScoped<IModelTypeRepository, ModelTypeRepository>();
builder.Services.AddScoped<IPurchaseRecordRepository, PurchaseRecordRepository>();
builder.Services.AddScoped<ISpecialRepository, SpecialRepository>();
builder.Services.AddScoped<IVehicleRecordRepository, VehicleRecordRepository>();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AutoDealerDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConntectionStrings:AutoDealerDbContextConntection"]);
});

var app = builder.Build();

#region MiddleWare Components

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute();//endpoint middleware.

#endregion
app.Run();

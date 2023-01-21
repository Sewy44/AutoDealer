using AutoDealer.Repositories.Interfaces;
using AutoDealer.Repositories.MockRepositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IBrandNameRepository, MockBrandNameRepository>();
builder.Services.AddScoped<IContactRequestRepository, MockContactRequestRepository>();  
builder.Services.AddScoped<ICustomerRecordRepository, MockCustomerRecordRepository>();  
builder.Services.AddScoped<IExteriorColorTypeRepository, MockExteriorColorTypeRepository>();    
builder.Services.AddScoped<IInteriorColorTypeRepository, MockInteriorColorTypeRepository>();   
builder.Services.AddScoped<IModelTypeRepository, MockModelTypeRepository>();
builder.Services.AddScoped<IPurchaseRecordRepository, MockPurchaseRecordRepository>();
builder.Services.AddScoped<ISpecialRepository, MockSpecialRepository>();
builder.Services.AddScoped<IVehicleRecordRepository, MockVehicleRecordRepository>();
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

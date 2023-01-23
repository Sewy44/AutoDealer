using AutoDealer.Repositories.Interfaces;
using AutoDealer.Repositories.MockRepositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IBrandNameRepository, BrandNameRepositoryQA>();
builder.Services.AddScoped<IContactRequestRepository, ContactRequestRepositoryQA>();  
builder.Services.AddScoped<ICustomerRecordRepository, CustomerRecordRepositoryQA>();  
builder.Services.AddScoped<IExteriorColorTypeRepository, ExteriorColorTypeRepositoryQA>();    
builder.Services.AddScoped<IInteriorColorTypeRepository, InteriorColorTypeRepositoryQA>();   
builder.Services.AddScoped<IModelTypeRepository, ModelTypeRepositoryQA>();
builder.Services.AddScoped<IPurchaseRecordRepository, PurchaseRecordRepositoryQA>();
builder.Services.AddScoped<ISpecialRepository, SpecialRepositoryQA>();
builder.Services.AddScoped<IVehicleRecordRepository, VehicleRecordRepositoryQA>();
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

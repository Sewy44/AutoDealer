using AutoDealer.Repositories.Interfaces;
using AutoDealer.Repositories.MockRepositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBrandRepository, BrandRepositoryQA>();
builder.Services.AddScoped<IContactRequestRepository, ContactRequestRepositoryQA>();  
builder.Services.AddScoped<ICustomerRecordRepository, CustomerRecordRepositoryQA>();  
builder.Services.AddScoped<IExteriorColorRepository, ExteriorColorRepositoryQA>();    
builder.Services.AddScoped<IInteriorColorRepository, InteriorColorRepositoryQA>();   
builder.Services.AddScoped<IModelTypeRepository, ModelTypeRepositoryQA>();
builder.Services.AddScoped<IPurchaseRecordRepository, PurchaseRecordRepositoryQA>();
builder.Services.AddScoped<ISpecialRepository, SpecialRepositoryQA>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepositoryQA>();

builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<AutoDealerDbContext>(options =>
//{
//    options.UseSqlServer(
//        builder.Configuration["ConnectionStrings:AutoDealerDbContextConnection"]);
//});

var app = builder.Build();

#region MiddleWare Components

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute();//endpoint middleware.
//DBInitializer.Seed(app);
#endregion
app.Run();

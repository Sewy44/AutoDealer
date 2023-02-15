using AutoDealer.Models;
using AutoDealer.Models.Customer;
using AutoDealer.Models.Enums;
using AutoDealer.Models.Purchase;
using AutoDealer.Models.Special;
using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Repositories
{
    public static class DBInitializer
    {
        private static DateTime _addedDate = new DateTime(2023, 2, 14);
        private static DateTime _purchaseDate = new DateTime(2023, 1, 22);
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AutoDealerDbContext context = applicationBuilder.ApplicationServices.CreateScope
                ().ServiceProvider.GetRequiredService<AutoDealerDbContext>();

            if (!context.CustomerRecords.Any())
            {
                context.AddRange
                (new CustomerRecord
                {
                    CustomerId = Guid.NewGuid(),
                    FirstName = "Jim",
                    LastName = "Jimerson",
                    PhoneNumber = "502-555-5555",
                    AddedDate = _addedDate,
                    AddressLineOne = "555 5th Street",
                    Email = "Jim@jim.com",
                    City = "Louisville",
                    ZipCode = "40444",
                    State = StateAbbreviation.KY
                },
                new CustomerRecord
                {
                    CustomerId = Guid.NewGuid(),
                    FirstName = "Tom",
                    LastName = "Thomson",
                    PhoneNumber = "502-555-4444",
                    AddedDate = _addedDate,
                    AddressLineOne = "Tomson St.",
                    Email = "Tom@tom.com",
                    City = "Columbus",
                    ZipCode = "40000",
                    State = StateAbbreviation.OH
                });
            }

            if (!context.Brands.Any())
            {
                context.AddRange
                (new Brand()
                {
                    BrandNameId = Guid.NewGuid(),
                    BrandName = "Ford",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new Brand()
                {
                    BrandNameId = Guid.NewGuid(),
                    BrandName = "GMC",
                    AddedDate = _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                new Brand()
                {
                    BrandNameId = Guid.NewGuid(),
                    BrandName = "Toyota",
                    AddedDate = _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                new Brand()
                {
                    BrandNameId = Guid.NewGuid(),
                    BrandName = "Kia",
                    AddedDate = _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                 new Brand()
                 {
                     BrandNameId = Guid.NewGuid(),
                     BrandName = "Jeep",
                     AddedDate = _addedDate,
                     AddedBy = "jamie@Autodealer.com"
                 });
            }

            if (!context.ContactRequests.Any())
            {
                context.AddRange
                (
                new ContactRequest()
                {
                    ContactRequestId = Guid.NewGuid(),
                    ContactEmail = "test@email.com",
                    DateContactRequested = _addedDate
                },
                new ContactRequest()
                {
                    ContactRequestId = Guid.NewGuid(),
                    ContactEmail = "emailme@email.com",
                    DateContactRequested = _addedDate
                },
                new ContactRequest()
                {
                    ContactRequestId = Guid.NewGuid(),
                    ContactFirstName = "Jim",
                    ContactPhone = "502-555-5555",
                    DateContactRequested = _addedDate
                },
                new ContactRequest()
                {
                    ContactRequestId = Guid.NewGuid(),
                    ContactFirstName = "Tom",
                    ContactPhone = "502-555-4444",
                    DateContactRequested = _addedDate
                });
            }

            if (!context.ExteriorColors.Any())
            {
                context.AddRange
                (new ExteriorColor()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Red"
                },
                new ExteriorColor()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Black"
                },
                new ExteriorColor()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Silver"
                },
                new ExteriorColor()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Blue"
                },
                new ExteriorColor()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "White"
                });
            }

            if (!context.InteriorColors.Any())
            {
                context.AddRange
                (new InteriorColor()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Black"
                },
                new InteriorColor()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Tan"
                },
                new InteriorColor()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "White"
                },
                new InteriorColor()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Gray"
                });
            }

            if (!context.Models.Any())
            {
                context.AddRange
                (new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Edge",
                    BrandName = context.Brands.FirstOrDefault(x => x.BrandName == "Ford"),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Mustang",
                    BrandName = context.Brands.FirstOrDefault(x => x.BrandName == "Ford"),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Sorrento",
                    BrandName = context.Brands.FirstOrDefault(x => x.BrandName == "Kia"),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Optima",
                    BrandName = context.Brands.FirstOrDefault(x => x.BrandName == "Kia"),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Grand Cherokee L",
                    BrandName = context.Brands.FirstOrDefault(x => x.BrandName == "Jeep"),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Wrangler",
                    BrandName = context.Brands.FirstOrDefault(x => x.BrandName == "Jeep"),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "ForeRunner",
                    BrandName = context.Brands.FirstOrDefault(x => x.BrandName == "Toyota"),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Tercel",
                    BrandName = context.Brands.FirstOrDefault(x => x.BrandName == "Toyota"),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                });
            }

            //if (!context.PurchaseRecords.Any())
            //{
            //    context.AddRange
            //    (
            //    new PurchaseRecord()
            //    {
            //        PurchaseId = Guid.NewGuid(),
            //        TypeOfPurchase = PurchaseType.DealerFinance,
            //        PurchasedVehicleRecord = new VehicleRecord(),
            //        PurchasingCustomer = new CustomerRecord(),
            //        PurchaseDate = _purchaseDate,
            //        PurchasePrice = 50000,
            //        SalesRepresentative = "Jamie Seward"
            //    },
            //    new PurchaseRecord()
            //    {
            //        PurchaseId = Guid.NewGuid(),
            //        TypeOfPurchase = PurchaseType.BankFinance,
            //        PurchasedVehicleRecord = new VehicleRecord(),
            //        PurchasingCustomer = new CustomerRecord(),
            //        PurchaseDate = _purchaseDate,
            //        PurchasePrice = 30000,
            //        SalesRepresentative = "Jamie Seward"
            //    });
            //}

            if (!context.Specials.Any())
            {
                context.AddRange
                (
                new Special
                {
                    SpecialId = Guid.NewGuid(),
                    SpecialName = "Free Tires For Life!",
                    SpecialDescription = "Speak with any representative to learn how you can take advantage of"
                + "this great offer to get free tires for the life of your vehicle!",
                    AddedBy = "jamie@autodealer.com",
                    AddedDate = _addedDate,
                    ExpirationDate = DateTime.Now.AddMonths(1),
                    ImageFileName = "tires.jpg"
                },
                new Special
                {
                    SpecialId = Guid.NewGuid(),
                    SpecialName = "$1,000 off MSRP for any new SUV!",
                    SpecialDescription = "Come in today to purchase your new SUV and save $1,000!",
                    AddedBy = "jamie@autodealer.com",
                    AddedDate = _addedDate,
                    ExpirationDate = DateTime.Now.AddDays(14),
                    ImageFileName = "tires.jpg"
                });
            }

            if (!context.Vehicles.Any())
            {
                context.AddRange
                (new Vehicle
                {
                    VehicleVIN = "1C4RJFBG5FC767030",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorName == "Tan"),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorName == "Black"),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = context.Models.FirstOrDefault(m => m.Model == "Edge"),
                    Mileage = 590,
                    Year = "2022",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 57000,
                    CurrentListPrice = 57000,
                    MRSP = 58500,
                    Description = "Very cool SUV!",
                    IsUsed = true
                },
                new Vehicle
                {
                    VehicleVIN = "1C4RJFBG5FC767031",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorName == "Red"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.Model == "Mustang"),
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "A beautiful sports car!",
                    IsFeatured = true
                },
                new Vehicle
                {
                    VehicleVIN = "aaaaaaaaaaaaaaaaa",
                    Transmission = Models.Enums.TransmissionType.Manual,
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorName == "Blue"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.Model == "Tercel"),
                    Mileage = 360000,
                    Year = "1978",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 200,
                    CurrentListPrice = 200,
                    MRSP = 200,
                    Description = "A classic!",
                    IsFeatured = true,
                    IsUsed = true
                },
                new Vehicle
                {
                    VehicleVIN = "bbbbbbbbbbbbbbbb",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorName == "Black"),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorName == "Black"),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = context.Models.FirstOrDefault(m => m.Model == "Grand Cherokee"),
                    Mileage = 2600,
                    Year = "2022",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 51500,
                    CurrentListPrice = 51500,
                    MRSP = 54500,
                    Description = "A beautiful used SUV!"
                },
                new Vehicle
                {
                    VehicleVIN = "ccccccccccccccccc",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorName == "Tan"),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorName == "Silver"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.Model == "Optima"),
                    Mileage = 2300,
                    Year = "2021",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 32000,
                    CurrentListPrice = 32000,
                    MRSP = 36400,
                    Description = "llorem Ipsum...!"
                },
                new Vehicle
                {
                    VehicleVIN = "ddddddddddddddddd",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorName == "White"),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = context.Models.FirstOrDefault(m => m.Model == "Wrangler"),
                    Mileage = 127000,
                    Year = "2015",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 20000,
                    CurrentListPrice = 20000,
                    MRSP = 41500,
                    Description = "A great Jeep for playing outdoors!",
                    IsFeatured = true
                },
                new Vehicle
                {
                    VehicleVIN = "eeeeeeeeeeeeeeeee",
                    Transmission = Models.Enums.TransmissionType.Manual,
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorName == "Black"),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorName == "Black"),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = context.Models.FirstOrDefault(m => m.Model == "Sorrento"),
                    Mileage = 35000,
                    Year = "2020",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 23000,
                    CurrentListPrice = 23000,
                    MRSP = 41500,
                    Description = "Another kinda cool SUV!"
                },
                new Vehicle
                {
                    VehicleVIN = "fffffffffffffffff",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorName == "Red"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.Model == "Mustang"),
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Could we have any more Mustangs?",
                    IsFeatured = true,
                    IsSold = false
                },
                new Vehicle
                {
                    VehicleVIN = "ggggggggggggggggg",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorName == "Red"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.Model == "Mustang"),
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Kina cool SUV!",
                    IsFeatured = true,
                    IsSold = false
                },
                new Vehicle
                {
                    VehicleVIN = "hhhhhhhhhhhhhhhhh",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorName == "Red"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.Model == "Mustang"),
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Kina cool SUV!",
                    IsFeatured = true,
                    IsSold = false
                });
            }

            context.SaveChanges();
        }
    }
}

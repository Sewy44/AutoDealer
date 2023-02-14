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

            if (!context.BrandNames.Any())
            {
                context.AddRange
                (new BrandName()
                {
                    BrandNameId = Guid.NewGuid(),
                    MakeName = "Ford",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new BrandName()
                {
                    BrandNameId = Guid.NewGuid(),
                    MakeName = "GMC",
                    AddedDate = _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                new BrandName()
                {
                    BrandNameId = Guid.NewGuid(),
                    MakeName = "Toyota",
                    AddedDate = _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                new BrandName()
                {
                    BrandNameId = Guid.NewGuid(),
                    MakeName = "Kia",
                    AddedDate = _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                 new BrandName()
                 {
                     BrandNameId = Guid.NewGuid(),
                     MakeName = "Jeep",
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
                (new ExteriorColorType()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Red"
                },
                new ExteriorColorType()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Black"
                },
                new ExteriorColorType()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Silver"
                },
                new ExteriorColorType()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Blue"
                },
                new ExteriorColorType()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "White"
                });
            }

            if (!context.InteriorColors.Any())
            {
                context.AddRange
                (new InteriorColorType()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Black"
                },
                new InteriorColorType()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Tan"
                },
                new InteriorColorType()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "White"
                },
                new InteriorColorType()
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
                    ModelName = "Edge",
                    Make = new BrandName()
                    {
                        MakeName = "Ford"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Mustang",
                    Make = new BrandName()
                    {
                        MakeName = "Ford"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Sorrento",
                    Make = new BrandName()
                    {
                        MakeName = "Kia"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Optima",
                    Make = new BrandName()
                    {
                        MakeName = "Kia"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Grand Cherokee L",
                    Make = new BrandName()
                    {
                        MakeName = "Jeep"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Wrangler",
                    Make = new BrandName()
                    {
                        MakeName = "Jeep"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "ForeRunner",
                    Make = new BrandName()
                    {
                        MakeName = "Toyota"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Tercel",
                    Make = new BrandName()
                    {
                        MakeName = "Toyota"
                    },
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

            if (!context.VehicleRecords.Any())
            {
                context.AddRange
                (new VehicleRecord
                {
                    VehicleVIN = "1C4RJFBG5FC767030",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = new InteriorColorType { InteriorColorName = "Tan" },
                    ExteriorColor = new ExteriorColorType { ExteriorColorName = "Black" },
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = new ModelType { ModelName = "Edge", Make = new BrandName { MakeName = "Ford" } },
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
                new VehicleRecord
                {
                    VehicleVIN = "1C4RJFBG5FC767031",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = new InteriorColorType { InteriorColorName = "Gray" },
                    ExteriorColor = new ExteriorColorType { ExteriorColorName = "Red" },
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = new ModelType { ModelName = "Mustang", Make = new BrandName { MakeName = "Ford"}},
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
                new VehicleRecord
                {
                    VehicleVIN = "aaaaaaaaaaaaaaaaa",
                    Transmission = Models.Enums.TransmissionType.Manual,
                    InteriorColor = new InteriorColorType { InteriorColorName = "Gray" },
                    ExteriorColor = new ExteriorColorType { ExteriorColorName = "Blue" },
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = new ModelType { ModelName = "Tercel", Make = new BrandName { MakeName = "Toyota" } },
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
                new VehicleRecord
                {
                    VehicleVIN = "bbbbbbbbbbbbbbbb",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = new InteriorColorType { InteriorColorName = "Black" },
                    ExteriorColor = new ExteriorColorType { ExteriorColorName = "Black" },
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = new ModelType { ModelName = "Grand Cherokee", Make = new BrandName { MakeName = "Jeep" } },
                    Mileage = 2600,
                    Year = "2022",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 51500,
                    CurrentListPrice = 51500,
                    MRSP = 54500,
                    Description = "A beautiful used SUV!"
                },
                new VehicleRecord
                {
                    VehicleVIN = "ccccccccccccccccc",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = new InteriorColorType { InteriorColorName = "Tan" },
                    ExteriorColor = new ExteriorColorType { ExteriorColorName = "Silver" },
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = new ModelType { ModelName = "Optima", Make = new BrandName { MakeName = "Kia" } },
                    Mileage = 2300,
                    Year = "2021",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 32000,
                    CurrentListPrice = 32000,
                    MRSP = 36400,
                    Description = "llorem Ipsum...!"
                },
                new VehicleRecord
                {
                    VehicleVIN = "ddddddddddddddddd",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = new InteriorColorType { InteriorColorName = "Gray" },
                    ExteriorColor = new ExteriorColorType { ExteriorColorName = "White" },
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = new ModelType { ModelName = "Wrangler", Make = new BrandName { MakeName = "Jeep" } },
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
                new VehicleRecord
                {
                    VehicleVIN = "eeeeeeeeeeeeeeeee",
                    Transmission = Models.Enums.TransmissionType.Manual,
                    InteriorColor = new InteriorColorType { InteriorColorName = "Black" },
                    ExteriorColor = new ExteriorColorType { ExteriorColorName = "Black" },
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = new ModelType { ModelName = "Sorrento", Make = new BrandName { MakeName = "Kia" } },
                    Mileage = 35000,
                    Year = "2020",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 23000,
                    CurrentListPrice = 23000,
                    MRSP = 41500,
                    Description = "Another kinda cool SUV!"
                },
                new VehicleRecord
                {
                    VehicleVIN = "fffffffffffffffff",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = new InteriorColorType { InteriorColorName = "Gray" },
                    ExteriorColor = new ExteriorColorType { ExteriorColorName = "Red" },
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = new ModelType { ModelName = "Mustang", Make = new BrandName { MakeName = "Ford" } },
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
                new VehicleRecord
                {
                    VehicleVIN = "ggggggggggggggggg",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = new InteriorColorType { InteriorColorName = "Gray" },
                    ExteriorColor = new ExteriorColorType { ExteriorColorName = "Red" },
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = new ModelType { ModelName = "Mustang", Make = new BrandName { MakeName = "Ford" } },
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
                new VehicleRecord
                {
                    VehicleVIN = "hhhhhhhhhhhhhhhhh",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = new InteriorColorType { InteriorColorName = "Gray" },
                    ExteriorColor = new ExteriorColorType { ExteriorColorName = "Red" },
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = new ModelType { ModelName = "Mustang", Make = new BrandName { MakeName = "Ford" } },
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

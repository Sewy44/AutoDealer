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
                    Brand = context.Brands.FirstOrDefault(x => x.BrandNameId == Guid.Parse("ecad7c2d-3450-4ecb-8b9c-dfb73dafb3e2")),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Mustang",
                    Brand = context.Brands.FirstOrDefault(x => x.BrandNameId == Guid.Parse("ecad7c2d-3450-4ecb-8b9c-dfb73dafb3e2")),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Sorrento",
                    Brand = context.Brands.FirstOrDefault(x => x.BrandNameId == Guid.Parse("8aba5f89-740b-484b-bf2f-a9df93f2a9cc")),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Optima",
                    Brand = context.Brands.FirstOrDefault(x => x.BrandNameId == Guid.Parse("8aba5f89-740b-484b-bf2f-a9df93f2a9cc")),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Grand Cherokee L",
                    Brand = context.Brands.FirstOrDefault(x => x.BrandNameId == Guid.Parse("ba7fa5ed-60b0-474e-b98d-67e91d100516")),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Wrangler",
                    Brand = context.Brands.FirstOrDefault(x => x.BrandNameId == Guid.Parse("ba7fa5ed-60b0-474e-b98d-67e91d100516")),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "ForeRunner",
                    Brand = context.Brands.FirstOrDefault(x => x.BrandNameId == Guid.Parse("d4975b8e-d604-4a88-9e2a-223ad33b8840")),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Tercel",
                    Brand = context.Brands.FirstOrDefault(x => x.BrandNameId == Guid.Parse("d4975b8e-d604-4a88-9e2a-223ad33b8840")),
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                });
            }

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
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorId == Guid.Parse("df2c0772-a378-44b4-8d39-1cc4f5116068")),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorId == Guid.Parse("73dd93c2-6981-43f5-9ce8-de95e64efb38")),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = context.Models.FirstOrDefault(m => m.ModelId == Guid.Parse("fb2f441c-2eee-4fdf-a839-b352f663fa80")),
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
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorId == Guid.Parse("1fe48760-37ea-4046-8024-5a8611478afa")),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorId == Guid.Parse("9f66c16d-9b58-4f03-aa23-b56172fbf527")),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.ModelId == Guid.Parse("40b69f23-4fc4-4df9-b371-5b087d7ed43b")),
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
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorId == Guid.Parse("1fe48760-37ea-4046-8024-5a8611478afa")),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorId == Guid.Parse("327587e4-1b69-4d63-a4d6-5b2fe451fef5")),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.ModelId == Guid.Parse("e59836eb-8cba-4450-a8f2-88547a50a6d5")),
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
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorId == Guid.Parse("a3f1106d-9269-48a8-8a55-86a332506efd")),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorId == Guid.Parse("73dd93c2-6981-43f5-9ce8-de95e64efb38")),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = context.Models.FirstOrDefault(m => m.ModelId == Guid.Parse("4f4b8b25-5222-4525-8d30-acfcc750dabe")),
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
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorId == Guid.Parse("df2c0772-a378-44b4-8d39-1cc4f5116068")),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorId == Guid.Parse("7d616aef-f248-4701-ba96-728bef39396f")),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.ModelId == Guid.Parse("d23580cc-8cca-4af1-9963-75f665010e5e")),
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
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorId == Guid.Parse("1fe48760-37ea-4046-8024-5a8611478afa")),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorId == Guid.Parse("fd1afccf-f4ff-4fc9-a303-ae343526dead")),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = context.Models.FirstOrDefault(m => m.ModelId == Guid.Parse("fdbee36e-c8c3-46e4-aba0-94014c2af7f2")),
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
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorId == Guid.Parse("a3f1106d-9269-48a8-8a55-86a332506efd")),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorId == Guid.Parse("73dd93c2-6981-43f5-9ce8-de95e64efb38")),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = context.Models.FirstOrDefault(m => m.ModelId == Guid.Parse("1b2341b3-e1f2-42c8-ae2a-5832535a19db")),
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
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorId == Guid.Parse("1fe48760-37ea-4046-8024-5a8611478afa")),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorId == Guid.Parse("9f66c16d-9b58-4f03-aa23-b56172fbf527")),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.ModelId == Guid.Parse("40b69f23-4fc4-4df9-b371-5b087d7ed43b")),
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
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorId == Guid.Parse("1fe48760-37ea-4046-8024-5a8611478afa")),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorId == Guid.Parse("9f66c16d-9b58-4f03-aa23-b56172fbf527")),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.ModelId == Guid.Parse("40b69f23-4fc4-4df9-b371-5b087d7ed43b")),
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
                    InteriorColor = context.InteriorColors.FirstOrDefault(c => c.InteriorColorId == Guid.Parse("1fe48760-37ea-4046-8024-5a8611478afa")),
                    ExteriorColor = context.ExteriorColors.FirstOrDefault(c => c.ExteriorColorId == Guid.Parse("9f66c16d-9b58-4f03-aa23-b56172fbf527")),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = context.Models.FirstOrDefault(m => m.ModelId == Guid.Parse("40b69f23-4fc4-4df9-b371-5b087d7ed43b")),
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

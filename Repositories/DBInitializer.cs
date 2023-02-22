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

            if (context.CustomerRecords.Any())
            {
                return;
            }

            var customers = new CustomerRecord[]
            {
                new CustomerRecord
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
                }
            };

            foreach (var customer in customers)
            {
                context.CustomerRecords.Add(customer);
            }

            context.SaveChanges();

            if (context.Brands.Any())
            {
                return;
            }

            var brands = new Brand[]
            {
                new Brand()
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
                }
            };

            foreach (var brand in brands)
            {
                context.Add(brand);
            }

            context.SaveChanges();

            if (context.ContactRequests.Any())
            {
                return;
            }

            var contactRequests = new ContactRequest[]
            {
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
                }
            };

            foreach (var contact in contactRequests)
            {
                context.Add(contact);
            }

            context.SaveChanges();

            if (context.ExteriorColors.Any())
            {
                return;
            }

            var exteriorColors = new ExteriorColor[]
            {
                new ExteriorColor()
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
                }
            };

            foreach (var color in exteriorColors)
            {
                context.Add(color);
            }

            context.SaveChanges();

            if (context.InteriorColors.Any())
            {
                return;
            }

            var interiorColors = new InteriorColor[]
            {
                new InteriorColor()
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
                }
             };

            foreach(var color in interiorColors)
            {
                context.Add(color);
            }

            context.SaveChanges();

            if (context.Models.Any())
            {
                return;
            }

            var models = new ModelType[]
            {
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Edge",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate,
                    BrandNameId = brands.Single(b => b.BrandName == "Ford").BrandNameId
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Mustang",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate,
                    BrandNameId = brands.Single(b => b.BrandName == "Ford").BrandNameId
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Sorrento",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate,
                    BrandNameId = brands.Single(b => b.BrandName == "Kia").BrandNameId
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Optima",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate,
                    BrandNameId = brands.Single(b => b.BrandName == "Kia").BrandNameId
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Grand Cherokee L",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate,
                    BrandNameId = brands.Single(b => b.BrandName == "Jeep").BrandNameId
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Wrangler",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate,
                    BrandNameId = brands.Single(b => b.BrandName == "Jeep").BrandNameId
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "ForeRunner",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate,
                    BrandNameId = brands.Single(b => b.BrandName == "Toyota").BrandNameId
                },
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Tercel",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate,
                    BrandNameId = brands.Single(b => b.BrandName == "Toyota").BrandNameId
                }
            };

            foreach (var model in models)
            {
                context.Add(model);
            }

            context.SaveChanges();

            if (context.Specials.Any())
            {
                return;
            }

            var specials = new Special[]
            {
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
                }
            };

            foreach (var special in specials)
            {
                context.Add(special);
            }

            context.SaveChanges();

            if (context.Vehicles.Any())
            {
                return;
            }

            var vehicles = new Vehicle[]
            {
            new Vehicle
                {
                    VehicleVIN = "1C4RJFBG5FC767030",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColorId = interiorColors.Single(c => c.InteriorColorName == "Tan").InteriorColorId,
                    ExteriorColorId = exteriorColors.Single(c => c.ExteriorColorName == "Black").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    ModelId = models.Single(m => m.Model == "Edge").ModelId,
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
                    InteriorColorId = interiorColors.Single(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = exteriorColors.Single(c => c.ExteriorColorName == "Red").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = models.Single(m => m.Model == "Mustang").ModelId,
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
                    InteriorColorId = interiorColors.Single(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = exteriorColors.Single(c => c.ExteriorColorName == "Blue").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = models.Single(m => m.Model == "Tercel").ModelId,
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
                    InteriorColorId = interiorColors.Single(c => c.InteriorColorName == "Black").InteriorColorId,
                    ExteriorColorId = exteriorColors.Single(c => c.ExteriorColorName == "Black").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    ModelId = models.Single(m => m.Model == "ForeRunner").ModelId,
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
                    InteriorColorId = interiorColors.Single(c => c.InteriorColorName == "Tan").InteriorColorId,
                    ExteriorColorId = exteriorColors.Single(c => c.ExteriorColorName == "Silver").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = models.Single(m => m.Model == "Optima").ModelId,
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
                    InteriorColorId = interiorColors.Single(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = exteriorColors.Single(c => c.ExteriorColorName == "White").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    ModelId = models.Single(m => m.Model == "Wrangler").ModelId,
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
                    InteriorColorId = interiorColors.Single(c => c.InteriorColorName == "Black").InteriorColorId,
                    ExteriorColorId = exteriorColors.Single(c => c.ExteriorColorName == "Black").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    ModelId = models.Single(m => m.Model == "Sorrento").ModelId,
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
                    InteriorColorId = interiorColors.Single(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = exteriorColors.Single(c => c.ExteriorColorName == "Red").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = models.Single(m => m.Model == "Mustang").ModelId,
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
                    InteriorColorId = interiorColors.Single(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = exteriorColors.Single(c => c.ExteriorColorName == "Red").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = models.Single(m => m.Model == "Mustang").ModelId,
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Kina cool car!",
                    IsFeatured = true,
                    IsSold = false
                },
                new Vehicle
                {
                    VehicleVIN = "hhhhhhhhhhhhhhhhh",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColorId = interiorColors.Single(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = exteriorColors.Single(c => c.ExteriorColorName == "Red").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = models.Single(m => m.Model == "Mustang").ModelId,
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1 / 21 / 2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Kina cool Car!",
                    IsFeatured = true,
                    IsSold = false
                }
            };

            foreach (var vehicle in vehicles)
            {
                context.Add(vehicle);
            }

            context.SaveChanges();
        }
    }
}

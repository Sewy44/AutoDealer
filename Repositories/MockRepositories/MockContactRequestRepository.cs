using AutoDealer.Models;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class MockContactRequestRepository : IContactRequestRepository
    {
        public IEnumerable<ContactRequest> GetAll() =>
            new List<ContactRequest>()
            {
                new ContactRequest()
                {
                    ContactRequestId = Guid.NewGuid(),
                    ContactEmail = "test@email.com",
                    DateContactRequested = DateTime.Now,
                },
                new ContactRequest()
                {
                    ContactRequestId = Guid.NewGuid(),
                    ContactEmail = "emailme@email.com",
                    DateContactRequested = DateTime.Now,
                },
                new ContactRequest()
                {
                    ContactRequestId = Guid.NewGuid(),
                    ContactFirstName = "Jim",
                    ContactPhone = "502-555-5555",
                    DateContactRequested = DateTime.Now,
                },
                new ContactRequest()
                {
                    ContactRequestId = Guid.NewGuid(),
                    ContactFirstName = "Tom",
                    ContactPhone = "502-555-4444",
                    DateContactRequested = DateTime.Now,
                }
            };


        public void InsertContactRequest(ContactRequest contactRequest)
        {
            throw new NotImplementedException();
        }
    }
}

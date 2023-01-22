using AutoDealer.Models;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class ContactRequestRepositoryQA : IContactRequestRepository
    {
        private List<ContactRequest> _requests = new List<ContactRequest>();
        private static DateTime _addedDate = new DateTime(2023, 1, 22);


        public ContactRequestRepositoryQA()
        {
            var seedList = SeedRepo();
            
            foreach(var request in seedList)
            {
                _requests.Add(request);
            }
        }
        public IEnumerable<ContactRequest> SeedRepo() =>
            new List<ContactRequest>()
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

        public IEnumerable<ContactRequest> GetAll()
        {
            return _requests;
        }
        public void InsertContactRequest(ContactRequest contactRequest)
        {
            _requests.Add(contactRequest);
        }
    }
}

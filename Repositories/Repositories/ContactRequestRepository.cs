using AutoDealer.Models;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{  
    public class ContactRequestRepository : IContactRequestRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public ContactRequestRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ContactRequest> GetAll()
        {
            return _dbContext.ContactRequests;
        }

        public void InsertContactRequest(ContactRequest contactRequest)
        {
            _dbContext.ContactRequests.Add(contactRequest);
        }
    }
}

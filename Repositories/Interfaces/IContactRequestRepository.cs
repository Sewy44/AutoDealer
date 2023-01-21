using AutoDealer.Models;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IContactRequestRepository
    {
        IEnumerable<ContactRequest> GetAll();
        void InsertContactRequest(ContactRequest contactRequest);
    }
}

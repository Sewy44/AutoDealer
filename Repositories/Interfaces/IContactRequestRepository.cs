using AutoDealer.Models;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IContactRequest
    {
        IEnumerable<ContactRequest> GetAll();
        void InsertContactRequest(ContactRequest contactRequest);
    }
}

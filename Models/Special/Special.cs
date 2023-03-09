using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.Special
{
    public class Special
    {   
        public Guid SpecialId { get; set; }
        public string SpecialName { get; set; }
        public string SpecialDescription { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ImageFileName { get; set; }
    }
}

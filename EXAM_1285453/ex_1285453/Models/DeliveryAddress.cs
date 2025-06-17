using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex_1285453.Models
{
    public class DeliveryAddress
    {
        public int DeliveryAddressId { get; set; }
        [Required, ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [Required, StringLength(60)]
        public string ContactPerson { get; set; } = default!;
        [Required, StringLength(30)]
        public string Phone { get; set; } = default!;
        [Required, StringLength(100)]
        public string Address { get; set; } = default!;
        public virtual Customer? Customer { get; set; }
    }
}

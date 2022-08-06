using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PaymentMethod:IEntity

    {
        [Key]
        public int paymentMethodId { get; set; }
        [StringLength(30)]
        public string paymentMethodName { get; set; }

        public ICollection<Rental> rentals { get; set; }

    }
}

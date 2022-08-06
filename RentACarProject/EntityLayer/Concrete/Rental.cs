using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Kiralama
    public class Rental:IEntity

    {
        [Key]
        public int rentalId { get; set; }
        public DateTime rentalDate { get; set; }
        [StringLength(100)]
        public string description { get; set; }
        public DateTime rentalReturnDate { get; set; }

        public int paymentMethodId { get; set; }
        public virtual PaymentMethod paymentMethod { get; set; }

        //customer ile car arasında oluşan rental tablosu çoka çok ilişki.
        // bu yüzden her iki tablonunda idsni bu tabloya getireceğiz.
        public int customerId { get; set; }
        public virtual Customer customer { get; set; } 

        public int carId { get; set; }
        public virtual Car car { get; set; }
    }
}

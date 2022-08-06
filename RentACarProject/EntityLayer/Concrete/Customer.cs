using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer:IEntity
    {
        [Key]
        public int customerId { get; set; }
        [StringLength(30)]
        public string userName { get; set; }
        [StringLength(30)]
        public string password { get; set; }
        [StringLength(30)]
        public string firstName { get; set; }
        [StringLength(30)]
        public string lastName { get; set; }
        [StringLength(50)]
        public string eMail { get; set; }
        public DateTime birthDate { get; set; }
        [StringLength(50)]
        public string adress { get; set; }

        //car-customer
        public ICollection<Rental> rentals { get; set; }


    }
}

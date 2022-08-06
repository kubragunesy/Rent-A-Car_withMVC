using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Car:IEntity
    {
        [Key]
        public int carId { get; set; }
        [StringLength(30)]
        public string carName { get; set; }
        public int carModelYear { get; set; }
        public float carDailyPrice { get; set; }
        [StringLength(100)]
        public string carDescription { get; set; }

        // Bu şekilde az tarafın Idsini (brand) çok tarafa göndermiş olduk. virtual ile de hangi tablodan 
        //geldiğini belirttik.
        public int brandId { get; set; }
        public virtual Brand brand { get; set; }

        public int colorId { get; set; }
        public virtual Color color { get; set; }

        //car-customer
        public ICollection<Rental> rentals { get; set; }
    }
}

using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // Marka
    //Marka ile araba arasında teke çok ilişki var.
    //Bir arabanın 1 markası olur, 1 markanın birden çok arabası olur. 
    //Az tarafın ıdsi (brand) çoka gider.
    //Icollection ile hangi tabloyla ilişkili olduğubu bildireceğiz.
    // Migration yapısını kullanmak istiyorsak, tablo arasındaki ilişkileri migrationa bildirmemiz gerekir.
    public class Brand:IEntity
    {
        [Key]
        public int brandId { get; set; }
        [StringLength(30)]
        public string brandName { get; set; }

        // Brand-car ilişkisini bu şekilde belirtmiş olduk.
        public ICollection<Car> cars { get; set; }

    }
}

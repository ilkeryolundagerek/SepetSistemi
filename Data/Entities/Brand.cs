using System.Collections.Generic;

namespace SepetSistemi.Data.Entities
{
    public class Brand : BaseModify
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}

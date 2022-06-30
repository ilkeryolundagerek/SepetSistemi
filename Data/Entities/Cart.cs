using System.Collections.Generic;

namespace SepetSistemi.Data.Entities
{
    public enum CartStatus { Completed, Continue, Canceled }

    public class Cart : Base
    {
        public virtual ICollection<CartItem> CartItems { get; set; }
        public string Status { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace SepetSistemi.Data.Entities
{
    public abstract class Base
    {
        [Key]
        public int Id { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}

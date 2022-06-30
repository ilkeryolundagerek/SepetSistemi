using System;

namespace SepetSistemi.Data.Entities
{
    public abstract class BaseModify : Base
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime ModifiedTime { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
    }
}

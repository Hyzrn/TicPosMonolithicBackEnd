using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public abstract class EntityBase: IRecoverableEntity
    {
        public EntityBase()
        {
            CreatedAt = DateTime.Now;
            IsDeleted = false; //TODO : Silinmiş kayıt Update edildiğinde silinmemiş hale geliyor
            CreatedBy = 0; 
        }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}

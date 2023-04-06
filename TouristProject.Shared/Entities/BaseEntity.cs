using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristProject.Shared.Entities
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Core.Entities
{
    public abstract class BaseEntity
    {
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
    }
}
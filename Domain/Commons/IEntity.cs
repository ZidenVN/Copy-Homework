using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commons
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

    }
}

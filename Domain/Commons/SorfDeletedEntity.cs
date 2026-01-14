using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commons
{
    public abstract class SorfDeletedEntity
    {
        public DateTimeOffset? DeletedAt { get; set; }
    }
}

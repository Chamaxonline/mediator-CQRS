using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Database
{
    public class EventEntity
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public string Payload { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

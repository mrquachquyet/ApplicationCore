using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}

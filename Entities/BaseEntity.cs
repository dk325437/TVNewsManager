using System;
using TVNewsManager.Collections;

namespace TVNewsManager.Entities
{
    [Serializable]
    public abstract class BaseEntity
    {
        public string Id { get; set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}

using System;
using TVNewsManager.Collections;

namespace TVNewsManager.Entities
{
    // Lớp cơ sở trừu tượng cho các thực thể trong hệ thống
    [Serializable]
    public abstract class BaseEntity
    {
        // Mỗi thực thể có một Id duy nhất (string)
        public string Id { get; set; }

        // Constructor bảo vệ: khi tạo mới đối tượng thì tự sinh Id (dùng Guid)
        // Guid.NewGuid().ToString() đảm bảo Id là duy nhất toàn cục
        protected BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}

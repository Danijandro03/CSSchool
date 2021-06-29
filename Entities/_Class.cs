using System;

namespace Coreschool.Entities
{
    public class _Class
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public _Class() => UniqueId = Guid.NewGuid().ToString();
    }
    
}
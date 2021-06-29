using System;

namespace Coreschool.Entities
{
    public class Asignature
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Asignature() => UniqueId = Guid.NewGuid().ToString();
    }
    
}
using System;

namespace Etapa1.Entities
{
    public class student
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public student() => UniqueId = Guid.NewGuid().ToString();
    }
}
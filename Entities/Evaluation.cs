using System;

namespace Coreschool.Entities
{
    public class Evaluation
    {
        public Student Student {get; set;}
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Asignature Asig {get; set;}
        public float Note { get; set;}
        public Evaluation() => UniqueId = Guid.NewGuid().ToString();
    }
    
}
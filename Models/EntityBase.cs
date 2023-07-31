﻿namespace PropertyStore.Models
{
    public class EntityBase
    {
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public bool Cancelled { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public partial class Person
    {
        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string givenName { get; set; }
        public string gender { get; set; }
        public string birthDate { get; set; }
        public string birthPlace { get; set; }
        public string deathDate { get; set; }
        public string deathPlace { get; set; }
        public string occupation { get; set; }
    
        public virtual List Lists { get; set; }
        public virtual Father Fathers { get; set; }
        public virtual Mother Mothers { get; set; }
    }
}

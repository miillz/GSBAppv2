//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE_MISSION3
{
    using System;
    using System.Collections.Generic;
    
    public partial class famille
    {
        public famille()
        {
            this.medicaments = new HashSet<medicament>();
        }
    
        public string id { get; set; }
        public string libelle { get; set; }
    
        public virtual ICollection<medicament> medicaments { get; set; }
    }
}

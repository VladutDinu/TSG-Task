//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TSG_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personal_Proiecte_TSG
    {
        public int ID_Personal { get; set; }
        public int ID_Proiect { get; set; }

        public override string ToString()
        {
            return "Personal_Proiecte: " + this.ID_Personal + " " + this.ID_Proiect;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kütüphane.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategoryBook
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public int CategoryID { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual categories categories { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProgramlamaProjesi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Programlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Programlar()
        {
            this.ProgramKategorileri = new HashSet<ProgramKategorileri>();
        }
    
        public int ProgramID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<int> OgretmenID { get; set; }
        public string ProgramAdi { get; set; }
        public Nullable<long> UstAciklama { get; set; }
        public Nullable<long> AltAciklama { get; set; }
        public string AnaResimYolu { get; set; }
        public string AltResimYolu { get; set; }
        public Nullable<int> OgrenciSayisi { get; set; }
        public Nullable<int> Ucret { get; set; }
        public string ProgramSuresi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramKategorileri> ProgramKategorileri { get; set; }
        public virtual ProgramKategorileri ProgramKategorileri1 { get; set; }
        public virtual Ogretmenler Ogretmenler { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cactus.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cactusi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cactusi()
        {
            this.Cactus_Vistavka = new HashSet<Cactus_Vistavka>();
        }
    
        public int Id_cactus { get; set; }
        public string Name_cactus { get; set; }
        public string Where_from { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Instructions { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> Id_vid { get; set; }
    
        public virtual Vid Vid { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cactus_Vistavka> Cactus_Vistavka { get; set; }
    }
}

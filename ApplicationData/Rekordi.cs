//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProfGames.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rekordi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rekordi()
        {
            this.Viktorina = new HashSet<Viktorina>();
        }
    
        public int id { get; set; }
        public string komanda_1 { get; set; }
        public string komanda_2 { get; set; }
        public Nullable<int> ohko_k_1 { get; set; }
        public Nullable<int> ohko_k_2 { get; set; }
        public string komanda_3 { get; set; }
        public string komanda_4 { get; set; }
        public Nullable<int> ohko_k_3 { get; set; }
        public Nullable<int> ohko_k_4 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viktorina> Viktorina { get; set; }
    }
}

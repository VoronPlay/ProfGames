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
    
    public partial class Voprosi_History_of_the_IT_sphere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voprosi_History_of_the_IT_sphere()
        {
            this.Viktorina = new HashSet<Viktorina>();
        }
    
        public int id { get; set; }
        public string Vopros_1 { get; set; }
        public string Vopros_2 { get; set; }
        public string Vopros_3 { get; set; }
        public string Vopros_4 { get; set; }
        public string Vopros_5 { get; set; }
        public string Vopros_6 { get; set; }
        public string Vopros_7 { get; set; }
        public string Vopros_8 { get; set; }
        public string Vopros_9 { get; set; }
        public string Vopros_10 { get; set; }
        public string Vopros_11 { get; set; }
        public string Vopros_12 { get; set; }
        public string Vopros_13 { get; set; }
        public string Vopros_14 { get; set; }
        public string Vopros_15 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viktorina> Viktorina { get; set; }
    }
}

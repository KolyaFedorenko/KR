//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRKR
{
    using System;
    using System.Collections.Generic;
    
    public partial class Camp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Camp()
        {
            this.Travel = new HashSet<Travel>();
        }
    
        public int Id { get; set; }
        public string Место { get; set; }
        public string Координаты { get; set; }
        public Nullable<System.DateTime> Время { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Travel> Travel { get; set; }
    }
}

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
    
    public partial class Travel
    {
        public int Id { get; set; }
        public Nullable<int> Id_Снаряжения { get; set; }
        public Nullable<int> Id_Питания { get; set; }
        public Nullable<int> Id_Маршрута { get; set; }
        public Nullable<int> Id_Остановки { get; set; }
    
        public virtual Camp Camp { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual Movement Movement { get; set; }
        public virtual Ration Ration { get; set; }
    }
}

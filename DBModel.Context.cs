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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PRKRFEntities : DbContext
    {
        public PRKRFEntities()
            : base("name=PRKRFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Camp> Camp { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Movement> Movement { get; set; }
        public virtual DbSet<Ration> Ration { get; set; }
        public virtual DbSet<Travel> Travel { get; set; }
    }
}

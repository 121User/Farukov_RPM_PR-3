//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAuthorization.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryBase : DbContext
    {
        public LibraryBase()
            : base("name=LibraryBase")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventTicket> EventTicket { get; set; }
        public virtual DbSet<Exhibition> Exhibition { get; set; }
        public virtual DbSet<ExhibitionTicket> ExhibitionTicket { get; set; }
        public virtual DbSet<Hall> Hall { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeEvent> TypeEvent { get; set; }
        public virtual DbSet<TypeOrder> TypeOrder { get; set; }
    }
}

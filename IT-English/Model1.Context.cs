﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IT_English
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class usersEntities : DbContext
    {
        public usersEntities()
            : base("name=usersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cours> Cours { get; set; }
        public virtual DbSet<Editing> Editing { get; set; }
        public virtual DbSet<Homework> Homework { get; set; }
        public virtual DbSet<Lessons> Lessons { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
    }
}

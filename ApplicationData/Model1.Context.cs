﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProfGamesEntities : DbContext
    {
        private static ProfGamesEntities _context;

        public ProfGamesEntities()
            : base("name=ProfGamesEntities")
        {
        }

        public static ProfGamesEntities GetContext()
        {
            if (_context == null)
                _context = new ProfGamesEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Rekordi> Rekordi { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Viktorina> Viktorina { get; set; }
        public virtual DbSet<Voprosi_History_of_the_IT_sphere> Voprosi_History_of_the_IT_sphere { get; set; }
        public virtual DbSet<Voprosi_IT> Voprosi_IT { get; set; }
        public virtual DbSet<Voprosi_People_in_Programming> Voprosi_People_in_Programming { get; set; }
        public virtual DbSet<Vopsori_Kot_Meshke> Vopsori_Kot_Meshke { get; set; }
    }
}

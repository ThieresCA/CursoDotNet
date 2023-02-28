using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class ApplicationContext : DbContext
    {
        //segundo passo é criar o DbSet
        //terceiro passo é criar um Mapping
        DbSet<UserEntity> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            //aqui o user entity vai ser configurado pelo UserMap.Configure
            //quarto passo é adicionar no OnModelCreating a configuração do entity
            modelBuilder.Entity<UserEntity> (new UserMap().Configure);
        }
    }
}
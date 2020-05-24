﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Template.Infraestrutura.Dominio.Models;

namespace Template.Infraestrutura.Dominio.Configs
{
    public class IdiomaConfiguration : IEntityTypeConfiguration<Idioma>
    {
        public void Configure(EntityTypeBuilder<Idioma> builder)
        {
            builder.ToTable("language");

            builder.Property(i => i.Id)
                .HasColumnName("language_id");

            builder.Property(i => i.Nome)
                .HasColumnName("name")
                .HasColumnType("char(20)")
                .IsRequired();

            builder.Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}
using Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.DataConfig
{
    internal class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(u => u.User).HasColumnName("USUARIO");
            builder.Property(u => u.NombreUsuario).HasColumnName("NOMBRE_USUARIO");
            builder.HasKey(u => u.User);
        }
    }
}

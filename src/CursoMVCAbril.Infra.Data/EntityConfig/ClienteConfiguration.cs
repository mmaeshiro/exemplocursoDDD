using System.Data.Entity.ModelConfiguration;
using CursoMVCAbril.Domain.Entities;

namespace CursoMVCAbril.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .HasMaxLength(150)
                .IsRequired();

            Property(c => c.Email)
                .IsRequired();

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11);

            Property(c => c.DataNascimento)
                .IsRequired();

            Ignore(c => c.ResultadoValidacao);

            // Mapeamento de nomes
            ToTable("Clientes");
        } 
    }
}
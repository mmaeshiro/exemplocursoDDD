using System.Data.Entity.ModelConfiguration;
using CursoMVCAbril.Domain.Entities;

namespace CursoMVCAbril.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(300);

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(8);

            Property(e => e.Bairro)
                .IsRequired();

            Property(e => e.Complemento)
                .HasMaxLength(300);

            // Config Nomes
            ToTable("Enderecos");

            // Relacionamentos
            HasRequired(e => e.Cliente)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(e => e.ClienteId);
        }
    }
}
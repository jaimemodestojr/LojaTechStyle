// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechStyle.Dados;

namespace TechStyle.Dados.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TechStyle.Dominio.Modelo.DetalheProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto")
                        .IsUnique();

                    b.ToTable("DetalhesProduto");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.ItemVendas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int>("IdVendas")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto");

                    b.HasIndex("IdVendas");

                    b.ToTable("ItemVendas");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeLocal")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeMinima")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto")
                        .IsUnique();

                    b.ToTable("Loja");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("IdSegmento")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdSegmento");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.ProdutoEmEstoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("QuantidadeLocal")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeMinima")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeTotal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto")
                        .IsUnique();

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.Segmento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Subcategoria")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Segmento");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.Vendas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDaVenda")
                        .HasColumnType("smalldatetime");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.DetalheProduto", b =>
                {
                    b.HasOne("TechStyle.Dominio.Modelo.Produto", "Produto")
                        .WithOne("DetalheProduto")
                        .HasForeignKey("TechStyle.Dominio.Modelo.DetalheProduto", "IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.ItemVendas", b =>
                {
                    b.HasOne("TechStyle.Dominio.Modelo.Produto", "Produto")
                        .WithMany("ItemVendas")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechStyle.Dominio.Modelo.Vendas", "Vendas")
                        .WithMany("ItemVendas")
                        .HasForeignKey("IdVendas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.Loja", b =>
                {
                    b.HasOne("TechStyle.Dominio.Modelo.Produto", "Produto")
                        .WithOne("Loja")
                        .HasForeignKey("TechStyle.Dominio.Modelo.Loja", "IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.Produto", b =>
                {
                    b.HasOne("TechStyle.Dominio.Modelo.Segmento", "Segmento")
                        .WithMany("Produtos")
                        .HasForeignKey("IdSegmento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Segmento");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.ProdutoEmEstoque", b =>
                {
                    b.HasOne("TechStyle.Dominio.Modelo.Produto", "Produto")
                        .WithOne("Estoque")
                        .HasForeignKey("TechStyle.Dominio.Modelo.ProdutoEmEstoque", "IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.Produto", b =>
                {
                    b.Navigation("DetalheProduto");

                    b.Navigation("Estoque");

                    b.Navigation("ItemVendas");

                    b.Navigation("Loja");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.Segmento", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("TechStyle.Dominio.Modelo.Vendas", b =>
                {
                    b.Navigation("ItemVendas");
                });
#pragma warning restore 612, 618
        }
    }
}

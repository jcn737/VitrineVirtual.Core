using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VitrineVirtual.Model;

namespace VitrineVirtual.Data
{
    public class VitrineVirtualDBContext : DbContext
    {

        public VitrineVirtualDBContext(DbContextOptions<VitrineVirtualDBContext> options)
        : base(options)
        { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Faturamento_Rev> FaturamentoRev { get; set; }
        public DbSet<Faturamento_Loja> FaturamentoLoja { get; set; }
        public DbSet<Faturamento_Adm> FaturamentoAdm { get; set; }
        public DbSet<Despesas_Lucros_Rev> FaturamentoLucrosRev { get; set; }
        public DbSet<Despesas_Lucros_Loja> DespesasLucrosLoja { get; set; }
        public DbSet<Despesas_Lucros_Adm> DespesasLucrosAdm { get; set; }
        public DbSet<Compras_Pag_Seguro> ComparaPagSeguro { get; set; }
        public DbSet<Catalogo_Produtos_Rev> CatalogoProdutoRev { get; set; }
        public DbSet<Catalogo_Produto_Loja> CatalogoProdutoLoja { get; set; }
        public DbSet<Carrinho_Compras> CarrinhoCompras { get; set; }
        public DbSet<Cadastro_Revendedores> CadastroRev { get; set; }
        public DbSet<Cadastro_Produto_Rev> CadastroProdutoRev { get; set; }
        public DbSet<Cadastro_Produto_Loja> CadastroProdutoLoja { get; set; }
        public DbSet<Cadastro_Logistas> CadastroLojista { get; set; }
        public DbSet<Cadastro_Empresas> CadastroEmpresa { get; set; }
        public DbSet<Cadastro_Administradores> CadastroAdm { get; set; }
        public DbSet<Menu_Itens> MenuItens { get; set; }
        public DbSet<FilePath> FilePath { get; set; }
    }
}

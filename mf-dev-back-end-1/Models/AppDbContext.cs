using Microsoft.EntityFrameworkCore;


namespace mf_dev_back_end_1.Models
{
    //cria clsse AppDbContext para gerenciar o contexto
    public class AppDbContext : DbContext //faz herança DbContext, classe ppDbContext passa a herdar todas as características e propriedades do DbContext
    {
        //no construtor AppDbContext, o DbContextOptions recebe, da classe AppDbContext, options e passa como base para a herança DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //associa tabela de banco de dados a entidade "Veiculos", que é do tipo DbSet
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}

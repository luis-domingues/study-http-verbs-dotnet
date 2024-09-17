using Microsoft.EntityFrameworkCore;
using WebApiCrud.Entities;

namespace WebApiCrud.Context;

public class AgendaContext : DbContext
{
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) {  }
    
    public DbSet<Contato> Contatos { get; set; }
}
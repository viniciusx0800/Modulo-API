using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.Net.Http.Headers;


namespace Context
{
    public class AgendaContext : DbContext
    {
       public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
       {

       }

       public DbSet<contato> Contatos( get set );
       
    }

    internal class set
    {
    }

    public class get
    {
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Data.Context
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext(DbContextOptions options) : base(options) { }
    }
}

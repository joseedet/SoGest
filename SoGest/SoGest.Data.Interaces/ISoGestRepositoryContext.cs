using Microsoft.EntityFrameworkCore;

using SoGest.Data.Model.Entities;
using SoGest.Data.Model.Interfaces;

namespace SoGest.Data.Interaces
{
    public interface ISoGestRepositoryContext:ISoGestDbContext
    {
        DbSet<Almacen> Almacenes { get; set; }
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Concepto> Conceptos { get; set; }
        DbSet<Departamento> Departamentos { get; set; }
        DbSet<IVA> IVAs { get; set; }
        DbSet<Medida> Medidas { get; set; }
        DbSet<Proveedor> Proveedores { get; set; }
        DbSet<TipoDocumento> TipoDocumentos { get; set; }
        DbSet<TEntity> Set<TEntity> () where TEntity : class;

    }
}

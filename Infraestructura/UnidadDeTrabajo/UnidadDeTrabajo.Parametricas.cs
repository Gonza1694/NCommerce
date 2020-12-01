using Dominio.Entidades;
using Dominio.Repositorio;
using Infraestructura.Repositorio;

namespace Infraestructura.UnidadDeTrabajo
{
    public partial class UnidadDeTrabajo
    {
        // ============================================================================================================ //

        private IRepositorio<Provincia> provinciaRepositorio;

        public IRepositorio<Provincia> ProvinciaRepositorio => provinciaRepositorio
                                                               ?? (provinciaRepositorio =
                                                                   new Repositorio<Provincia>(_context));

        // ============================================================================================================ //

        private IRepositorio<Departamento> departamentoRepositorio;

        public IRepositorio<Departamento> DepartamentoRepositorio => departamentoRepositorio
                                                                  ?? (departamentoRepositorio =
                                                                      new Repositorio<Departamento>(_context));

        // ============================================================================================================ //

        private IRepositorio<Localidad> localidadRepositorio;

        public IRepositorio<Localidad> LocalidadRepositorio => localidadRepositorio
                                                               ?? (localidadRepositorio =
                                                                   new Repositorio<Localidad>(_context));

        // ============================================================================================================ //

        private IRepositorio<CondicionIva> condicionIvaRepositorio;

        public IRepositorio<CondicionIva> CondicionIvaRepositorio => condicionIvaRepositorio
                                                                     ?? (condicionIvaRepositorio =
                                                                         new Repositorio<CondicionIva>(_context));

        // ============================================================================================================ //

        private IRepositorio<Marca> marcaRepositorio;

        public IRepositorio<Marca> MarcaRepositorio => marcaRepositorio
                                                       ?? (marcaRepositorio =
                                                           new Repositorio<Marca>(_context));

        // ============================================================================================================ //

        private IRepositorio<Rubro> rubroRepositorio;

        public IRepositorio<Rubro> RubroRepositorio => rubroRepositorio
                                                       ?? (rubroRepositorio =
                                                           new Repositorio<Rubro>(_context));

        // ============================================================================================================ //

        private IRepositorio<UnidadMedida> unidadMedidaRepositorio;

        public IRepositorio<UnidadMedida> UnidadMedidaRepositorio => unidadMedidaRepositorio
                                                                     ?? (unidadMedidaRepositorio =
                                                                         new Repositorio<UnidadMedida>(_context));

        // ============================================================================================================ //

        private IRepositorio<Iva> ivaRepositorio;

        public IRepositorio<Iva> IvaRepositorio => ivaRepositorio
                                                   ?? (ivaRepositorio =
                                                       new Repositorio<Iva>(_context));

        // ============================================================================================================ //

        private IRepositorio<Deposito> depositoRepositorio;

        public IRepositorio<Deposito> DepositoRepositorio => depositoRepositorio
                                                             ?? (depositoRepositorio =
                                                                 new Repositorio<Deposito>(_context));

        // ============================================================================================================ //
    }
}
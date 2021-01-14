using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.SBS.Models.DTO;

namespace Web.SBS.Providers.Interfaces
{
    public interface IUsuarioProvider
    {
        Task<int> GrabarUsuario(UsuarioModel model);
        Task<bool> EliminarUsuario(int usuarioId);
        Task<IEnumerable<BusquedaUsuarioDto>> BuscarUsuario(FiltroBusquedaUsuarioDto model);
    }
}

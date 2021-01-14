using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.SBS.Models;
using Web.SBS.Models.DTO;
using Web.SBS.Providers.Interfaces;
using Web.SBS.Utils.RestClient;

namespace Web.SBS.Providers.Implementations
{
    public class UsuarioProvider : IUsuarioProvider
    {
        private readonly IRestClient restClient;

        public UsuarioProvider(IRestClient restClient)
        {
            this.restClient = restClient;
        }

        public async Task<int> GrabarUsuario(UsuarioModel param)
        {
            return await restClient.PostAsync<int>("/api/Usuario/Grabar", param);
        }
        public async Task<bool> EliminarUsuario(int usuarioId)
        {
            return await restClient.GetAsync<bool>("/api/Usuario/Eliminar/" + usuarioId);
        }
        public async Task<IEnumerable<BusquedaUsuarioDto>> BuscarUsuario(FiltroBusquedaUsuarioDto param)
        {
            return await restClient.PostListAsync<BusquedaUsuarioDto>("/api/Usuario/Buscar", param);
        }
    }
}
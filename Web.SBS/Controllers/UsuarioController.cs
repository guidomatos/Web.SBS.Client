using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Web.SBS.Models.DTO;
using Web.SBS.Providers.Interfaces;

namespace Web.SBS.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<Controller> _logger;
        private readonly IUsuarioProvider _usuarioProvider;

        /// <summary>
        /// UsuarioController
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="usuarioService"></param>
        public UsuarioController
            (
            ILogger<Controller> logger,
            IUsuarioProvider usuarioProvider
            )
        {
            _logger = logger;
            _usuarioProvider = usuarioProvider;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GrabarUsuario
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpPost("Grabar")]
        public JsonResult GrabarUsuario([FromBody] UsuarioModel param)
        {
            var success = true;
            int result = 0;

            try
            {
                result = _usuarioProvider.GrabarUsuario(param).Result;
            }
            catch (Exception ex)
            {
                success = false;
                _logger.LogError(default(EventId), ex, ex.Message);
            }

            return Json(new
            {
                success,
                data = result
            });
        }

        /// <summary>
        /// EliminarUsuario
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpPost("Eliminar")]
        public JsonResult EliminarUsuario([FromBody] int usuarioId)
        {
            var success = true;
            bool result = false;

            try
            {
                result = _usuarioProvider.EliminarUsuario(usuarioId).Result;
            }
            catch (Exception ex)
            {
                success = false;
                _logger.LogError(default(EventId), ex, ex.Message);
            }

            return Json(new
            {
                success,
                data = result
            });
        }

        /// <summary>
        /// BuscarUsuario
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpPost("Buscar")]
        public JsonResult BuscarUsuario([FromBody] FiltroBusquedaUsuarioDto param)
        {
            var success = true;
            IEnumerable<BusquedaUsuarioDto> lista = null;

            try
            {
                lista = _usuarioProvider.BuscarUsuario(param).Result;
            }
            catch (Exception ex)
            {
                success = false;
                _logger.LogError(default(EventId), ex, ex.Message);
            }

            return Json(new
            {
                success,
                data = lista
            });
        }

    }
}
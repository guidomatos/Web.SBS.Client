using System.Collections.Generic;

namespace Web.SBS
{
    public class UsuarioModel
    {
        public int UsuarioId { get; set; }
        public int RolId { get; set; }
        public string CodigoUsuario { get; set; }
        public string ClaveSecreta { get; set; }
        public string Email { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Alias { get; set; }
        public int PrimeraVezLogin { get; set; }
        public int Activo { get; set; }
    }
}

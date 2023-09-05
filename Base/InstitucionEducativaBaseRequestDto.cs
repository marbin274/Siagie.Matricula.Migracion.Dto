using System.ComponentModel;

namespace Siagie.Matricula.Migracion.Dto.Base
{
    public class InstitucionEducativaBaseRequestDto
    {
        [DisplayName("El código modular")]
        public string CodigoModular { get; set; }

        [DisplayName("El anexo")]
        public string Anexo { get; set; }
    }
}
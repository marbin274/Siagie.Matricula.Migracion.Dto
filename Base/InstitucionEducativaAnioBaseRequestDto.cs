using System.ComponentModel;

namespace Siagie.Matricula.Migracion.Dto.Base
{
    public class InstitucionEducativaAnioBaseRequestDto : InstitucionEducativaBaseRequestDto
    {
        [DisplayName("El año académico")]
        public short? Anio { get; set; }
    }
}
using Siagie.Matricula.Migracion.Dto.Base;

namespace Siagie.Matricula.Migracion.Dto.Estudiante;

public class GetEstudiantesByIeRequest : InstitucionEducativaAnioBaseRequestDto
{
    public string GradoId { get; set; }
}
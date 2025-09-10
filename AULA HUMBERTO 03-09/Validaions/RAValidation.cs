using System.ComponentModel.DataAnnotations;

namespace AULA_HUMBERTO_03_09.Validaions
{
    public class RAValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;
            if (string.IsNullOrEmpty(value.ToString())) return false;

            string duasPrimeirasLetras = value.ToString().Substring(0, 2);

            if(duasPrimeirasLetras.ToUpper() != "RA") return false;

            string numeros = value.ToString().Substring(2, 6);

            int resultado;
            int.TryParse(numeros, out resultado);

            if (resultado == 0) return false;

            return true;
        }
    }
}

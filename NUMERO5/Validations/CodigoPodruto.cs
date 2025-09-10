using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Validations
{
    public class CodigoProdutoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var codigo = value as string;

            if (string.IsNullOrEmpty(codigo))
                return false;

            // Regex para AAA-1234
            var regex = new Regex(@"^[A-Z]{3}-\d{4}$");

            if (!regex.IsMatch(codigo))
                return false;

            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return "Código do produto inválido. Formato esperado: AAA-1234.";
        }
    }
}

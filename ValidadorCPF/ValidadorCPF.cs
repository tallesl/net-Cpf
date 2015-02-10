using System.Collections.Generic;
using System.Linq;

namespace ValidacaoCPF
{
    public static class ValidadorCPF
    {
        public static bool Valido(string numero)
        {
            if (
                (string.IsNullOrWhiteSpace(numero) || (numero.Length != 11 && numero.Length != 14)) ||
                (numero.Length == 12 && !ApenasDigitos(numero)) ||
                (numero.Length == 15 && !ApenasDigitosEMascara(numero))
            )
            {
                return false;
            }
            else
            {
                var verificadores = numero.Substring(9, 2);

                var digitos = numero.Substring(0, 9);

                var verificador1 = Mod11(digitos);
                if (verificador1 != verificadores[0])
                {
                    return false;
                }

                digitos += verificador1;

                var verificador2 = Mod11(digitos);
                return verificador2 == verificadores[1];
            }
        }

        private static bool ApenasDigitos(string numero)
        {
            return numero.Any(digito => digito < '0' || digito > '9');
        }

        private static bool ApenasDigitosEMascara(string numero)
        {
            for (var i = 0; i < numero.Length; ++i)
            {
                if (

                    // Verificando ponto
                    ((i == 3 || i == 7) && numero[i] != '.') ||

                    // Verificando traço
                    (i == 11 && numero[i] != '-') ||

                    // Verificando dígitos
                    (numero[i] < '0' || numero[i] > '9')
                )
                {
                    return false;
                }
            }
            return true;
        }

        private static char Mod11(string numero)
        {
            var soma = 0;
            var digitos = ObterDigitos(numero).ToArray();
            for (int i = digitos.Length - 1, multiplicador = 2; i >= 0; --i, ++multiplicador)
            {
                soma += digitos[i] * multiplicador;
            }

            var mod11 = soma % 11;
            if (mod11 < 2) return '0';
            else return (11 - mod11).ToString()[0];
        }

        private static IEnumerable<int> ObterDigitos(string numero)
        {
            foreach (var digito in numero)
            {
                yield return int.Parse(digito.ToString());
            }
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace ValidacaoCPF
{
    public static class ValidadorCPF
    {
        public static bool Valido(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero) || (numero.Length != 11 && numero.Length != 14))
            {
                return false;
            }
            else if (numero.Length == 14 && !MascaraCorreta(numero))
            {
                return false;
            }
            else
            {
                numero = ApenasDigitos(numero);
                if (numero.Length != 11)
                {
                    return false;
                }

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

        private static string ApenasDigitos(string numero)
        {
            return new string(numero.Where(digito => digito >= '0' && digito <= '9').ToArray());
        }

        private static bool MascaraCorreta(string numero)
        {
            return numero[3] == '.' && numero[7] == '.' && numero[11] == '-';
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
            return mod11 < 2 ? '0' : (11 - mod11).ToString()[0];
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

using System.Globalization;
using System.Text;

namespace SisRh.Domain.Core.Util
{
    public static class Functions
    {
        /// <summary>
        /// Remove a pontuação da string
        /// </summary>
        /// <param name="valor">String a ser manipulada</param>
        /// <returns>String sem pontuação</returns>
        public static string RemovePontuacao(string valor)
        {
            if (string.IsNullOrEmpty(valor))
                return valor;

            return valor.Replace(".", "").Replace("-", "").Replace("/", "").Replace("-", "");
        }

        /// <summary>
        /// Remove a pontuação da string
        /// </summary>
        /// <param name="valor">Objeto a ser manipulada</param>
        /// <returns>String sem pontuação</returns>
        public static string RemovePontuacao(object valor)
        {
            if (valor == null)
                return null;

            return valor.ToString().Replace(".", "").Replace("-", "").Replace("/", "").Replace("-", "");
        }

        /// <summary>
        /// Remove acentuação
        /// </summary>
        /// <param name="s">String para manipulação</param>
        /// <returns>String manipulada</returns>
        public static string RemoveDiacritics(string s)
        {
            string normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }
    }
}

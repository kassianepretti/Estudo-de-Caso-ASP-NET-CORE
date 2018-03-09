namespace SisRh.Domain.Core.Util
{
    public class MensagemValidation
    {
        public string Campo { get; set; }
        public string Mensagem { get; set; }

        public static MensagemValidation GetObjeto(string campo, string mensagem)
        {
            return new MensagemValidation()
            {
                Campo = campo != null ? campo : string.Empty,
                Mensagem = mensagem
            };
        }
    }
}

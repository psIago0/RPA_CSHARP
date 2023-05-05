using NUnit.Framework;
using PrimeiroProjeto.Page;

namespace PrimeiroProjeto.Test
{
    public class ValidaCpfTest : ValidaCpfPage
    {
        public void ValidaCpf()
        {
            string cpfGerado = GuardaCpf();
            FechaAnuncio1();
            AbreValidador();
            EscreveCpf(cpfGerado);
            ValidarCpf();
            // ConfereValidacao();
        }
    }
}

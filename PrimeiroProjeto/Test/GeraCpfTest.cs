using NUnit.Framework;
using PrimeiroProjeto.Page;

namespace PrimeiroProjeto.Test
{
    public class GeraCpfTest : ValidaCpfTest
    {
        public void GeraCpf()
        {
            AbreGerador();
            SelecionaUf();
            GerarCpf();
        }
    }
}

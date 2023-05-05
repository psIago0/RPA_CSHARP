using NUnit.Framework;

namespace PrimeiroProjeto.Test
{
    public class ProcessadorTest : GeraCpfTest
    {
        [Test]
        public void Processador()
        {
            GeraCpf();
            ValidaCpf();
        }

    }
}

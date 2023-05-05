using PrimeiroProjeto.Core;

namespace PrimeiroProjeto.Page
{
    public class GeraCpfPage : Begin
    {

        public void AbreGerador()
        {
            Click("//*[@id=\'wrapper-content\']/div[1]/div[1]/a/div[1]/img");
        }

        public void SelecionaUf()
        {
            SelectOption("//*[@id=\'cpf_estado\']/option", "SP");
        }

        public void GerarCpf()
        {
            Click("//*[@id=\'bt_gerar_cpf\']");
        }

    }
}

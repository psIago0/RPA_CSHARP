using PrimeiroProjeto.Core;
using System;
using System.IO;

namespace PrimeiroProjeto.Page
{
    public class GeraCpfPage : Begin
    {

        public void AbrirGerador()
        {
            Click("//*[@id=\'wrapper-content\']/div[1]/div[1]/a/div[1]/img");
        }

        public void SelecionarUf()
        {
            SelectOption("//*[@id=\'cpf_estado\']/option", "SP");
        }

        public void GerarCpf()
        {
            Click("//*[@id=\'bt_gerar_cpf\']");
        }

        public void InserirArquivoCpf()
        {
            StreamWriter arquivo = new(caminhoDataBase + "/cpf.txt", true);

            Find("//*[@id=\'texto_cpf\']/span");
            string cpfGerado = GetValue("//*[@id=\'texto_cpf\']");

            arquivo.WriteLine(cpfGerado);
            arquivo.Flush();
            arquivo.Close();

        }


    }
}

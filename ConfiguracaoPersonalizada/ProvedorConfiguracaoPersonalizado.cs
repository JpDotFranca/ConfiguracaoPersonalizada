using Microsoft.Extensions.Configuration;
using System;

namespace ConfiguracaoPersonalizada
{
    public class ProvedorConfiguracaoPersonalizado : ConfigurationProvider
    {
        private FonteConfiguracaoPersonalizada _fonteConfiguracao;

        public ProvedorConfiguracaoPersonalizado(FonteConfiguracaoPersonalizada fonteConfiguracao,
                                                 ISinalizadorAtualizacao sinalizadorAtualizacao)
        {
            _fonteConfiguracao = fonteConfiguracao;
            sinalizadorAtualizacao.Sinalizador += QuandoConfiguracoesAtualizarem; 
        }

        private void QuandoConfiguracoesAtualizarem(object fonte, EventArgs argumentos) => Load();

        public override void Load()
        { 
            Data = _fonteConfiguracao.Buscar();
        }
    }
}

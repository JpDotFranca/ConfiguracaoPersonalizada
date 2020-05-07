using Microsoft.Extensions.Configuration;
using System;

namespace ConfiguracaoPersonalizada
{
    public static class ConfiguracaoPersonalizadaExtensions
    {
        public static IConfigurationBuilder AdicionarConfiguracaoPersonalizada(this IConfigurationBuilder configuracao,
                                                                               Action<OpcoesConfiguracaoPersonalizada> configurador)
        {
            var opcoesConfiguracao = new OpcoesConfiguracaoPersonalizada();
            configurador(opcoesConfiguracao);
            configuracao.Add(new FonteConfiguracaoPersonalizada(opcoesConfiguracao, new SinalizadorAtualizacaoTemporal()));

            return configuracao;
        }
    }
}

using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace ConfiguracaoPersonalizada
{
    public class FonteConfiguracaoPersonalizada : IConfigurationSource
    {
        internal OpcoesConfiguracaoPersonalizada Opcoes { get; set; }
        private ISinalizadorAtualizacao _sinalizador { get; set; }

        public FonteConfiguracaoPersonalizada(OpcoesConfiguracaoPersonalizada opcoes, 
                                              ISinalizadorAtualizacao sinalizador)
        {
            Opcoes = opcoes;
            _sinalizador = sinalizador;
        }

        internal Dictionary<string, string> Buscar()
        {
            string miliSegundoAtual = (DateTime.Now.Millisecond).ToString();
            return new Dictionary<string, string> {
                { "Valor", miliSegundoAtual }
            };
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new ProvedorConfiguracaoPersonalizado(this, _sinalizador);
        }
    }
}

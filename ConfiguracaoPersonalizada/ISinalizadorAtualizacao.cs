using System;

namespace ConfiguracaoPersonalizada
{
    public interface ISinalizadorAtualizacao
    {
        delegate void SinalizazadorEventHandler(object fonte, EventArgs argumentos);
        event SinalizazadorEventHandler Sinalizador;
        void SinalizarAtualizacao();
    }
}

using System;
using System.Timers;
using static ConfiguracaoPersonalizada.ISinalizadorAtualizacao;

namespace ConfiguracaoPersonalizada
{
    public class SinalizadorAtualizacaoTemporal : ISinalizadorAtualizacao
    {
        private Timer _temporizador;
        public event SinalizazadorEventHandler Sinalizador;

        public SinalizadorAtualizacaoTemporal(int segundosIntervalo = 5)
        {
            ConfigurarTemporizador(segundosIntervalo);
        }

        private void ConfigurarTemporizador(int segundosIntervalo)
        {
            _temporizador = new Timer();
            _temporizador.AutoReset = true; 
            _temporizador.Interval = TimeSpan.FromSeconds(segundosIntervalo).TotalMilliseconds;
            _temporizador.Elapsed += (s, e) => { SinalizarAtualizacao(); };
            _temporizador.Start();
        }

        public void SinalizarAtualizacao()
        {
            Sinalizador(null, EventArgs.Empty);
        }
    }
}

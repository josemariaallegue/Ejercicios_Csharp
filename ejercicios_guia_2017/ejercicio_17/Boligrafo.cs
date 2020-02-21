using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_17
{
    class Boligrafo
    {
        #region campos

        const short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;

        #endregion

        #region constructores
        public Boligrafo(ConsoleColor color, short tinta)
        {
            this._color = color;
            this._tinta = tinta;
        }
        #endregion

        #region metodos

        /// <summary>
        /// getter del color
        /// </summary>
        /// <returns></returns>
        public ConsoleColor GetColor()
        {
            return this._color;
        }

        /// <summary>
        /// getter de tinta
        /// </summary>
        /// <returns></returns>
        public short GetTinta()
        {
            return this._tinta;
        }

        /// <summary>
        /// setea la tinta
        /// </summary>
        /// <param name="tinta">cantidad de tinta a setear</param>
        private void SetTinta(short tinta)
        {
            short tintaFinal = (short)(GetTinta() + tinta);

            if (tintaFinal > cantidadTintaMaxima)
            {
                this._tinta = 100;
            }
            else if (tintaFinal < 0)
            {
                this._tinta = 0;
            }
            else
            {
                this._tinta = tintaFinal;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns></returns>
        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno;
            short i;
            dibujo = "";

            if (GetTinta() - (short)gasto <= 0)
            {
                Console.WriteLine("No fue posible hacer la totalidad del dibujo");
                retorno = false;
            }
            else
            {

                for (i = 1; i <= gasto; i++)
                {
                    dibujo = dibujo + "*";
                }

                SetTinta((short)gasto);
                retorno = true;

            }

            return retorno;

        }

        /// <summary>
        /// recargo el nivel de tinta al maximo
        /// </summary>
        public void Recargar()
        {
            SetTinta(100);
        }

        #endregion
    }

}

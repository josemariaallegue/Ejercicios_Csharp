﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }

            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }

            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }

            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }

            set
            {
                this.numero = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }

            set
            {
                this.vueltasRestantes = value;
            }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        public string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno.AppendFormat("Escuderia: {0}\nNumero: {1}\nEn competencia: {2}\nVueltas restantes: {3}\nCantidad de combustible: {4}", this.Escuderia, this.Numero, this.VueltasRestantes, this.CantidadCombustible).ToString();
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            bool retorno = false;

            if (v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

    }
}

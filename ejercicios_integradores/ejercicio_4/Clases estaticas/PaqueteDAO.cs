using Dapper;
using ejercicio_4.Clases;
using ejercicio_4.Excepciones;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ejercicio_4.Clases_estaticas
{
    public static class PaqueteDAO
    {
        #region metodos y sobrecargas

        public static bool Insertar(Paquete p)
        {
            bool retorno = false;
            string alumno = "Jose Maria Allegue";

            try
            {
                using (IDbConnection coneccion = new SqlConnection(DataBaseHelper.ConnectionStringName("CorreoDB")))
                {
                    coneccion.Execute($"INSERT INTO PAQUETES (direccionEntrega, trackingID, alumno) VALUES ('{p.DireccionEntrega}', '{p.TrackingId}', '{alumno}');");
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new TrackingIdRepetidoException("Error al insertar datos a la tabla", e);
            }

            return retorno;
        }

        #endregion
    }
}

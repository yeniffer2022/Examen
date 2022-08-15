using Datos.Intefaces;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Datos.Repositorios
{
    public class AerolineaRepositorio : IAerolineaRepositorio
    {
        private string CadenaConexion;

        public AerolineaRepositorio (string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }

        public Task<bool> Actualizar(Aerolinea aerolinea)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Aerolinea aerolinea)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Aerolinea>> GetLista()
        {
            throw new NotImplementedException();
        }

        public async Task<Aerolinea> GetPorCodigo(string IdVuelo)
        {
            Aerolinea aero = new Aerolinea();
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = @" SELECT * FROM Aerolinea WHERE IdVuelo = @IdVuelo ;";
                aero = await conexion.QueryFirstAsync<Aerolinea>(sql, new { IdVuelo });
            }
            catch (Exception)
            {
            }
            return aero;
        }

        public async Task<bool> Nuevo(Aerolinea aerolinea)
        {
            bool result = false;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = @"INSERT INTO Aerolinea (IdVuelo, Origen, Destino, Avion, Cantidad, Piloto, Fecha) 
                                 VALUES (@IdVuelo, @Origen, @Destino, @Avion, @Cantidad, @Piloto, @Fecha);";

                result =Convert.ToBoolean(await conexion.ExecuteAsync(sql, aerolinea));
            }
            catch (Exception ex)
            {
    
            }
            return result;
        }
    }
}

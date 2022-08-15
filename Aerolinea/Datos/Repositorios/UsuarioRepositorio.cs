using Dapper;
using Datos.Intefaces;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio

    {
        private string CadenaConexion;

        public UsuarioRepositorio(string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }


        public Task<bool> Actualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetLista()
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> GetPorCodigo(string codigo)
        {
            Usuario user = new Usuario();
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = @" SELECT * FROM usuario WHERE Codigo = @Codigo ;";
                user = await conexion.QueryFirstAsync<Usuario>(sql, new {codigo});
            }
            catch (Exception)
            {
            }
            return user;
        }

        public async Task<bool> Nuevo(Usuario usuario)
        {
            bool result = false;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = @"INSERT INTO usuario (Codigo, Nombre, Clave, Rol, EstaActivo) 
                                 VALUES (@Codigo, @Nombre, @Clave, @Rol, @EstaActivo);";

                result =Convert.ToBoolean(await conexion.ExecuteAsync(sql, usuario));
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}

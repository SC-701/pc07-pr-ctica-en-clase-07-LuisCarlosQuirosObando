using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DA
{
    public class CategoriaDA : ICategoriaDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;


        public CategoriaDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        #region Operaciones
        public async Task<IEnumerable<Categoria>> Obtener()
        {
            string query = @"ObtenerCategorias";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Categoria>(query);
            return resultadoConsulta;
        }


        #endregion
    }
}

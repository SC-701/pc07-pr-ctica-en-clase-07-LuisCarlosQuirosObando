using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DA
{
    public class SubCategoriaDA : ISubCategoriaDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;


        public SubCategoriaDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        #region Operaciones

        public async Task<IEnumerable<SubCategoria>> Obtener(Guid IdCategoria)
        {
            string query = @"ObtenerSubCategorias";
            var resultadoConsulta = await _sqlConnection.QueryAsync<SubCategoria>(query,
                new { IdCategoria = IdCategoria });
            return resultadoConsulta;
        }
        #endregion

    }
}

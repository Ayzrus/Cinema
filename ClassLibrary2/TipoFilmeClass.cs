using ClassLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace TipoFilme
{
    public class TipoFilmeClass
    {
        #region Constantes

        public const string Table = "TipoFilme";

        #endregion Constantes

        #region Propriedades

        public int Id { get; set; }
        public string Descricao { get; set; }

        #endregion Propriedades

        #region Métodos Estáticos

        /// <summary>
        /// Método para obter todos os tipos de filme (Read)
        /// </summary>
        public static List<TipoFilmeClass> GetTipoFilmes()
        {
            var tipoFilmes = new List<TipoFilmeClass>();
            using (var connection = new Connection())
            {
                var query = $"SELECT * FROM {Table}";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tipoFilmes.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return tipoFilmes;
        }

        /// <summary>
        /// Método para inserir um novo tipo de filme (Create)
        /// </summary>
        /// <param name="tipoFilme"></param>
        public static void InserirTipoFilme(TipoFilmeClass tipoFilme)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Descricao) VALUES (@Descricao)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Descricao", tipoFilme.Descricao);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para atualizar um tipo de filme existente (Update)
        /// </summary>
        /// <param name="tipoFilme"></param>
        public static void AtualizarTipoFilme(TipoFilmeClass tipoFilme)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET Descricao = @Descricao WHERE Id = @Id";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Id", tipoFilme.Id);
                    command.Parameters.AddWithValue("@Descricao", tipoFilme.Descricao);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para deletar um tipo de filme (Delete)
        /// </summary>
        /// <param name="id"></param>
        public static void DeletarTipoFilme(int id)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE Id = @Id";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static TipoFilmeClass MapFromReader(MySqlDataReader reader)
        {
            var tipoFilme = new TipoFilmeClass
            {
                Id = reader.Cast<int>("Id"),
                Descricao = reader.Cast<string>("Descricao"),
            };
            return tipoFilme;
        }

        #endregion Métodos Estáticos
    }
}

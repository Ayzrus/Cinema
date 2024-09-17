using ClassLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Local
{
    public class LocalClass
    {
        #region Constantes

        public const string Table = "Local";

        #endregion Constantes

        #region Propriedades

        public int Id { get; set; }
        public string Descricao { get; set; }

        #endregion Propriedades

        #region Métodos Estáticos

        /// <summary>
        /// Método para obter todos os locais (Read)
        /// </summary>
        public static List<LocalClass> GetLocais()
        {
            var locais = new List<LocalClass>();
            using (var connection = new Connection())
            {
                var query = $"SELECT * FROM {Table}";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            locais.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return locais;
        }

        /// <summary>
        /// Método para inserir um novo local (Create)
        /// </summary>
        /// <param name="local"></param>
        public static void InserirLocal(LocalClass local)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Descricao) VALUES (@Descricao)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Descricao", local.Descricao);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para atualizar um local existente (Update)
        /// </summary>
        /// <param name="local"></param>
        public static void AtualizarLocal(LocalClass local)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET Descricao = @Descricao WHERE Id = @Id";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Id", local.Id);
                    command.Parameters.AddWithValue("@Descricao", local.Descricao);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para deletar um local (Delete)
        /// </summary>
        /// <param name="id"></param>
        public static void DeletarLocal(int id)
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

        private static LocalClass MapFromReader(MySqlDataReader reader)
        {
            var local = new LocalClass
            {
                Id = reader.Cast<int>("Id"),
                Descricao = reader.Cast<string>("Descricao"),
            };
            return local;
        }

        #endregion Métodos Estáticos
    }
}

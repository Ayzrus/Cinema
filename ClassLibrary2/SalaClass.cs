using ClassLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Sala
{
    public class SalaClass
    {
        #region Constantes

        public const string Table = "Sala";

        #endregion Constantes

        #region Propriedades

        public int Id_Sala { get; set; }
        public string Descricao { get; set; }
        public int Id_Cinema { get; set; }

        #endregion Propriedades

        #region Métodos Estáticos

        /// <summary>
        /// Método para obter todas as salas (Read)
        /// </summary>
        public static List<SalaClass> GetSalas()
        {
            var salas = new List<SalaClass>();
            using (var connection = new Connection())
            {
                var query = $"SELECT * FROM {Table}";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            salas.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return salas;
        }

        /// <summary>
        /// Método para inserir uma nova sala (Create)
        /// </summary>
        /// <param name="sala"></param>
        public static void InserirSala(SalaClass sala)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Descricao, Id_Cinema) VALUES (@Descricao, @Id_Cinema)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Descricao", sala.Descricao);
                    command.Parameters.AddWithValue("@Id_Cinema", sala.Id_Cinema);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para atualizar uma sala existente (Update)
        /// </summary>
        /// <param name="sala"></param>
        public static void AtualizarSala(SalaClass sala)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET Descricao = @Descricao, Id_Cinema = @Id_Cinema WHERE Id_Sala = @Id_Sala";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Id_Sala", sala.Id_Sala);
                    command.Parameters.AddWithValue("@Descricao", sala.Descricao);
                    command.Parameters.AddWithValue("@Id_Cinema", sala.Id_Cinema);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para deletar uma sala (Delete)
        /// </summary>
        /// <param name="id_Sala"></param>
        public static void DeletarSala(int id_Sala)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE Id_Sala = @Id_Sala";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Id_Sala", id_Sala);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static SalaClass MapFromReader(MySqlDataReader reader)
        {
            var sala = new SalaClass
            {
                Id_Sala = reader.Cast<int>("Id_Sala"),
                Descricao = reader.Cast<string>("Descricao"),
                Id_Cinema = reader.Cast<int>("Id_Cinema"),
            };
            return sala;
        }

        #endregion Métodos Estáticos
    }
}

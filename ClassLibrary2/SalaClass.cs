using Cinema;
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

        public int Codigo_sala { get; set; }
        public string Descricao { get; set; }
        public int Id_Cinema { get; set; }
        public string Cinema { get; set; }

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
                var query = $@"
                    SELECT S.*, C.Nome as Cinema
                    FROM {Table} S
                    LEFT JOIN {CinemaClass.Table} C ON C.Id_cinema = S.Id_Cinema
                ";
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
                var query = $"UPDATE {Table} SET Descricao = @Descricao, Id_Cinema = @Id_Cinema WHERE Codigo_sala = @Codigo_sala";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Codigo_sala", sala.Codigo_sala);
                    command.Parameters.AddWithValue("@Descricao", sala.Descricao);
                    command.Parameters.AddWithValue("@Id_Cinema", sala.Id_Cinema);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para deletar uma sala (Delete)
        /// </summary>
        /// <param name="codigo_sala"></param>
        public static void DeletarSala(int codigo_sala)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE Codigo_sala = @Codigo_sala";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Codigo_sala", codigo_sala);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static SalaClass MapFromReader(MySqlDataReader reader)
        {
            var sala = new SalaClass
            {
                Codigo_sala = reader.Cast<int>("Codigo_sala"),
                Descricao = reader.Cast<string>("Descricao"),
                Id_Cinema = reader.Cast<int>("Id_Cinema"),
                Cinema = reader.Cast<string>("Cinema"),
            };
            return sala;
        }

        #endregion Métodos Estáticos
    }
}

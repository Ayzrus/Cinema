﻿using ClassLibrary;
using Local;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Cinema
{
    public class CinemaClass
    {
        #region Constantes

        public const string Table = "Cinema";

        #endregion Constantes

        #region Propriedades

        public int Id_Cinema { get; set; }
        public string Nome { get; set; }
        public int Id_Local { get; set; }

        public string Local { get; set; }

        #endregion Propriedades

        #region Métodos Estáticos

        /// <summary>
        /// Método para obter todos os cinemas (Read)
        /// </summary>
        public static List<CinemaClass> GetCinemas()
        {
            var cinemas = new List<CinemaClass>();
            using (var connection = new Connection())
            {
                var query = $@"
                    SELECT C.*, L.Descricao AS Local FROM {Table} C
                    LEFT JOIN {LocalClass.Table} L ON L.Id = C.Id_local
                ";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cinemas.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return cinemas;
        }

        /// <summary>
        /// Método para inserir um novo cinema (Create)
        /// </summary>
        /// <param name="cinema"></param>
        public static void InserirCinema(CinemaClass cinema)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Nome, Id_Local) VALUES (@Nome, @Id_Local)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Nome", cinema.Nome);
                    command.Parameters.AddWithValue("@Id_Local", cinema.Id_Local);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para atualizar um cinema existente (Update)
        /// </summary>
        /// <param name="cinema"></param>
        public static bool AtualizarCinema(CinemaClass cinema)
        {
            try
            {
                using (var connection = new Connection())
                {
                    var query = $"UPDATE {Table} SET Nome = @Nome, Id_Local = @Id_Local WHERE Id_Cinema = @Id_Cinema";
                    using (var command = new MySqlCommand(query, connection.MySqlConnection))
                    {
                        command.Parameters.AddWithValue("@Id_Cinema", cinema.Id_Cinema);
                        command.Parameters.AddWithValue("@Nome", cinema.Nome);
                        command.Parameters.AddWithValue("@Id_Local", cinema.Id_Local);

                        // Verifica se alguma linha foi afetada
                        int rowsAffected = command.ExecuteNonQuery();

                        // Se pelo menos uma linha foi afetada, retorna true
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Aqui você pode fazer um log do erro se necessário
                Console.WriteLine($"Erro ao atualizar cinema: {ex.Message}");
                return false;
            }
        }


        /// <summary>
        /// Método para deletar um cinema (Delete)
        /// </summary>
        /// <param name="id_Cinema"></param>
        public static void DeletarCinema(int id_Cinema)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE Id_Cinema = @Id_Cinema";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Id_Cinema", id_Cinema);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Pega um cinema específico pelo Id (Read)
        /// </summary>
        /// <param name="id_Cinema"></param>
        /// <returns></returns>
        public static CinemaClass GetCinema(int id_Cinema)
        {
            CinemaClass cinema = null;
            using (var connection = new Connection())
            {
                var query = $@"
            SELECT C.*, L.Descricao AS Local 
            FROM {Table} C
            LEFT JOIN {LocalClass.Table} L ON L.Id = C.Id_local
            WHERE C.Id_cinema = @Id_Cinema
        ";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Id_Cinema", id_Cinema);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cinema = MapFromReader(reader);
                        }
                    }
                }
            }
            return cinema;
        }

        private static CinemaClass MapFromReader(MySqlDataReader reader)
        {
            var Aeroporto = new CinemaClass
            {
                Id_Cinema = reader.Cast<int>("Id_Cinema"),
                Nome = reader.Cast<string>("Nome"),
                Id_Local = reader.Cast<int>("Id_Local"),
                Local = reader.Cast<string>("Local")
            };
            return Aeroporto;
        }

        #endregion Métodos Estáticos
    }
}

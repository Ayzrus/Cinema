﻿using ClassLibrary;
using MySql.Data.MySqlClient;
using Sala;
using Sessoes;
using System;
using System.Collections.Generic;
using TipoFilme;

namespace Filmes
{
    public class FilmesClass
    {
        #region Constantes

        public const string Table = "Filme";

        #endregion Constantes

        #region Propriedades

        public int Codigo_filme { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
        public int Id_tipo { get; set; }
        public int TotalFilmesEmExibicao { get; set; }
        public string TipoFilme { get; set; }

        #endregion Propriedades

        #region Métodos Estáticos

        /// <summary>
        /// Método para obter todos os filmes (Read)
        /// </summary>
        public static List<FilmesClass> GetFilmes()
        {
            var filmes = new List<FilmesClass>();
            using (var connection = new Connection())
            {
                var query = $@"
                    SELECT F.*, TF.Descricao AS TipoFilme
                    FROM {Table} F
                    LEFT JOIN {TipoFilmeClass.Table} TF ON TF.Id = F.Id_tipo
                ";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            filmes.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return filmes;
        }

        /// <summary>
        /// Método para inserir um novo filme (Create)
        /// </summary>
        /// <param name="filme"></param>
        public static void InserirFilme(FilmesClass filme)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Nome, Ano, Descricao, Id_tipo) VALUES (@Nome, @Ano, @Descricao, @Id_tipo)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Nome", filme.Nome);
                    command.Parameters.AddWithValue("@Ano", filme.Ano);
                    command.Parameters.AddWithValue("@Descricao", filme.Descricao);
                    command.Parameters.AddWithValue("@Id_tipo", filme.Id_tipo);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para atualizar um filme existente (Update)
        /// </summary>
        /// <param name="filme"></param>
        public static void AtualizarFilme(FilmesClass filme)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET Nome = @Nome, Ano = @Ano, Descricao = @Descricao, Id_tipo = @Id_tipo WHERE Codigo_filme = @Codigo_filme";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Codigo_filme", filme.Codigo_filme);
                    command.Parameters.AddWithValue("@Nome", filme.Nome);
                    command.Parameters.AddWithValue("@Ano", filme.Ano);
                    command.Parameters.AddWithValue("@Descricao", filme.Descricao);
                    command.Parameters.AddWithValue("@Id_tipo", filme.Id_tipo);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para deletar um filme (Delete)
        /// </summary>
        /// <param name="codigo_filme"></param>
        public static void DeletarFilme(int codigo_filme)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE Codigo_filme = @Codigo_filme";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Codigo_filme", codigo_filme);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para obter a quantidade dos filmes em exibição (Read)
        /// </summary>
        public static int GetTotalFilmesEmExibicao()
        {
            using (var connection = new Connection())
            {
                var query = $@"
                SELECT COUNT(s.Codigo_filme) AS TotalFilmesEmExibicao
                FROM Sessao s
                JOIN {Table} f ON s.Codigo_filme = f.Codigo_filme
                JOIN {SalaClass.Table} sa ON s.Codigo_sala = sa.Codigo_sala
                WHERE s.Ativa = 1
            ";

                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    var totalFilmes = Convert.ToInt32(command.ExecuteScalar());
                    return totalFilmes;
                }
            }
        }

        private static FilmesClass MapFromReader(MySqlDataReader reader)
        {
            var filme = new FilmesClass
            {
                Codigo_filme = reader.Cast<int>("Codigo_filme"),
                Nome = reader.Cast<string>("Nome"),
                Ano = reader.Cast<int>("Ano"),
                Descricao = reader.Cast<string>("Descricao"),
                Id_tipo = reader.Cast<int>("Id_tipo"),
                TotalFilmesEmExibicao = reader.Cast<int>("Id_tipo"),
                TipoFilme = reader.Cast<string>("TipoFilme"),
            };
            return filme;
        }

        #endregion Métodos Estáticos
    }
}

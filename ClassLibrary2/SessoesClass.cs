using ClassLibrary;
using Filmes;
using MySql.Data.MySqlClient;
using Sala;
using System;
using System.Collections.Generic;

namespace Sessoes
{
    public class SessoesClass
    {
        #region Constantes

        public const string Table = "Sessao";

        #endregion Constantes

        #region Propriedades

        public int Id_Sessao { get; set; }
        public string Sala { get; set; }
        public string Filme { get; set; }
        public int Codigo_sala { get; set; }
        public int Codigo_filme { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public int Ativa { get; set; }
        public int Id_Cinema { get; set; }

        #endregion Propriedades

        #region Métodos Estáticos

        /// <summary>
        /// Método para obter todas as sessões (Read)
        /// </summary>
        public static List<SessoesClass> GetSessoes()
        {
            var sessoes = new List<SessoesClass>();
            using (var connection = new Connection())
            {
                var query = $@"
                    SELECT 
                    s.Id_Sessao,
                    s.Codigo_sala,
                    s.Codigo_filme,
                    s.Data,
                    s.Hora,
                    s.Ativa,
                    f.Nome AS Nome_Filme,
                    sa.Descricao AS Nome_Sala,
                    sa.Id_cinema
                FROM 
                    {Table} s
                JOIN 
                    {FilmesClass.Table} f ON s.Codigo_filme = f.Codigo_filme
                JOIN 
                    {SalaClass.Table} sa ON s.Codigo_sala = sa.Codigo_sala
                ";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sessoes.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return sessoes;
        }

        /// <summary>
        /// Método para inserir uma nova sessão (Create)
        /// </summary>
        /// <param name="sessao"></param>
        public static void InserirSessao(SessoesClass sessao)
        {
            using (var connection = new Connection())
            {
                var query = $"INSERT INTO {Table} (Codigo_sala, Codigo_filme, Data, Hora, Ativa) VALUES (@Codigo_sala, @Codigo_filme, @Data, @Hora, @Ativa)";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Codigo_sala", sessao.Codigo_sala);
                    command.Parameters.AddWithValue("@Codigo_filme", sessao.Codigo_filme);
                    command.Parameters.AddWithValue("@Data", sessao.Data);
                    command.Parameters.AddWithValue("@Hora", sessao.Hora);
                    command.Parameters.AddWithValue("@Ativa", sessao.Ativa);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para atualizar uma sessão existente (Update)
        /// </summary>
        /// <param name="sessao"></param>
        public static void AtualizarSessao(SessoesClass sessao)
        {
            using (var connection = new Connection())
            {
                var query = $"UPDATE {Table} SET Codigo_sala = @Codigo_sala, Codigo_filme = @Codigo_filme, Data = @Data, Hora = @Hora, Ativa = @Ativa WHERE Id_Sessao = @Id_Sessao";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Id_Sessao", sessao.Id_Sessao);
                    command.Parameters.AddWithValue("@Codigo_sala", sessao.Codigo_sala);
                    command.Parameters.AddWithValue("@Codigo_filme", sessao.Codigo_filme);
                    command.Parameters.AddWithValue("@Data", sessao.Data);
                    command.Parameters.AddWithValue("@Hora", sessao.Hora);
                    command.Parameters.AddWithValue("@Ativa", sessao.Ativa);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para deletar uma sessão (Delete)
        /// </summary>
        /// <param name="id_Sessao"></param>
        public static void DeletarSessao(int id_Sessao)
        {
            using (var connection = new Connection())
            {
                var query = $"DELETE FROM {Table} WHERE Id_Sessao = @Id_Sessao";
                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    command.Parameters.AddWithValue("@Id_Sessao", id_Sessao);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para obter todas as sessões ativas (Read)
        /// </summary>
        public static List<SessoesClass> GetSessoesAtivas()
        {
            var sessoes = new List<SessoesClass>();
            using (var connection = new Connection())
            {
                var query = $@"
                    SELECT 
                    s.Id_Sessao,
                    s.Codigo_sala,
                    s.Codigo_filme,
                    s.Data,
                    s.Hora,
                    s.Ativa,
                    f.Nome AS Nome_Filme,
                    sa.Descricao AS Nome_Sala,
                    sa.Id_cinema
                FROM 
                    {Table} s
                JOIN 
                    {FilmesClass.Table} f ON s.Codigo_filme = f.Codigo_filme
                JOIN 
                    {SalaClass.Table} sa ON s.Codigo_sala = sa.Codigo_sala
                WHERE 
                    s.Ativa = 1
                ";

                using (var command = new MySqlCommand(query, connection.MySqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sessoes.Add(MapFromReader(reader));
                        }
                    }
                }
            }
            return sessoes;
        }

        private static SessoesClass MapFromReader(MySqlDataReader reader)
        {
            return new SessoesClass
            {
                Id_Sessao = reader.Cast<int>("Id_Sessao"),
                Sala = reader.Cast<string>("Nome_Sala"),
                Filme = reader.Cast<string>("Nome_Filme"),
                Codigo_sala = reader.Cast<int>("Codigo_sala"),
                Codigo_filme = reader.Cast<int>("Codigo_filme"),
                Data = reader.Cast<DateTime>("Data"),
                Hora = reader.Cast<TimeSpan>("Hora"),
                Ativa = reader.Cast<int>("Ativa"),
                Id_Cinema = reader.Cast<int>("Id_cinema")
            };
        }

        #endregion Métodos Estáticos
    }
}

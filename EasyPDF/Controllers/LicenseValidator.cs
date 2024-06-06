using EasyPDF.Controllers;
using EasyPDF;
using Npgsql;
using PdfSharp.Pdf.Content.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPDF.Controllers
{
    internal class LicenseValidator
    {
        private readonly string _connectionString;

        public LicenseValidator(string connectionString)
        {
            _connectionString = connectionString;
        }

        public (bool isValid, int codigoError, DateTime datainicio, DateTime dataFimLicenca, string nome, string mensagem) ValidateAndUpdateHardwareId(string hardwareId)
        {
            DateTime dataFimLicenca = DateTime.MinValue;
            DateTime datainicio = DateTime.MinValue;
            string mensagem = null;
            string nome = null;

            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();

                    // Perform the update and select operation
                    using (var cmd = new NpgsqlCommand(@"
                    WITH updated_row AS (
                        UPDATE licenses
                        SET access_count = access_count + 1
                        WHERE hardware_id = @hardwareId
                        RETURNING nome, datainicio, datafimlicenca, access_count, mensagem
                    )
                    SELECT 
                        nome,
                        mensagem,
                        datainicio,
                        datafimlicenca
                    FROM updated_row;", conn))
                    {
                        cmd.Parameters.AddWithValue("hardwareId", hardwareId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal("datainicio")))
                                {
                                    datainicio = reader.GetDateTime(reader.GetOrdinal("datainicio"));
                                }

                                if (!reader.IsDBNull(reader.GetOrdinal("datafimlicenca")))
                                {
                                    dataFimLicenca = reader.GetDateTime(reader.GetOrdinal("datafimlicenca"));
                                }

                                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                                {
                                    nome = reader.GetString(reader.GetOrdinal("nome"));
                                }

                                if (!reader.IsDBNull(reader.GetOrdinal("mensagem")))
                                {
                                    mensagem = reader.GetString(reader.GetOrdinal("mensagem"));
                                }

                                if (dataFimLicenca < DateTime.Now)
                                {
                                    return (false, 2, datainicio, dataFimLicenca, nome, mensagem);
                                }
                                else
                                {
                                    return (true, 0, datainicio, dataFimLicenca, nome, mensagem);
                                }
                            }
                        }
                    }

                    string MensagemBemVindo = "Bem-vindo ao EasyPDF! Este sistema foi criado para melhorar sua experiência, oferecendo ferramentas e recursos para otimizar suas tarefas diárias.";

                    using (var insertCmd = new NpgsqlCommand(@"
                    INSERT INTO licenses (hardware_id, access_count, datainicio, datafimlicenca, nome, mensagem)
                    VALUES (@hardwareId, 1, @datainicio, @dataFimLicenca, @nome, @mensagem);", conn))
                    {
                        insertCmd.Parameters.AddWithValue("hardwareId", hardwareId);
                        insertCmd.Parameters.AddWithValue("datainicio", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("dataFimLicenca", DateTime.Now.AddDays(7).Date.AddHours(23).AddMinutes(59).AddSeconds(59)); // Licença válida por 7 dias
                        insertCmd.Parameters.AddWithValue("nome", Environment.MachineName);
                        insertCmd.Parameters.AddWithValue("mensagem", MensagemBemVindo);

                        insertCmd.ExecuteNonQuery();

                        return (true, 0, DateTime.Now, DateTime.Now.AddDays(7).Date.AddHours(23).AddMinutes(59).AddSeconds(59), Environment.MachineName, MensagemBemVindo);
                    }
                }
            }
            catch (Exception ex)
            {
                // Em caso de exceção, podemos também incluir a mensagem do erro para depuração
                return (false, 99, DateTime.MinValue, DateTime.MinValue, "", "Erro desconhecido: " + ex.Message);
            }
        }
        public void RegisterHardwareId(string hardwareId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO licenses (hardware_id) VALUES (@hardwareId)", conn))
                    {
                        cmd.Parameters.AddWithValue("hardwareId", hardwareId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error registering hardware ID: {ex.Message}");
            }
        }

        public void CreateLicensesTable()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS licenses (
                        id SERIAL PRIMARY KEY,
                        hardware_id VARCHAR(64) UNIQUE NOT NULL
                    );";
                    using (var cmd = new NpgsqlCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating licenses table: {ex.Message}");
            }
        }
    }
}

//INSERT INTO public.licenses (hardware_id, nome, datainicio, datafimlicenca)
//VALUES('ac92ab3b11cabcc665ce86559ab87a336fce33357dc9637c2c95a2767f7092ea', 'Tron', '2024-06-03 11:55:00.000', '2024-06-03 23:59:59.000');


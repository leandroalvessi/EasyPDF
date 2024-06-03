using EasyPDF.Controllers;
using EasyPDF;
using Npgsql;
using PdfSharp.Pdf.Content.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPDF.Controllers
{
    internal class LicenseValidator
    {
        private readonly string _connectionString;

        public LicenseValidator(string connectionString)
        {
            _connectionString = connectionString;
        }

        public (bool isValid, int codigoError, DateTime dataFimLicenca) ValidateHardwareId(string hardwareId)
        {
            DateTime dataFimLicenca = DateTime.MinValue; // Inicializar a variável

            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT nome, datainicio, datafimlicenca FROM licenses WHERE hardware_id = @hardwareId", conn))
                    {
                        cmd.Parameters.AddWithValue("hardwareId", hardwareId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var nome = reader.GetString(reader.GetOrdinal("nome"));
                                var dataInicio = reader.GetDateTime(reader.GetOrdinal("datainicio"));
                                dataFimLicenca = reader.GetDateTime(reader.GetOrdinal("datafimlicenca"));

                                if (dataFimLicenca < DateTime.Now)
                                {
                                    return (false, 2, dataFimLicenca);
                                }

                                return (true, 0, dataFimLicenca);
                            }
                            else
                            {
                                return (false, 1, dataFimLicenca);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, 99, dataFimLicenca);
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


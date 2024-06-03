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

        public (bool isValid, int codigoError, DateTime dataFimLicenca) ValidateAndUpdateHardwareId(string hardwareId)
        {
            DateTime dataFimLicenca = DateTime.MinValue;
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(@"
                WITH updated_row AS (
                    UPDATE licenses
                    SET access_count = access_count + 1
                    WHERE hardware_id = @hardwareId
                    RETURNING nome, datainicio, datafimlicenca, access_count
                )
                SELECT 
                    CASE 
                        WHEN EXISTS (SELECT 1 FROM updated_row) THEN
                            true
                        ELSE
                            false
                    END AS isValid,
                    CASE 
                        WHEN EXISTS (SELECT 1 FROM updated_row) THEN
                            0 -- No error
                        ELSE
                            1 -- Error code 1: Não encontrado
                    END AS codigoError,
                    CASE 
                        WHEN EXISTS (SELECT 1 FROM updated_row) THEN
                            (SELECT datafimlicenca FROM updated_row) -- Retorna datafimlicenca se encontrado
                        ELSE
                            NULL -- Retorna NULL se não encontrado
                    END AS dataFimLicenca;", conn))
                    {
                        cmd.Parameters.AddWithValue("hardwareId", hardwareId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool isValid = reader.GetBoolean(reader.GetOrdinal("isValid"));
                                int codigoError = reader.GetInt32(reader.GetOrdinal("codigoError"));
                                dataFimLicenca = reader.GetDateTime(reader.GetOrdinal("dataFimLicenca"));

                                return (isValid, codigoError, dataFimLicenca);
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
                // Em caso de exceção
                return (false, 99, dataFimLicenca); // Error code 99: Erro desconhecido
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



using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using wystawiacz_faktur.DTO;

namespace wystawiacz_faktur.repository
{
    public class KontrahentRepository
    {
        
        public IList<KontrahentListItemDTO> PobierzKontrahentList()
        {
            var result = new List<KontrahentListItemDTO>();
            var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                try
                {
                    using (var sql = new MySqlCommand("SELECT id_nabywca, nazwa, NIP, adres, numer_konta, typ FROM kontrahent", conn))
                    using (var reader = sql.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new KontrahentListItemDTO
                            {

                                id_nabywca = reader.GetInt32(0),
                                nazwa = reader.GetString(1),
                                NIP = reader.GetString(2),
                                adres = reader.GetString(3),
                                numer_konta = reader.GetString(4),
                                typ = reader.GetString(5)
                            });

                        }
                        reader.Close();
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            return result;
        }

        public IList<AddKontrahentListItemDTO> DodajKontrahentList(IList<AddKontrahentListItemDTO> lista)
        {
            
            var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var sql = new MySqlCommand("INSERT INTO kontrahent (nazwa, NIP, adres, numer_konta, kod_pocztowy, miasto, typ) VALUES(@nazwa, @NIP, @adres, @numer_konta, @kod_pocztowy, @miasto, @typ)", conn)) 
                {
                    sql.Parameters.AddWithValue("@nazwa", lista[0].nazwa);
                    sql.Parameters.AddWithValue("@NIP", lista[0].NIP);
                    sql.Parameters.AddWithValue("@adres", lista[0].adres);
                    sql.Parameters.AddWithValue("@numer_konta", lista[0].numer_konta);
                    sql.Parameters.AddWithValue("@kod_pocztowy", lista[0].kod_pocztowy);
                    sql.Parameters.AddWithValue("@miasto", lista[0].miasto);
                    sql.Parameters.AddWithValue("@typ", lista[0].typ);

                    sql.ExecuteNonQuery();
                }
            }
            return lista;
        }

        public IList<DropKontrahentListItemDTO> UsunKontrahentList(IList<DropKontrahentListItemDTO> lista)
        {
            var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var sql = new MySqlCommand("DELETE FROM kontrahent WHERE id_nabywca = @id_nabywca", conn))
                {
                    sql.Parameters.AddWithValue("@id_nabywca", lista[0].id_nabywca);

                    sql.ExecuteNonQuery();
                }
            }
            return lista;
        }

        public IList<UpdateKontrahentListItemDTO> DownloadForUpdateKontrahentList(int idNabywca)
        {
            var lista = new List<UpdateKontrahentListItemDTO>();
            var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                try
                {
                    using (var sql = new MySqlCommand("SELECT nazwa, NIP, adres, numer_konta, kod_pocztowy, miasto, typ FROM kontrahent WHERE id_nabywca = @id_nabywca", conn))
                    {
                        sql.Parameters.AddWithValue("@id_nabywca", idNabywca);

                       

                        using (var reader = sql.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new UpdateKontrahentListItemDTO
                                {
                                    nazwa = reader.GetString(0),
                                    NIP = reader.GetString(1),
                                    adres = reader.GetString(2),
                                    numer_konta = reader.GetString(3),
                                    kod_pocztowy = reader.GetString(4),
                                    miasto = reader.GetString(5),
                                    typ = reader.GetString(6)
                                });

                            }
                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return lista;
        }
        public IList<UpdateKontrahentListItemDTO> UpdateKontrahentList(IList<UpdateKontrahentListItemDTO> lista)
        {
            var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var sql = new MySqlCommand("UPDATE kontrahent SET nazwa = @nazwa WHERE id_nabywca = @id_nabywca", conn))
                {
                    sql.Parameters.AddWithValue("@id_nabywca", lista[0].id_nabywca);
                    sql.Parameters.AddWithValue("@nazwa", lista[0].nazwa);

                    sql.ExecuteNonQuery();
                }
            }
            return lista;
        }
        
    }
}
/*var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
using (var conn = new MySqlConnection(connStr))
{
    conn.Open();
    var sql = new MySqlCommand("SELECT nazwa, adres, numer_konta, typ FROM kontrahent");

    using (var reader = sql.ExecuteReader())
    {
        while (reader.Read())
        {
            string nazwa = reader.GetString(0);
            string adres = reader.GetString(1);
            string nr_konta = reader.GetString(2);
            string typ = reader.GetString(3);

        }
    }
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                String sql = "SELECT nazwa, adres, numer_konta, typ FROM kontrahent";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
*/
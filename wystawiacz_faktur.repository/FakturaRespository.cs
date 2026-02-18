using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using wystawiacz_faktur.DTO;

namespace wystawiacz_faktur.repository
{
    public class FakturaRespository
    {
        public IList<FakturaListItemDTO> PobierzFakturaList()
        {
            var result = new List<FakturaListItemDTO>();
            var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var sql = new MySqlCommand("SELECT id_faktura_poz, nazwa, cena_netto, wartosc_vat, ilosc FROM faktura_poz", conn))
                using (var reader = sql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new FakturaListItemDTO()
                        {
                            id_faktura_poz = reader.GetInt32(0),
                            nazwa = reader.GetString(1),
                            cena_netto = reader.GetDecimal(2).ToString(),
                            wartosc_vat = reader.GetDecimal(3).ToString(),
                            ilosc = reader.GetInt32(4)
                        });
                    }
                    reader.Close();
                }
            }
            return result;

        }
        public IList<AddProduktListItemDTO> DodajProduktList(IList<AddProduktListItemDTO> lista)
        {

            var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var sql = new MySqlCommand("INSERT INTO faktura_poz (nazwa, cena_brutto, cena_netto, VAT, Jedn_miary, wartosc_vat, ilosc) VALUES(@nazwa, @cena_brutto, @cena_netto, @VAT, @Jedn_miary, @wartosc_vat, @ilosc)", conn))
                {
                    sql.Parameters.AddWithValue("@nazwa", lista[0].nazwa);
                    sql.Parameters.AddWithValue("@cena_brutto", lista[0].cena_brutto);
                    sql.Parameters.AddWithValue("@cena_netto", lista[0].cena_netto);
                    sql.Parameters.AddWithValue("@VAT", lista[0].VAT);
                    sql.Parameters.AddWithValue("@Jedn_miary", lista[0].Jedn_miary);
                    sql.Parameters.AddWithValue("@wartosc_vat", lista[0].wartosc_vat);
                    sql.Parameters.AddWithValue("@ilosc", lista[0].ilosc);

                    sql.ExecuteNonQuery();
                }
            }
            return lista;
        }

        public IList<DropProduktListItemDTO> UsunProduktList(IList<DropProduktListItemDTO> lista)
        {
            var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var sql = new MySqlCommand("DELETE FROM faktura_poz WHERE id_faktura_poz = @id_faktura_poz", conn))
                {
                    sql.Parameters.AddWithValue("@id_nabywca", lista[0].id_faktura_poz);

                    sql.ExecuteNonQuery();
                }
            }
            return lista;
        }

        public IList<UpdateProduktListItemDTO> DownloadForUpdateProduktList(int idProd)
        {
            var lista = new List<UpdateProduktListItemDTO>();
            var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                try
                {
                    using (var sql = new MySqlCommand("SELECT nazwa, cena_brutto, cena_netto, VAT, Jedn_miary, wartosc_vat, ilosc FROM faktura_poz WHERE id_faktura_poz = @id_faktura_poz", conn))
                    {
                        sql.Parameters.AddWithValue("@id_faktura_poz", idProd);



                        using (var reader = sql.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new UpdateProduktListItemDTO
                                {
                                    nazwa = reader.GetString(0),
                                    cena_brutto = reader.GetDecimal(1),
                                    cena_netto = reader.GetDecimal(2),
                                    VAT = reader.GetDecimal(3),
                                    Jedn_miary = reader.GetString(4),
                                    wartosc_vat = reader.GetDecimal(5),
                                    ilosc = reader.GetInt32(6)
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
        public IList<UpdateProduktListItemDTO> UpdateProduktList(IList<UpdateProduktListItemDTO> lista)
        {
            var connStr = "server=localhost;database=mydb;user=root;password=DBServer12;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var sql = new MySqlCommand("UPDATE faktura_poz SET nazwa = @nazwa, cena_brutto = @cena_brutto, cena_netto = @cena_netto, VAT = @VAT, Jedn_miary = @Jedn_miary, wartosc_vat = @wartosc_vat, ilosc = @ilosc WHERE id_faktura_poz = @id_faktura_poz", conn))
                {
                    sql.Parameters.AddWithValue("@id_faktura_poz", lista[0].id_faktura_poz);
                    sql.Parameters.AddWithValue("@nazwa", lista[0].nazwa);
                    sql.Parameters.AddWithValue("@cena_brutto", lista[0].cena_brutto);
                    sql.Parameters.AddWithValue("@cena_netto", lista[0].cena_netto);
                    sql.Parameters.AddWithValue("@VAT", lista[0].VAT);
                    sql.Parameters.AddWithValue("@Jedn_miary", lista[0].Jedn_miary);
                    sql.Parameters.AddWithValue("@wartosc_vat", lista[0].wartosc_vat);
                    sql.Parameters.AddWithValue("@ilosc", lista[0].ilosc);

                    sql.ExecuteNonQuery();
                }
            }
            return lista;
        }
    }
}

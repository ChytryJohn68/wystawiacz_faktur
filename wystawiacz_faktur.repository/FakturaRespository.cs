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
                using (var sql = new MySqlCommand("SELECT id_faktura_poz, nazwa, cena_netto, wartosc_vat, ilosc FROM faktura_poz",conn))
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
    }
}

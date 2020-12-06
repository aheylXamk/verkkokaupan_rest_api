using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;



namespace ot9.Models {

    public class TuoteTieto {

        public int Id {get; set;}
        public string Vari {get; set;}
        public string Koko {get; set;}
        public decimal Hinta {get; set;}
        public int Saldo {get; set;}
    }

    public class Tuotehallinta {

        private string YhteysAsetukset {get;} = "server=localhost;user=root;password=;database=verkkokauppa;SslMode=none";

        public List<TuoteTieto> haeKaikki() {

            try {

                using (MySqlConnection yhteys = new MySqlConnection(this.YhteysAsetukset)) {

                    yhteys.Open();

                    string SqlLause = "SELECT * FROM tuotteet";

                    MySqlDataReader tulokset = new MySqlCommand(SqlLause, yhteys).ExecuteReader();

                    List<TuoteTieto> lista = new List<TuoteTieto>();

                    while (tulokset.Read()) {

                        int tulosId = tulokset.GetInt32("Id");
                        string tulosVari = tulokset.GetString("Vari");
                        string tulosKoko = tulokset.GetString("Koko");
                        decimal tulosHinta = tulokset.GetDecimal("Hinta");
                        int tulosSaldo = tulokset.GetInt32("Varastotilanne");

                        lista.Add(new TuoteTieto() {Id=tulosId, Vari=tulosVari, Koko=tulosKoko, Hinta=tulosHinta, Saldo=tulosSaldo});


                    }


                    return lista;
                    
                }

            } catch (Exception e) {

                throw new Exception("Tietojen hakemisessa tapahtui virhe", e);
            }
        }

        public List<TuoteTieto> haeOsa(string max) {

            try {

                using (MySqlConnection yhteys = new MySqlConnection(this.YhteysAsetukset)) {

                    yhteys.Open();

                    string SqlLause = "SELECT * FROM tuotteet LIMIT ?";

                    MySqlCommand kysely = new MySqlCommand(SqlLause, yhteys);

                    kysely.Parameters.Add("@max", MySqlDbType.Int32);

                    kysely.Parameters["@max"].Value = max;

                    kysely.Prepare();

                    MySqlDataReader tulokset = kysely.ExecuteReader();

                    List<TuoteTieto> lista = new List<TuoteTieto>();

                    while (tulokset.Read()) {

                        int tulosId = tulokset.GetInt32("Id");
                        string tulosVari = tulokset.GetString("Vari");
                        string tulosKoko = tulokset.GetString("Koko");
                        decimal tulosHinta = tulokset.GetDecimal("Hinta");
                        int tulosSaldo = tulokset.GetInt32("Varastotilanne");

                        lista.Add(new TuoteTieto() {Id=tulosId, Vari=tulosVari, Koko=tulosKoko, Hinta=tulosHinta, Saldo=tulosSaldo});


                    }


                    return lista;
                    
                }

            } catch (Exception e) {

                throw new Exception("Tietojen hakemisessa tapahtui virhe", e);
            }
        }

          public List<TuoteTieto> haeYksi(string id) {

            try {

                using (MySqlConnection yhteys = new MySqlConnection(this.YhteysAsetukset)) {

                    yhteys.Open();

                    string SqlLause = "SELECT * FROM tuotteet WHERE Id=?";

                    MySqlCommand kysely = new MySqlCommand(SqlLause, yhteys);

                    kysely.Parameters.Add("@id", MySqlDbType.Int32);

                    kysely.Parameters["@id"].Value = id;

                    kysely.Prepare();

                    MySqlDataReader tulokset = kysely.ExecuteReader();

                    List<TuoteTieto> lista = new List<TuoteTieto>();

                    while (tulokset.Read()) {

                        int tulosId = tulokset.GetInt32("Id");
                        string tulosVari = tulokset.GetString("Vari");
                        string tulosKoko = tulokset.GetString("Koko");
                        decimal tulosHinta = tulokset.GetDecimal("Hinta");
                        int tulosSaldo = tulokset.GetInt32("Varastotilanne");

                        lista.Add(new TuoteTieto() {Id=tulosId, Vari=tulosVari, Koko=tulosKoko, Hinta=tulosHinta, Saldo=tulosSaldo});


                    }


                    return lista;
                    
                }

            } catch (Exception e) {

                throw new Exception("Tietojen hakemisessa tapahtui virhe", e);
            }
        }


        public void LisaaUusi(TuoteTieto tuoteTieto) {

            try {

                using (MySqlConnection yhteys = new MySqlConnection(this.YhteysAsetukset)) {

                    yhteys.Open();

                    string SqlLause = "INSERT INTO tuotteet (Vari, Koko, Hinta, Varastotilanne) VALUES (?,?,?,?)";

                    MySqlCommand kysely = new MySqlCommand(SqlLause, yhteys);

                    kysely.Parameters.Add("@Vari", MySqlDbType.Text);
                    kysely.Parameters.Add("@Koko", MySqlDbType.Text);
                    kysely.Parameters.Add("@Hinta", MySqlDbType.Decimal);
                    kysely.Parameters.Add("@Saldo", MySqlDbType.Int16);

                    kysely.Parameters["@Vari"].Value = tuoteTieto.Vari;
                    kysely.Parameters["@Koko"].Value = tuoteTieto.Koko;
                    kysely.Parameters["@Hinta"].Value = tuoteTieto.Hinta;
                    kysely.Parameters["@Saldo"].Value = tuoteTieto.Saldo;

                    kysely.Prepare();

                    kysely.ExecuteNonQuery();
                    
                }

            } catch (Exception e) {

                throw new Exception("Tietojen hakemisessa tapahtui virhe", e);
            }
        }

        public void Poista(int id) {

            try {

                using (MySqlConnection yhteys = new MySqlConnection(this.YhteysAsetukset)) {

                    yhteys.Open();

                    string SqlLause = "DELETE FROM tuotteet WHERE id = ?";

                    MySqlCommand kysely = new MySqlCommand(SqlLause, yhteys);

                    kysely.Parameters.Add("@id", MySqlDbType.Int16);

                    kysely.Parameters["@id"].Value = id;

                    kysely.Prepare();

                    kysely.ExecuteNonQuery();
                    
                }

            } catch (Exception e) {

                throw new Exception("Tietojen hakemisessa tapahtui virhe", e);
            }
        }


    }

}
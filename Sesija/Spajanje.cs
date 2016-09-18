using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;


namespace Sesija
{
    public class Spajanje
    {
        SqlConnection conn;
        SqlConnectionStringBuilder connStringBuilder;
        void ConnectTo()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            //"Data Source=DESKTOP-QDOFTEF;Initial Catalog=EasyReport;Integrated Security=True
            connStringBuilder.DataSource = "DESKTOP-QDOFTEF";
            connStringBuilder.InitialCatalog = "EasyReport";
            connStringBuilder.IntegratedSecurity = true;
            conn = new SqlConnection(connStringBuilder.ToString());
        }
        public Spajanje()
        {
            ConnectTo();
        }
        public void Insert (Zaposlenici p)
        {
            try
            {
                string cmdText = "Insert into dbo.Zaposlenici values (@Ime, @Prezime, @kor_ime, @lozinka, @tip_zaposlenika)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@Ime", p.Ime);
                cmd.Parameters.AddWithValue("@Prezime", p.Prezime);
                cmd.Parameters.AddWithValue("@kor_ime", p.Kor_ime);
                cmd.Parameters.AddWithValue("@lozinka", p.Lozinka);
                cmd.Parameters.AddWithValue("@tip_zaposlenika", p.Tip_zaposlenika);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void insert1(projekti p1)
        {
            try
            {
                string cmdText = "Insert into dbo.projekti values (@naziv, @budzet)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@naziv", p1.Naziv);
                cmd.Parameters.AddWithValue("@budzet", p1.Budzet);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally{
                if(conn!= null)
                {
                    conn.Close();

                }
            }
        }
        public void insert2(zaposlenici_projekti p2)
        {
            try
            {
                string cmdText = "Insert into dbo.zaposlenici_projekti values (@id_zaposlenika, @id_projekta, 0)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@id_zaposlenika", p2.Id_zaposlenika);
                cmd.Parameters.AddWithValue("@id_projekta", p2.Id_projekta);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}

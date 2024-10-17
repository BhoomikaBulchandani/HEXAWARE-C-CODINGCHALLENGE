using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Library;
using Utility_Library;

namespace DAO_Library
{
    public class DonationDAO
    {
        private string connectionString;

        public DonationDAO(string connString)
        {
            connectionString = connString;
        }

        public void RecordCashDonation(CashDonation donation)
        {
            using (SqlConnection conn = DBConnUtil.GetConnection(connectionString))
            {
                string query = "INSERT INTO Donations (DonorName, Amount, DonationDate, Type) VALUES (@DonorName, @Amount, @DonationDate, @Type)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DonorName", donation.DonorName);
                cmd.Parameters.AddWithValue("@Amount", donation.Amount);
                cmd.Parameters.AddWithValue("@DonationDate", donation.DonationDate);
                cmd.Parameters.AddWithValue("@Type", "Cash");

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void RecordItemDonation(ItemDonation donation)
        {
            using (SqlConnection conn = DBConnUtil.GetConnection(connectionString))
            {
                string query = "INSERT INTO Donations (DonorName, Amount, DonationDate, Type) VALUES (@DonorName, @Amount, @DonationDate, @Type)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DonorName", donation.DonorName);
                cmd.Parameters.AddWithValue("@Amount", donation.Amount);
                cmd.Parameters.AddWithValue("@DonationDate", donation.DonationDate);
                cmd.Parameters.AddWithValue("@Type", "Item");

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}

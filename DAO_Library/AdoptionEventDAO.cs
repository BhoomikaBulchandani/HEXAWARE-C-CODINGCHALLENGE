using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility_Library;

namespace DAO_Library
{
    public class AdoptionEventDAO
    {
        private string connectionString;

        public AdoptionEventDAO(string connString)
        {
            connectionString = connString;
        }

        public void RegisterParticipant(string participantName, int eventId)
        {
            using (SqlConnection conn = DBConnUtil.GetConnection(connectionString))
            {
                string query = "INSERT INTO Participants (ParticipantName, EventId) VALUES (@ParticipantName, @EventId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ParticipantName", participantName);
                cmd.Parameters.AddWithValue("@EventId", eventId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void AddAdoptionEvent(string eventName, DateTime eventDate)
        {
            using (SqlConnection conn = DBConnUtil.GetConnection(connectionString))
            {
                string query = "INSERT INTO AdoptionEvents (EventName, EventDate) VALUES (@EventName, @EventDate)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventName", eventName);
                cmd.Parameters.AddWithValue("@EventDate", eventDate);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


        public List<string> GetParticipantsForEvent(int eventId)
        {
            List<string> participants = new List<string>();
            using (SqlConnection conn = DBConnUtil.GetConnection(connectionString))
            {
                string query = "SELECT ParticipantName FROM Participants WHERE EventId = @EventId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventId", eventId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    participants.Add(reader["ParticipantName"].ToString());
                }

                conn.Close();
            }
            return participants;
        }

        public List<string> GetUpcomingEvents()
        {
            List<string> events = new List<string>();
            using (SqlConnection conn = DBConnUtil.GetConnection(connectionString))
            {
                string query = "SELECT * FROM AdoptionEvents";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string eventDetail = $"Event ID: {reader["EventId"]}, Event Name: {reader["EventName"]}, Date: {reader["EventDate"]}";
                    events.Add(eventDetail);
                }

                conn.Close();
            }
            return events;
        }
    }
}

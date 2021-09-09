using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dorm_managment_system.Models
{
    public class Booking
    {
        String Book_ID { get; set; }
        String Std_ID { get; set; }
        String Room_ID { get; set; }
        String Start_Date { get; set; }
        String End_Date { get; set; }
        String Req_Block { get; set; }
        String Term_Reason { get; set; }

        public Booking(string book_ID, string std_ID, string room_ID, string start_Date, string end_Date, string req_Block, string term_Reason)
        {
            Book_ID = book_ID;
            Std_ID = std_ID;
            Room_ID = room_ID;
            Start_Date = start_Date;
            End_Date = end_Date;
            Req_Block = req_Block;
            Term_Reason = term_Reason;
        }

        public static void requestBooking(
            String Start_Date,
            String End_Date,
            String Req_Block
            )
        {
            Database db = new Database();
            db.setData($"" +
                $"INSERT INTO [dbo].[Booking] ( [Std_ID], [Room_ID], [Start_Date], [End_Date], [Req_Block], [Term_Reason]) " +
                $"VALUES ( N'{Instances.values.loggedInStudent.ID}'," +
                $"NULL," +
                $"N'{Start_Date}'," +
                $"N'{End_Date}'," +
                $"N'{Req_Block}', " +
                $"NULL)" +
                $"","Booking request submitted");
        }

        public static List<Booking> getAllBooking()
        {
            List<Booking> list = new List<Booking>();

            Database db = new Database();
            DataSet ds = db.getData("select * from Booking");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(
                    new Booking(
                    row["Book_ID"].ToString(),
                    row["Std_ID"].ToString(),
                    row["Room_ID"].ToString(),
                    row["Start_Date"].ToString(),
                    row["End_Date"].ToString(),
                    row["Req_Block"].ToString(),
                    row["Term_Reason"].ToString()
                        )
                    );
            }
            return list;
        }
    }
}

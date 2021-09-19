using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dorm_managment_system
{
    public class Warden
    {
        public String ID { get; set; }
        public String Pass { get; set; }
        public String Name { get; set; }
        public String Contact { get; set; }

        public Warden(string iD, string pass, string name, string contact)
        {
            ID = iD;
            Pass = pass;
            Name = name;
            Contact = contact;
        }


        public static List<Warden> getAllWardens()
        {
            Database db = new Database();

            DataSet ds = db.getData("select * from Warden");

            List<Warden> list = new List<Warden>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {

                list.Add(
                    new Warden(
                        row["Id"].ToString(),
                        row["Password"].ToString(),
                        row["Name"].ToString(),
                        row["Contact"].ToString()
                        ));
            }


            return list;
        }

        public void getRoomRequests() { }

        public void getRoomAvailability() { }

        public void updateRoomStatus() { }

    }
}

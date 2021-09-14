using System;
using System.Collections.Generic;
using System.Text;

namespace Dorm_managment_system
{
    class Booking2
    {
        private string bookingID;
        private string studentID;
        private string roomID;
        private string startdate;
        private string enddate;
        private string requested_block;
        private string reason;

        public string BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public string Startdate
        {
            get { return startdate; }
            set { startdate = value; }
        }
        public string Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }
        public string RequestedBlock
        {
            get { return requested_block; }
            set { requested_block = value; }
        }
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public Booking2(string astuedntID, string areason)
        {
            this.bookingID = " ";
            this.studentID = astuedntID;
            this.roomID = " ";
            this.startdate = " ";
            this.enddate = " ";
            this.requested_block = " ";
            this.reason = areason;
        }

        public void studentterminate()
        {

            Database db = new Database();
            db.getData("$UPDATE [dbo].[Booking] SET Term_Reason =[reason] WHERE Std_ID = [studentID];", "$Your request is a ");
        }
    }
}


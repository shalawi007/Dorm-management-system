using System;
using System.Collections.Generic;
using System.Text;

namespace Dorm_managment_system
{
    public class Instances
    {
        public Instances()
        {
        }
        public static Instances instance = null;
        public static Instances values
        {
            get
            {
                if (instance == null)
                {
                    instance = new Instances();
                }
                return instance;
            }
        }

        public Student loggedInStudent = null;
        public Warden loggedInWarden = null;
        public String defaultDateFormat = "yyyy-MM-dd";

    }
}

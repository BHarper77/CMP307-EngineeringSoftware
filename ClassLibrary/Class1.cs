using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UserIDClass
    {
        int userID = 0;

        //Getter and setter for passing UserID between forms
        public void setter(int ID)
        {
            ID = userID;
        }

        public int getter()
        {
            return userID;
        }
    }
}

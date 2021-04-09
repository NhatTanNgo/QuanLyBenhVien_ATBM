using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class DAO_Table
    {
        private static DAO_Table _instance = null;
        public static DAO_Table Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAO_Table();
                }
                return _instance;
            }
        }


    }
}

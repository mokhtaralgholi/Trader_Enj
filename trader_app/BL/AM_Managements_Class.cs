﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace trader_app.BL
{

    class AM_Managements_Class
    {
      
        public void p_AM_insert_Managements(int Management_ID,
                                     string A_N,
                                     string E_N,
                                     string Location 
                                    )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Management_ID", SqlDbType.Int);
            param[0].Value = Management_ID;

            param[1] = new SqlParameter("@A_N", SqlDbType.NVarChar, (20));
            param[1].Value = A_N;

            param[2] = new SqlParameter("@E_N", SqlDbType.NVarChar, (20));
            param[2].Value = E_N;


            param[3] = new SqlParameter("@Location", SqlDbType.NVarChar);
            param[3].Value = Location;


            param[4] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[4].Value = PL.main.Use_id;

            DAL.Executecommade("p_AM_insert_Managements", param);



        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SBMApp.MODELS
{
    public class GateWay
    {
        private string connectionString = @"Server=(local);Database=SBMDB;Integrated Security=true;";

        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }

        public SqlDataReader Reader { get; set; }
        public string Query { get; set; }

        public GateWay()
        {
            Connection = new SqlConnection(connectionString);
            Command = new SqlCommand();
            Command.Connection = Connection;

        }


    }
}
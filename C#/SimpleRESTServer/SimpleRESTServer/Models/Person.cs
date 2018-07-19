﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleRESTServer.Models
{
    public class Person
    {
        public long ID { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public Double PayRate { get; set; }
        public DateTime StartDate { get; set; }
        public  DateTime EndDate { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTest.Models
{
    /// <summary>
    /// One person representation
    /// </summary>
    public class people
    {
        /// <summary>
        /// user Id.
        /// </summary>
        public int id { set; get; } = 0;
        /// <summary>
        /// user first name.
        /// </summary>
        public string fName { set; get; } = "";
        /// <summary>
        /// user last name.
        /// </summary>
        public string lName { set; get; } = "";

    }
}
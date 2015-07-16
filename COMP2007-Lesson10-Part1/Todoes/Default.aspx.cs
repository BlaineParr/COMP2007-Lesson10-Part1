using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using COMP2007_Lesson10_Part1.Models;

namespace COMP2007_Lesson10_Part1.Todoes
{
    public partial class Default : System.Web.UI.Page
    {
		protected COMP2007_Lesson10_Part1.Models.TodoConnection _db = new COMP2007_Lesson10_Part1.Models.TodoConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Model binding method to get List of Todo entries
        // USAGE: <asp:ListView SelectMethod="GetData">
        public IQueryable<COMP2007_Lesson10_Part1.Models.Todo> GetData()
        {
            return _db.Todoes;
        }
    }
}


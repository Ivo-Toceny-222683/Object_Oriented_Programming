using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calculate_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("Result.aspx?1={0}&2={1}&OP={2}", operand1.Text, operand2.Text, OperDropDown.SelectedValue));
        }
    }
}
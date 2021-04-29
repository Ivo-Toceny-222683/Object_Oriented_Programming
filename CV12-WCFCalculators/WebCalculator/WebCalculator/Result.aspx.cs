using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalculator
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string operand1 = Request.QueryString["1"];
            string operand2 = Request.QueryString["2"];
            string oper = Request.QueryString["OP"];
            string operText = "";

            if(operand1 != null && operand2 != null && oper != null)
            {
                switch (oper)
                {
                    case "plus":
                        operText = "+";
                        break;
                    case "minus":
                        operText = "-";
                        break;
                    case "multiply":
                        operText = "*";
                        break;
                    case "divide":
                        operText = "/";
                        break;
                }

                CalculatorService.Service1Client conn = new CalculatorService.Service1Client();
                try
                {
                    Response.Write(String.Format("{0} {1} {2} = {3}", operand1, operText, operand2, conn.Spocti(Convert.ToDecimal(operand1), Convert.ToDecimal(operand2), oper)));
                }
                catch(Exception)
                {
                    Response.Write("Unable to calculate!");
                }
                
            }
        }
    }
}
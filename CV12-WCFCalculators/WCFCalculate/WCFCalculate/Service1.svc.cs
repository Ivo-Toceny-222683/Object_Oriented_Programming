using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFCalculate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public decimal Spocti(decimal operand1, decimal operand2, string operation)
        {
            decimal result = 0;

            switch (operation)
            {
                case "plus":
                    result = operand1 + operand2;
                    break;
                case "minus":
                    result = operand1 - operand2;
                    break;
                case "multiply":
                    result = operand1 * operand2;
                    break;
                case "divide":
                    try
                    {
                        result = operand1 / operand2;
                    }
                    catch(DivideByZeroException)
                    {
                        throw;
                    }
                    break;
            }

            return result;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}

using System;
using Microsoft.AspNetCore.Mvc;

namespace csharptask4.Controllers
{
     public class CalcController : Controller
    {
        [HttpGet]

        public ActionResult Compare()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Compare(string firstnumber , string secondnumber)
        {
            ViewBag.Result =square(firstnumber , secondnumber);
           
            return View();
        }
        private static string square(String firstnum, String secondnum)
        {
            int firstnumber;
            int secondnumber;
            bool isfirstnumbertrue = int.TryParse(firstnum, out firstnumber);
            bool issecondnumbertrue  = int.TryParse(secondnum, out secondnumber);
            string output = String.Empty;

            if (firstnum == "" || secondnum == "")
            {
                output = "kindly input values";
            }
            else if (isfirstnumbertrue && issecondnumbertrue)
            {
                if (firstnumber < 0 || secondnumber < 0)
                {
                    output = "Input only positive numbers";
                }
                else
                {
                    double firstnumbersqr = Math.Sqrt(firstnumber);
                    double secondnumbersqr = Math.Sqrt(secondnumber);

                    if (firstnumbersqr > secondnumbersqr)
                    {
                        output = "The number" + firstnumber + "with squareroot" + firstnumbersqr + " has a higher squareroot than the numbe r"+ secondnumber + " with " + secondnumbersqr;
                    }
                    else if(secondnumber > firstnumber)
                    {
                        output = "The number" + secondnumber + " with squareroot " + secondnumbersqr + " has a higher squareroot than the number " + firstnumber +" with " + firstnumbersqr;
                    }
                    else if (firstnumber == secondnumber)
                    {
                        output = "The number has the same value ,input another value";
                    }
                    else 
                    {
                        output ="input only a number";
                    }
                }
            }
            return output;
        }
    }
}

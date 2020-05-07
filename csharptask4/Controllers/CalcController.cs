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
            int numberoneinput;
            int numbertwoinput;
            bool isnumberoneinputtrue = int.TryParse(firstnum, out numberoneinput);
            bool isnumbertwoinputtrue  = int.TryParse(secondnum, out numbertwoinput);
            string result = String.Empty;

            if (firstnum == "" || secondnum == "")
            {
                result = "kindly input values";
            }
            else if (isnumberoneinputtrue && isnumbertwoinputtrue)
            {
                if (numberoneinput < 0 || numbertwoinput < 0)
                {
                    result = "Input only positive numbers";
                }
                else
                {
                    double numberoneinputsqr = Math.Sqrt(numberoneinput);
                    double numbertwoinputsqr = Math.Sqrt(numbertwoinput);

                    if (numberoneinputsqr > numbertwoinputsqr)
                    {
                        result = "The number" + numberoneinput + "with squareroot" + numberoneinputsqr + " has a higher squareroot than the number"+ numbertwoinput + " with " + numbertwoinputsqr;
                    }
                    else if(numbertwoinput > numberoneinput)
                    {
                        result = "The number" + numbertwoinput + " with squareroot " + numbertwoinputsqr + " has a higher squareroot than the number " + numberoneinput +" with " + numberoneinputsqr;
                    }
                    else if (numberoneinput == numbertwoinput)
                    {
                        result = "The number has the same value ,input another value";
                    }
                    else 
                    {
                        result ="input only a number";
                    }
                }
            }
            return result;
        }
    }
}

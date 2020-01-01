using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using BinaryConverterWeb.Models;

namespace BinaryConverterWeb.Controllers
{
    public class WithOutAsciiController : Controller
    {
        // GET: WithOutAscii

        [HttpGet]
        public ActionResult DecimalToBinary()
        {
            return View();
        } 
      
        [HttpPost]
        public ActionResult DecimalToBinary(StringNonAsciiInputModel model)
        {
            if (ModelState.IsValid)
            {
                string input = model.Text;
                int check = 0;

                if (int.TryParse(input, out check))
                {
                    var result = Convert.ToString(Convert.ToInt32(input), 2);


                    ViewBag.BinaryOutput = result;
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Decimal number !!! ";
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult OctalToBinary()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OctalToBinary(StringNonAsciiInputModel model)
        {
            if (ModelState.IsValid)
            {
                string input = model.Text;

                int check;
                int error = -1;

                if (int.TryParse(input, out check))
                {
                    char[] checkArray = input.ToCharArray();

                    foreach (var iteam in checkArray)
                    {
                        
                        if (iteam == 56 || iteam == 57)
                        {
                            error = 1;
                            break;
                        }
                        else
                        {
                            error = -1;
                        }
                    }
                    if (error == -1)
                    {
                        var result = Convert.ToString(Convert.ToInt32(input), 2);


                        ViewBag.BinaryOutput = result;
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "This is not a Octal number !!! ";
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Octal number !!! ";
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult HexadecimalToBinary()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HexadecimalToBinary(StringNonAsciiInputModel model)
        {
            if (ModelState.IsValid)
            {
                string input = model.Text;

                int error = -1;

                char[] checkArray = input.ToCharArray();

                foreach (var iteam in checkArray)
                {

                    if (iteam == 1 || iteam == 2 || iteam == 3 || iteam == 4 || iteam == 5 || iteam == 6 || iteam == 48 
                        || iteam == 49 || iteam == 50 || iteam == 51 || iteam == 52 || iteam == 53 || iteam == 54 ||
                        iteam == 55 || iteam == 56 || iteam == 57 || iteam == 65 || iteam == 66 || iteam == 67 || iteam == 68
                        || iteam == 69 || iteam == 70 || iteam == 97 || iteam == 98 || iteam == 99 || iteam == 100
                        || iteam == 101 || iteam == 102)
                    {
                        error = -1;
                     
                    }
                    else
                    {
                        error = 1;
                        break;
                    }
                }
                if (error == -1)
                {

                    var result = Convert.ToString(Convert.ToInt32(input, 16), 2);

                    ViewBag.BinaryOutput = result;
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Hexadecimal number !!! ";
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult BinaryToDecimal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BinaryToDecimal(StringInputModel model)
        {
            if (ModelState.IsValid)
            {
                string textInput = model.Text;

                char[] inputCheck = textInput.ToCharArray();

                int error = -1;

                foreach (var iteam in inputCheck)
                {
                    int bits = iteam;

                    if (bits == 48 || bits == 49)
                    {
                        error = -1;
                    }
                    else
                    {
                        error = 1;
                        break;
                    }

                }
                if (error == -1)
                {
                    var result = Convert.ToString(Convert.ToInt32(textInput,2), 10);

                    ViewBag.BinaryOutput = result;
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Binary number !!!";
                }

            }

            return View();
        }

        [HttpGet]
        public ActionResult BinaryToOctal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BinaryToOctal(StringInputModel model)
        {
            if (ModelState.IsValid)
            {
                string textInput = model.Text;

                char[] inputCheck = textInput.ToCharArray();

                int error = -1;

                foreach (var iteam in inputCheck)
                {
                    int bits = iteam;

                    if (bits == 48 || bits == 49)
                    {
                        error = -1;
                    }
                    else
                    {
                        error = 1;
                        break;
                    }

                }
                if (error == -1)
                {
                    var result = Convert.ToString(Convert.ToInt32(textInput, 2), 8);

                    ViewBag.BinaryOutput = result;
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Binary number !!!";
                }

            }

            return View();
        }

        [HttpGet]
        public ActionResult BinaryToHexadecimal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BinaryToHexadecimal(StringInputModel model)
        {
            if (ModelState.IsValid)
            {
                string textInput = model.Text;

                char[] inputCheck = textInput.ToCharArray();

                int error = -1;

                foreach (var iteam in inputCheck)
                {
                    int bits = iteam;

                    if (bits == 48 || bits == 49)
                    {
                        error = -1;
                    }
                    else
                    {
                        error = 1;
                        break;
                    }

                }
                if (error == -1)
                {
                    var result = Convert.ToString(Convert.ToInt32(textInput, 2), 16);

                    ViewBag.BinaryOutput = result;
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Binary number !!!";
                }

            }

            return View();
        }

        [HttpGet]
        public ActionResult OctalToHexadecimal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OctalToHexadecimal(StringNonAsciiInputModel model)
        {
            if (ModelState.IsValid)
            {
                string input = model.Text;

                int check;
                int error = -1;

                if (int.TryParse(input, out check))
                {
                    char[] checkArray = input.ToCharArray();

                    foreach (var iteam in checkArray)
                    {

                        if (iteam == 56 || iteam == 57)
                        {
                            error = 1;
                            break;
                        }
                        else
                        {
                            error = -1;
                        }
                    }
                    if (error == -1)
                    {
                        var result = Convert.ToString(Convert.ToInt32(input,8), 16);


                        ViewBag.BinaryOutput = result;
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "This is not a Octal number !!! ";
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Octal number !!! ";
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult HexadecimalToOctal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HexadecimalToOctal(StringNonAsciiInputModel model)
        {
            if (ModelState.IsValid)
            {
                string input = model.Text;

                int error = -1;

                char[] checkArray = input.ToCharArray();

                foreach (var iteam in checkArray)
                {

                    if (iteam == 1 || iteam == 2 || iteam == 3 || iteam == 4 || iteam == 5 || iteam == 6 || iteam == 48
                        || iteam == 49 || iteam == 50 || iteam == 51 || iteam == 52 || iteam == 53 || iteam == 54 ||
                        iteam == 55 || iteam == 56 || iteam == 57 || iteam == 65 || iteam == 66 || iteam == 67 || iteam == 68
                        || iteam == 69 || iteam == 70 || iteam == 97 || iteam == 98 || iteam == 99 || iteam == 100
                        || iteam == 101 || iteam == 102)
                    {
                        error = -1;

                    }
                    else
                    {
                        error = 1;
                        break;
                    }
                }
                if (error == -1)
                {

                    var result = Convert.ToString(Convert.ToInt32(input, 16), 8);

                    ViewBag.BinaryOutput = result;
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Hexadecimal number !!! ";
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult OctalToDecimal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OctalToDecimal(StringNonAsciiInputModel model)
        {
            if (ModelState.IsValid)
            {
                string input = model.Text;

                int check;
                int error = -1;

                if (int.TryParse(input, out check))
                {
                    char[] checkArray = input.ToCharArray();

                    foreach (var iteam in checkArray)
                    {

                        if (iteam == 56 || iteam == 57)
                        {
                            error = 1;
                            break;
                        }
                        else
                        {
                            error = -1;
                        }
                    }
                    if (error == -1)
                    {
                        var result = Convert.ToString(Convert.ToInt32(input, 8), 10);


                        ViewBag.BinaryOutput = result;
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "This is not a Octal number !!! ";
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Octal number !!! ";
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult HexadecimalToDecimal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HexadecimalToDecimal(StringNonAsciiInputModel model)
        {
            if (ModelState.IsValid)
            {
                string input = model.Text;

                int error = -1;

                char[] checkArray = input.ToCharArray();

                foreach (var iteam in checkArray)
                {

                    if (iteam == 1 || iteam == 2 || iteam == 3 || iteam == 4 || iteam == 5 || iteam == 6 || iteam == 48
                        || iteam == 49 || iteam == 50 || iteam == 51 || iteam == 52 || iteam == 53 || iteam == 54 ||
                        iteam == 55 || iteam == 56 || iteam == 57 || iteam == 65 || iteam == 66 || iteam == 67 || iteam == 68
                        || iteam == 69 || iteam == 70 || iteam == 97 || iteam == 98 || iteam == 99 || iteam == 100
                        || iteam == 101 || iteam == 102)
                    {
                        error = -1;

                    }
                    else
                    {
                        error = 1;
                        break;
                    }
                }
                if (error == -1)
                {

                    var result = Convert.ToString(Convert.ToInt32(input, 16), 10);

                    ViewBag.BinaryOutput = result;
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Hexadecimal number !!! ";
                }
            }

            return View();
        }
    }
}
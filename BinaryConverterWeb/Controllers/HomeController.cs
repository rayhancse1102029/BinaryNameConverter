using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using BinaryConverterWeb.Models;

namespace BinaryConverterWeb.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        } 
    
        [HttpPost]
        public ActionResult Index(StringInputModel model)
        {
            if (ModelState.IsValid)
            {
                string textInput = model.Text;

                byte[] textInputArray = Encoding.ASCII.GetBytes(textInput);


                string[] textInputArray2 = new String[1000];
                string[] textInputArrayBinary = new String[1000];

                for (var i = 0; i < textInputArray.Length; i++)
                {

                    textInputArray2[i] = textInputArray[i] + " ";
                }
                for (var i = 0; i < textInputArray.Length; i++)
                {
                    var s = Convert.ToString(textInputArray[i], 2);

                    textInputArrayBinary[i] = s + " ";
                }

                ViewBag.AsciiOutput = textInputArray2;
                ViewBag.BinaryOutput = textInputArrayBinary;

            }

            return View();
        }

        [HttpGet]
        public ActionResult StringToDecimal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StringToDecimal(StringInputModel model)
        {
            if (ModelState.IsValid)
            {
                string textInput = model.Text;

                byte[] textInputArray = Encoding.ASCII.GetBytes(textInput);


                string[] textInputArray2 = new String[1000];
                string[] textInputArrayBinary = new String[1000];

                for (var i = 0; i < textInputArray.Length; i++)
                {

                    textInputArray2[i] = textInputArray[i] + " ";
                }
                for (var i = 0; i < textInputArray.Length; i++)
                {
                    var s = Convert.ToString(textInputArray[i], 10);

                    textInputArrayBinary[i] = s + " ";
                }

                ViewBag.AsciiOutput = textInputArray2;
                ViewBag.BinaryOutput = textInputArrayBinary;

            }

            return View();
        }

        [HttpGet]
        public ActionResult StringToOctal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StringToOctal(StringInputModel model)
        {
            if (ModelState.IsValid)
            {
                string textInput = model.Text;

                byte[] textInputArray = Encoding.ASCII.GetBytes(textInput);


                string[] textInputArray2 = new String[1000];
                string[] textInputArrayBinary = new String[1000];

                for (var i = 0; i < textInputArray.Length; i++)
                {

                    textInputArray2[i] = textInputArray[i] + " ";
                }
                for (var i = 0; i < textInputArray.Length; i++)
                {
                    var s = Convert.ToString(textInputArray[i], 8);

                    textInputArrayBinary[i] = s + " ";
                }

                ViewBag.AsciiOutput = textInputArray2;
                ViewBag.BinaryOutput = textInputArrayBinary;

            }

            return View();
        }

        [HttpGet]
        public ActionResult StringToHexadecimal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StringToHexadecimal(StringInputModel model)
        {
            if (ModelState.IsValid)
            {
                string textInput = model.Text;

                byte[] textInputArray = Encoding.ASCII.GetBytes(textInput);


                string[] textInputArray2 = new String[1000];
                string[] textInputArrayBinary = new String[1000];

                for (var i = 0; i < textInputArray.Length; i++)
                {

                    textInputArray2[i] = textInputArray[i] + " ";
                }
                for (var i = 0; i < textInputArray.Length; i++)
                {
                    var s = Convert.ToString(textInputArray[i], 16);

                    textInputArrayBinary[i] = s + " ";
                }

                ViewBag.AsciiOutput = textInputArray2;
                ViewBag.BinaryOutput = textInputArrayBinary;

            }

            return View();
        }

        [HttpGet]
        public ActionResult DecimalToBinary()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DecimalToBinary(StringInputModel model)
        {
            if (ModelState.IsValid)
            {
                string textInput = model.Text;
                int value;
                if (Int32.TryParse(textInput, out  value))
                {
                    textInput = value.ToString();

                    byte[] textInputArray = Encoding.ASCII.GetBytes(textInput);


                    string[] textInputArray2 = new String[1000];
                    string[] textInputArrayBinary = new String[1000];

                    for (var i = 0; i < textInputArray.Length; i++)
                    {

                        textInputArray2[i] = textInputArray[i] + " ";
                    }
                    for (var i = 0; i < textInputArray.Length; i++)
                    {
                        var s = Convert.ToString(textInputArray[i], 2);

                        textInputArrayBinary[i] = s + " ";
                    }

                    ViewBag.AsciiOutput = textInputArray2;
                    ViewBag.BinaryOutput = textInputArrayBinary;
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Decimal number !!!";
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
        public ActionResult OctalToBinary(StringInputModel model)
        {
            if (ModelState.IsValid)
            {
                string textInput = model.Text;

                int value;
                int error = -1;

                if (Int32.TryParse(textInput, out value))
                {
                    char[] checkArray = textInput.ToCharArray();

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

                        textInput = value.ToString();

                        byte[] textInputArray = Encoding.ASCII.GetBytes(textInput);


                        string[] textInputArray2 = new String[1000];
                        string[] textInputArrayBinary = new String[1000];

                        for (var i = 0; i < textInputArray.Length; i++)
                        {

                            textInputArray2[i] = textInputArray[i] + " ";
                        }
                        for (var i = 0; i < textInputArray.Length; i++)
                        {
                            var s = Convert.ToString(textInputArray[i], 2);

                            textInputArrayBinary[i] = s + " ";
                        }

                        ViewBag.AsciiOutput = textInputArray2;
                        ViewBag.BinaryOutput = textInputArrayBinary;
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "This is not a Octal number !!! ";
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Octal number !!!";
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
        public ActionResult HexadecimalToBinary(StringInputModel model)
        {
            if (ModelState.IsValid)
            {
                string textInput = model.Text;

                int error = -1;

                    char[] checkArray = textInput.ToCharArray();

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

                        byte[] textInputArray = Encoding.ASCII.GetBytes(textInput);


                        string[] textInputArray2 = new String[1000];
                        string[] textInputArrayBinary = new String[1000];

                        for (var i = 0; i < textInputArray.Length; i++)
                        {

                            textInputArray2[i] = textInputArray[i] + " ";
                        }
                        for (var i = 0; i < textInputArray.Length; i++)
                        {
                            var s = Convert.ToString(textInputArray[i], 2);

                            textInputArrayBinary[i] = s + " ";
                        }

                        ViewBag.AsciiOutput = textInputArray2;
                        ViewBag.BinaryOutput = textInputArrayBinary;
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "This is not a Hexadecimal number !!! ";
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Hexadecimal number !!!";
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
                    byte[] textInputArray = Encoding.ASCII.GetBytes(textInput);


                    string[] textInputArray2 = new String[1000];
                    string[] textInputArrayBinary = new String[1000];

                    for (var i = 0; i < textInputArray.Length; i++)
                    {

                        textInputArray2[i] = textInputArray[i] + " ";
                    }
                    for (var i = 0; i < textInputArray.Length; i++)
                    {
                        var s = Convert.ToString(textInputArray[i], 10);

                        textInputArrayBinary[i] = s + " ";
                    }

                    ViewBag.AsciiOutput = textInputArray2;
                    ViewBag.BinaryOutput = textInputArrayBinary;
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
                    byte[] textInputArray = Encoding.ASCII.GetBytes(textInput);


                    string[] textInputArray2 = new String[1000];
                    string[] textInputArrayBinary = new String[1000];

                    for (var i = 0; i < textInputArray.Length; i++)
                    {

                        textInputArray2[i] = textInputArray[i] + " ";
                    }
                    for (var i = 0; i < textInputArray.Length; i++)
                    {
                        var s = Convert.ToString(textInputArray[i], 8);

                        textInputArrayBinary[i] = s + " ";
                    }

                    ViewBag.AsciiOutput = textInputArray2;
                    ViewBag.BinaryOutput = textInputArrayBinary;
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
                    byte[] textInputArray = Encoding.ASCII.GetBytes(textInput);


                    string[] textInputArray2 = new String[1000];
                    string[] textInputArrayBinary = new String[1000];

                    for (var i = 0; i < textInputArray.Length; i++)
                    {

                        textInputArray2[i] = textInputArray[i] + " ";
                    }
                    for (var i = 0; i < textInputArray.Length; i++)
                    {
                        var s = Convert.ToString(textInputArray[i], 16);

                        textInputArrayBinary[i] = s + " ";
                    }

                    ViewBag.AsciiOutput = textInputArray2;
                    ViewBag.BinaryOutput = textInputArrayBinary;
                }
                else
                {
                    ViewBag.ErrorMessage = "This is not a Binary number !!!";
                }

            }

            return View();
        }
    }
}
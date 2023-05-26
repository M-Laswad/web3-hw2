using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web3_hw2.Models;

namespace Web3_hw2.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

[HttpPost]
    public IActionResult Calculate(double no1, double no2, string op)
    {
        double result;

        switch (op)
        {
            case "+":
                result = no1 + no2;
                break;
            case "-":
                result = no1 - no2;
                break;
            case "*":
                result = no1 * no2;
                break;
            case "/":
                result = no2 == 0 ? 0 : no1 / no2;
                break;
            default:
                result = 0;
                break;
        }

        ViewBag.Result = result;

        return View("Index");
    }

}

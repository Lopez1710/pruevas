using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PruevasQR.Entidaes;
using PruevasQR.Models;
using PruevasQR.Negocio;
using System.Collections.Generic;
using System.Diagnostics;

using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;



namespace PruevasQR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            QR qr = new QR();
            Alumno pr = new Alumno();
            //-------------------------- crear qr con datos en un exel
            //string stream = "D:\\codigos\\ff.xlsx"; //aqui pones la url del exel
            //IWorkbook miexel = new XSSFWorkbook(stream);

            //ISheet hojaexel = miexel.GetSheetAt(0);
            //int cantidad = hojaexel.LastRowNum;

            //List<Alumno> lista = new List<Alumno>();

            //for (int i = 1; i <= cantidad; i++)
            //{

            //    IRow fila = hojaexel.GetRow(i);
            //    if (fila.GetCell(0) != null)
            //    {
            //        lista.Add(new Alumno
            //        {
            //            nombre = fila.GetCell(0).ToString(),
            //            cod = fila.GetCell(1).ToString(),
            //            correo = fila.GetCell(2).ToString(),
            //            pago = fila.GetCell(3).ToString()
            //        });
            //    }
            //    else
            //    {
            //        break;
            //    }


            //}
           
            //foreach (var list in lista)
            //{

            //    pr.nombre = list.nombre;
            //    pr.cod = list.cod;
            //    pr.correo = list.correo;
            //    pr.pago = list.pago;
            //    string jsone = JsonConvert.SerializeObject(pr).ToString();

            //    qr.GenerarQR(jsone.ToString(), list.nombre);


            //}

            //--------------------------------------------------------------------------------------------------------------------------

            //-----------crear qr individual----------------------





            pr.nombre = "h";
            pr.cod = "f";
            pr.correo = "g";
            pr.pago = "y";
            string json = JsonConvert.SerializeObject(pr).ToString();

            qr.GenerarQR(json.ToString(), pr.nombre);
            Console.WriteLine(json);




            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
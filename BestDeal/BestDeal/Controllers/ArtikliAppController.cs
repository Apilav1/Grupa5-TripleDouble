using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestDeal.Interfaces;
using BestDeal.Models;
using BestDeal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BestDeal.Controllers
{
    public class ArtikliAppController : Controller
    {
        private readonly ITipovi _tipoviApp;
        private readonly IArtikli _artikliApp;

        public ArtikliAppController(ITipovi tipovi, IArtikli artikli)
        {
            _tipoviApp = tipovi;
            _artikliApp = artikli;
        }

        /*public ViewResult List()
        {
            ViewBag.Name = "Testara";
            ArtikliViewModel vm = new ArtikliViewModel();
            vm.artikli = _artikliApp.artikliApp;
            vm.trenutniTip = "NekiTip";
            return View(vm);
        }*/
        public static void WriteErrorLog(string strErrorText)
        {
            try
            {
                //DECLARE THE FILENAME FROM THE ERROR LOG
                string strFileName = "errorLog.txt";
                /*DECLARE THE FOLDER WHERE THE LOGFILE HAS TO BE  STORED, IN THIS EXAMPLE WE CHOSE THE PATH OF THE CURRENT APPLICATION*/
                string strPath = "C:\\Users\\Mirza\\Documents\\GitHub\\Grupa5-TripleDouble";
                //WRITE THE ERROR TEXT AND THE CURRENT DATE-TIME TO THE ERROR FILE
                System.IO.File.AppendAllText(strPath + "\\" + strFileName, strErrorText + " - " + DateTime.Now.ToString() + "\r\n");
            }
            catch (Exception ex)
            {
                WriteErrorLog("Error in WriteErrorLog: " + ex.Message);
            }
        }
        public ViewResult List(string tip)
        {
            string _tip = tip;
            IEnumerable<Artikal> artikliA;
            string sadasnjiTip = string.Empty;
            WriteErrorLog(tip);
            if (string.IsNullOrEmpty(tip))
            {
                artikliA = _artikliApp.artikliApp.OrderBy(n => n.IdArtikla);
                sadasnjiTip = "Svi artikli";

            }
            else
            {
                artikliA = _artikliApp.artikliApp.Where(p => p.TipArtikla.Ime.Equals(_tip)).OrderBy(p => p.NazivArtikla);
                sadasnjiTip = tip;
            }
            return View(new ArtikliViewModel
            {
                artikli = artikliA,
                trenutniTip = sadasnjiTip
            });
        }
    }
}
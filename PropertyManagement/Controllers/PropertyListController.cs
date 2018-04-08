using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using PropertyManagement.Models;
using PropertyManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropertyManagement.Controllers
{
    public class PropertyListController : Controller
    {
        private Repository<tblprakrutiproperty> tblproperty;
        // GET: PropertyList

        public PropertyListController()
        {
            tblproperty = new Repository<tblprakrutiproperty>();
        }


        public ActionResult Index()
        {
           var list = tblproperty.Getall();
            return View(list);
        }
        
    }
}
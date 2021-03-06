﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTHeadBrewery.DAL;

namespace MTHeadBrewery.Controllers
{
    public class FileController : Controller
    {
        private  BreweryContext db = new BreweryContext();
        //  
        // GET: /File/  
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Files.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dvd_MvcCodeFirst.Models;

namespace Dvd_MvcCodeFirst.Controllers
{
    public class TestController : Controller
    {
        private BancoContexto db = new BancoContexto();
        // GET: Test
        public ActionResult Index()
        {
            return View(db.Alunos.ToList());
        }

        public ViewResult Details(int id)
        {
            Aluno aluno = db.Alunos.Find(id);
            return View(aluno);
        }
    }
}
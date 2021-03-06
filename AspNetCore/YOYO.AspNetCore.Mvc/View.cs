﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOYO.AspNetCore.Mvc.ResponseProcessor;
using YOYO.AspNetCore.Owin;

namespace YOYO.AspNetCore.Mvc
{
    public class View : IActionResult
    {
        public View(string path) { Path = path; }

        public string Path { set; get; }

        public string ControllerName { set; get; }

        public string ActionName { set; get; }

        public dynamic Model { set; get; }

        public DynamicDictionary ViewBag { set; get; }

        public Task ProcessAsync(IOwinContext context)
        {
            return new ViewResponseProcessor(context).ProcessAsync(this);
        }
    }
}

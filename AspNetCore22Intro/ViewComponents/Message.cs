using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore22Intro.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore22Intro.ViewComponents
{
    public class Message : ViewComponent
    {
        private readonly IMessageService _message;

        public Message(IMessageService message)
        {
            _message = message;
        }

        public IViewComponentResult Invoke()
        {
            var model = _message.GetMessage();
            return View("Default", model);
        }
    }
}

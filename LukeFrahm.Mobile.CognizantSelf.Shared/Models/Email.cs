using System;
using System.Collections.Generic;
using System.IO;

namespace LukeFrahm.Mobile.CognizantSelf.Shared.Models
{
    public class Email
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public IList<string> Attachments { get; set; }

        public Email()
        {
        }
    }
}

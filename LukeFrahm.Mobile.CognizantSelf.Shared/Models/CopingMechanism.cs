using System;
using System.Linq;
using System.Collections.Generic;

namespace LukeFrahm.Mobile.CognizantSelf.Shared.Models
{
    public class CopingMechanism : IStorableModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<string> UseCases { get; set; }
        public IDictionary<byte, string> Steps { get; set; }
        public string Notes { get; set; }

        public CopingMechanism()
        {
        }
    }
}

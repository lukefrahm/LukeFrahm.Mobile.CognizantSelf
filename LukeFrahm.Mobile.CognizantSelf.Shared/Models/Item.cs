using System;

namespace LukeFrahm.Mobile.CognizantSelf.Shared.Models
{
    public class Item : IStorableModel
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}
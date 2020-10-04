using System;
namespace LukeFrahm.Mobile.CognizantSelf.Shared.Models
{
    public class JournalEntry : IStorableModel
    {
        public DateTime DateEntered { get; set; }
        public string Summary { get; set; }
        public string Notes { get; set; }
        public CheckInRecord CheckIn { get; set; }

        public JournalEntry()
        {
        }
    }
}

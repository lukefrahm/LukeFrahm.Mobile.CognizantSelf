using System;
using System.Collections.Generic;

namespace LukeFrahm.Mobile.CognizantSelf.Shared.Models
{
    public class DailyLogRecord : IStorableModel
    {
        public DateTime DateEntered { get; set; }
        public List<CheckInRecord> CheckIns { get; set; }
        public List<JournalEntry> Journals { get; set; }
        
        public DailyLogRecord()
        {
        }
    }
}

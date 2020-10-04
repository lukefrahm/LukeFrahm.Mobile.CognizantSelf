using System;
namespace LukeFrahm.Mobile.CognizantSelf.Shared.Models
{
    public class CheckInRecord : IStorableModel
    {
        // Emotional Turmoil
        public byte Depression { get; set; }
        public byte Anxiety    { get; set; }
        public byte Suicidal   { get; set; }

        // Base Emotions
        public byte Happiness  { get; set; }
        public byte Anger      { get; set; }
        public byte Tranquil   { get; set; }
        public byte Trusting   { get; set; }
        public byte Surprise   { get; set; }
        public byte Prideful   { get; set; }
        public byte Hurt       { get; set; }

        // Extended Emotions
        public byte Disgust    { get; set; }
        public byte Afraid     { get; set; }
        public byte Distressed { get; set; }
        public byte Dread      { get; set; }
        public byte Tense      { get; set; }
        public byte Uneasy     { get; set; }
        public byte Worried    { get; set; }
        public byte Despair    { get; set; }
        
        public CheckInRecord()
        {
        }
    }
}

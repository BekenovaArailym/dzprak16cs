using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Xml;

namespace FManagerApp
{
    [DataContract(Name = "Settings")]
    public class Settings
    {
        [DataMember(Name = "FontSize")]
        public short FontSize { get; private set; }

        [DataMember(Name = "FontColor")]
        public Color FontColor { get; private set; }

        public Settings()
        {
            FontSize = 14; 
            FontColor = Color.Red; 
        }

        public Settings(short fontSize, Color fontColor)
        {
            FontSize = fontSize;
            FontColor = fontColor;
        }

        public void UpdateSettings(short newFontSize, Color newFontColor)
        {
            FontSize = newFontSize;
            FontColor = newFontColor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Enumerations;

namespace Common.UIElements
{
    /// <summary>
    ///an img tag acts like a link in HTML 
    /// </summary>
    public class ImageButton
    {
        public string ImageUrl { get; set; }
        public string Id { get; set; } // html element id attribute
        public string Value { get; set; }
        public string Tooltip { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public bool UseAsLink { get; set; } // act like a button
        public DataLoadType DataLoadType { get; set; } // loads a new page or opens modal box when imageButton object clicked

        public ImageButton(string tooltip)
        {
            this.Tooltip = tooltip;
            this.Id = "";
            this.UseAsLink = true;
        }
        public ImageButton()
        {
            this.Id = "";
            this.Tooltip = "";
            this.UseAsLink = true;
        }
    }
}

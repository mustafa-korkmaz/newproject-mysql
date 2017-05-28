namespace Common.UIElements
{
    /// <summary>
    ///an anchor tag acts like a link in HTML 
    /// </summary>
    public class LinkButton
    {
        private string _displayText;
        public string DisplayText
        {
            get
            {
                return this._displayText;
            }
            set
            {
                this._displayText = value;
            }
        }
        public string Id { get; set; } // html element id attribute
        private string _value;
        public string Value
        {
            get
            {
                if (this.UseDisplayTextAsValue)
                {
                    return this._displayText;
                }
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        public string Tooltip { get; set; }
        public bool UseDisplayTextAsValue { private get; set; } // if true DisplayText and Value properties are the same

        private string _controllerName;
        public string ControllerName
        {
            get
            {
                return _controllerName;
            }

            set
            {
                _controllerName = value;
            }
        }

        private string _actionName;
        public string ActionName
        {
            get
            {
                return _actionName;
            }

            set
            {
                _actionName = value;
            }
        }

        public LinkButton(string displayText)
        {
            this.DisplayText = displayText;
            this.UseDisplayTextAsValue = false; //do not show linktext property as value (use cell value as linkText)
            this.Tooltip = displayText;
            this.Id = "";
        }
        public LinkButton()
        {
            this.UseDisplayTextAsValue = false; //do not show linktext property as value (use cell value as linkText)
            this.Id = "";
            this.Tooltip = "";
        }

        public string GetHtml()
        {
            var dataAttributes = string.Format("data-action=\"{0}\" data-controller=\"{1}\" data-value=\"{2}\" data-text=\"{3}\"", _actionName, _controllerName, _value, _displayText);
            return string.Format("<a href=\"{0}\" class=\"{1}\" {3}>{2}</a>", "javascript:", "link-button", _displayText, dataAttributes);
            //    var onclickText = string.Format("new LinkButton('{0}', '{1}', '{2}', '{3}',this).doAction()", DataLoadType.ToString(), _controllerName, _actionName, _value);
            //    return string.Format("<a href=\"{0}\" onclick=\"{1}\">{2}</a>", "javascript:", onclickText, _displayText);
        }
    }
}
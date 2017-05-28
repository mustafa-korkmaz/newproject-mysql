using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common.UIElements
{
    /// <summary>
    /// sayfaların ustundeki navigasyon section örnek: anasayfa->ön ödeme-> giriş -> Ön Ödeme(geri sayfası) gibi
    /// </summary>
    public class Breadcrumb
    {
        private int id;
        private int parentId; // bağlı olduğu breadcrumb
        private string controllerName;
        private string actionName;
        private string viewTitle;
        private string backButtonText;

        public int Id { get { return this.id; } set { id = value; } }
        public int ParentId { get { return this.parentId; } set { this.parentId = value; } }
        public string ControllerName { get { return this.controllerName.ToLower(); } set { controllerName = value; } }
        public string ActionName { get { return this.actionName.ToLower(); } set { actionName = value; } }
        public string ViewTitle { get { return this.viewTitle; } set { viewTitle = value; } }
        public string BackButtonText { get { return this.backButtonText; } set { backButtonText = value; } }
    }
}
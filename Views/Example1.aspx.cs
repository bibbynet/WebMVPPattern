using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMVPPattern.Models;
using WebMVPPattern.Presenters;

namespace WebMVPPattern.Views
{
    public partial class Example1 : System.Web.UI.Page, IExample1View
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            new Example1ViewPresent(this);
            btnGetDatetime.Click += btnGetDatetime_Click;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadEvent(this, e);
        }

        void btnGetDatetime_Click(object sender, EventArgs e)
        {
            ClickSubmitEvent(sender, e);
        }

        public event EventHandler ClickSubmitEvent;
        public event EventHandler LoadEvent;

        public string Time
        {
            set
            {
                txtDatetimeNow.Text = value;
            }
        }

        public IList<Person> PersonData
        {
            set
            {
                gvPersonData.DataSource = value;
                gvPersonData.DataBind();
            }
        }
    }
}
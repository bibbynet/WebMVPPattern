using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVPPattern.Models;

namespace WebMVPPattern.Presenters
{
    public interface IExample1View
    {
        event EventHandler ClickSubmitEvent;
        event EventHandler LoadEvent;
        string Time { set; }
        IList<Person> PersonData { set; }
    }
}
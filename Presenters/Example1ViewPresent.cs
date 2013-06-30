using System;
using WebMVPPattern.Services;

namespace WebMVPPattern.Presenters
{
    public class Example1ViewPresent
    {
        private IExample1View view;

        public Example1ViewPresent(IExample1View view)
        {
            this.view = view;
            WireViewEvent();
        }

        private void WireViewEvent()
        {
            view.ClickSubmitEvent += ViewClickSubmitEvent;
            view.LoadEvent += view_LoadEvent;
        }

        void view_LoadEvent(object sender, EventArgs e)
        {
            var service = new PersonService();
            view.PersonData = service.GetPersonData();
        }

        void ViewClickSubmitEvent(object sender, EventArgs e)
        {
            view.Time = DateTime.Now.ToString();
        }
    }
}
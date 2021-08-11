using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Library.PageElements.Abstract.PageObject.Wait
{
    public class WaitUIObject
    {
        public TimeSpan TimeSpan { get; private set; }

        public WaitConditions WaitConditions { get; set; }

        private WaitUIObject(TimeSpan timeSpan, WaitConditions waitConditions)
        {
            TimeSpan = timeSpan;
            WaitConditions = waitConditions;
        }

        public static WaitUIObject ToBeVisible(int timeOutInSeconds)
        {
            return new WaitUIObject(TimeSpan.FromSeconds(timeOutInSeconds), WaitConditions.ElementIsVisible);
        }

        public static WaitUIObject ToBePresent(int timeOutInSeconds)
        {
            return new WaitUIObject(TimeSpan.FromSeconds(timeOutInSeconds), WaitConditions.ElementIsPresent);
        }

        public static WaitUIObject ToBeInteractable(int timeOutInSeconds)
        {
            return new WaitUIObject(TimeSpan.FromSeconds(timeOutInSeconds), WaitConditions.ElementIsInteractable);
        }
    }
}

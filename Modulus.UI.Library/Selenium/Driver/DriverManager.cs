using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Selenium.Driver
{
    /// <summary>
    /// Manages the operations related to the WebDriver and its intance.
    /// </summary>
    public abstract class DriverManager
    {
        public IWebDriver Driver { get; private set; }

        protected abstract IWebDriver GetDriverInstance();

        /// <summary>
        /// Creates a WebDriver instance(singleton).
        /// Starts the browser (if it's not started yet).
        /// </summary>
        public void StartDriver()
        {
            if (Driver != null)
            {
                throw new InvalidOperationException("Driver already started.");
            }

            Driver = GetDriverInstance();
        }
        /// <summary>
        /// Quits the Driver (closes the browser).
        /// </summary>
        public void QuitDriver()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver = null;
            }
        }

        /// <summary>
        /// Maximizes the browser window.
        /// </summary>
        public void Maximize()
        {
            Driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Performs page refresh on browser level.
        /// </summary>
        public void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }

        /// <summary>
        /// Loads the given url in the current browser.
        /// </summary>
        /// <param name="url">Url to laod.</param>
        public void LoadUrl(string url)
        {
            Driver.Url = url;
        }

        /// <summary>
        /// Taksee a screenshot on the current browser state.
        /// </summary>
        /// <param name="screenshotName">Name of the screenshot file.</param>
        /// <returns>Screenshot file path.</returns>
        public string TakeScreenshot(string screenshotName)
        {
            return null;
        }
    }
}

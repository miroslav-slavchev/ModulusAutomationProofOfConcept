using Modulus.QA.UI.Library.Exceptions.LocatorJson;
using Modulus.UI.Config;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI
{
    public class LocatorProvider
    {
        private const string LocatorTypeKey = "type";
        private const string LocatorStringKey = "locator";
        private const string LocatorStringFormatKey = "locatorFormat";
        private const string SearchContextKey = "SearchContext";

        private JObject _locatorsJson;

        /// <summary>
        ///  Initializes a new instance of the <see cref="LocatorProvider"/> class.
        /// </summary>
        /// <param name="fileName">
        ///  Name of the json file containing locator jsons.
        /// </param>
        public LocatorProvider(string fileName)
        {
            FileName = string.Format("{0}.json", fileName);
            _locatorsJson = JObject.Parse(File.ReadAllText(GetFilePath(fileName)));
        }

        internal string FileName { get; private set; }

        private string GetFilePath(string fileName)
        {
            string relativePathFormat = ConfigurationReader.GetSetting(
                Assembly.GetExecutingAssembly().GetName().Name,
                "locatorPathFormat"
            );
            string absolutePath = AppDomain.CurrentDomain.BaseDirectory + string.Format(relativePathFormat, fileName);
            return string.Format(absolutePath);
        }

        /// <summary>
        ///  Get the locator of an web element after inserting arguments in the locator string format
        /// </summary>
        /// <param name="webElementName">Json key of the locator json</param>
        /// <param name="locatorStringArgs">String argument to be inserted into locator string format</param>
        /// <returns>OpenQA.Selenium.By object for the specified key</returns>
        public By GetLocator(string webElementName, string[] locatorStringArgs)
        {
            string locatorString = String.Format(GetLocatorStringFormat(webElementName), locatorStringArgs);
            return GetLocator(GetLocatorType(webElementName), locatorString);
        }

        /// <summary>
        /// Get the locator of an web element
        /// </summary>
        /// <param name="webElementName">Json key of the locator json</param>
        /// <returns>OpenQA.Selenium.By object for the specified key</returns>
        public By GetLocator(string webElementName)
        {
            return GetLocator(GetLocatorType(webElementName), GetLocatorString(webElementName));
        }

        private By GetLocator(string type, string locatorString)
        {
            By locator;

            switch (type)
            {
                case "ClassName":
                    locator = By.ClassName(locatorString);
                    break;
                case "CssSelector":
                    locator = By.CssSelector(locatorString);
                    break;
                case "Id":
                    locator = By.Id(locatorString);
                    break;
                case "LinkText":
                    locator = By.LinkText(locatorString);
                    break;
                case "Name":
                    locator = By.Name(locatorString);
                    break;
                case "PartialLinkText":
                    locator = By.PartialLinkText(locatorString);
                    break;
                case "TagName":
                    locator = By.TagName(locatorString);
                    break;
                case "XPath":
                    locator = By.XPath(locatorString);
                    break;
                default:
                    string message = $"Not supported locator type: '{type}'";
                    throw new InvalidSelectorException(message);
            }

            return locator;
        }

        internal By GetSearchContextLocator()
        {
            By locator;

            if (_locatorsJson.ContainsKey(SearchContextKey))
            {
                locator = GetLocator(GetLocatorType(SearchContextKey), GetLocatorString(SearchContextKey));
            }
            else
            {
                locator = GetBodyLocator();
            }

            return locator;
        }

        internal By GetBodyLocator() => By.TagName("body");

        private string GetLocatorType(string webElementName)
        {
            JToken locatorType = GetWebElementJson(webElementName)[LocatorTypeKey];

            if (locatorType == null)
            {
                string message = string.Format(
                    "'{0}' key is mandatory for '{1}' json in '{2}'",
                    LocatorTypeKey,
                    webElementName,
                    FileName
                );
                throw new NoLocatorTypeException(message);
            }

            return locatorType.ToString();
        }

        private string GetLocatorString(string webElementName)
        {
            JToken locatorString = GetWebElementJson(webElementName)[LocatorStringKey];

            if (locatorString == null)
            {
                string message = string.Format(
                    "Could not find '{0}' key for '{1}' json in '{2}'",
                    LocatorStringKey,
                    webElementName,
                    FileName
                );
                throw new NoLocatorKeyException(message);
            }

            return locatorString.ToString();
        }

        private string GetLocatorStringFormat(string webElementName)
        {
            JToken locatorStringFormat = GetWebElementJson(webElementName)[LocatorStringFormatKey];

            if (locatorStringFormat == null)
            {
                string message = string.Format(
                    "Could not find '{0}' key for '{1}' json in '{2}'",
                    LocatorStringFormatKey,
                    webElementName,
                    FileName
                );
                throw new NoLocatorKeyException(message);
            }

            return locatorStringFormat.ToString();
        }

        private JObject GetWebElementJson(string webElementName)
        {
            JObject webElementJson = (JObject)_locatorsJson[webElementName];

            if (webElementJson == null)
            {
                string message = string.Format("{0} key not found in {1}", webElementName, FileName);
                throw new NoSuchLocatorJsonKeyException(message);
            }

            return webElementJson;
        }
    }
}

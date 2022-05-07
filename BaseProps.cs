using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public enum scrollType
    {
        H,
        V,
        C
    }
    public enum driversType
    {
        chrome,
        firefox,
        IE
    }
    public enum propertype
    {
        Id, Class, Name , Xpath, LinkText
    }
    public class BaseProps
    {   
       
        public static IWebDriver driver { get; set; }
        public static IJavaScriptExecutor js { get; set; }

        public static Actions actions { get; set; }
    }

}

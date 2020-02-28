using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;
//using OpenQA.Selenium.Alert

namespace PAIS_NIE

{
    [TestFixture]
    public class PAIS
    {

        string Url = "https://csd-test.manipal.edu/PAISNIE_Selenium/Login.aspx";
        //private bool acceptNextAlert = true;
        //private IWebDriver driver;

        [Test]
        public void A_LocalPO()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t3")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("PO Entry", driver.FindElement(By.XPath("//strong[contains(text(),'PO Entry')]")).Text);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();

            IWebElement element_xpath = driver.FindElement(By.XPath("//select[@id='ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU'] "));
            //Create a select object 
            SelectElement selectunit = new SelectElement(element_xpath);
            //select the option by text.
            selectunit.SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDept")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.FindElement(By.Id("DeptName")).Click();
            //driver.FindElement(By.Id("DeptName")).Clear();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("DeptName")).SendKeys("Department3");
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("DeptCode")).Click();
            //driver.FindElement(By.Id("DeptCode")).Clear();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("DeptCode")).SendKeys("D3");
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("btnSearch")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//span[@id='GridViewDept_LabelDID_2']")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_ButtonDebsearch']")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("vendName")).Click();
            driver.FindElement(By.Id("vendName")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("vendName")).SendKeys("J C GUPTA & SONS");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("btnSearch")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//span[@id='GridViewVendor_LabelVID_0']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();


            driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_ButtonShip']")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("LoactionName")).Click();
            driver.FindElement(By.Id("LoactionName")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("LoactionName")).SendKeys("NIE ,MYSORE");
            driver.FindElement(By.Id("LoactionCode")).Click();
            driver.FindElement(By.Id("LoactionCode")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("LoactionCode")).SendKeys("MYSORE");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("btnSearch")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//span[@id='GridViewShipLocation_LabelVID_0']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            IWebElement xpath = driver.FindElement(By.XPath("//select[@id='ContentPlaceHolder1_ContentPlaceHolder3_ddlTaxComponent']"));
            //Create a select object 
            SelectElement selecttax = new SelectElement(xpath);
            //select the option by text.
            selecttax.SelectByText("CGST+SGST");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).SendKeys("rgtrevrgve");
            Task.Delay(2000).Wait();

            IWebElement element = driver.FindElement(By.XPath("//select[@id='DropDownListTermCond']"));
            //Create a select object 
            SelectElement select = new SelectElement(element);
            //select the option by text.
            select.SelectByText("TC001");
            Task.Delay(2000).Wait();

            var element3 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_itemBtn_0']"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_itemBtn_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ItemIdsrc")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ItemIdsrc")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ItemIdsrc")).SendKeys("1210");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Itemsrc")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'Select')]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_HSNLabel_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_HSNLabel_0")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_HSNLabel_0")).SendKeys("HSN-06");
            Task.Delay(2000).Wait();

            IWebElement element2 = driver.FindElement(By.XPath("//select[@id='ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_DDLMatTax_0']"));
            //Create a select object 
            SelectElement select1 = new SelectElement(element2);
            //select the option by text.
            select1.SelectByText("GST Item");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_POQtyLabel_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_POQtyLabel_0")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_POQtyLabel_0")).SendKeys("30");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element5 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script5 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js5 = (IJavaScriptExecutor)driver;
            js5.ExecuteScript(script5, element5);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();           
            //driver.SwitchTo().Alert().Accept();


            //acceptNextAlert = true;
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSubmit")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            //driver.SwitchTo().Alert().Accept();
            //Task.Delay(2000).Wait();
            //acceptNextAlert = true;
            //driver.SwitchTo().Alert().Accept();
            driver.FindElement(By.XPath("//a[@id='HyperLinkLogout']")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu2@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t7")).Click();
            Task.Delay(1000).Wait();

            Assert.AreEqual("Local PO HOI", driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_ContentPlaceHolder3_txtRoleName']")).Text);
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_0")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).Clear();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).SendKeys("qwewqeqeqwe");
            //Task.Delay(2000).Wait();

            ////driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_HSNLabel_0']")).Click();
            ////driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_HSNLabel_0']")).Clear();
            ////driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_HSNLabel_0']")).SendKeys("10");
            ////Task.Delay(2000).Wait();

            //var element4 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSaveEdit"));
            //var script4 = "arguments[0].scrollIntoView(true);";
            //IJavaScriptExecutor js4 = (IJavaScriptExecutor)driver;
            //js4.ExecuteScript(script4, element4);
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSaveEdit")).Click();
            //driver.SwitchTo().Alert().Accept();
            //Task.Delay(2000).Wait();
            ////driver.SwitchTo().Alert().Accept();
            ////Task.Delay(2000).Wait();


            var element7 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0"));
            var script7 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js7 = (IJavaScriptExecutor)driver;
            js7.ExecuteScript(script7, element7);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();



            var element6 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script6 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js6 = (IJavaScriptExecutor)driver;
            js6.ExecuteScript(script6, element6);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            //driver.SwitchTo().Alert().Accept();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave']")).Click();
            //acceptNextAlert = true;
            //driver.SwitchTo().Alert().Accept();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[@id='HyperLinkLogout']")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }


        [Test]
        public void B_LocalGRNEntry()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t9")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("GRN Entry", driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_ContentPlaceHolder3_Label2']")).Text);
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBU")).Click();
            //Task.Delay(1000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBU")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBU")).Click();
            Task.Delay(1000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBU"))).SelectByText("BU1");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep")).Click();
            Task.Delay(1000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep"))).SelectByText("Department2");
            Task.Delay(2000).Wait();

            //var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep"));
            //var script = "arguments[0].scrollIntoView(true);";
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript(script, element1);
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPOItem")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_RadioMarkPO_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPoLineDesc_CheckBoxMarkPO_0")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPOLine']")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).SendKeys("7");
            Task.Delay(2000).Wait();


            IWebElement selectDate = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvDate"));
            selectDate.Click();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender4_today")).Click();
            Task.Delay(5000).Wait();

            var element4 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script4 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js4 = (IJavaScriptExecutor)driver;
            js4.ExecuteScript(script4, element4);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            //driver.SwitchTo().Alert().Accept();
            //Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            ////acceptNextAlert = true;
            //driver.SwitchTo().Alert().Accept();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();





            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu6@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t23")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEdit_0")).Click();
            Task.Delay(1000).Wait();

            var element5 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnApprove"));
            var script5 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js5 = (IJavaScriptExecutor)driver;
            js5.ExecuteScript(script5, element5);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnApprove")).Click();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[@id='HyperLinkLogout']")).Click();
            Task.Delay(3000).Wait();

            //driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_btnApprove']")).Click();
            ////acceptNextAlert = true;
            //driver.SwitchTo().Alert().Accept();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("HyperLinkLogout")).Click();
            driver.Close();

        }

        [Test]
        public void C_PREntry()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t6")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("PR Entry", driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_ContentPlaceHolder3_Label2']")).Text);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpbusUnit")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpbusUnit"))).SelectByText("BU1");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpbusUnit")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep"))).SelectByText("Department2");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpGrp")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpGrp"))).SelectByText("COMPUTERS");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpGrp")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("156898988");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCmt")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCmt")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCmt")).SendKeys("yewgwwrwgh");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(1000).Wait();
            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[3]/table[1]/tbody[1]/tr[7]/td[1]/div[1]/table[1]/tbody[1]/tr[4]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.LinkText("Select")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_QtyReq_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_QtyReq_0")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_QtyReq_0")).SendKeys("60");
            Task.Delay(2000).Wait();

            var element3 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(4000).Wait();

            driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit']")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[@id='HyperLinkLogout']")).Click();
            Task.Delay(2000).Wait();




            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu6@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t13")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();


            var element4 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Save"));
            var script4 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js4 = (IJavaScriptExecutor)driver;
            js4.ExecuteScript(script4, element4);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Save")).Click();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[@id='HyperLinkLogout']")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu2@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t10")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();
            var element5 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve"));
            var script5 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js5 = (IJavaScriptExecutor)driver;
            js5.ExecuteScript(script5, element5);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();

        }

        [Test]
        public void D_POEntryFlow()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t9"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t9")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("PO Entry", driver.FindElement(By.XPath("//strong[contains(text(),'PO Entry')]")).Text);
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDept")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("GridViewDept_LabelDID_2")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropdownlistPoType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropdownlistPoType"))).SelectByText("indigenous");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSearch")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPR_CheckBoxMarkPR_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSubPRLine_CheckBoxMarkPRLine_0")).Click();
            Task.Delay(2000).Wait();
            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPrLine"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPrLine")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDebsearch")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.XPath("//span[@id='GridViewVendor_LabelVID_0']")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.XPath("//span[@id='GridViewVendor_LabelVID_1']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonShip")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("GridViewShipLocation_LabelVID_4")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose"))).SelectByText("BOTH");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlTaxComponent")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlTaxComponent"))).SelectByText("CGST+SGST");
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("DropDownListTermCond")).Click();
            var element0 = driver.FindElement(By.Id("DropDownListTermCond"));
            var script0 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js0 = (IJavaScriptExecutor)driver;
            js0.ExecuteScript(script0, element0);
            driver.FindElement(By.Id("DropDownListTermCond")).Click();
            new SelectElement(driver.FindElement(By.Id("DropDownListTermCond"))).SelectByText("CAPG1");
            Task.Delay(2000).Wait();

            var element4 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_DDLMatTax_0"));
            var script4 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js4 = (IJavaScriptExecutor)driver;
            js4.ExecuteScript(script4, element4);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_DDLMatTax_0")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_DDLMatTax_0"))).SelectByText("GST Item");
            Task.Delay(2000).Wait();

            var element9 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0"));
            var script9 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js9 = (IJavaScriptExecutor)driver;
            js9.ExecuteScript(script9, element9);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0")).SendKeys("10");
            Task.Delay(2000).Wait();


            var element3 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSubmit")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();



            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv6@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t1")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("Finance Executive", driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_ContentPlaceHolder3_txtRoleName']")).Text);
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();

            var element5 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script5 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js5 = (IJavaScriptExecutor)driver;
            js5.ExecuteScript(script5, element5);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();



            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu5@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t3")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("Purchase Director", driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_ContentPlaceHolder3_txtRoleName']")).Text);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();

            var element6 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script6 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js6 = (IJavaScriptExecutor)driver;
            js6.ExecuteScript(script6, element6);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();



            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t10")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            var element7 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script7 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js7 = (IJavaScriptExecutor)driver;
            js7.ExecuteScript(script7, element7);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }



        [Test]
        public void E_GRNEntryFlow()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu6@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t20")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("GRN Entry", driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_ContentPlaceHolder3_Label2']")).Text);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlStoreBU")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlStoreBU"))).SelectByText("STR_B");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBU")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBU"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep"))).SelectByText("Department2");
            Task.Delay(2000).Wait();

            var element9 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPOItem"));
            var script9 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js9 = (IJavaScriptExecutor)driver;
            js9.ExecuteScript(script9, element9);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPOItem")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_RadioMarkPO_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPoLineDesc_CheckBoxMarkPO_0")).Click();
            Task.Delay(2000).Wait();
            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPOLine"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPOLine")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).SendKeys("06");
            Task.Delay(2000).Wait();

            IWebElement selectDate = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvDate"));
            selectDate.Click();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender4_today")).Click();
            Task.Delay(5000).Wait();

            var element6 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script6 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js6 = (IJavaScriptExecutor)driver;
            js6.ExecuteScript(script6, element6);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Alert().Accept();
            //Task.Delay(1000).Wait();

            //Alert Alert = driver.SwitchTo().Alert();
            //String SaveAlertMsg = Alert.getText();
            //if (SaveAlertMsg.Equals("Status is in Submitted...Do You Want To Continue?"))
            //{

            //}

            //{
            //    Alert.Accept();
            //    pagecode = pagecode + " System.out.println("\nGRN Changes Alert Msg is\n");\n";
            //    Alert Alert1 = driver.SwitchTo().Alert();
            //    String SaveAlertMsg1 = Alert1.getText();
            //    Alert1.accept();
            //    System.out.println(SaveAlertMsg1);
            //    Assert.assertEquals(SaveAlertMsg1, "GRN Changes Saved Successfully!");
            //    pagecode = pagecode + " System.out.println(\"Add 1st item to PR \");\n";
            //String expectedMessage = "GRN Created Successfully";
            //String alertMessage = driver.SwitchTo().Alert().getText();
            //Assert.assertEquals(alertMessage, expectedMessage);

            //System.out.println("Alert text is: " + driver.SwitchTo().Alert().getText());

            //String expectedMessage = "GRN Created Successfully";
            //String message = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).GetAttribute.message();
            //Assert.assertEquals("Your error message", message.Contains(expectedMessage));
            //Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Do you want to continue"));
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();



            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu2@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t22")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            var element10 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnApprove"));
            var script10 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js10 = (IJavaScriptExecutor)driver;
            js10.ExecuteScript(script10, element10);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnApprove")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Alert().Accept();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();

            driver.Close();

        }



        [Test]
        public void F_ChangePR()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t8")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("                                                                                        Change PR", driver.FindElement(By.XPath("//b[contains(text(),'Change PR')]")).Text);
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();

            var element28 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnView_0"));
            var script28 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js28 = (IJavaScriptExecutor)driver;
            js28.ExecuteScript(script28, element28);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnView_0")).Click();
            Task.Delay(2000).Wait();

            var element26 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_CheckBoxMarkPR_0"));
            var script26 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js26 = (IJavaScriptExecutor)driver;
            js26.ExecuteScript(script26, element26);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_CheckBoxMarkPR_0")).Click();
            Task.Delay(2000).Wait();

            var element27 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1"));
            var script27 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js27 = (IJavaScriptExecutor)driver;
            js27.ExecuteScript(script27, element27);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void G_POCancel()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t11")).Click();
            Task.Delay(2000).Wait();

            //Assert.AreEqual("PO List", driver.FindElement(By.XPath("//legend[contains(text(),'PO List')]")).Text);
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();

            var element28 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_0"));
            var script28 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js28 = (IJavaScriptExecutor)driver;
            js28.ExecuteScript(script28, element28);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            var element27 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script27 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js27 = (IJavaScriptExecutor)driver;
            js27.ExecuteScript(script27, element27);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void H_POAmendment()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t12")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("PO Amendment-Selection of Items for Amendment", driver.FindElement(By.XPath("//span[contains(text(),'PO Amendment-Selection of Items for Amendment')]")).Text);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();

            var element28 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_0"));
            var script28 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js28 = (IJavaScriptExecutor)driver;
            js28.ExecuteScript(script28, element28);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_0")).Click();
            Task.Delay(2000).Wait();

            var element26 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_chkSelectItem_0"));
            var script26 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js26 = (IJavaScriptExecutor)driver;
            js26.ExecuteScript(script26, element26);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_chkSelectItem_0")).Click();
            Task.Delay(2000).Wait();

            var element27 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnDone"));
            var script27 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js27 = (IJavaScriptExecutor)driver;
            js27.ExecuteScript(script27, element27);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnDone")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("DropDownListTermCond")).Click();
            new SelectElement(driver.FindElement(By.Id("DropDownListTermCond"))).SelectByText("TCCAP");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).SendKeys("yujhjnfhn");
            Task.Delay(2000).Wait();


            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSubmit"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSubmit")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void I_POView()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t14")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();

            var element28 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_0"));
            var script28 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js28 = (IJavaScriptExecutor)driver;
            js28.ExecuteScript(script28, element28);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_0")).Click();
            Task.Delay(2000).Wait();

            var element27 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPrint"));
            var script27 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js27 = (IJavaScriptExecutor)driver;
            js27.ExecuteScript(script27, element27);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPrint")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void J_POItemsRelease()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t15")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();

            var element28 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_0"));
            var script28 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js28 = (IJavaScriptExecutor)driver;
            js28.ExecuteScript(script28, element28);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void K_POClosure()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t16")).Click();
            Task.Delay(2000).Wait();

            var element28 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_0"));
            var script28 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js28 = (IJavaScriptExecutor)driver;
            js28.ExecuteScript(script28, element28);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            var element27 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonClose"));
            var script27 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js27 = (IJavaScriptExecutor)driver;
            js27.ExecuteScript(script27, element27);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonClose")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void L_POUpdate()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t17")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();

            var element28 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_2"));
            var script28 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js28 = (IJavaScriptExecutor)driver;
            js28.ExecuteScript(script28, element28);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).SendKeys("ertrgfg");
            Task.Delay(2000).Wait();

            var element11 = driver.FindElement(By.Id("DropDownListTermCond"));
            var script11 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js11 = (IJavaScriptExecutor)driver;
            js11.ExecuteScript(script11, element11);
            driver.FindElement(By.Id("DropDownListTermCond")).Click();
            new SelectElement(driver.FindElement(By.Id("DropDownListTermCond"))).SelectByText("TC001");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void M_ClonePR()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t19"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t19")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSearch")).Click();
            Task.Delay(2000).Wait();

            var element28 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_0"));
            var script28 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js28 = (IJavaScriptExecutor)driver;
            js28.ExecuteScript(script28, element28);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtRemarks")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtRemarks")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtRemarks")).SendKeys("WEWQETWQERWQTQE");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Save"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Save")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void N_VendorEntry()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu1@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t27")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("Vendor Entry", driver.FindElement(By.XPath("//b[contains(text(),'Vendor Entry')] ")).Text);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Addbtn")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_VendorCategoryList")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_VendorCategoryList"))).SelectByText("PO Vendor");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtVendorName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtVendorName")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtVendorName")).SendKeys("INDIAN MESS");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUDL")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUDL"))).SelectByText("NIEAD");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_EntityDL")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_EntityDL"))).SelectByText("Trust");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_InfoStatusDrp")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_InfoStatusDrp"))).SelectByText("DraftMode");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlVendorTaxCl")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlVendorTaxCl"))).SelectByText("GST Excluded Vendor");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_PanNumTb")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_PanNumTb")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_PanNumTb")).SendKeys("ABCDE1006X");
            Task.Delay(2000).Wait();

            var element12 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script12 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js12 = (IJavaScriptExecutor)driver;
            js12.ExecuteScript(script12, element12);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t25")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("PANSearchTb")).Click();
            driver.FindElement(By.Id("PANSearchTb")).Clear();
            driver.FindElement(By.Id("PANSearchTb")).SendKeys("ABCDE1006X");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();

            var element20 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_0"));
            var script20 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js20 = (IJavaScriptExecutor)driver;
            js20.ExecuteScript(script20, element20);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            var element21 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnAddvendor"));
            var script21 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js21 = (IJavaScriptExecutor)driver;
            js21.ExecuteScript(script21, element21);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnAddvendor")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_address1Tb")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_address1Tb")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_address1Tb")).SendKeys("hebal");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtVCity")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtVCity")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtVCity")).SendKeys("Banglore");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_StateTb")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_StateTb")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_StateTb")).SendKeys("karnataka");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_contactNumTb")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_contactNumTb")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_contactNumTb")).SendKeys("8978748989");
            Task.Delay(2000).Wait();

            var element24 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextStateCode"));
            var script24 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js24 = (IJavaScriptExecutor)driver;
            js24.ExecuteScript(script24, element24);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextStateCode")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextStateCode"))).SelectByText("Karnataka");
            Task.Delay(2000).Wait();

            var element22 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script22 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js22 = (IJavaScriptExecutor)driver;
            js22.ExecuteScript(script22, element22);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t27")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("PANSearchTb")).Click();
            driver.FindElement(By.Id("PANSearchTb")).Clear();
            driver.FindElement(By.Id("PANSearchTb")).SendKeys("ABCDE1006X");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();

            var element23 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEdit_0"));
            var script23 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js23 = (IJavaScriptExecutor)driver;
            js23.ExecuteScript(script23, element23);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_InfoStatusDrp")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_InfoStatusDrp"))).SelectByText("Approved");
            Task.Delay(2000).Wait();

            var element25 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script25 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js25 = (IJavaScriptExecutor)driver;
            js25.ExecuteScript(script25, element25);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t26")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("PANSearchTb")).Click();
            driver.FindElement(By.Id("PANSearchTb")).Clear();
            driver.FindElement(By.Id("PANSearchTb")).SendKeys("ABCDE1006X");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void O_PRImport()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t6")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("PR Entry", driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_ContentPlaceHolder3_Label2']")).Text);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpbusUnit")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpbusUnit"))).SelectByText("BU1");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpbusUnit")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep"))).SelectByText("Department2");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpGrp")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpGrp"))).SelectByText("Others");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpGrp")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("987984815");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("Import");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCmt")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCmt")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCmt")).SendKeys("etretertertger");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(1000).Wait();
            driver.FindElement(By.XPath("//tr[8]//td[1]//a[1]")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.LinkText("Select")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_QtyReq_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_QtyReq_0")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_QtyReq_0")).SendKeys("40");
            Task.Delay(2000).Wait();

            var element3 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(4000).Wait();

            driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit']")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[@id='HyperLinkLogout']")).Click();
            Task.Delay(2000).Wait();




            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu6@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t13")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();


            var element4 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Save"));
            var script4 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js4 = (IJavaScriptExecutor)driver;
            js4.ExecuteScript(script4, element4);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Save")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[@id='HyperLinkLogout']")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu2@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t10")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();
            var element5 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve"));
            var script5 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js5 = (IJavaScriptExecutor)driver;
            js5.ExecuteScript(script5, element5);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void P_POImport()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t9")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("PO Entry", driver.FindElement(By.XPath("//strong[contains(text(),'PO Entry')]")).Text);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDept")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("GridViewDept_LabelDID_2")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropdownlistPoType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropdownlistPoType"))).SelectByText("Import");
            Task.Delay(2000).Wait();

            var element3 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_allowEdit_0"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_allowEdit_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSearch")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPR_CheckBoxMarkPR_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSubPRLine_CheckBoxMarkPRLine_0")).Click();
            Task.Delay(2000).Wait();
            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPrLine"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPrLine")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDebsearch")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("GridViewVendor_LabelVID_0")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("GridViewVendor_LabelVID_0")).Click();
            Task.Delay(1000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose"))).SelectByText("BOTH");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpPOCurType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpPOCurType"))).SelectByText("USD");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("POConRate")).Click();
            driver.FindElement(By.Id("POConRate")).Clear();
            driver.FindElement(By.Id("POConRate")).SendKeys("20");
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("DropDownListTermCond")).Click();
            new SelectElement(driver.FindElement(By.Id("DropDownListTermCond"))).SelectByText("TCCON");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ImageAddCost"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ImageAddCost")).Click();
            Task.Delay(2000).Wait();

            var element11 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1"));
            var script11 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js11 = (IJavaScriptExecutor)driver;
            js11.ExecuteScript(script11, element11);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox1")).SendKeys("TEST3");
            Task.Delay(2000).Wait();

            var element12 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBoxCost1"));
            var script12 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js12 = (IJavaScriptExecutor)driver;
            js12.ExecuteScript(script12, element12);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBoxCost1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBoxCost1")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBoxCost1")).SendKeys("200");
            Task.Delay(2000).Wait();

            var element13 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button3"));
            var script13 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js13 = (IJavaScriptExecutor)driver;
            js13.ExecuteScript(script13, element13);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button3")).Click();
            Task.Delay(2000).Wait();

            var element31 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script31 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js31 = (IJavaScriptExecutor)driver;
            js31.ExecuteScript(script31, element31);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSubmit")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv6@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t1")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("Finance Executive", driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_ContentPlaceHolder3_txtRoleName']")).Text);
            Task.Delay(2000).Wait();

            var element10 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0"));
            var script10 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js10 = (IJavaScriptExecutor)driver;
            js10.ExecuteScript(script10, element10);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();


            var element21 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script21 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js21 = (IJavaScriptExecutor)driver;
            js21.ExecuteScript(script21, element21);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu5@manipal.edu");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t3")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("Purchase Director", driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_ContentPlaceHolder3_txtRoleName']")).Text);
            Task.Delay(2000).Wait();

            var element5 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0"));
            var script5 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js5 = (IJavaScriptExecutor)driver;
            js5.ExecuteScript(script5, element5);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();


            var element7 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script7 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js7 = (IJavaScriptExecutor)driver;
            js7.ExecuteScript(script7, element7);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t10")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            var element8 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script8 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js8 = (IJavaScriptExecutor)driver;
            js8.ExecuteScript(script8, element8);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(3000).Wait();

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();

            driver.Close();
        }

        [Test]
        public void Q_ImportGRN()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3@manipal.edu");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("test123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t26")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("GRN Entry", driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_ContentPlaceHolder3_Label2']")).Text);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlStoreBU")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlStoreBU"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBU")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBU"))).SelectByText("BU1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDept")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("GridViewDept_LabelDID_2")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            var element3 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPOItem"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPOItem")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            //driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_RadioMarkPO_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPoLineDesc_CheckBoxMarkPO_0")).Click();
            Task.Delay(2000).Wait();
            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPOLine"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPOLine")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).SendKeys("8");
            Task.Delay(2000).Wait();

            IWebElement selectDate = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvDate"));
            selectDate.Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender4_today")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlTaxComponent")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlTaxComponent"))).SelectByText("CGST+SGST");
            Task.Delay(2000).Wait();

            var element7 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script7 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js7 = (IJavaScriptExecutor)driver;
            js7.ExecuteScript(script7, element7);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();
            var element8 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnApprove"));
            var script8 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js8 = (IJavaScriptExecutor)driver;
            js8.ExecuteScript(script8, element8);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnApprove")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
    }
}










Imports System
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium.Firefox

Public Class cAmazonPage

    Public Class ConstantsUtils
        Public Const Url = "https://www.amazon.co.uk"
        Public Const AmazonLogo = "span.nav-logo-base"

        Public Const DropDownCategory = "#searchDropdownBox"
        Public Const SearchBox = "#twotabsearchtextbox"
        Public Const SearchButton = "input.nav-input:nth-child(2)"

        Public Const FirstitemLink = "#result_0 > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > a:nth-child(1)"
        Public Const FirstItemName = "#result_0 > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > a:nth-child(1) > h2:nth-child(1)"
        Public Const FirstItemBadge = "#result_0 > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1) > span:nth-child(1)"
        Public Const FirstItemPrice = "#result_0 > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(2) > a:nth-child(1) > span:nth-child(1)"
        Public Const FirstItemPaperBack = "#result_0 > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1) > h3:nth-child(1)"

        Public Const DetailsPrice = "span.a-color-base:nth-child(3) > span:nth-child(1)"
        Public Const DetailsName = "#productTitle"
        Public Const DetailsBadge = ".a-icon-addon"
        Public Const DetailsPaperback = "#a-autoid-4-announce > span:nth-child(1)"
        Public Const AddToBasketButton = "#add-to-cart-button"

        Public Const AddToBasketNotification = "h1.a-size-medium"
        Public Const EditBasketButton = "#hlb-view-cart-announce"

        Public Const BasketPrice = ".sc-product-price"
        Public Const BasketName = "ul.a-spacing-mini > li:nth-child(1) > span:nth-child(1) > a:nth-child(1) > span:nth-child(1)"
        Public Const BasketPaperBack = ".sc-product-binding"
        Public Const BasketQuantity = ".a-dropdown-prompt"
        Public Const BasketFinalPrice = "span.a-size-medium:nth-child(2)"
    End Class

    Public Class Driver

        Public Shared Property Instance As IWebDriver
        Public Shared Property Wait As WebDriverWait

        Public Shared ReadOnly Property BaseAddress As String
            Get
                Return ConstantsUtils.Url
            End Get
        End Property

        Public Shared Function GetWebElementText(ByVal sId As String)
            Return Wait.Until(ExpectedConditions.ElementExists(By.CssSelector(sId))).Text
        End Function

        Public Shared Sub Initialize()
            Instance = New FirefoxDriver
            Wait = New WebDriverWait(Instance, TimeSpan.FromSeconds(30))
            Instance.Manage.Window.Maximize()
        End Sub

        Public Shared Sub Navigate()
            Instance.Navigate.GoToUrl(BaseAddress)
        End Sub

        Public Shared Sub Close()
            Instance.Close()
        End Sub

    End Class

    Public Class AmazonNavigation

        Public Shared Sub ChangeCategory(p0 As String)
            Driver.Wait.Until(ExpectedConditions.ElementExists(By.CssSelector(ConstantsUtils.DropDownCategory)))
            Dim slct As SelectElement = New SelectElement(Driver.Instance.FindElement(By.CssSelector(ConstantsUtils.DropDownCategory)))
            slct.SelectByText(p0)
        End Sub

        Public Shared Sub SearchForItem(p0 As String)
            Dim txt As IWebElement = Driver.Wait.Until(ExpectedConditions.ElementExists(By.CssSelector(ConstantsUtils.SearchBox)))
            txt.SendKeys(p0)
            Dim btn As IWebElement = Driver.Instance.FindElement(By.CssSelector(ConstantsUtils.SearchButton))
            btn.Click()
        End Sub

        Public Shared Function CheckAmazonIsLoaded() As Boolean

            Return (String.Compare(Driver.GetWebElementText(ConstantsUtils.AmazonLogo), "Amazon.co.uk", True) = 0)

        End Function

        Public Shared Sub OpenFirstItemDetails()
            Driver.Instance.FindElement(By.CssSelector(ConstantsUtils.FirstitemLink)).Click()
        End Sub

        Public Shared Sub AddItemToBasket()
            Dim btn As IWebElement = Driver.Instance.FindElement(By.CssSelector(ConstantsUtils.AddToBasketButton))
            btn.Click()
        End Sub

        Public Shared Sub EditBasket()
            Dim btn As IWebElement = Driver.Instance.FindElement(By.CssSelector(ConstantsUtils.EditBasketButton))
            btn.Click()
        End Sub
    End Class

End Class

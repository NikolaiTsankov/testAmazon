Imports System
Imports TechTalk.SpecFlow
Imports taskAmazon.cAmazonPage

Namespace taskAmazon

    <Binding()> _
    Public Class SpecFlowAmazon

        <BeforeScenario>
        Public Sub Setup()
            Driver.Initialize()
        End Sub

        <AfterScenario>
        Public Sub TearDown()
            Driver.Close()
        End Sub

        <TechTalk.SpecFlow.Given("The Amazon page")>
        Public Sub GivenTheAmazonPage()
            Driver.Navigate()
        End Sub

        <TechTalk.SpecFlow.Given("Check if page is loaded")>
        Public Sub GivenCheckIfPageIsLoaded()
            Assert.IsTrue(AmazonNavigation.CheckAmazonIsLoaded())
        End Sub

        <TechTalk.SpecFlow.When("I select '(.*)' category")>
        Public Sub WhenISelectCategory(ByVal p0 As String)
            AmazonNavigation.ChangeCategory(p0)
        End Sub

        <TechTalk.SpecFlow.When("I search for '(.*)'")>
        Public Sub WhenISearchFor(ByVal p0 As String)
            AmazonNavigation.SearchForItem(p0)
        End Sub

        <TechTalk.SpecFlow.When("Navigate to the fist item details")>
        Public Sub WhenNavigateToTheFistItemDetails()
            AmazonNavigation.OpenFirstItemDetails()
        End Sub

        <TechTalk.SpecFlow.When("Add the book to the basket")>
        Public Sub WhenAddTheBookToTheBasket()
            AmazonNavigation.AddItemToBasket()
        End Sub

        <TechTalk.SpecFlow.When("Click on edit the basket")>
        Public Sub WhenClickOnEditTheBasket()
            AmazonNavigation.EditBasket()
        End Sub

        <TechTalk.SpecFlow.Then("Vefify the fist item is '(.*)'")>
        Public Sub ThenVefifyTheFistItemIs(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.FirstItemName)

            Assert.AreEqual(p0, sActual, True)
        End Sub

        <TechTalk.SpecFlow.Then("Verify the badge is '(.*)'")>
        Public Sub ThenVerifyTheBadgeIs(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.FirstItemBadge)

            Assert.AreEqual(p0, sActual, True)
        End Sub

        <TechTalk.SpecFlow.Then("Verify the price is '(.*)'")>
        Public Sub ThenVerifyThePriceIs(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.FirstItemPrice)

            Assert.AreEqual(p0, sActual, True)
        End Sub

        <TechTalk.SpecFlow.Then("Verify that type is '(.*)'")>
        Public Sub ThenVerifyThatTypeIs(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.FirstItemPaperBack)

            Assert.AreEqual(p0, sActual, True)
        End Sub

        <TechTalk.SpecFlow.Then("Verify the title is '(.*)' in Details Screen")> _
        Public Sub ThenVerifyTheTitleIsInDetailsScreen(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.DetailsName)

            Assert.AreEqual(p0, sActual, True)
        End Sub
        
        <TechTalk.SpecFlow.Then("Verify the badge is '(.*)' in Details Screen")> _
        Public Sub ThenVerifyTheBadgeIsInDetailsScreen(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.DetailsBadge)
            Dim b As Boolean = False
            b = sActual.Contains(p0)
            Assert.IsTrue(b)
        End Sub
        
        <TechTalk.SpecFlow.Then("Verify the price is '(.*)' in Details Screen")> _
        Public Sub ThenVerifyThePriceIsInDetailsScreen(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.DetailsPrice)

            Assert.AreEqual(p0, sActual, True)
        End Sub
        
        <TechTalk.SpecFlow.Then("Verify that type is '(.*)' in Details Screen")> _
        Public Sub ThenVerifyThatTypeIsInDetailsScreen(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.DetailsPaperback)

            Assert.AreEqual(p0, sActual, True)
        End Sub
        
        <TechTalk.SpecFlow.Then("Verify that the notification is shown With the title '(.*)'")> _
        Public Sub ThenVerifyThatTheNotificationIsShownWithTheTitle(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.AddToBasketNotification)

            Assert.AreEqual(p0, sActual, True)
        End Sub

        <TechTalk.SpecFlow.Then("verify title is '(.*)' in Basket Screen")>
        Public Sub ThenVerifyTitleIsInBasketScreen(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.BasketName)

            Assert.AreEqual(p0, sActual, True)
        End Sub

        <TechTalk.SpecFlow.Then("verify type of print is '(.*)'  in Basket Screen")> _
        Public Sub ThenVerifyTypeOfPrintIsInBasketScreen(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.BasketPaperBack)

            Assert.AreEqual(p0, sActual, True)
        End Sub
        
        <TechTalk.SpecFlow.Then("verify price is '(.*)'  in Basket Screen")> _
        Public Sub ThenVerifyPriceIsInBasketScreen(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.BasketPrice)

            Assert.AreEqual(p0, sActual, True)
        End Sub

        <TechTalk.SpecFlow.Then("verify quantity is '(.*)'  in Basket Screen")>
        Public Sub ThenVerifyQuantityIsInBasketScreen(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.BasketQuantity)

            Assert.AreEqual(p0, sActual, True)
        End Sub

        <TechTalk.SpecFlow.Then("verify total price is '(.*)'  in Basket Screen")> _
        Public Sub ThenVerifyTotalPriceIsInBasketScreen(ByVal p0 As String)
            Dim sActual As String = Driver.GetWebElementText(ConstantsUtils.BasketFinalPrice)

            Assert.AreEqual(p0, sActual, True)
        End Sub

    End Class

End Namespace

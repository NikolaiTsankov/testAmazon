﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by SpecFlow (http://www.specflow.org/).
'     SpecFlow Version:2.1.0.0
'     SpecFlow Generator Version:2.0.0.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
#Region "Designer generated code"
'#pragma warning disable
Imports TechTalk.SpecFlow

Namespace taskAmazon
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0"),  _
     System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()>  _
    Partial Public Class SpecFlowAmazonFeature
        
        Private Shared testRunner As TechTalk.SpecFlow.ITestRunner
        
#ExternalSource("SpecFlowAmazon.feature",1)
#End ExternalSource
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()>  _
        Public Shared Sub FeatureSetup(ByVal testContext As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(Nothing, 0)
            Dim featureInfo As TechTalk.SpecFlow.FeatureInfo = New TechTalk.SpecFlow.FeatureInfo(New System.Globalization.CultureInfo("en-US"), "SpecFlowAmazon", ""&Global.Microsoft.VisualBasic.ChrW(9)&"From Amazon"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"As a user"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"I want to order Game of thrones the first book", ProgrammingLanguage.VB, CType(Nothing,String()))
            testRunner.OnFeatureStart(featureInfo)
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()>  _
        Public Shared Sub FeatureTearDown()
            testRunner.OnFeatureEnd
            testRunner = Nothing
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()>  _
        Public Overridable Sub TestInitialize()
            If ((Not (testRunner.FeatureContext) Is Nothing)  _
                        AndAlso (testRunner.FeatureContext.FeatureInfo.Title <> "SpecFlowAmazon")) Then
                taskAmazon.SpecFlowAmazonFeature.FeatureSetup(Nothing)
            End If
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()>  _
        Public Overridable Sub ScenarioTearDown()
            testRunner.OnScenarioEnd
        End Sub
        
        Public Overridable Sub ScenarioSetup(ByVal scenarioInfo As TechTalk.SpecFlow.ScenarioInfo)
            testRunner.OnScenarioStart(scenarioInfo)
        End Sub
        
        Public Overridable Sub ScenarioCleanup()
            testRunner.CollectScenarioErrors
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Amazon Book Byuer"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowAmazon"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")>  _
        Public Overridable Sub AmazonBookByuer()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Amazon Book Byuer", New String() {"mytag"})
#ExternalSource("SpecFlowAmazon.feature",7)
Me.ScenarioSetup(scenarioInfo)
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",8)
 testRunner.Given("The Amazon page", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",9)
 testRunner.And("Check if page is loaded", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",10)
 testRunner.When("I select 'Books' category", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",11)
 testRunner.And("I search for 'Game of Thrones'", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",12)
 testRunner.Then("Vefify the fist item is 'A Game of Thrones (A Song of Ice and Fire, Book 1)'", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",13)
 testRunner.And("Verify the badge is 'Best Seller'", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",14)
 testRunner.And("Verify the price is '£4.00'", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",15)
 testRunner.And("Verify that type is 'Paperback'", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",16)
 testRunner.When("Navigate to the fist item details", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",17)
 testRunner.Then("Verify the title is 'A Game of Thrones (A Song of Ice and Fire, Book 1)' in Detai"& _ 
                    "ls Screen", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",18)
 testRunner.And("Verify the badge is 'Best Seller' in Details Screen", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",19)
 testRunner.And("Verify the price is '£4.00' in Details Screen", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",20)
 testRunner.And("Verify that type is 'Paperback' in Details Screen", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",21)
 testRunner.When("Add the book to the basket", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",22)
 testRunner.Then("Verify that the notification is shown With the title 'Added to Basket'", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",23)
 testRunner.When("Click on edit the basket", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",24)
 testRunner.Then("verify title is 'A Game of Thrones (A Song of Ice and Fire, Book 1)' in Basket Sc"& _ 
                    "reen", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",25)
 testRunner.And("verify type of print is 'paperback'  in Basket Screen", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",26)
 testRunner.And("verify price is '£4.00'  in Basket Screen", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",27)
 testRunner.And("verify quantity is '1'  in Basket Screen", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowAmazon.feature",28)
 testRunner.And("verify total price is '£4.00'  in Basket Screen", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
    End Class
End Namespace
'#pragma warning restore
#End Region
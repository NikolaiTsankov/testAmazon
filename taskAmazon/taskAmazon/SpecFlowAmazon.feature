Feature: SpecFlowAmazon
	From Amazon
	As a user
	I want to order Game of thrones the first book

@mytag
Scenario: Amazon Book Byuer 
	Given The Amazon page
	And Check if page is loaded
	When I select 'Books' category
	And I search for 'Game of Thrones'
	Then Vefify the fist item is 'A Game of Thrones (A Song of Ice and Fire, Book 1)'
	And Verify the badge is 'Best Seller'
	And Verify the price is '£4.00'
	And Verify that type is 'Paperback'
	When Navigate to the fist item details
	Then Verify the title is 'A Game of Thrones (A Song of Ice and Fire, Book 1)' in Details Screen
	And Verify the badge is 'Best Seller' in Details Screen
	And Verify the price is '£4.00' in Details Screen
	And Verify that type is 'Paperback' in Details Screen
	When Add the book to the basket
	Then Verify that the notification is shown With the title 'Added to Basket'
	When Click on edit the basket
	Then verify title is 'A Game of Thrones (A Song of Ice and Fire, Book 1)' in Basket Screen
	And verify type of print is 'paperback'  in Basket Screen
	And verify price is '£4.00'  in Basket Screen
	And verify quantity is '1'  in Basket Screen
	And verify total price is '£4.00'  in Basket Screen
Feature: Create UVP
 
  Scenario Outline:  An individual applicant should be able to create a uvp for a passenger vehicle 
    Given I am on the uvp page
    When I create a passenger uvp for a passenger vehicle type <passenger vehicle type> garaged at  <garage address> with permit start date as today for duration <duration>
    And I navigate to the next step to enter the permit type
    And I select uvp permit type for preparation for registration in Victoria and click next
    Then the page to enter vehicle details page is dispalyed
    
    Examples:
      | passenger vehicle type         | garage address                             | duration | 
      | Sedan                          | 60 Denmark Street, KEW  VIC  3101          | 5 days   |       
      | Bus or van seating 10 or more  | unit 26 60 Denmark Street, KEW  VIC  3101  | 20 days  |   



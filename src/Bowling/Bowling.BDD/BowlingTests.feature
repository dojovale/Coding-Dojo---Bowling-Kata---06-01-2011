Feature: Bowling Game Score
	In order to focus on drop pins
	As a bowling player
	I want to be told of the score of my game

@mytag
Scenario: All Ones Game
	Given a new bowling game	
	When I roll the ball 20 times and hit 1 pin per roll  
	Then the score should be 20

Scenario: Gutter Game
	Given a new bowling game	
	When I roll the ball into the gutter 20 times  
	Then the score should be 0

Scenario: Spare In First Frame
	Given a new bowling game	
	When I do a spare in the first frame
	And Hit tree pins in the next roll
	And throw the ball in the gutter on next 17 rolls  
	Then the score should be 16

Scenario: Strike In First Frame
	Given a new bowling game	
	When I do a strike in the first frame
	And Hit tree pins in the next roll
	And Hit four pins in the next roll
	And throw the ball in the gutter on next 17 rolls  
	Then the score should be 24

Scenario: Perfect Game
	Given a new bowling game	
	When I do 12 consecutive strikes	
	Then the score should be 300

Scenario: All Fives Game
	Given a new bowling game	
	When I throw 5 pins in 21 consecutive rolls	
	Then the score should be 150


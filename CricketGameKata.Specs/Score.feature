Feature: Batter Score
	In order to build a cricket game
	As a developer
	I want to calculate the batter's score.

@sanity
Scenario: Batter gets out without scoring
	Given I started a new game of cricket
	When Batter gets out
	Then Batter score should be 0

@sanity
Scenario: Batter scores runs before getting out
	Given I started a new game of cricket
	And Batter scored 4 runs
	When Batter gets out
	Then Batter score should be 4


@sanity
Scenario: Batter cannot score runs after getting out
 Given I started a new game of cricket
 And Batter scored 2 runs
 And Batter scored 5 runs
 When Batter gets out
 And Batter scored 4 runs
 Then Batter score should be 7
 

@sanity
Scenario Outline: Batter scores multiple times before getting out
	Given I started a new game of cricket
	And Batter scored <Ball1> runs
	And Batter scored <Ball2> runs
	And Batter scored <Ball3> runs
	When Batter gets out
	Then Batter score should be <Total>
	And game should be finished
	Examples: 
	| Ball1 | Ball2 | Ball3 | Total |
	| 0     | 0     | 0     | 0     |
	| 1     | 0     | 6     | 7     |
	| 2     | 3     | 4     | 9     |
	| 5     | 6     | 6     | 17    |

Tools:	Unit Test -- NUnit
		DI -- Autofac
		Console App

Done:	Barely working connect 4 game with the minimal unit test. Six Acceptance test has been tested.

To do:	Refactor Game class, apply state design pattern r to handle the board state change
		Remove all the magic string and int to app config and use config injector to replace
		May also need to add the observer to the Player and board when new coin drops	
		Performace at this moment is not taken into account but need to refactor the algorithm on the Judge to achieve Big O

Question for stakeholder: what kind of situation is regarded as invalid board dimension? 
							Currenly the game accepts any number but character. Is there any limitation for the size of the board?
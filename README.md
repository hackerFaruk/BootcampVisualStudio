# My C# MCSD Journey

This repo  is list of my projects i made during my boot camp for MCSD training. 


## Current work  ( focus)

Cureently developing console market app. 
Adding hash system for purchase verification 



## csharp console  / Console App 1 

This is most basic application i made for this boot camp. It aims to apply basic skills in C# using visual studio. IT includes simple loops and basic logical conditionings.

Added a simgle ascii game called dungeon crawler. Currently it only allows movement inside. 

It includes diffrent types of basic applications can be selected with user input and also a typo preventing system is being built for this application so it can midigate fat fingers like mine  :D

## ~~end of life for console  app1~~  
Console app 1 is ended.   
In recap it can make simple  logical comparations and maths. It uses loops. It uses a hashmap for input controls and  has a ascii game that can be controlled  w a s d. It tries to gues your selection if you just write first few chars of given command. It also has a basic control mechnaism to prevent you fromm putting in string or chars where int is need.  It was a basic starter work  



## secondConsoleApp

Uses better architecture much more inline with solid principles    


now your hero cant move out of dungeon in dungeon crawler ther is no escape 

Aims of project :

have better dungeon crawler   
have better typo preventtaion  
have some waht data retantion with either local or azure data base 


## NPAT Game
To better use OOP consepts a game exercise has been made. Basic npat game allows variable amount of users to play name animal place thing game. It requires passing around the pc between players, selects a random letter then asks everyone their word clears screen asks for next player. when game ends game distuributes point to duplicate answers, gives full points  to unique ones and no points to wrong answers. 



## Console Market

It is a shopping app but made without ui. It is all backend. uses diffrent concepts of backend even has a 3d secure mockup 

Some cool thing about this 
ıt creates a text in project file when you tryto make purchase and returns hash of that calue to verification system so you need to reach your files and put in the code and its hash is tested. 
Since i dont have a smtp server it just uses a text file as message
i have used text file instead of win form since i wnat it to work on linux too 


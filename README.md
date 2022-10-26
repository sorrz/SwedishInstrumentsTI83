# SwedishInstrumentsTI83
by Dan Stjärnborg

## What is this?
This is a simple calculator written in c# as a turnin for a school assignment.
It uses different variable types, is very overly complicated, and showcases some bad and good practices. 

It does however feature some good to know stuff, as how to ref a List between different functions and classes.
Aswell as basic Error handling, looping and condition testing. 

If you want to use it, you are free to fork or clone it - have fun! 

### Further Development
No further Development will be done to this project, I might eventually make a new calculator, just for fun and learning experiences.

## Post making Analysis
The project itself was a rahter fun one, even tho very basic. 
I found myself re-doing the calculator several times, becuase I wanted to have stuff formatted in another way.
I started using Switch statements, but when I changed the MainMenu Capture for History Listing (to fit the foreach loop to make it look good)
i just continued with if, elseif, elsefi, else, instead of redoing it a second time and making a switch. 

### Different Choices?
Looking back, I could probably have planned the project better, 
using a Design Pattern like a version of the Factory Method to do the Calculations and passing them back to a PlaceHolder
Before presenting it all on a MainScreen. Only using the "program.cs" as an entry point.
This would have made for a cleaner code and program overall.

I have documentet/commented the code farily well and so it should be easy to read and understand.


### Instructions for the assignment
Below are the instructions and checkpoints for the assignment.
During development I put them as TODO's and later moved them into the "readme" so I 
could have them easily asscible.

When working I've ticked them of and changed their status to "check" when they where done.
This was a great healp going back making sure I filled the criterias for the Assignment.

CHECK: Välkomnande meddelande

CHECK: En lista för att spara historik för räkningar

CHECK: Användaren matar in tal och matematiska operation

CHECK: OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!

CHECK: Ifall användaren skulle dela 0 med 0 visa Ogiltig inmatning!

CHECK: Lägga resultat till listan

CHECK: Visa resultat

CHECK: Fråga användaren om den vill visa tidigare resultat.

CHECK: Visa tidigare resultat

CHECK: Fråga användaren om den vill avsluta eller fortsätta.


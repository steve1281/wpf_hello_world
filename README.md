Hello World WPF 

Probably the simplest example that demonstrates displaying text, reading elements, and updating text.


Key things to remember (for this simple example):

- create the project, select WPF Application C#.  This creates a bunch of code for you. 
- ToolBox should be visible on the left (assuming default layout) whenever you edit an xaml file.
- You can drag and drop UI elements onto you form.  
- You can edit in the XAML source direct, or edit the properties in the panel to the left.
- Double click the element to inject code to handle the click event.


Adding Linq and Lambda:

- so SQL like commands map onto linq, and similar methods exist in the lambda notation
- sounds like M$ prefers Linq; my experience leans more toward lambda
- more on this later...

Things you don't need to remember, but might be useful later on:

- you can print to the visual studio debug using *Trace.Writeln("message");* 
- you can tell the project to launch a console, and then use *Console.Writeln ...*


Adding a branch:

- IDE has tools for this, or just *git checkout -b link_understanding_basics*
- Do the usual thing:  *git add .*, * git commit -m ...*
- if the branch needs to go to the remote, you will need to set upstream it. (e.g for a code review)
*git push --set-upstream origin linq_understanding_basics*
- after you do that once, you can just *push* it
- another approach, merge it to your local "main" and then push that. Depends on the team really.


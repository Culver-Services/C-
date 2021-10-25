1. Define Code-First (i.e., Google the term, read articles, watch videos, etc.).

-Entity Framework introduced the Code-First approach with Entity Framework 4.1. 

-Code-First is mainly useful in Domain Driven Design. In the Code-First approach, you focus on the domain of your application and start creating classes for your domain entity rather than design your database first and then create the classes which match your database design.

-The following figure illustrates the code-first approach. https://www.entityframeworktutorial.net/images/EF5/code-first.png

-As you can see in the above figure, EF API will create the database based on your domain classes and configuration. 
-This means you need to start coding first in C# or VB.NET and then EF will create the database from your code.

-Code-First Workflow
-The following figure illustrates the code-first development workflow. https://www.entityframeworktutorial.net/images/codefirst/dev-workflow.png
-The development workflow in the code-first approach would be: Create or modify domain classes 
-> configure these domain classes using Fluent-API or data annotation attributes 
-> -Create or update the database schema using automated migration or code-based migration.




2. Create a basic Entity Framework Code-First app that creates a basic Student database and adds one student.

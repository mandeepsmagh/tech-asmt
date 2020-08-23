# Match Text

## Requirements

Write an application that :

* Has a GUI

* Accepts two strings as input: one string is called "text" and the other is called "subtext" in this problem statement,

* Has a button which, when clicked, will match the subtext against the text, outputting the character positions of the beginning of each match for the subtext within the text.

* Allows multiple matches and case insensitive matching

## Assumptions

* GUI = Web application
  
## Implementation

* Solution implemented using Asp.net core 3.1 (Razor pages)

* Xunit based test project to validate action method result type

* Data annotation attributes for required values and only alphabets allowed as input.

* Github Action to build main project, can be extended for deployment to azure.

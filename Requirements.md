## Vision

**Code Talk** helps users learn how to "speak" code.

New developers often struggle with properly talking about code aloud. Are you supposed to mention the curly brackets? Are you missing a keyword when you describe the line of code? Should you be saying instantiate or invoke?

With **Code Talk** users can select from common lines of code, personalize some of the details and get a line of text they can say aloud.

Users can gain confidence in talking about code. Be it with having in depth conversations with fellow developers, or even helping them nail that whiteboard interview.

You can walk the walk. Now let **Code Talk** help you talk the talk.

---------------------------

### Scope (In/Out)

**IN**
- The app will allow users to choose from common code structures to translate into spoken code
- The app will ask users to fill in types, variable and method names to personalize the spoken code
- The app will provide users the ability to change existing spoken code lines to something they would prefer
- The app allows users to delete spoken code lines that they are no longer interested in saving

**OUT**
- This app will never have paid features. It is and always will be free to use.

---------------------------

### MVP

Users can CRUD spoken code snippets.

**Front-End**
- Allows user to select and personalize a line of code and send it to the API.
- User can update or delete lines of spoken code they have previously created.

**Back-End**
- API will take in a request and return a spoken code snippet.
- Spoken code snippets will be saved to database and can be queried.

---------------------------

### Stretch

- Expanding options of code lines users can choose from.
- Adding Azure API, Text to Speech, to allow users to hear their created spoken code snippets.

---------------------------

### Functional Requirements

- A user can create a spoken code snippet.
- A user can update a spoken code snippet.
- A user can search through previously created spoken code snippets.
- A user can delete a previously created spoken code snippet.

---------------------------

### Non-Functional Requirements

- Modifiability: App should be easy to build upon, as the database will be kept open ended. Allowing for stretch goals to be implemented without having to restructure the entire database.
- Usability: App should be intuitive to navigate and users should easily be able to get to their desired outcome. Users should be comfortable with app within 1 minute of use.

---------------------------

### Data Flow

1. User selects from a drop down menu, which common line of code user would like translated.
2. Selection will then display a corresponding form containing fields for any data types, variable names and method names. User will then fill out form.
3. User personalized form data will be sent out to the API from selected form page.
4. API will then find the matching common line of code's spoken snippet and plug in the form data.
5. API will save code spoken snippet into table.
6. Spoken code snippet will be returned to on results view.

Similar flows happen for deletes and updates.
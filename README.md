# Code Talk 

##### *Authors: Denevan Pettie, Jon Rice, Meggan Triplett, Richard Rosado*  

------------------------------

## Description  

**Code Talk** aids users in learning to coherently verbalize their code.

New developers often struggle to talk through their code with confidence.  **Code Talk** offers users the opportunity to select a customized line of code and receive feedback on how to vocalize the method and it's contents.

With **Code Talk** users can gain the confidence they need to establish connections through high level conversations with fellow developers.

------------------------------ 

## API  

Code Talk API :

https://github.com/code-talk-group/CodeTalkAPI  

## Homepage  

![CodeTalk](https://user-images.githubusercontent.com/47064974/61012251-89f8ff80-a332-11e9-87e3-5d35e0e36a12.png)


## Wireframes  

### *Home Page*
![IndexWire](https://user-images.githubusercontent.com/47064974/60835998-6a6aa700-a179-11e9-93cf-dbb0b95ce666.png)  

### *Results Page*
![ResultsWire](https://user-images.githubusercontent.com/47064974/60835992-676fb680-a179-11e9-8b94-27f6ca872e3e.png)  

-------------------------------

## User Stories  

***1. As a user, I want dropdown code options to easily create a syntactically correct method***

**Features:**
- User can select and input variable options into forms
- User can select mock code from the dropdown 
- After completing all required options, user can confirm valid code with a redirect to result

**Acceptance:**
- Ensure forms are linked to the dropdown
- Ensure all inputs are completed and valid before submitting code 

***2. As a user, I want to send a query to the API to update the results to reflect all of my previous searches***

**Features:**  
- User can view current result
- User can view previous results

**Acceptance:**  
- Ensure that each new result is reflected when results are viewed


***3. As a user, I want to update individual results to suit my understanding and personal preference***

**Features:**
- User can select a result to update
- User can update a selected result
- User can view updated results

**Acceptance:**
- Ensure correct entry is present in results
- Ensure that updated entry changes are reflected in results

***4. As a user, I want to input a code snippet and receive a gramatically correct sentence verbalizing my code.***

**Features:**
- User can select all input options to complete a method with syntactically correct code
- User can be directed to a result page
- User can view a sentence verbalizing their code

**Acceptance:**  
- Ensure that all inputs are completed to submit syntactically correct code
- Ensure that on submit, page redirects to result
- Ensure that sumbitted code returns relevant description of submitted code


***5. As a user, I want to send a query to the API to remove results which are no longer relevant to me.***

**Feature:**  
- User can view all previous results
- User can select a result to be deleted by the API

**Acceptance:**
- Ensure that all previous results are visible
- Ensure that selected result is no longer present on result page

------------------------------

## Getting Started
Clone this repository to your local machine.

$ git clone [https://github.com/code-talk-group/Code-Talk-FrontEnd.git]

-------------------------------

##### Annotation  

TBD

------------------------------

## Change Log  
 
TBD

-------------------------------  

## License  

MIT License
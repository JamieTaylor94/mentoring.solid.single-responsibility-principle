# Single Responsibility Principle (SRP)

## What is the Single Responsibility Principle?

[Learn here](https://medium.com/@ipapikas/solid-series-1-5-single-responsibility-principle-5a93f235f0c4#:~:text=The%20single%20responsibility%20principle%20states,entirely%20encapsulated%20by%20the%20class.&text=%E2%80%9CA%20class%20should%20have%20only%20one%20reason%20to%20change.%E2%80%9D)


## Practical 

A software engineer working for the government has thrown together a simple console application for Boris & friends to sign up to this year’s Christmas party. Unfortunately, this employee is off sick and having to self-isolate after getting a bit too close and personal with Matt Nobcock. 

Here are the requirements:

- As a party organiser I want users to be able to submit their name and email-address to register for the Christmas party.
- As a user I should be able to see a success message is displayed to the user when registered.
- As a party organiser I only want users of 18 years and over to be able to register.
- As a user I should be able to see that my registration has been rejected if I do not meet the age criteria.

The first two requirements has been completed but the application cannot go live without age restrictions. 

Hints:

- Age validation logic needs adding.
- A success message is displayed to the user when succesfully registered.
- The age validation should be in a new class and should be unit tested.

## Evidence for the matrix

Create a file called single-responsibility-principle.md

Answer the following questions:

What is single responsibility principle?   
Why do we use single responsibility principle?   

Insert a link that goes to that file in the repo in your GitHub account.


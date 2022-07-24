# NML Refactoring Test
## Introduction
Your team has implemented various types of notifiers that can send 
messages via email, Slack and Teams. A story for an implementation that
can send messages over SMS as been added to the sprint, which has come to you.

On inspecting the current implementation you realise that the existing 
implementations duplicate code. They also all follow the same pattern. It 
would therefore be prudent at this stage to refactor the existing notifiers
into an inheritance hierarchy. Once abstracted you will be able more easily 
implement the SMSNotifier. 

The current implementation should be self-explanatory. `AggregateNotifier` 
is responsible for invoking all notification channels configured for
a user with the received `NotificationMessage`.    

To complete the implementation of the `SmsNotifier`, you will need to use an 
instance of a `SmsApiClient` (found in the `Dependencies` directory), and an 
instance of a `SmsMessageBuilder` (found in the `MessageBuilders` directory).

# Time
This problem should take at most an hour and a half (1h 30m).

## Rules
  - You *must not*  change the names of any of the following:
    - Any of the types in the `Notifiers` directory
    - Any of the types the `MessageBuilders` directory
    - Any of the types in the `Dependencies` directory
  - You *must not*  change method or property signatures of any of the following:
    - `INotifier`
    - `AggregateNotifier`
    - `NotificationMessage`
    - Any of the types in the `Dependencies` directory
  - You *must not*  make any code changes to:
    - Any of the types in the `Dependencies` directory
    
 ## Submission
  - Upload you solution to Github as a public solution and send the URL to NML. 
  - Alternatively ZIP you solution and email to NML. 
  
  ## Additional Notes
  - You do not need to be able to run or debug this code to complete the challenge.
  - Follow the rules as outlined. You will *not* get a more favoured 
    evaluation if you attempt improve, change or rename any code specified 
    as off limits. We know you are a great coder already!
  - Ideally the solution should compile once you are done.
  - You can leave reasonable code comments if you feel we 
    will not understand your reasons for some implementation.
  - We recommend you keep to the time indicated above. If
    you run out of time, rather submit what you have been able
    to do up to that point. You can spend you free time on
    much better things than slaving away at this! We promise to fairly evaluate your 
    effort even if it isn't complete.    
     
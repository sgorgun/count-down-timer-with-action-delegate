# Count Down Timer with Action<> Delegate. 

Intermediate level task for practice events. 

Estimated time to complete the task - 45 min.  

The task requires .NET 6 SDK installed.  

## Task description

- You need to implement the `Timer` class for simulating a countdown clock. The Timer has the ability to send out messages with the information about  `Started`, `Tick` and `Stopped` events to other types subscribed to the events. Use `Action<>` delegates as event handler delegates. _Don't use the .NET System. Timer classes for the Timer implementation_.    
- The `Timer` class should have the following functionality:
    - When an object of the `Timer` class is constructed it has to be assigned:
        - Name (not a null or an empty string, otherwise the exception `ArgumentException` should be thrown);
        - Number of ticks (the number has to be greater than 0; otherwise, the exception  `ArgumentException` should be thrown).
    - After  the Timer has been created it should be called to Run. In response to Run, the Timer fires the `Started` event. The event should contain the information about the Timer's Name and the Number of ticks to be fired.
    - After firing the `Started` event, the Timer starts firing `Tick` events with the information abount the Timer's name and the number of ticks left to fire.  There should be delays between the `Tick` events. To emulate the delays between the `Tick` events, it is recommended to use the `Thread.Sleep` method.
    - After all `Tick` events have been fired, the Timer has to fire `Stopped` event, the event should contain the Timer's name information.

- You need to complete the  implementation of the `CountDownNotifier` class. This class consumes events from the `Timer`.  The implementation logic must check that when the object of `CountDownNotifier` class is created, the `null` is not passed as a parameter insted of the `Timer` object. 
- Provide the implementation of the [Factory methods](https://gitlab.com/epam-autocode-tasks/delegates-events-task/-/tree/master/CustomTimer/Factories) (see [Factory method theory](https://en.wikipedia.org/wiki/Factory_method_pattern)) to create objects of the `Timer` and `CountDownNotifier` classes.


## Task Checklist

* Build a solution in [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio?view=vs-2019). Make sure there are **no compiler errors and warnings**, fix these issues and rebuild the solution. 
* Run all unit tests with [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2019) and make sure there are **no failed unit tests**. Fix your code to [make all tests GREEN](https://stackoverflow.com/questions/276813/what-is-red-green-testing). 
* Review all your changes in the codebase **before** [staging the changes and creating a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits?view=azure-devops&tabs=visual-studio). 
* [Stage your changes, create a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits?view=azure-devops&tabs=visual-studio), and publish your changes to the remote repository. 

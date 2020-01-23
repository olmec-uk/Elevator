# Goal
The goal of this is excercise is to give us some code to talk about in a face to face interview. We're not looking for a specific approach or functionality. A more complete system doesn't mean it's better designed.

# Task
To write an implementation for an elevator to service requests

* Create implementations for [`IElevatorStatus`](Interfaces/IElevatorStatus.cs) and [`IElevatorControls`](Interfaces/IElevatorControls.cs)
* Bind the implimentatons using Ninject (https://github.com/ninject/Ninject/wiki/Dependency-Injection-With-Ninject)

The elevator should now run using the existing code

* When running the console application the elevator should move between floors servicing requests
* If any modifications are needed to the runner then feel free to make them. This isn't a perfect system
* Add people to the [list](ElevatorRunner/Program.cs#L23) to test different scenarios

The elevator is considered complete when it can move people from their initial floor to their desired floor

## Optional improvements / ideas
* An elevator can serve as many requests in one direction as it can before going the other way
* An elevator can be called to any floor at any time, but it need not immediately service that request
* Requests for the elevator to go in the opposite direction of travel for the elevator can be ignored until the elevator is traveling in that direction
* Any other changes you'd make to the system
* Display waiting people on a floor and/or people in the elevator

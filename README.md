# Observer-Pattern
I will show you a simple implementation of Observer Pattern based on .NET Events.

# Introduction
The observer pattern is simply a publish/subscribe relationship.
* The publisher is also referred to as the subject that we want to watch for a state change.
* Then we have one or more Subscribers, also referred to as Observers. These are the dependent objects that will be notified when the state changes.

# Real-World Observer
On Twitter, Follow capability allows up to setup an observer relationship whenever I follow someone on Twitter, whenever that person's state changes (by adding a tweet), I notified it. Not only me, everyone who is the follower gets notified.

# Consider Observers When?
* One object is dependent on the changes in another object.
* Changing in one Object requires changes to many others (other objects are monitoring one object).
* When changes to an object should allow notification to others without any knowledge of them.

# Intent
* Creates a separation b/w the subject & observer
* Allow multiple observers to react to changes to a single object.
# Structure
* The subject provides a way to Register, Un-Register, and Notify.
* Observer provides a way to Update.

# Summary
In this post, we saw one implementation of the observer pattern, which uses built-in .NET types. We learned a few terminologies, e.g., what is subject, what is observed, and learn that those are sometimes called publishers, subscribers, consumers, etc. Till next time, Happy Coding.

https://dzone.com/articles/observer-pattern-in-net

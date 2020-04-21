# CsharpConcept   [![Build Status](https://dev.azure.com/raju1234888/Csharp/_apis/build/status/EzDevPrac.CsharpConcept-Raju%20(1)?branchName=master)](https://dev.azure.com/raju1234888/Csharp/_build/latest?definitionId=5&branchName=master)



### Design Pattern
Design pattern is basically of three types.
A design pattern is a general, reusable solution to a commonly occurring problem within a given context in software design.

Design pattern is basically of three types.

`Creational Design Patterns`
`Structural Design Patterns`
`Behavior Design Patterns`

### Facade Design Pattern.

Facade Design Pattern is part of the structural design pattern family. 
1. It is used to simplify the interaction process.
2. Subclass are independent classes.
3. Facade has refrence to these class.
4. Subclass don't have refrence to facade class.
5. Make easierr to create to subclasses due to loose coupling between the subclasses.
6. Act as entry point for each subclasses.

**Go and read this you will enjoy it and can easily grasp the idea behind facade design pattern.**


> Story mode.\
>**For eg...**

>Raju is trying to create an e-commerce website. He finds that many actions are performed by the buyer or the client in this short interval of time. In that short interval a client has to make an order, make payment and wait for the delivery he thinks.<br/>

**These are in general even many more services that are performed during this time.**

>He created class of three services `PaymentService`, and `InventoryService` and linked these with the MainController class. 
After some time he finds that he needed one more subclass ShippingService for delivery status. So he created and linked with the other classes. But he finds that it was very disturbing because of the tight coupling of the classes with each other. 

**Here the client directly interacts with the subclasses and every other classes are tightly coupled.**

 >Every time he do some changes he has to alter every class. 
 
**And to solve this problem facade design pattern is introduced. It simplifies the complexity**.

>After some time he called his friend Srini and explained everything. Srini told him to go through the Facade Design Pattern. So he started looking through the pattern. After some time he was astonished that these problems can be easily solved using this pattern.

**And to solve this problem facade design pattern is introduced. It simplify the complexity. In other sense every service class such as payment, inventory availability,
delivery status will independent. These classes are linked to the facade class. Facade has a reference to every subclass but the subclass don't have a link to the facade.**

>So he created an interface named IOrderServiceFacade. And he implemented that in another class called facade. This facade class has reference to every other subclasses.

**The user will interact with facade class and then the facade class will interact with other subclasses such as inventory, delivery, payment etc. **
  
>So every time client makes an interface with facade class and this class make communicates with every other subclass. Now he doesn't need to change every other subclass to create new subclasses.


### Simple Class Diagram Of facade pattern Implementation.


![FascadePattern](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/b1f8717becfa80ad883f1fbb3a8dfeba/FascadePattern.png)

Go Checkout and play with it [Simple example](https://github.com/EzDevPrac/CsharpConcept-Raju/tree/master/Facade)

---


### Builder design pattern.

 **Builder design pattern which is one of the Creational Design Patterns. Builder design pattern is used to create complex object**.

>>>
The builder pattern allows you to enforce a step-by-step process to construct a complex object as a finished product. In this pattern, the step-by-step construction process remains same but the finished products can have different representations.
>>>
**An example of builder design pattern is given below.**

Checkout and play with it [Simple example](https://github.com/EzDevPrac/CsharpConcept-Raju/tree/master/Builder)



# CsharpConcept   [![Build Status](https://dev.azure.com/raju1234888/Csharp/_apis/build/status/EzDevPrac.CsharpConcept-Raju%20(1)?branchName=master)](https://dev.azure.com/raju1234888/Csharp/_build/latest?definitionId=5&branchName=master)




# Object-Oriented Programming in C#.


## What is OOP?
Well, OOP is a programming Paradigm in which every program is considered as a part or as an object.
*For instance, when we develop a Banking Application then everything in this context we will consider as an object. And each object will talk to each other.Such as A Bank Customer will talk to a Bank Employee. And every Bank Employee can talk to the Bank Manager, even the Customer can talk to the Manager.Here The Customer, Employee, and Manager can be taken as an Object.*

## Why OOP?
First of all, if we go and look before the OOPs, it was mostly a structural or procedural way of solving the problem. And OOPs have certain advantages over them such as data hiding, code reusability was not available in structural programming.While even maintainability is much easier in case of OOP.

### Features of OOPs
  - **Abstraction**
  - **Encapsulation**
  - **Inheritance**
  - **Polymorphism**


## Abstraction:

  - **What!**
  
 It is a process of hiding the implementation part and exposing or showing only the necessary details through the help of methods or properties. It is achieved by using the abstract keyword. Abstraction can be possible without the use of abstract keyword also. Complete abstraction can be gained by using an interface.

- **Why!**   
  - Help to hide or encapsulate the unnecessary logic.
  - Help to increase security by only exposing the necessary details.
  - Increase the code reusability and code duplication is avoided.
  - Helps to reuse methods without knowing the logic part.

- **When!**
  - In case when we only want to provide the functionality of what my method does rather than how it does.
*For instance, we don't know the logical implementation of the Console.WriteLine But we still able to use it.*

## Encapsulation:

 - **What!**
 
 Encapsulation is a process of limiting the scope of data members by binding these data members to some methods or behavior. It is achieved by using access modifiers. These data members can be only accessed through the behaviors and properties.

- **Why!**
  - It provides loose coupling.
  - Gives the concept of Modularity. i.e Every program is considered as a separate module.
  - Data Security is increased due to the scope limitation.

- **When!**
  - In case when you want that your data member should not take any corrupted or garbage value and to prevent unauthorized access this data member is given access through some behavior that contains the logic solution for verifying this.
  - When you want to separate every component as a module.

## Inheritance:

- **What!**

 Inheritance is one of the key features of OOPs which allow us to inherit the field(instance variable) and property of another class. In real-time the blood relation is the most clearest and best example of inheritance.

- **Why!**
  - Code Reusability.
  - Common Functionality.
  
- **When!**
  - When we want to have common functionality in multiple classes.

## Polymorphism:

- **What!**

It is a process of redefining a method by keeping the same name and same or different implementation. It can be achieved in two ways...

   - Overloading
   - Overriding

- **Why!**
  - Code Flexibility

- **When!**
  - When we want to have a common name for different operations.
## Overloading(Compile-time, Early binding, Static binding)
                    

                                                              **STILL Under Update** 


---



#  Dependency Injection(DI) & Inversion of Control (IoC)

- What is Dependency Injection?
- What is Inversion of Control?
- Types of DI.
- More READ.



## What is Dependency Injection?

As the word dependent means to take support of something or someone and Injection refer to inject something. **So, we can say that Dependency Injection is a process of injecting something with the help of someone or something**. 

### Important Read:-
>*Suppose you are ill and you need an injection to be cured but you know that you can't do it by yourself so you went to the doctor and asked for his help. Now you are dependent on the doctor for the medicine to be injected to you through injection.*

## Principles

Dependency Injection is based on the letter  **D** in the **SOLID** principles. D stand for [Dependency inversion principle](https://en.wikipedia.org/wiki/Dependency_inversion_principle "Dependency inversion principle"). 

## Inversion of Control
As the word Inversion describes a condition where something is turned upside down. Inversion of Control also describes a condition where the control is changed.

### Important Read:-
>*Before marriage you are controlling the house. After marriage your wife is controlling the house*.

It is based on the **Hollywood Principle**.

Dependency Injection is at the **micro** level and Inversion of Control is at the **macro** level.

_“**Inversion of control is principal and Dependency Injection is implementation**”_.

### Types of Dependency Injection 

-  [Constructor](https://softwareengineering.stackexchange.com/questions/177649/what-is-constructor-injection)
-   Setter (Properties)
-   Method. 

### MORE READ
- https://www.freecodecamp.org/news/a-quick-intro-to-dependency-injection-what-it-is-and-when-to-use-it-7578c84fa88f/
- https://github.com/ninject/ninject/wiki/Dependency-Injection-By-Hand
- https://blog.ploeh.dk/
- https://stackoverflow.com/questions/130794/what-is-dependency-injection
- https://martinfowler.com/articles/injection.html


---


# Design Pattern
Design pattern is basically of three types.
A design pattern is a general, reusable solution to a commonly occurring problem within a given context in software design.

Design pattern is basically of three types.

`Creational Design Patterns`
`Structural Design Patterns`
`Behavior Design Patterns`


---
## Strategy Pattern

- What is Strategy Pattern?
- Real World Application.
- Class Diagram.
-  Pseudocode.
 - What are benefits?

### What is Strategy Pattern?

Strategy Pattern is one **behavior design pattern** that lets you help in make decision over a various plan or strategy. It is based upon the open closed principle. It provides you to set which strategy you want to take during the runtime.

### Real World Application.

*Suppose you are going to your home from school and you know that there is two different path for going home. Path A is little long and Path B is short. For reaching home you have to decide which path you have to take either Path A or either Path B.*


### Class Diagram.

![Class diagram](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/56d39e0afc85c8156ac7db163a42e1f6/Stategy.png)

### Pseudocode.

    > strategy.sln
  
  ```csharp

interface IStrategy    //implement an interface
    {
        object PerformAlgorithm(object data);
    }


 class SortingMathodA : IStrategy   //ConcreteStrategyA
 {
 write your sorting method
 }


 class SortingMathodB : IStrategy   //ConcreteStrategyB
 {
 write your sorting method
 }


  class Context
  {
  public Context() { }       //create a Context contructor 
  
   public void SetStrategy(IStrategy strategy)
        {
            this.Strategy = strategy;   // Set your sortingmethod
        }
  define somemethod
  
  }


  class Client
  {
  Call the context class       // var Context = new Context();
  select the sorting method
    if(sortingMethod == A)
  call the context class and pass this sorting method A.
    if(sortingMethod == B)
  call the context class and pass this sorting method B.
  print result;
  }


  class Driver
  {
  static void Main(string[] args)
        {
            new Client().Main();  //implement main
        }
  }
   ```


### What are benefits?
- used to alter the behavior of the object at run time.
- have lot of class only differ in only way to execute.
- use it to isolate business layer.

### IMp Point.
    * Comes under behavioral design pattern.
    * Follow Open/Closed Principle.
    * Used to take decision at run time.
    
### More Read
https://en.wikipedia.org/wiki/Open%E2%80%93closed_principle <br/>
https://en.wikipedia.org/wiki/Strategy_pattern <br/>
http://w3sdesign.com/?gr=b09&ugr=proble


---


### Decorator Pattern

Decorator design pattern is one of the **structural design pattern**.As it name specifies it is used to decorate an object with different behaviors.

>  Points to remember 
- Used to load different behavior dynamically with an object .
- One of the structural design pattern.
- Comes handy when you think better way to implement inheritance.
- Follow [Open closed Principle](https://en.wikipedia.org/wiki/Open%E2%80%93closed_principle)
- Easy to modify the classes and it's dependency

### Story Mode:

*This is the story of a Cat named Tom(Many of you may have heard it) a genius programmer. He has a shop of flower bouquet. Tom was designing software for managing his shop and to provide different types of flower bouquet. He was designing his software and writing classes for different types of flower bouquet and during that interval a girl named Terena and his friend Lavanya came and asked do you also decorate these flower bouquet? Tom replied yes we do. And as per the requirement Tom has sold the flower bouquet. Then Tom went on writing the software suddenly this incident struck his mind and he thought that for every type of flower bouquet he needs to add different types of decoration. (**For an example for RoseBouquet there can be n no of decoration such as GlitterRoseBouquet, Paperwrapperbonquet, etc**). So he started thinking that every time he needs to add some new flower or new decoration he needs to modify the overall class. So he started searching on the internet and found help on the book written by [(GoF)](https://en.wikipedia.org/wiki/Design_Patterns). In that he read about decorator patterns which allow him to create an object dynamically with different behavior. He thought to implement this pattern in his software. And he was successful and after that whenever some new decoration comes he just add a class and pass that class behavior to flower bouquet object.*

 

---



### Singleton Pattern

Singleton design pattern is one of the **creational design patterns**. As its name specifies it only be **instantiated** only once. It is useful when the following cases arise.

- When only one instance of a class is created.
- Provide a global access point to this instance.

 **A simple flow of Score calculator in different cases while playing games. I have a `Runningclass` named `Trackscore` and a `killingclass` name `KillScore`. And a `ScoreManager class` which will only create a single instance and provide global access to manage all score during gameplay.**
 
![Flow diagram](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/d103afe7da75dec83b9af9480dd51093/SingletonPattern.png)


*Here is the simple example go play with it [EagerInitilization](https://github.com/EzDevPrac/CsharpConcept-Raju/tree/master/EagerInitilization) and [LazyInitialization](https://github.com/EzDevPrac/CsharpConcept-Raju/tree/master/LazyInitialization)*

---


### Facade Design Pattern.

Facade Design Pattern is part of the **structural design pattern** family. 
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



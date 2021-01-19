# Fake Zoo
Authors: Michael Falk, Scott Falbo <br>
*version 1.0.0*


## Overview
We are creating a fake zoo to practice Object Oriented Programming where in, each creature is derived from a classification class, which is derived from an animal class.

The exercise is to practice working with `abstract` and `virtual` properties as well as `override`.


## Getting Started
+ `git clone https://github.com/MikeyFalk/Lab06-OOP-Principles-.git`
+ This app has no implementation at present


## Example



## Architecture
+ `Animal()`
  + `Mythic()`
    + `Unicorn()`
    + `Dragon()`
    + `Gryphon()`
  + `OfThisRealm()`
    + `Wombat()`
    + `HoneyBadger()`

<br>

![FakeZoo UML](./assets/Imaginary_Zoo.jpg)

## Change Log

+ version 1.0.0 - *01/18/2021 4:45pm* -
  + Created the UML for the application
  + Built the top level `abstract Animal()` class.
  + Derived two classes from the `Animal()` class.
    + `abstract Mythical()`
    + `abstract OfThisWorld()`
+ version 1.0.1 - *01/18/2021 6:15pm* - 
  + Derived three concrete class from `Mythical()`:
    + `Unicorn()`
    + `Dragon()`
    + `Gryphon()`
  + Derived two concrete classes from `OfThisWorld()`:
    + `Wombat`
    + `HoneyBadger`
  + Each concrete class defines the `abstract` properties and in some cases `overrides` the `virtual` properties.
  
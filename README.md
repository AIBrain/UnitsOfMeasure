Type Safe Units of Measure
==========================

A series of type definitions and monads written in C# for enforcing type
safety between units of measures and providing compile-time type checking
of operations on units of measure. Additionally, it provides automatic
conversion between common unit standards.

Unfortunately, this code is a little obtuse because of how C# generics
work. There is no good way to make a class generic to numbers, so I've
punted and just made everything a double precision floating point.

The library is meant to strictly encode every interaction between classes
of units. For example, while it is obvious that one should not add a
Mass to a Velocity, it's less obvious that one should not add a Velocity
to a Velocity. The correct operation is to add a Change in Velocity to a
Velocity. Subtracting two Velocities will give a Change in Velocity in
return. Dividing a Change in Velocity by a Change in Time should result
in an Acceleration. Multiplying an Acceleration by a Change in Time
should result in a Change in Velocity.

Halp!
=====
I'm a programmer, not a physicist. I have a good handle on arithmetic
and other fields of mathematics, but my recollection of the physical
properties and their relationships is rusty. I could use some help building
the code out to fulfill as much as possible, and to make sure the semantics
of some of the composite types make sense.
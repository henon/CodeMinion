![CodeMinion](art/code_minion-128x128-trans.png)

# CodeMinion
A code generator framework written by the SciSharp team to generate the APIs of several SciSharp libraries. You code the intersting parts, the minion writes the rest for you.

The framework consists of two different code generators:
* **The Minion**
* **Regen**

## The Minion
The Minion is capable of generating the source code of entire libraries from model definitions and is currently specialized on wrapping Python libraries using Pythonnet. The model definitions are usually harvested off of HTML documentation pages. 

### Generated by the Minion
These libraries have been generated by CodeMinion from Python docs:
* [Numpy.NET](https://github.com/SciSharp/Numpy.NET) ... 39,103 lines of code (mostly done)
* [Torch.NET](https://github.com/SciSharp/Torch.NET) ... 10,767 lines of code (work in progress)
* [Keras.NET](https://github.com/SciSharp/Keras.NET) ... 7,573 lines of code (mostly done)
* [SpaCy.NET](https://github.com/SciSharp/SpaCy.NET) ... (work in progress)

## Regen

Regen is a template compiler allowing to expand in-line templates to be compiled into C# code and inserted into the same source file. It is mainly used to generate repetitive code - for instance the efficient handling of primitive types without boxing requires a branch for every type that executes the same operation. 

Regen comes with a handy Visual Studio plugin which compiles embedded `regen-lang` templates in your C# source files. 

Jump to [Regen's readme](https://github.com/SciSharp/CodeMinion/tree/master/src/Regen.Core).

### Powered by Regen
These libraries heavily rely on Regen:
* [NumSharp](https://github.com/SciSharp/NumSharp)

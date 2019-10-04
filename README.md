### Prerequisites
-  [Mono C# Compiler](https://www.mono-project.com/download/stable/)

### Description
These are some exercises to better understand programming concepts in C#
1. Animal - Inheritance and polymorphism through method overriding.
2. New vs Override - Shows what happens when you forget not include the override keyword. In order to do this intentionally and avoid the warning use the new keyword
    ### Without the `override` keyword
    ```bash
      mono ForgotOverride.exe
    ```
    Output
    ```bash
      Base
      Sub
      Base
    ```

    ### With the `override` keyword
    The Name property is not merely hidden it is overridden
    ```bash
      mono WithOverride.exe
    ```
    Output
    ```bash
      Base
      Sub
      Sub
    ```
    ### With intention not to use the `override` keyword use the `new` keyword
    Using the `new` keyword gives the same result as not including the `override` but gets rid of the warning . It is rarely used.
    Output
    ```bash
      Base
      Sub
      Base
    ```

### Run the Animal folder
* Change directory to the specific folder
* Run the .exe file using mono C# compiler

For example

```bash
  cd Animal/
  mono Animal.exe
```

### Run the Collections folder
* Change directory to the Collections folder
* Change directory to the specific folder
* Run the .cs file using csharp command

For example

```bash
  cd Collections/JaggedArrays/
  csharp Cell.cs
```

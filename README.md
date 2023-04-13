<div dir='rtl' align="center">
In the name of the Lord who guides to the right path

   University of Esfahan

   Data Building - Dr. Ramezani

   Autumn 01-02

   The third project - calculator


<img src="https://s25.picofile.com/file/8455118076/Picture55.png" hieght="500"/>
  
   Project designers: Amir Ali Goli - Mohammad Tawakli - Alireza Sai - Hossein Aliturkan
</div>


<div dir='rtl' align="justify">
  
### Topic: Stack
  
Project goals:
+ Work with stack data structures
+ Familiarity with interjections and suffixes

  ----------
In this project, we are going to simulate the performance of a calculator. You must implement addition (+), subtraction (-), multiplication (*), division (/), power (^).

Be careful that the input numbers can be of decimal type and your program must use "." (auditor) to support.

   Considering that the calculator should also support the parentheses of the expressions, calculate the parentheses and priority of the expressions with the help of the data stack structure.
 
You have to implement the data stack building class yourself and using ready-made classes is not allowed!

Tips:
One of the ways to calculate expressions is to convert them into postfix form.

### Error handling
  If the given expression does not have the correct and standardized format, for example, the parentheses are wrong or the operators are not used correctly, you should print an error and then manage it.
  Examples of incorrect entries that should print an error:
 
  <div dir='ltr' align="justify">


  ```

  )(3+1)*2
  (((2+5)^2)+4
  5+3
  +5^
  0.5

  ```


  </div>

### Entrance:
A mathematical expression consists of rational numbers and parentheses "()" and the desired operators, which are given as a string.
### Output:
A number that is the result of the given mathematical expression or an error message if there is an error.
 
   <div dir='ltr' align="justify">


    Input 1:

  ```
   (1+3) * 2^2
```

  Output statement 1:

```
   16
```

   Input 2:

```
   -(-(2^3))/4+1
```

   Output statement 2:

```
   3
```

   Entry 3:

```
   -(((1+2)*(-3))^(1+1))
```

   Output statement 3:

```
   -81
```

   Input 4:

```
   (2+3)
```

   Output statement 4:

```
   error
```

   Input 5:

```
   3+4^
```

   Output statement 5:

```
   error
```

   Input 6:

```
   ((1.4+1.6)*10)/100
```
   
   Output statement 6:

```
   0.3
```
  
   </div>

## History
  Your calculator should print the status of the expression at each step of the calculation.

Print calculation steps:
 
  Step 1:

4*(2^3)<br>


  Step 2:
 
  4*8<br>


  Step 3:
 
  32<br>


  Final answer:<br>


  32<br>
  <br>



## Bonus section:
To implement this part, you must have an option called "add new operator" in the menu of your program so that you can define desired operators and add them to the calculator and use them in calculations.
  The way to define the new operator will be as follows:

   <div dir='ltr' align="justify">
    
  add new operator <br>
a Comp b = 2*a+b<br>
 


  add new operator<br>
a trick b = a^b/b<br>


 
add new operator<br>
a square b = a^2+b^2<br>
   </div>
  
  ### Other additions:
+ Beautiful graphics for the calculator itself
+ Adding scientific calculator operators and entering mathematical functions (sine, derivative)
+ Drawing graphs of functions
<hr>


### Additional notes:
+ This project must be implemented by a single person.
+ The project implementation platform is on GitHub.
+ Try to do each part in a separate commit.
+ Compliance with the principles of clean coding takes a large part of the grade and if the code is completely implemented in an unprincipled way. It will not be delivered.
+ The use of any language, framework and graphical interfaces is completely free.
+ People who use new technologies will be given an additional renewal token.
+ You will receive an additional token by implementing each point item.
+ Timely analyze the calculation part of the expression and commit and push its analysis in a separate branch compared to the project branch.

  </div>

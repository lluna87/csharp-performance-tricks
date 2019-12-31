## Return character counts in a given input string  
  
Write a method *GetCharacterCount*  in the class *Exercise* that expects a string parameter called name and does the following:  
  
For every unique character in the name, count how many times that character occurs in the name. Return a dictionary with each unique character in the name as key, and the count of how many times that character appears in the name as the value. Ignore spaces and treat all characters as lower case.  
  
So for the input string "John Doe", I expect the following output:    
'j':1  
'o':2  
'h':1  
'n':1  
'd':1  
'e':1    
Requirements: your code _cannot_ use boxing or unboxing  
The exercise.cs file contains one or more errors. It returns invalid output, but it also introduces boxing and unboxing in the compiled code. Your task is to remove all errors. Make sure you return the correct output, and ensure that the compiler will not introduce BOX or UNBOX operations anywhere.
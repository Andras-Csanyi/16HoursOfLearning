package com.andrascsanyi.practice.fizzbuzz;

// TODO: input validation

public class FizzBuzz {
  public String fizzBuzz(Integer input) {
    String fizz = "fizz";
    String buzz = "buzz";
    
    if (input%3 == 0 && input%5 == 0) {
      return fizz + "-" + buzz;
    }
    
    if(input%3 == 0){
      return fizz;
    }
    
    if(input%5 == 0) {
      return buzz;
    }
    
    return "";
    
  }
}

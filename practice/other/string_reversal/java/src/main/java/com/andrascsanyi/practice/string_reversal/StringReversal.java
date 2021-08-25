package com.andrascsanyi.practice.string_reversal;


public class StringReversal {

  public String reverseWithStringBuilder(String input){
    String toLower = input.toLowerCase();
    StringBuilder builder = new StringBuilder(toLower);
    return builder.reverse().toString();
  }

  public String reverseWithLoop(String input) {
    String toLower = input.toLowerCase();
    StringBuilder builder = new StringBuilder();
    for (int i = toLower.length()-1; i >= 0; i--) {
      char element = toLower.charAt(i);
      System.out.println(element);
      builder.append(element);
    }
    return builder.toString();
  }
}

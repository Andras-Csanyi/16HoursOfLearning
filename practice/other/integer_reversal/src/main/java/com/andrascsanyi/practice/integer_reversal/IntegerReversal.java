package com.andrascsanyi.practice.integer_reversal;

public class IntegerReversal {

  public Integer reverseLoop(Integer input){
    StringBuilder builder = new StringBuilder();
    String inputString = input.toString();
    Boolean isNegative = false;
    char negative = '-';

    if(inputString.charAt(0) == negative){
      isNegative = true;
      String negativeSignedChopped = inputString.substring(1);
      builder.append(negativeSignedChopped);
    } else {
      builder.append(inputString);
    }

    builder.reverse();

    // remove leading zeros
    for (int i = 0; i < builder.length() -1; i++){
      if(builder.charAt(i) == '0'){
        builder.replace(i, i, "");
      }
    }

    if(isNegative) {
      builder.insert(0, '-');
    }

    String result = builder.toString();
    Integer intRes = Integer.parseInt(result);
    return intRes;
  }

  public Integer reverse(Integer input) {
    return Integer.reverse(input);
  }
}

package com.andrascsanyi.practice;

public class TwoSum {
  public Integer[] bruteForce(Integer[] intArray, Integer twoSum) {
    for (int i = 0; i < intArray.length; i++) {
      for (int k = i + 1; k < intArray.length; k++) {
        Integer ii = intArray[i];
        Integer kk = intArray[k];
        if (intArray[i] + intArray[k] == twoSum) {
          return new Integer[]{i, k};
        }
      }
    }
    return null;
  }
}

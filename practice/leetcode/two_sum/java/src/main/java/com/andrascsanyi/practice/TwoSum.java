package com.andrascsanyi.practice;

import java.util.HashMap;
import java.util.Map;

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

  public Integer[] optimalSolution(Integer[] intArray, Integer twoSum) {
    Map<Integer, Integer> alreadyComputed = new HashMap<>();
    for (int i = 0; i < intArray.length; i++) {
      if (alreadyComputed.containsKey(twoSum - intArray[i])) {
        Integer entry = alreadyComputed.get(twoSum - intArray[i]);
        return new Integer[]{entry, i};
      } else {
        alreadyComputed.put(intArray[i], i);
      }
    }
    return null;
  }
}

package com.andrascsanyi.practice;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class CountVowels {
  public Integer count(String input) {
    // TODO: input validation

    Integer result = 0;
    List<String> vowels = Arrays.asList("e", "u", "i", "o", "a");
    for (int i = 0; i < input.length(); i++) {
      char charAt = input.charAt(i);

      if (vowels.contains(String.valueOf(charAt))) {
        result += 1;
      }
    }

    return result;
  }
}

package com.andrascsanyi.practice.charcount;

import static java.lang.Math.toIntExact;

import java.util.HashMap;

// TODO: validation

public class CharCounter {

  public Integer countCharByLoop(String input, char character) {
    Integer result = 0;
    char characterLowerCase = Character.toLowerCase(character);
    char[] inputCharArray = input.toLowerCase().toCharArray();
    for (int i = 0; i < input.length(); i++) {
      if (inputCharArray[i] == characterLowerCase) {
        result++;
      }
    }
    return result;
  }

  // TODO:
  // check other way of casting long to int, boundaries!!!

  public Integer countCharByStream(String input, char character) {
    char characterLowerCase = Character.toLowerCase(character);
    long res = input.toLowerCase().chars().filter(ch -> ch == characterLowerCase).count();
    int result = toIntExact(res);
    return result;
  }

  public HashMap<Character, Long> countOccurencesByLoop(String input) {
    HashMap<Character, Long> result = new HashMap<>();
    char[] charArray = input.toLowerCase().toCharArray();
    for (int i = 0; i < charArray.length; i++) {
      char elem = charArray[i];
      if (!result.containsKey(elem)) {
        long occ = input.toLowerCase().chars().filter(ch -> ch == elem).count();
        result.put(elem, occ);
      }
    }
    return result;
  }

}

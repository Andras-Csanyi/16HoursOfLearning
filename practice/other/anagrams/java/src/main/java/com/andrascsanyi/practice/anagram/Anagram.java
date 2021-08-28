package com.andrascsanyi.practice.anagram;

import java.util.HashMap;

public class Anagram {
  public Boolean isAnagramOf(String example, String pattern) {
    String cleanExample = cleanForAnagramCheck(example);
    String cleanPattern = cleanForAnagramCheck(pattern);

    HashMap<String, Integer> charMapExample = createCharMap(cleanExample);
    HashMap<String, Integer> charMapPattern = createCharMap(cleanPattern);
    
    if(charMapExample.equals(charMapPattern)) {
      return true;
    }
    return false;
  }
  
  private HashMap<String, Integer> createCharMap(String input) {
    char[] chars = input.toLowerCase().toCharArray();
    HashMap<String, Integer> result = new HashMap<>();
    
    for (char c : chars) {
      if(result.containsKey(String.valueOf(c))) {
        Integer occurence = result.get(String.valueOf(c));
        occurence++;
        result.replace(String.valueOf(c), occurence);
      } else {
        result.put(String.valueOf(c), 1);
      }
    }
    
    return result;
  }
  
  private String cleanForAnagramCheck(String input) {
    return input.replaceAll("[^a-zA-Z0-9]", "");
  }
}

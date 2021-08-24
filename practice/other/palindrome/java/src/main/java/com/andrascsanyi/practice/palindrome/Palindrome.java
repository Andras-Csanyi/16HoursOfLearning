package com.andrascsanyi.practice.palindrome;

import java.util.Locale;

public class Palindrome {

  public Boolean isPalindromeByStringReversal(String inputString) {

    String replaceResult = sanitizeCharacters(inputString);

    StringBuilder stringBuilder = new StringBuilder(replaceResult);
    String reversed = stringBuilder.reverse().toString();

    if (reversed.equals(replaceResult)) {
      return true;
    }

    return false;

  }

  public Boolean isPalindromeByIteration(String inputString) {
    String sanitized = sanitizeCharacters(inputString);

    for (int i = 0; i < sanitized.length()-1/2; i++){
      if(sanitized.charAt(i) != sanitized.charAt(sanitized.length()-1-i)){
        return false;
      }
    }
    return true;
  }

  private String sanitizeCharacters(String inputString) {
    String replaceResult = inputString
        .replace(".", "")
        .replace("!", "")
        .replace("?", "")
        .replace(",", "")
        .replace(" ", "")
        .replace("'", "")
        .toLowerCase();
    return replaceResult;
  }


}

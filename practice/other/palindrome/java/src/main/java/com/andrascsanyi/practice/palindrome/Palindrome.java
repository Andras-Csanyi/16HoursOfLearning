package com.andrascsanyi.practice.palindrome;

import java.util.Locale;

public class Palindrome {

  public Boolean isPalindromeByStringReversal(String inputString) {

    String replaceResult = inputString
        .replace(".", "")
        .replace("!", "")
        .replace("?", "")
        .replace(",", "")
        .replace(" ", "")
        .replace("'", "")
        .toLowerCase();

    StringBuilder stringBuilder = new StringBuilder(replaceResult);
    String reversed = stringBuilder.reverse().toString();

    if (reversed.equals(replaceResult)) {
      return true;
    }

    return false;

  }
}

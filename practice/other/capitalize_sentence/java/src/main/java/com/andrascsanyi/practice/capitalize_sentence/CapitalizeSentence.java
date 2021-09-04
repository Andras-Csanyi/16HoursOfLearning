package com.andrascsanyi.practice.capitalize_sentence;

import java.util.ArrayList;
import java.util.Arrays;

public class CapitalizeSentence {

  // TODO: input validation
  public String capitalize(String input) {
    String[] splits = input.split(" ");
    StringBuilder res = new StringBuilder();

    for (int i = 0; i < splits.length; i++) {
      String piece = splits[i];

      res.append(String.valueOf(piece.charAt(0)).toUpperCase());
      res.append(piece.substring(1));

      if (i != splits.length - 1) {
        res.append(" ");
      }
    }

    return res.toString();
  }

  public String capitalizeSecondVersion(String input) {
    char[] chars = input.toCharArray();
    StringBuilder builder = new StringBuilder();

    for (int i = 0; i < chars.length; i++) {

      if (i == 0) {
        builder.append(Character.toUpperCase(chars[i]));
      }

      if (i >= 1) {
        if (Character.isWhitespace(chars[i - 1])) {
          builder.append(Character.toUpperCase(chars[i]));
        } else {
          builder.append(chars[i]);
        }

      }
    }
    return builder.toString();
  }

  public String capitalizeThirdVersion(String input) {
    char[] chars = input.toCharArray();
    StringBuilder builder = new StringBuilder();
    builder.append(Character.toUpperCase(chars[0]));

    for (int i = 1; i < chars.length; i++) {

        if (Character.isWhitespace(chars[i - 1])) {
          builder.append(Character.toUpperCase(chars[i]));
        } else {
          builder.append(chars[i]);
        }

    }
    return builder.toString();
  }
}

package com.andrascsanyi.practice;

import java.util.ArrayList;

public class Pyramid {
  public ArrayList<String> build(Integer height) {
    ArrayList<String> result = new ArrayList<>();

    int hashmarkCounter = 1;
    for (int i = 0; i < height; i++) {

      int fillUpOneSide = height - i - 1;

      StringBuilder lineBuilder = new StringBuilder();
      for (int j = 0; j < fillUpOneSide; j++) {
        lineBuilder.append(" ");
      }

      for (int k = 0; k < hashmarkCounter; k++) {
        lineBuilder.append("#");
      }
      hashmarkCounter += 2;

      for (int j = 0; j < fillUpOneSide; j++) {
        lineBuilder.append(" ");
      }

      result.add(lineBuilder.toString());
    }

    return result;
  }
}

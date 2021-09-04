package com.andrascsanyi.practice.step_shape;

import java.util.ArrayList;

public class StepShape {
  public ArrayList<String> steps(Integer steps) {
    ArrayList<String> result = new ArrayList<>();

    for (int i = steps; i > 0; i--) {
      StringBuilder singleLineBuilder = new StringBuilder();

      int hashmarks = steps - i + 1;
      int spaces = steps - hashmarks;

      for (int j = 0; j < hashmarks; j++) {
        singleLineBuilder.append("#");
      }

      for (int k = 0; k < spaces; k++) {
        singleLineBuilder.append(" ");
      }

      result.add(singleLineBuilder.toString());
    }

    return result;
  }
}

package com.andrascsanyi.practice;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class SpiralMatrix {
  public ArrayList<ArrayList<String>> create(Integer input) {
    // input check
    List<List<String>> result = null;

    for (int i = 0; i < input; i++) {
      List<String> singleLine = Arrays.asList(new String[input]);
      result.add(singleLine);
    }
    
    return null;
  }

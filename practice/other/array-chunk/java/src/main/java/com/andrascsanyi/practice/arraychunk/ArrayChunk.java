package com.andrascsanyi.practice.arraychunk;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class ArrayChunk {
  public ArrayList<List<Integer>> chunk(HashMap<List<Integer>, Integer> input) {
    Map.Entry<List<Integer>, Integer> entry = input.entrySet().iterator().next();
    List<Integer> integers = entry.getKey();
    Integer chunkSize = entry.getValue();

    ArrayList<List<Integer>> result = new ArrayList<>();

    Integer counter = 0;
    ArrayList<Integer> bag = new ArrayList<>();
    for (int i = 0; i < integers.size(); i++) {
      Integer value = integers.get(i);

      if (counter <= chunkSize) {
        bag.add(value);
        counter++;
      }

      if (counter.equals(chunkSize)) {
        result.add(bag);
        counter = 0;
        bag = new ArrayList<>();
      }

      if (i == integers.size() - 1 && !bag.isEmpty()) {
        result.add(bag);
      }
    }
    return result;
  }

  public ArrayList<List<Integer>> chunkArraySize(
      HashMap<List<Integer>, Integer> input
  ) {
    Map.Entry<List<Integer>, Integer> entry = input.entrySet().iterator().next();
    List<Integer> integers = entry.getKey();
    Integer chunkSize = entry.getValue();

    ArrayList<List<Integer>> result = new ArrayList<>();

    for (int i = 0; i < integers.size(); i++) {

      List<Integer> actual;
      if (result.size() > 0) {
        actual = result.get(result.size() - 1);
      } else {
        result.add(new ArrayList<>());
        actual = result.get(result.size() - 1);
      }

      if (!actual.contains(integers.get(i)) && actual.size() < chunkSize) {
        actual.add(integers.get(i));
      }

      if (!actual.contains(integers.get(i)) && actual.size() == chunkSize) {
        ArrayList<Integer> newChunk = new ArrayList<>();
        newChunk.add(integers.get(i));
        result.add(newChunk);
      }
    }

    return result;
  }

  public ArrayList<List<Integer>> chunkSubList(
      HashMap<List<Integer>, Integer> input
  ) {
    Map.Entry<List<Integer>, Integer> entry = input.entrySet().iterator().next();
    List<Integer> integers = entry.getKey();
    Integer chunkSize = entry.getValue();

    ArrayList<List<Integer>> result = new ArrayList<>();
    int start = 0;
    int end = start + chunkSize;

    for (int i = 0; i < integers.size(); i += chunkSize) {
      List<Integer> subList = integers.subList(start, end);
      result.add(subList);

      start += chunkSize;
      end += chunkSize;

      if (end > integers.size()) {
        end = integers.size();
      }
    }

    return result;
  }
}

package com.andrascsanyi.practice.arraychunk;

import java.util.ArrayList;
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
    for (int i = 0; i < integers.size(); i++){
      Integer value = integers.get(i);
            
      if(counter <= chunkSize){
        bag.add(value);
        counter++;
      }
      
      if(counter.equals(chunkSize)) {
        result.add(bag);
        counter = 0;
        bag = new ArrayList<>();
      }
    }
    return result;
  }
}

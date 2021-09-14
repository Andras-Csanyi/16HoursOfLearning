package com.andrascsanyi.practice;

public class TruckLoadJournal {
  public Integer process(String journal) {

    String[] splitToItems = journal.split(" ");
    Integer result = 0;
    for (String singleItem : splitToItems) {
      String singleItemReplaced = singleItem.replace("b", " ");
      String[] singleItemSplit = singleItemReplaced.split(" ");

      Integer boxAmount;
      if (!singleItemSplit[0].equals("")) {
        boxAmount = Integer.parseInt(singleItemSplit[0]);
      } else {
        boxAmount = 1;
      }
      Integer weight = Integer.parseInt(singleItemSplit[1]);

      result += boxAmount * weight;
    }

    return result;
  }
}

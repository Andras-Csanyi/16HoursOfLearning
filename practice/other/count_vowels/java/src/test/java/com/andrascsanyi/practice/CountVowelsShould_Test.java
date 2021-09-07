package com.andrascsanyi.practice;

import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class CountVowelsShould_Test {
  private CountVowels countVowels;
  
  @BeforeTest
  public void setup() {
    countVowels = new CountVowels();
  }
  
  @DataProvider(name = "data")
  public Object[][] dataProvider() {
    return new Object[][]{
        {"asd", 1},
        {"asdasd", 2},
        {"sdsds", 0},
        {"euioa", 5}
    };
  }
  
  @Test(dataProvider = "data")
  public void test(String input, Integer expected) {
    assertThat(countVowels.count(input))
        .isEqualTo(expected);
  }
}

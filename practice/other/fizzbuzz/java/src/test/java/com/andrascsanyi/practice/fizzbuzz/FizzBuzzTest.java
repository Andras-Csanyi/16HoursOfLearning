package com.andrascsanyi.practice.fizzbuzz;

import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class FizzBuzzTest {
  
  private FizzBuzz fizzBuzz;
  
  @BeforeTest
  public void before() {
    fizzBuzz = new FizzBuzz();
  }
  
  @DataProvider(name = "fizzbuzzData")
  public Object[][] data() {
    return new Object[][]{
        {1, ""},
        {2, ""},
        {3, "fizz"},
        {4, ""},
        {5, "buzz"},
        {6, "fizz"},
        {7, ""},
        {8, ""},
        {9, "fizz"},
        {10, "buzz"},
        {11, ""},
        {12, "fizz"},
        {13, ""},
        {14, ""},
        {15, "fizz-buzz"},
    };
  }
  
  @Test(dataProvider = "fizzbuzzData")
  public void test(Integer input, String expectedOutput) {
    assertThat(fizzBuzz.fizzBuzz(input))
        .isEqualTo(expectedOutput);
  }
}

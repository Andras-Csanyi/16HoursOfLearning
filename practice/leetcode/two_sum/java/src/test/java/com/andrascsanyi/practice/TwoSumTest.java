package com.andrascsanyi.practice;

import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class TwoSumTest {
  private TwoSum twoSumCalculator;

  @BeforeTest
  public void setup() {
    twoSumCalculator = new TwoSum();
  }

  @DataProvider(name = "data")
  public Object[][] dataProvider() {
    return new Object[][]{
        {
            new Integer[]{1, 3, 6, 7, 8, 9},
            17,
            new Integer[]{4, 5}
        },
        {
            new Integer[]{1, 3, 6, 7, 8, 9},
            18,
            null
        },
        {
            new Integer[]{1},
            3,
            null
        },
        {
            new Integer[]{1, 2},
            4,
            null
        }
    };
  }

  @Test(dataProvider = "data")
  public void testBruteForce(
      Integer[] intArray,
      Integer twoSum,
      Integer[] result) {
    assertThat(twoSumCalculator.bruteForce(intArray, twoSum))
        .isEqualTo(result);
  }

  @Test(dataProvider = "data")
  public void testOptimal(
      Integer[] intArray,
      Integer twoSum,
      Integer[] result) {
    assertThat(twoSumCalculator.optimalSolution(intArray, twoSum))
        .isEqualTo(result);
  }
}

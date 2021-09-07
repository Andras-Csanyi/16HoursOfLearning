package com.andrascsanyi.practice;

import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class SpiralMatrixShould_Test {

  private com.andrascsanyi.practice.SpiralMatrix spiralMatrix;

  @BeforeTest
  public void setup() {
    spiralMatrix = new com.andrascsanyi.practice.SpiralMatrix();
  }

  @DataProvider(name = "data")
  public Object[][] dataProvider() {
    return new Object[][]{
        {
            2,
            new ArrayList<List<String>>() {
              {
                add(Arrays.asList("1", "2"));
                add(Arrays.asList("4", "3"));
              }
            }
        },
        {
            3,
            new ArrayList<List<String>>() {
              {
                add(Arrays.asList("1", "2", "3"));
                add(Arrays.asList("8", "9", "4"));
                add(Arrays.asList("7", "6", "5"));
              }
            }
        },
        {
            4,
            new ArrayList<List<String>>() {
              {
                add(Arrays.asList("1", "2", "3", "4"));
                add(Arrays.asList("12", "13", "14", "5"));
                add(Arrays.asList("11", "16", "15", "6"));
                add(Arrays.asList("10", "9", "8", "7"));
              }
            }
        }
    };
  }

  @Test(dataProvider = "data")
  public void test(Integer input, ArrayList<ArrayList<String>> expected) {
    assertThat(spiralMatrix.create(input))
        .isEqualTo(expected);
  }
}

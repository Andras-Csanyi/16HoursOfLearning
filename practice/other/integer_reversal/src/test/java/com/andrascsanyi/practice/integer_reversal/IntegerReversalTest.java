package com.andrascsanyi.practice.integer_reversal;

import static org.assertj.core.api.Assertions.assertThat;

import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

public class IntegerReversalTest {

  private IntegerReversal integerReversal;

  @BeforeTest
  public void before() {
    integerReversal = new IntegerReversal();
  }

  @DataProvider(name = "integers")
  public Object[][] integerDataProviders() {
    return new Object[][]{
        {12, 21},
        {10, 1},
        {-23, -32},
        {-10, -1}
    };
  }

  @Test(dataProvider = "integers")
  public void testLoop(Integer input, Integer expected) {
    assertThat(integerReversal.reverseLoop(input))
        .isEqualTo(expected);
  }

  @Test(dataProvider = "integers")
  public void testInbuilt(Integer input, Integer expected) {
    assertThat(integerReversal.reverseLoop(input))
        .isEqualTo(expected);
  }
}

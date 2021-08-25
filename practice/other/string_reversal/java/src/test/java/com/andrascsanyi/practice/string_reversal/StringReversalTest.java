package com.andrascsanyi.practice.string_reversal;

import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;
import static org.assertj.core.api.Assertions.assertThat;


public class StringReversalTest {

  private StringReversal stringReversal;

  @BeforeTest
  public void before() {
    stringReversal = new StringReversal();
  }

  @DataProvider(name = "strings")
  public Object[][] dataProvider() {
    return new Object[][]{
        {"asd", "dsa"},
        {"Asd", "dsa"}
    };
  }

  @Test(dataProvider = "strings")
  public void testStringBuilder(String input, String expectedResult) {
    assertThat(stringReversal.reverseWithStringBuilder(input)).isEqualTo(expectedResult);
  }

  @Test(dataProvider = "strings")
  public void testLoop(String input, String expectedResult) {
    assertThat(stringReversal.reverseWithLoop(input))
        .isEqualTo(expectedResult);
  }
}

package com.andrascsanyi.practice.charcount;

import static org.assertj.core.api.Assertions.assertThat;

import java.util.HashMap;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

public class CharCountTest {

  private CharCounter charCounter;

  @BeforeTest
  public void beforeTest() {
    charCounter = new CharCounter();
  }

  @DataProvider(name = "charCountDataProvider")
  public Object[][] charCountDataProviderMethod() {
    return new Object[][]{
        {"Hello", 'H', 1},
        {"Hello", 'h', 1},
        {"Hello", 'l', 2}
    };
  }

  @DataProvider(name = "occurenceCounterData")
  public Object[][] occurenceCounterDataProvider() {
    return new Object[][]{
        {
            "Hello",
            new HashMap<Character, Long>() {{
              put('h', 1L);
              put('e', 1L);
              put('l', 2L);
              put('o', 1L);
            }}
        }
    };
  }

  @Test(dataProvider = "charCountDataProvider")
  public void testCharCount(String inputString, char character, Integer expectedResult) {

    assertThat(charCounter.countCharByLoop(inputString, character))
        .isEqualTo(expectedResult);

  }

  @Test(dataProvider = "charCountDataProvider")
  public void testCharCountByStream(String inputString, char character, Integer expectedResult) {
    assertThat(charCounter.countCharByStream(inputString, character))
        .isEqualTo(expectedResult);
  }

  @Test(dataProvider = "occurenceCounterData")
  public void testOccurenceCounter(String input, HashMap<Character, Long> expectedResult){
    assertThat(charCounter.countOccurencesByLoop(input))
        .isEqualTo(expectedResult);
  }

}

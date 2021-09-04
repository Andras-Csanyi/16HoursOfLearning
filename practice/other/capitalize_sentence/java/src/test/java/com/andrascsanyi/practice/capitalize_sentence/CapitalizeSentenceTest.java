package com.andrascsanyi.practice.capitalize_sentence;

import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class CapitalizeSentenceTest {

  private CapitalizeSentence capitalizeSentence;

  @BeforeTest
  public void before() {
    capitalizeSentence = new CapitalizeSentence();
  }

  @DataProvider(name = "capitalize")
  public Object[][] capitalizeDataProvider() {
    return new Object[][]{
        {"a short sentence", "A Short Sentence"},
        {"something, else", "Something, Else"},
        {"This one starts with capitals.", "This One Starts With Capitals."},
        {"lets add some; crazy- characters too", "Lets Add Some; Crazy- Characters Too"},
        {"This one Has Multiple capitals in it", "This One Has Multiple Capitals In It"}
    };
  }

  @Test(dataProvider = "capitalize")
  public void test(String input, String expectedResult) {
    assertThat(capitalizeSentence.capitalize(input))
        .isEqualTo(expectedResult);
  }

  @Test(dataProvider = "capitalize")
  public void testSecondVersion(String input, String expectedResult) {
    assertThat(capitalizeSentence.capitalizeSecondVersion(input))
        .isEqualTo(expectedResult);
  }

  @Test(dataProvider = "capitalize")
  public void testThirdVersion(String input, String expectedResult) {
    assertThat(capitalizeSentence.capitalizeThirdVersion(input))
        .isEqualTo(expectedResult);
  }
  
}

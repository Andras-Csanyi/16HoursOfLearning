package com.andrascsanyi.practice.anagram;

import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class AnagramTest {
  
  private Anagram anagram;
  
  @BeforeTest
  public void before() {
    anagram = new Anagram();
  }
  
  @DataProvider(name = "anagram")
  public Object[][] dataProvider() {
    return new Object[][]{
        {"Tar", "Rat", true},
        {"Tar", "Ratr", false},
        {"Save", "Vase", true},
        {"Save", "Vasy", false},
        {"Dormitory", "Dirty room", true},
        {"Dormitory", "Dirtr room", false},
        {"School master", "The classroom", true},
        {"School master", "The classsroom", false},
        {"O, Draconian devil", "Leonardo da Vinci", true},
        {"O, Draconian devil", "Leonardo ta Vinci", false},
    };
  }
  
  @Test(dataProvider = "anagram")
  public void test(String example, String pattern, Boolean expected) {
    assertThat(anagram.isAnagramOf(example, pattern))
        .isEqualTo(expected);
  }
  
  @Test
  public void testExample() {
    assertThat(anagram.isAnagramOf("Tar", "Ratr"))
        .isEqualTo(false);
  }
  
}

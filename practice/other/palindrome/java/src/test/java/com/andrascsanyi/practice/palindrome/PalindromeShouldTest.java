package com.andrascsanyi.practice.palindrome;

import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class PalindromeShouldTest {

  @DataProvider(name = "palindromes")
  public Object[][] palindromesDataProvider() {
    return new Object[][]{
        {"abba", Boolean.TRUE},
        {"asdasd", Boolean.FALSE},
        {"A nut for a jar of tuna.", Boolean.TRUE},
        {"A Santa dog lived as a devil god at NASA.", Boolean.TRUE},
        {"As I pee sir, I see Pisa!", Boolean.TRUE},
        {"Borrow or rob?", Boolean.TRUE},
        {"Dammit, I'm mad!", Boolean.TRUE},
        {"Do geese see God?", Boolean.TRUE},
        {"Doc, note, I dissent. A fast never prevents a fatness. I diet on cod.", Boolean.TRUE},
        {"Emil peed deep lime.", Boolean.TRUE},
        {"Evar, go to grave.", Boolean.TRUE},
        {"Go hang a salami, I'm a lasagna hog.", Boolean.TRUE},
        {"Golf? No sir, prefer prison flog.", Boolean.TRUE},
        {"Madam, in Eden, I'm Adam.", Boolean.TRUE},
        {"Mr. Owl ate my metal worm.", Boolean.TRUE},
        {"No lemon, no melon!", Boolean.TRUE},
        {"No pet so tragic as a cigar to step on.", Boolean.TRUE},
        {"Nurse, I spy gypsies, run!", Boolean.TRUE},
        {"was it a bar or a bat I saw?", Boolean.TRUE},
        {"Oozy rat in a sanitary zoo", Boolean.TRUE},
        {"Rats live on no evil star.", Boolean.TRUE},
        {"Stressed desserts", Boolean.TRUE},
        {"Taco cat", Boolean.TRUE},
        {"UFO tofu", Boolean.TRUE},
        {"Civic", Boolean.TRUE},
        {"A dog! A panic in a pagoda.", Boolean.TRUE},
        {"A lot not new I saw as I went on to L.A.", Boolean.TRUE}
    };
  }

  @Test(dataProvider = "palindromes")
  public void isPalindromeByStringReversal(String inputString, Boolean expectedResult) {

    // Arrange
    Palindrome palindrome = new Palindrome();

    // Act
    assertThat(palindrome.isPalindromeByStringReversal(inputString))
        .as("Palindrome candidate: %s", inputString)
        .isEqualTo(expectedResult);

  }

}

package com.andrascsanyi.practice;

import static org.assertj.core.api.Assertions.assertThat;

import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

public class TruckLoadJournalTest {
  
  private TruckLoadJournal truckLoadJournal;
  
  @BeforeTest
  public void setup() {
    truckLoadJournal = new TruckLoadJournal();
  }
  
  @DataProvider(name = "data")
  public Object[][] data() {
    return new Object[][]{
        {
            "b40 +3b20 -2b10 ",
            80
        }
    };
  }
  
  @Test(dataProvider = "data")
  public void test(String journal, Integer expectedResult) {
    assertThat(truckLoadJournal.process(journal))
        .isEqualTo(expectedResult);
  }
}

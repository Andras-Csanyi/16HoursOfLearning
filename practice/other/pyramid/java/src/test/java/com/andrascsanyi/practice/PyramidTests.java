package com.andrascsanyi.practice;

import java.util.ArrayList;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;
import static org.assertj.core.api.Assertions.assertThat;

public class PyramidTests {

  private Pyramid pyramid;

  @BeforeTest
  public void setup() {
    pyramid = new Pyramid();
  }

  @DataProvider(name = "data")
  public Object[][] dataProvider() {
    return new Object[][]{
        {
            1,
            new ArrayList<String>() {
              {
                add("#");
              }
            }
        },
        {
            2,
            new ArrayList<String>() {
              {
                add(" # ");
                add("###");
              }
            }
        },
        {
            3,
            new ArrayList<String>() {
              {
                add("  #  ");
                add(" ### ");
                add("#####");
              }
            }
        },
        {
            4,
            new ArrayList<String>() {
              {
                add("   #   ");
                add("  ###  ");
                add(" ##### ");
                add("#######");
              }
            }
        }

    };
  }

  @Test(dataProvider = "data")
  public void test(Integer height, ArrayList<String> expected) {
    assertThat(pyramid.build(height))
        .isEqualTo(expected);
  }
}

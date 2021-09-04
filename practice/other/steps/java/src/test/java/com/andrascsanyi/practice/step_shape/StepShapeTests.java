package com.andrascsanyi.practice.step_shape;

import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

import java.util.ArrayList;
import java.util.Arrays;

public class StepShapeTests {

  private StepShape stepShape;

  @BeforeTest
  public void setup() {
    stepShape = new StepShape();
  }

  @DataProvider(name = "step")
  public Object[][] data() {
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
                add("# ");
                add("##");
              }
            }
        },
        {
            3,
            new ArrayList<String>() {
              {
              add("#  ");
              add("## ");
              add("###");
              }
            }
        }
    };
  }

  @Test(dataProvider = "step")
  public void test(Integer steps, ArrayList<String> expectedResult) {
    assertThat(stepShape.steps(steps))
        .isEqualTo(expectedResult);
  }
}

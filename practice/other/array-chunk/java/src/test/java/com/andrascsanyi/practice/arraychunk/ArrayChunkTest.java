package com.andrascsanyi.practice.arraychunk;

import static org.assertj.core.api.Assertions.assertThat;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

public class ArrayChunkTest {

  private ArrayChunk arrayChunk;

  @BeforeTest
  public void beforeTest() {
    arrayChunk = new ArrayChunk();
  }

  @DataProvider(name = "arrayChunkDataProvider")
  public Object[][] dataProvider() {
    return new Object[][]{
        {
            // input
            new HashMap<List<Integer>, Integer>() {{
              put(Arrays.asList(1, 2), 2);
            }},
            // expected
            new ArrayList<List<Integer>>() {{
              add(Arrays.asList(1, 2));
            }}
        },
        {
            // input
            new HashMap<List<Integer>, Integer>() {{
              put(Arrays.asList(1, 2, 3), 2);
            }},
            // expected
            new ArrayList<List<Integer>>() {{
              add(Arrays.asList(1, 2));
              add(Arrays.asList(3));
            }}
        },
        {
            // input
            new HashMap<List<Integer>, Integer>() {{
              put(Arrays.asList(1, 2, 3, 4), 2);
            }},
            // expected
            new ArrayList<List<Integer>>() {{
              add(Arrays.asList(1, 2));
              add(Arrays.asList(3, 4));
            }}
        },
        {
            // input
            new HashMap<List<Integer>, Integer>() {{
              put(Arrays.asList(1, 2, 3, 4), 1);
            }},
            // expected
            new ArrayList<List<Integer>>() {{
              add(Arrays.asList(1));
              add(Arrays.asList(2));
              add(Arrays.asList(3));
              add(Arrays.asList(4));
            }}
        },
        {
            // input
            new HashMap<List<Integer>, Integer>() {{
              put(Arrays.asList(1, 2, 3, 4, 5), 3);
            }},
            // expected
            new ArrayList<List<Integer>>() {{
              add(Arrays.asList(1, 2, 3));
              add(Arrays.asList(4, 5));
            }}
        }
    };
  }

  @Test(dataProvider = "arrayChunkDataProvider")
  public void test(HashMap<List<Integer>, Integer> input,
                   ArrayList<List<Integer>> expectedResult) {
    assertThat(arrayChunk.chunk(input))
        .isEqualTo(expectedResult);
  }

  @Test(dataProvider = "arrayChunkDataProvider")
  public void testArraySize(HashMap<List<Integer>, Integer> input,
                            ArrayList<List<Integer>> expectedResult) {
    assertThat(arrayChunk.chunkArraySize(input))
        .isEqualTo(expectedResult);
  }

  @Test(dataProvider = "arrayChunkDataProvider")
  public void testSubList(HashMap<List<Integer>, Integer> input,
                          ArrayList<List<Integer>> expectedResult) {
    assertThat(arrayChunk.chunkSubList(input))
        .isEqualTo(expectedResult);
  }
}

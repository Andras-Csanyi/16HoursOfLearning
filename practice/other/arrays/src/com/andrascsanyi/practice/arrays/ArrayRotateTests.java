package com.andrascsanyi.practice.arrays;

import org.junit.jupiter.api.Test;

import static org.assertj.core.api.Assertions.*;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class ArrayRotateTests {

  @Test
  public void array_rotation_by_temp_array() {
    // Arrange
    int[] orig = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    int[] expected = {3, 4, 5, 6, 7, 8, 9, 1, 2};
    int d = 2;

    // Act
    int[] result = ArrayRotate.rotateByUsingTempArrays(orig, d);

    // Assert
    assertThat(result).isEqualTo(expected);

  }

  @Test
  public void array_rotation_by_onebyone() {
    // Arrange
    int[] orig = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    int[] expected = {3, 4, 5, 6, 7, 8, 9, 1, 2};
    int d = 2;

    // Act
    int[] result = ArrayRotate.rotateStepByStep(orig, d);

    // Assert
    assertThat(result).isEqualTo(expected);

  }

  @Test
  public void array_rotation_without_temp_arrays() {
    // Arrange
    int[] orig = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    int[] expected = {3, 4, 5, 6, 7, 8, 9, 1, 2};
    List<Integer> e = new ArrayList<>();
    for (int i : expected) {
      e.add(i);
    }
    int d = 2;

    // Act
    List<Integer> result = ArrayRotate.rotateWithoutTempArrays(orig, d);

    // Assert
    assertThat(e.equals(result)).isTrue();

  }
  
  @Test
  public void array_rotate_by_reverse() {
    // Arrange
    int[] orig = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    int[] expected = {3, 4, 5, 6, 7, 8, 9, 1, 2};
    
    // Act
    ArrayRotate.rotatePrimitiveArrayByReverse(orig, 2);
    
    // Assert
    System.out.println(Arrays.toString(orig));
    System.out.println(Arrays.toString(expected));
    assertThat(Arrays.equals(orig, expected)).isTrue();
  }

  @Test
  public void primitiveArrayReverse_fullArray() {
    // Arrange
    int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    int[] expected = {9, 8, 7, 6, 5, 4, 3, 2, 1};

    // Act
    ArrayRotate.reversePrimitiveArray(arr, 0, arr.length - 1);

    // Assert
    assertThat(Arrays.equals(arr, expected)).isTrue();
  }

  @Test
  public void primitiveArrayReverse_firstTwoElements() {
    // Arrange
    int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int[] expected = {2, 1, 3, 4, 5, 6, 7, 8, 9, 10};

    // Act
    ArrayRotate.reversePrimitiveArray(arr, 0, 1);

    // Assert
    assertThat(Arrays.equals(arr, expected)).isTrue();
  }

  @Test
  public void primitiveArrayReverse_lastTwoElements() {
    // Arrange
    int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int[] expected = {1, 2, 3, 4, 5, 6, 7, 8, 10, 9};

    // Act
    ArrayRotate.reversePrimitiveArray(arr, arr.length - 2, arr.length - 1);

    // Assert
    assertThat(Arrays.equals(arr, expected)).isTrue();
  }
}

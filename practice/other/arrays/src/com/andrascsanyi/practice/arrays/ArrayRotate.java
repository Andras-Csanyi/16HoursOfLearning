package com.andrascsanyi.practice.arrays;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.IntStream;

public class ArrayRotate {

  /**
   * This solution uses two temp arrays to make the rotation
   * Pros:
   * - a few lines only and there is no loop
   * Cons:
   * - in the background the original length of the array is scanned twice,
   * first time when the copies happen, second time when the concat happens
   *
   * time complexity: O(N)
   * space complexity: O(N)
   *
   * @param original
   * @param rotate
   * @return
   */
  public static int[] rotateByUsingTempArrays(int[] original, int rotate) {
    if (original.length < 1 || rotate < 1) {
      return null;
    }
    int[] originalSlice = Arrays.copyOfRange(original, rotate, original.length);
    int[] rotatedSlice = Arrays.copyOfRange(original, 0, rotate);
    return IntStream.concat(Arrays.stream(originalSlice), Arrays.stream(rotatedSlice)).toArray();
  }

  /**
   * this solution rotates the array one-by-one
   *
   * pro's:
   * - uses less memory
   *
   * con's:
   * - the code is complex --> requires more thorough testing and more comment which might not be maintained
   * - using ArrayList<Integer>> would be more comfortable and readable, however time and space complexity is a question
   * it needs to be investigated
   *
   * Time complexity: O(rotate_value * length of the array)
   * Space complexity: O(1)
   */
  public static int[] rotateStepByStep(int[] original, int rotate) {
    if (original.length < 1 || rotate < 1) {
      return null;
    }

    // the loop takes care of rotating the array
    for (int rotate_counter = 1; rotate_counter <= rotate; rotate_counter++) {
      int last = original[0];

      // this loop shifts the values by 1 to left
      for (int rotate_the_array_counter = 0; rotate_the_array_counter < original.length - 1; rotate_the_array_counter++) {
        original[rotate_the_array_counter] = original[rotate_the_array_counter + 1];
      }
      original[original.length - 1] = last;
    }

    return original;

  }

  /**
   * It rotates the array without using temp arrays
   * this solution takes advantage of the services provided by ArrayList<T>
   *
   * Pro's:
   * - the code is quite simple and easy to read
   * - no homegrown solutions here, we use a widely used API
   *
   * Con's:
   * - primitive array must be converted to ArrayList -> O(n)
   * - if the return type must be the same then ArrayList must be converted to primitive array
   * - boxing and optional unboxing
   *
   * Time complexity: O([1-2-3]n) (depending on the solution)
   * Space complexity: O(2n) - sublists use temporary space
   *
   * @param original
   * @param rotate
   * @return
   */
  public static List<Integer> rotateWithoutTempArrays(int[] original, int rotate) {
    if (original.length < 1 || rotate < 1) {
      return null;
    }

    List<Integer> arr = new ArrayList<>();
    for (int i : original) {
      arr.add(i);
    }

    ArrayList<Integer> result = new ArrayList<>();
    result.addAll(arr.subList(rotate, arr.size()));
    result.addAll(arr.subList(0, rotate));
    return result;
  }

  /**
   * Rotates the array by reverse its parts. The parts are created by the rotation value.
   * For example, if rotation is 2, then there will be a left side chunk size 2, and a right size chunk
   * where the size is the remaining array.
   * These chunks are reversed first, and the whole array is reversed again
   * 
   * Pro's:
   * - size/memory efficient - no ArrayList is used
   * - the code is pretty simple
   * 
   * Con's:
   * - you have to provide the reverse method and test it
   * 
   * @param original
   * @param rotate
   */
  public static void rotatePrimitiveArrayByReverse(int[] original, int rotate) {

    // left side
    reversePrimitiveArray(original, 0, rotate - 1);
    // right side
    reversePrimitiveArray(original, rotate, original.length - 1);
    // reverse full
    reversePrimitiveArray(original, 0, original.length - 1);
  }

  public static void reversePrimitiveArray(int[] arr, int startIndex, int endIndex) {
    // input checks here
    while (startIndex < endIndex) {
      int leftSide = arr[startIndex];
      int rightSide = arr[endIndex];
      arr[startIndex] = rightSide;
      arr[endIndex] = leftSide;
      startIndex++;
      endIndex--;
    }
  }

}

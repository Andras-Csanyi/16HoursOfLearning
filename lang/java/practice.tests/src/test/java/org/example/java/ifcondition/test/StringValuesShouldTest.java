package org.example.java.ifcondition.test;

import org.example.java.ifcondition.StringValues;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class StringValuesShouldTest {
  
  private StringValues _stringValues;
  
  @BeforeEach
  public void init(){
    _stringValues = new StringValues();
  }
  
  @Test
  public void usingEqualsReturnValidResult() {
    assertThat(_stringValues.useEquals()).isTrue();
  }
  
}

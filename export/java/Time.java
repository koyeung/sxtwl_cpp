/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 4.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.seantone.sxtwl;

public class Time {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected Time(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(Time obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  @SuppressWarnings("deprecation")
  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        sxtwlJNI.delete_Time(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public void setY(int value) {
    sxtwlJNI.Time_Y_set(swigCPtr, this, value);
  }

  public int getY() {
    return sxtwlJNI.Time_Y_get(swigCPtr, this);
  }

  public void setM(int value) {
    sxtwlJNI.Time_M_set(swigCPtr, this, value);
  }

  public int getM() {
    return sxtwlJNI.Time_M_get(swigCPtr, this);
  }

  public void setD(int value) {
    sxtwlJNI.Time_D_set(swigCPtr, this, value);
  }

  public int getD() {
    return sxtwlJNI.Time_D_get(swigCPtr, this);
  }

  public void setH(double value) {
    sxtwlJNI.Time_h_set(swigCPtr, this, value);
  }

  public double getH() {
    return sxtwlJNI.Time_h_get(swigCPtr, this);
  }

  public void setM(double value) {
    sxtwlJNI.Time_m_set(swigCPtr, this, value);
  }

  public double getM() {
    return sxtwlJNI.Time_m_get(swigCPtr, this);
  }

  public void setS(double value) {
    sxtwlJNI.Time_s_set(swigCPtr, this, value);
  }

  public double getS() {
    return sxtwlJNI.Time_s_get(swigCPtr, this);
  }

  public Time() {
    this(sxtwlJNI.new_Time(), true);
  }

}

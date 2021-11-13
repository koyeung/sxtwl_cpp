/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 4.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.seantone.sxtwl;

public class Day {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected Day(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(Day obj) {
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
        sxtwlJNI.delete_Day(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public static Day fromSolar(int _year, short _month, int _day) {
    long cPtr = sxtwlJNI.Day_fromSolar(_year, _month, _day);
    return (cPtr == 0) ? null : new Day(cPtr, false);
  }

  public static Day fromLunar(int year, short month, int day, boolean isRun) {
    long cPtr = sxtwlJNI.Day_fromLunar__SWIG_0(year, month, day, isRun);
    return (cPtr == 0) ? null : new Day(cPtr, false);
  }

  public static Day fromLunar(int year, short month, int day) {
    long cPtr = sxtwlJNI.Day_fromLunar__SWIG_1(year, month, day);
    return (cPtr == 0) ? null : new Day(cPtr, false);
  }

  public Day after(int day) {
    long cPtr = sxtwlJNI.Day_after(swigCPtr, this, day);
    return (cPtr == 0) ? null : new Day(cPtr, false);
  }

  public Day before(int day) {
    long cPtr = sxtwlJNI.Day_before(swigCPtr, this, day);
    return (cPtr == 0) ? null : new Day(cPtr, false);
  }

  public int getLunarDay() {
    return sxtwlJNI.Day_getLunarDay(swigCPtr, this);
  }

  public short getLunarMonth() {
    return sxtwlJNI.Day_getLunarMonth(swigCPtr, this);
  }

  public int getLunarYear(boolean chineseNewYearBoundary) {
    return sxtwlJNI.Day_getLunarYear__SWIG_0(swigCPtr, this, chineseNewYearBoundary);
  }

  public int getLunarYear() {
    return sxtwlJNI.Day_getLunarYear__SWIG_1(swigCPtr, this);
  }

  public GZ getYearGZ(boolean chineseNewYearBoundary) {
    return new GZ(sxtwlJNI.Day_getYearGZ__SWIG_0(swigCPtr, this, chineseNewYearBoundary), true);
  }

  public GZ getYearGZ() {
    return new GZ(sxtwlJNI.Day_getYearGZ__SWIG_1(swigCPtr, this), true);
  }

  public GZ getMonthGZ() {
    return new GZ(sxtwlJNI.Day_getMonthGZ(swigCPtr, this), true);
  }

  public GZ getDayGZ() {
    return new GZ(sxtwlJNI.Day_getDayGZ(swigCPtr, this), true);
  }

  public boolean isLunarLeap() {
    return sxtwlJNI.Day_isLunarLeap(swigCPtr, this);
  }

  public int getSolarYear() {
    return sxtwlJNI.Day_getSolarYear(swigCPtr, this);
  }

  public short getSolarMonth() {
    return sxtwlJNI.Day_getSolarMonth(swigCPtr, this);
  }

  public int getSolarDay() {
    return sxtwlJNI.Day_getSolarDay(swigCPtr, this);
  }

  public short getWeek() {
    return sxtwlJNI.Day_getWeek(swigCPtr, this);
  }

  public short getWeekIndex() {
    return sxtwlJNI.Day_getWeekIndex(swigCPtr, this);
  }

  public boolean hasJieQi() {
    return sxtwlJNI.Day_hasJieQi(swigCPtr, this);
  }

  public short getJieQi() {
    return sxtwlJNI.Day_getJieQi(swigCPtr, this);
  }

  public double getJieQiJD() {
    return sxtwlJNI.Day_getJieQiJD(swigCPtr, this);
  }

  public short getConstellation() {
    return sxtwlJNI.Day_getConstellation(swigCPtr, this);
  }

}

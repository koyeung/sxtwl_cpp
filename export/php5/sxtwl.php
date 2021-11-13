<?php

/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 4.0.2
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

// Try to load our extension if it's not already loaded.
if (!extension_loaded('sxtwl')) {
  if (strtolower(substr(PHP_OS, 0, 3)) === 'win') {
    if (!dl('php_sxtwl.dll')) return;
  } else {
    // PHP_SHLIB_SUFFIX gives 'dylib' on MacOS X but modules are 'so'.
    if (PHP_SHLIB_SUFFIX === 'dylib') {
      if (!dl('sxtwl.so')) return;
    } else {
      if (!dl('sxtwl.'.PHP_SHLIB_SUFFIX)) return;
    }
  }
}



abstract class sxtwl {
	const J2000 = J2000;

	static function fromSolar($year,$month,$day) {
		$r=fromSolar($year,$month,$day);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new Day($r);
		}
		return $r;
	}

	static function fromLunar($year,$month,$day,$isRun=false) {
		$r=fromLunar($year,$month,$day,$isRun);
		if (!is_resource($r)) return $r;
		return new Day($r);
	}

	static function siZhu2Year($year,$yue,$ri,$shi,$fromYear,$toYear) {
		$r=siZhu2Year($year,$yue,$ri,$shi,$fromYear,$toYear);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new JDList($r);
		}
		return $r;
	}

	static function getShiGz($dayTg,$hour) {
		$r=getShiGz($dayTg,$hour);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new GZ($r);
		}
		return $r;
	}

	static function getRunMonth($By) {
		return getRunMonth($By);
	}

	static function getLunarMonthNum($By,$month,$isRun=false) {
		return getLunarMonthNum($By,$month,$isRun);
	}

	static function JD2DD($jd) {
		$r=JD2DD($jd);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new Time($r);
		}
		return $r;
	}

	static function toJD($time) {
		return toJD($time);
	}
}

/* PHP Proxy Classes */
class JDList {
	public $_cPtr=null;
	protected $_pData=array();

	function __set($var,$value) {
		if ($var === 'thisown') return swig_sxtwl_alter_newobject($this->_cPtr,$value);
		$this->_pData[$var] = $value;
	}

	function __get($var) {
		if ($var === 'thisown') return swig_sxtwl_get_newobject($this->_cPtr);
		return $this->_pData[$var];
	}

	function __isset($var) {
		if ($var === 'thisown') return true;
		return array_key_exists($var, $this->_pData);
	}

	function __construct($n_or_other=null) {
		if (is_resource($n_or_other) && get_resource_type($n_or_other) === '_p_std__vectorT_double_t') {
			$this->_cPtr=$n_or_other;
			return;
		}
		switch (func_num_args()) {
		case 0: $this->_cPtr=new_JDList(); break;
		default: $this->_cPtr=new_JDList($n_or_other);
		}
	}

	function size() {
		return JDList_size($this->_cPtr);
	}

	function capacity() {
		return JDList_capacity($this->_cPtr);
	}

	function reserve($n) {
		JDList_reserve($this->_cPtr,$n);
	}

	function clear() {
		JDList_clear($this->_cPtr);
	}

	function push($x) {
		JDList_push($this->_cPtr,$x);
	}

	function is_empty() {
		return JDList_is_empty($this->_cPtr);
	}

	function pop() {
		return JDList_pop($this->_cPtr);
	}

	function get($i) {
		return JDList_get($this->_cPtr,$i);
	}

	function set($i,$val) {
		JDList_set($this->_cPtr,$i,$val);
	}
}

class Time {
	public $_cPtr=null;
	protected $_pData=array();

	function __set($var,$value) {
		$func = 'Time_'.$var.'_set';
		if (function_exists($func)) return call_user_func($func,$this->_cPtr,$value);
		if ($var === 'thisown') return swig_sxtwl_alter_newobject($this->_cPtr,$value);
		$this->_pData[$var] = $value;
	}

	function __get($var) {
		$func = 'Time_'.$var.'_get';
		if (function_exists($func)) return call_user_func($func,$this->_cPtr);
		if ($var === 'thisown') return swig_sxtwl_get_newobject($this->_cPtr);
		return $this->_pData[$var];
	}

	function __isset($var) {
		if (function_exists('Time_'.$var.'_get')) return true;
		if ($var === 'thisown') return true;
		return array_key_exists($var, $this->_pData);
	}

	function __construct($res=null) {
		if (is_resource($res) && get_resource_type($res) === '_p_Time') {
			$this->_cPtr=$res;
			return;
		}
		$this->_cPtr=new_Time();
	}
}

class GZ {
	public $_cPtr=null;
	protected $_pData=array();

	function __set($var,$value) {
		if ($var === 'tg') return GZ_tg_set($this->_cPtr,$value);
		if ($var === 'dz') return GZ_dz_set($this->_cPtr,$value);
		if ($var === 'thisown') return swig_sxtwl_alter_newobject($this->_cPtr,$value);
		$this->_pData[$var] = $value;
	}

	function __get($var) {
		if ($var === 'tg') return GZ_tg_get($this->_cPtr);
		if ($var === 'dz') return GZ_dz_get($this->_cPtr);
		if ($var === 'thisown') return swig_sxtwl_get_newobject($this->_cPtr);
		return $this->_pData[$var];
	}

	function __isset($var) {
		if (function_exists('GZ_'.$var.'_get')) return true;
		if ($var === 'thisown') return true;
		return array_key_exists($var, $this->_pData);
	}

	function __construct($tg=null,$dz=null) {
		if (is_resource($tg) && get_resource_type($tg) === '_p_GZ') {
			$this->_cPtr=$tg;
			return;
		}
		switch (func_num_args()) {
		case 0: $this->_cPtr=new_GZ(); break;
		case 1: $this->_cPtr=new_GZ($tg); break;
		default: $this->_cPtr=new_GZ($tg,$dz);
		}
	}
}

class Day {
	public $_cPtr=null;
	protected $_pData=array();

	function __set($var,$value) {
		if ($var === 'thisown') return swig_sxtwl_alter_newobject($this->_cPtr,$value);
		$this->_pData[$var] = $value;
	}

	function __get($var) {
		if ($var === 'thisown') return swig_sxtwl_get_newobject($this->_cPtr);
		return $this->_pData[$var];
	}

	function __isset($var) {
		if ($var === 'thisown') return true;
		return array_key_exists($var, $this->_pData);
	}
	function __construct($h) {
		$this->_cPtr=$h;
	}

	static function fromSolar($_year,$_month,$_day) {
		$r=Day_fromSolar($_year,$_month,$_day);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new Day($r);
		}
		return $r;
	}

	static function fromLunar($year,$month,$day,$isRun=false) {
		$r=Day_fromLunar($year,$month,$day,$isRun);
		if (!is_resource($r)) return $r;
		return new Day($r);
	}

	function after($day) {
		$r=Day_after($this->_cPtr,$day);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new Day($r);
		}
		return $r;
	}

	function before($day) {
		$r=Day_before($this->_cPtr,$day);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new Day($r);
		}
		return $r;
	}

	function getLunarDay() {
		return Day_getLunarDay($this->_cPtr);
	}

	function getLunarMonth() {
		return Day_getLunarMonth($this->_cPtr);
	}

	function getLunarYear($chineseNewYearBoundary=true) {
		return Day_getLunarYear($this->_cPtr,$chineseNewYearBoundary);
	}

	function getYearGZ($chineseNewYearBoundary=false) {
		$r=Day_getYearGZ($this->_cPtr,$chineseNewYearBoundary);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new GZ($r);
		}
		return $r;
	}

	function getMonthGZ() {
		$r=Day_getMonthGZ($this->_cPtr);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new GZ($r);
		}
		return $r;
	}

	function getDayGZ() {
		$r=Day_getDayGZ($this->_cPtr);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new GZ($r);
		}
		return $r;
	}

	function isLunarLeap() {
		return Day_isLunarLeap($this->_cPtr);
	}

	function getSolarYear() {
		return Day_getSolarYear($this->_cPtr);
	}

	function getSolarMonth() {
		return Day_getSolarMonth($this->_cPtr);
	}

	function getSolarDay() {
		return Day_getSolarDay($this->_cPtr);
	}

	function getWeek() {
		return Day_getWeek($this->_cPtr);
	}

	function getWeekIndex() {
		return Day_getWeekIndex($this->_cPtr);
	}

	function hasJieQi() {
		return Day_hasJieQi($this->_cPtr);
	}

	function getJieQi() {
		return Day_getJieQi($this->_cPtr);
	}

	function getJieQiJD() {
		return Day_getJieQiJD($this->_cPtr);
	}

	function getConstellation() {
		return Day_getConstellation($this->_cPtr);
	}
}


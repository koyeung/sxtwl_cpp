//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class JDList : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<double>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JDList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JDList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~JDList() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          sxtwlPINVOKE.delete_JDList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public JDList(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (double element in c) {
      this.Add(element);
    }
  }

  public JDList(global::System.Collections.Generic.IEnumerable<double> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (double element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public double this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(double[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(double[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, double[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public double[] ToArray() {
    double[] array = new double[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<double> global::System.Collections.Generic.IEnumerable<double>.GetEnumerator() {
    return new JDListEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new JDListEnumerator(this);
  }

  public JDListEnumerator GetEnumerator() {
    return new JDListEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class JDListEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<double>
  {
    private JDList collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public JDListEnumerator(JDList collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public double Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (double)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    sxtwlPINVOKE.JDList_Clear(swigCPtr);
  }

  public void Add(double x) {
    sxtwlPINVOKE.JDList_Add(swigCPtr, x);
  }

  private uint size() {
    uint ret = sxtwlPINVOKE.JDList_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = sxtwlPINVOKE.JDList_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    sxtwlPINVOKE.JDList_reserve(swigCPtr, n);
  }

  public JDList() : this(sxtwlPINVOKE.new_JDList__SWIG_0(), true) {
  }

  public JDList(JDList other) : this(sxtwlPINVOKE.new_JDList__SWIG_1(JDList.getCPtr(other)), true) {
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
  }

  public JDList(int capacity) : this(sxtwlPINVOKE.new_JDList__SWIG_2(capacity), true) {
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
  }

  private double getitemcopy(int index) {
    double ret = sxtwlPINVOKE.JDList_getitemcopy(swigCPtr, index);
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private double getitem(int index) {
    double ret = sxtwlPINVOKE.JDList_getitem(swigCPtr, index);
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, double val) {
    sxtwlPINVOKE.JDList_setitem(swigCPtr, index, val);
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(JDList values) {
    sxtwlPINVOKE.JDList_AddRange(swigCPtr, JDList.getCPtr(values));
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
  }

  public JDList GetRange(int index, int count) {
    global::System.IntPtr cPtr = sxtwlPINVOKE.JDList_GetRange(swigCPtr, index, count);
    JDList ret = (cPtr == global::System.IntPtr.Zero) ? null : new JDList(cPtr, true);
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, double x) {
    sxtwlPINVOKE.JDList_Insert(swigCPtr, index, x);
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, JDList values) {
    sxtwlPINVOKE.JDList_InsertRange(swigCPtr, index, JDList.getCPtr(values));
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    sxtwlPINVOKE.JDList_RemoveAt(swigCPtr, index);
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    sxtwlPINVOKE.JDList_RemoveRange(swigCPtr, index, count);
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static JDList Repeat(double value, int count) {
    global::System.IntPtr cPtr = sxtwlPINVOKE.JDList_Repeat(value, count);
    JDList ret = (cPtr == global::System.IntPtr.Zero) ? null : new JDList(cPtr, true);
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    sxtwlPINVOKE.JDList_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    sxtwlPINVOKE.JDList_Reverse__SWIG_1(swigCPtr, index, count);
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, JDList values) {
    sxtwlPINVOKE.JDList_SetRange(swigCPtr, index, JDList.getCPtr(values));
    if (sxtwlPINVOKE.SWIGPendingException.Pending) throw sxtwlPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(double value) {
    bool ret = sxtwlPINVOKE.JDList_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(double value) {
    int ret = sxtwlPINVOKE.JDList_IndexOf(swigCPtr, value);
    return ret;
  }

  public int LastIndexOf(double value) {
    int ret = sxtwlPINVOKE.JDList_LastIndexOf(swigCPtr, value);
    return ret;
  }

  public bool Remove(double value) {
    bool ret = sxtwlPINVOKE.JDList_Remove(swigCPtr, value);
    return ret;
  }

}

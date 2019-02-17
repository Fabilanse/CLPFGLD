/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Ufal.Parsito {

using System;
using System.Runtime.InteropServices;

public class Children : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IList<int>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Children(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Children obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Children() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          parsito_csharpPINVOKE.delete_Children(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public Children(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (int element in c) {
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

  public int this[int index]  {
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
        throw new ArgumentOutOfRangeException("Capacity");
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

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array)
#else
  public void CopyTo(int[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(int[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, int[] array, int arrayIndex, int count)
#endif
  {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

#if !SWIG_DOTNET_1
  System.Collections.Generic.IEnumerator<int> System.Collections.Generic.IEnumerable<int>.GetEnumerator() {
    return new ChildrenEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new ChildrenEnumerator(this);
  }

  public ChildrenEnumerator GetEnumerator() {
    return new ChildrenEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class ChildrenEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<int>
#endif
  {
    private Children collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ChildrenEnumerator(Children collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public int Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (int)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
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
        throw new InvalidOperationException("Collection modified.");
      }
    }

#if !SWIG_DOTNET_1
    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
#endif
  }

  public void Clear() {
    parsito_csharpPINVOKE.Children_Clear(swigCPtr);
  }

  public void Add(int x) {
    parsito_csharpPINVOKE.Children_Add(swigCPtr, x);
  }

  private uint size() {
    uint ret = parsito_csharpPINVOKE.Children_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = parsito_csharpPINVOKE.Children_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    parsito_csharpPINVOKE.Children_reserve(swigCPtr, n);
  }

  public Children() : this(parsito_csharpPINVOKE.new_Children__SWIG_0(), true) {
  }

  public Children(Children other) : this(parsito_csharpPINVOKE.new_Children__SWIG_1(Children.getCPtr(other)), true) {
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public Children(int capacity) : this(parsito_csharpPINVOKE.new_Children__SWIG_2(capacity), true) {
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private int getitemcopy(int index) {
    int ret = parsito_csharpPINVOKE.Children_getitemcopy(swigCPtr, index);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private int getitem(int index) {
    int ret = parsito_csharpPINVOKE.Children_getitem(swigCPtr, index);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, int val) {
    parsito_csharpPINVOKE.Children_setitem(swigCPtr, index, val);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(Children values) {
    parsito_csharpPINVOKE.Children_AddRange(swigCPtr, Children.getCPtr(values));
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public Children GetRange(int index, int count) {
    IntPtr cPtr = parsito_csharpPINVOKE.Children_GetRange(swigCPtr, index, count);
    Children ret = (cPtr == IntPtr.Zero) ? null : new Children(cPtr, true);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, int x) {
    parsito_csharpPINVOKE.Children_Insert(swigCPtr, index, x);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, Children values) {
    parsito_csharpPINVOKE.Children_InsertRange(swigCPtr, index, Children.getCPtr(values));
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    parsito_csharpPINVOKE.Children_RemoveAt(swigCPtr, index);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    parsito_csharpPINVOKE.Children_RemoveRange(swigCPtr, index, count);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Children Repeat(int value, int count) {
    IntPtr cPtr = parsito_csharpPINVOKE.Children_Repeat(value, count);
    Children ret = (cPtr == IntPtr.Zero) ? null : new Children(cPtr, true);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    parsito_csharpPINVOKE.Children_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    parsito_csharpPINVOKE.Children_Reverse__SWIG_1(swigCPtr, index, count);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, Children values) {
    parsito_csharpPINVOKE.Children_SetRange(swigCPtr, index, Children.getCPtr(values));
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(int value) {
    bool ret = parsito_csharpPINVOKE.Children_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(int value) {
    int ret = parsito_csharpPINVOKE.Children_IndexOf(swigCPtr, value);
    return ret;
  }

  public int LastIndexOf(int value) {
    int ret = parsito_csharpPINVOKE.Children_LastIndexOf(swigCPtr, value);
    return ret;
  }

  public bool Remove(int value) {
    bool ret = parsito_csharpPINVOKE.Children_Remove(swigCPtr, value);
    return ret;
  }

}

}
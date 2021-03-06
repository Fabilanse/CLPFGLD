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

public class Nodes : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerable<Node>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Nodes(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Nodes obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Nodes() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          parsito_csharpPINVOKE.delete_Nodes(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public Nodes(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (Node element in c) {
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

  public Node this[int index]  {
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
  public void CopyTo(Node[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(Node[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, Node[] array, int arrayIndex, int count)
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
  System.Collections.Generic.IEnumerator<Node> System.Collections.Generic.IEnumerable<Node>.GetEnumerator() {
    return new NodesEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new NodesEnumerator(this);
  }

  public NodesEnumerator GetEnumerator() {
    return new NodesEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class NodesEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<Node>
#endif
  {
    private Nodes collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public NodesEnumerator(Nodes collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Node Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (Node)currentObject;
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
    parsito_csharpPINVOKE.Nodes_Clear(swigCPtr);
  }

  public void Add(Node x) {
    parsito_csharpPINVOKE.Nodes_Add(swigCPtr, Node.getCPtr(x));
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = parsito_csharpPINVOKE.Nodes_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = parsito_csharpPINVOKE.Nodes_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    parsito_csharpPINVOKE.Nodes_reserve(swigCPtr, n);
  }

  public Nodes() : this(parsito_csharpPINVOKE.new_Nodes__SWIG_0(), true) {
  }

  public Nodes(Nodes other) : this(parsito_csharpPINVOKE.new_Nodes__SWIG_1(Nodes.getCPtr(other)), true) {
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public Nodes(int capacity) : this(parsito_csharpPINVOKE.new_Nodes__SWIG_2(capacity), true) {
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private Node getitemcopy(int index) {
    Node ret = new Node(parsito_csharpPINVOKE.Nodes_getitemcopy(swigCPtr, index), true);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Node getitem(int index) {
    Node ret = new Node(parsito_csharpPINVOKE.Nodes_getitem(swigCPtr, index), false);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Node val) {
    parsito_csharpPINVOKE.Nodes_setitem(swigCPtr, index, Node.getCPtr(val));
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(Nodes values) {
    parsito_csharpPINVOKE.Nodes_AddRange(swigCPtr, Nodes.getCPtr(values));
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public Nodes GetRange(int index, int count) {
    IntPtr cPtr = parsito_csharpPINVOKE.Nodes_GetRange(swigCPtr, index, count);
    Nodes ret = (cPtr == IntPtr.Zero) ? null : new Nodes(cPtr, true);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Node x) {
    parsito_csharpPINVOKE.Nodes_Insert(swigCPtr, index, Node.getCPtr(x));
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, Nodes values) {
    parsito_csharpPINVOKE.Nodes_InsertRange(swigCPtr, index, Nodes.getCPtr(values));
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    parsito_csharpPINVOKE.Nodes_RemoveAt(swigCPtr, index);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    parsito_csharpPINVOKE.Nodes_RemoveRange(swigCPtr, index, count);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Nodes Repeat(Node value, int count) {
    IntPtr cPtr = parsito_csharpPINVOKE.Nodes_Repeat(Node.getCPtr(value), count);
    Nodes ret = (cPtr == IntPtr.Zero) ? null : new Nodes(cPtr, true);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    parsito_csharpPINVOKE.Nodes_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    parsito_csharpPINVOKE.Nodes_Reverse__SWIG_1(swigCPtr, index, count);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, Nodes values) {
    parsito_csharpPINVOKE.Nodes_SetRange(swigCPtr, index, Nodes.getCPtr(values));
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}

}

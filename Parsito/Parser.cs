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

public class Parser : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Parser(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Parser obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Parser() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          parsito_csharpPINVOKE.delete_Parser(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void parse(Tree t, uint beam_size) {
    parsito_csharpPINVOKE.Parser_parse__SWIG_0(swigCPtr, Tree.getCPtr(t), beam_size);
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void parse(Tree t) {
    parsito_csharpPINVOKE.Parser_parse__SWIG_1(swigCPtr, Tree.getCPtr(t));
    if (parsito_csharpPINVOKE.SWIGPendingException.Pending) throw parsito_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Parser load(string file, uint cache) {
    IntPtr cPtr = parsito_csharpPINVOKE.Parser_load__SWIG_0(file, cache);
    Parser ret = (cPtr == IntPtr.Zero) ? null : new Parser(cPtr, true);
    return ret;
  }

  public static Parser load(string file) {
    IntPtr cPtr = parsito_csharpPINVOKE.Parser_load__SWIG_1(file);
    Parser ret = (cPtr == IntPtr.Zero) ? null : new Parser(cPtr, true);
    return ret;
  }

  public static readonly int NO_CACHE = parsito_csharpPINVOKE.Parser_NO_CACHE_get();
  public static readonly int FULL_CACHE = parsito_csharpPINVOKE.Parser_FULL_CACHE_get();

}

}
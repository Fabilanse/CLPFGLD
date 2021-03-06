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

class parsito_csharpPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [DllImport("parsito_csharp", EntryPoint="SWIGRegisterExceptionCallbacks_parsito_csharp")]
    public static extern void SWIGRegisterExceptionCallbacks_parsito_csharp(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [DllImport("parsito_csharp", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_parsito_csharp")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_parsito_csharp(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_parsito_csharp(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_parsito_csharp(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [ThreadStatic]
    private static Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(Exception e) {
      if (pendingException != null)
        throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(parsito_csharpPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static Exception Retrieve() {
      Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(parsito_csharpPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [DllImport("parsito_csharp", EntryPoint="SWIGRegisterStringCallback_parsito_csharp")]
    public static extern void SWIGRegisterStringCallback_parsito_csharp(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_parsito_csharp(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static parsito_csharpPINVOKE() {
  }


  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_Clear")]
  public static extern void Children_Clear(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_Add")]
  public static extern void Children_Add(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_size")]
  public static extern uint Children_size(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_capacity")]
  public static extern uint Children_capacity(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_reserve")]
  public static extern void Children_reserve(HandleRef jarg1, uint jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Children__SWIG_0")]
  public static extern IntPtr new_Children__SWIG_0();

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Children__SWIG_1")]
  public static extern IntPtr new_Children__SWIG_1(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Children__SWIG_2")]
  public static extern IntPtr new_Children__SWIG_2(int jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_getitemcopy")]
  public static extern int Children_getitemcopy(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_getitem")]
  public static extern int Children_getitem(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_setitem")]
  public static extern void Children_setitem(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_AddRange")]
  public static extern void Children_AddRange(HandleRef jarg1, HandleRef jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_GetRange")]
  public static extern IntPtr Children_GetRange(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_Insert")]
  public static extern void Children_Insert(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_InsertRange")]
  public static extern void Children_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_RemoveAt")]
  public static extern void Children_RemoveAt(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_RemoveRange")]
  public static extern void Children_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_Repeat")]
  public static extern IntPtr Children_Repeat(int jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_Reverse__SWIG_0")]
  public static extern void Children_Reverse__SWIG_0(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_Reverse__SWIG_1")]
  public static extern void Children_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_SetRange")]
  public static extern void Children_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_Contains")]
  public static extern bool Children_Contains(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_IndexOf")]
  public static extern int Children_IndexOf(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_LastIndexOf")]
  public static extern int Children_LastIndexOf(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Children_Remove")]
  public static extern bool Children_Remove(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_delete_Children")]
  public static extern void delete_Children(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_id_set")]
  public static extern void Node_id_set(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_id_get")]
  public static extern int Node_id_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_form_set")]
  public static extern void Node_form_set(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_form_get")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string Node_form_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_lemma_set")]
  public static extern void Node_lemma_set(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_lemma_get")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string Node_lemma_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_upostag_set")]
  public static extern void Node_upostag_set(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_upostag_get")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string Node_upostag_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_xpostag_set")]
  public static extern void Node_xpostag_set(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_xpostag_get")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string Node_xpostag_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_feats_set")]
  public static extern void Node_feats_set(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_feats_get")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string Node_feats_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_head_set")]
  public static extern void Node_head_set(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_head_get")]
  public static extern int Node_head_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_deprel_set")]
  public static extern void Node_deprel_set(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_deprel_get")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string Node_deprel_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_deps_set")]
  public static extern void Node_deps_set(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_deps_get")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string Node_deps_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_misc_set")]
  public static extern void Node_misc_set(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_misc_get")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string Node_misc_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_children_set")]
  public static extern void Node_children_set(HandleRef jarg1, HandleRef jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Node_children_get")]
  public static extern IntPtr Node_children_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Node__SWIG_0")]
  public static extern IntPtr new_Node__SWIG_0(int jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Node__SWIG_1")]
  public static extern IntPtr new_Node__SWIG_1(int jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Node__SWIG_2")]
  public static extern IntPtr new_Node__SWIG_2();

  [DllImport("parsito_csharp", EntryPoint="CSharp_delete_Node")]
  public static extern void delete_Node(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_Clear")]
  public static extern void Nodes_Clear(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_Add")]
  public static extern void Nodes_Add(HandleRef jarg1, HandleRef jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_size")]
  public static extern uint Nodes_size(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_capacity")]
  public static extern uint Nodes_capacity(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_reserve")]
  public static extern void Nodes_reserve(HandleRef jarg1, uint jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Nodes__SWIG_0")]
  public static extern IntPtr new_Nodes__SWIG_0();

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Nodes__SWIG_1")]
  public static extern IntPtr new_Nodes__SWIG_1(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Nodes__SWIG_2")]
  public static extern IntPtr new_Nodes__SWIG_2(int jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_getitemcopy")]
  public static extern IntPtr Nodes_getitemcopy(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_getitem")]
  public static extern IntPtr Nodes_getitem(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_setitem")]
  public static extern void Nodes_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_AddRange")]
  public static extern void Nodes_AddRange(HandleRef jarg1, HandleRef jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_GetRange")]
  public static extern IntPtr Nodes_GetRange(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_Insert")]
  public static extern void Nodes_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_InsertRange")]
  public static extern void Nodes_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_RemoveAt")]
  public static extern void Nodes_RemoveAt(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_RemoveRange")]
  public static extern void Nodes_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_Repeat")]
  public static extern IntPtr Nodes_Repeat(HandleRef jarg1, int jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_Reverse__SWIG_0")]
  public static extern void Nodes_Reverse__SWIG_0(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_Reverse__SWIG_1")]
  public static extern void Nodes_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Nodes_SetRange")]
  public static extern void Nodes_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_delete_Nodes")]
  public static extern void delete_Nodes(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Tree")]
  public static extern IntPtr new_Tree();

  [DllImport("parsito_csharp", EntryPoint="CSharp_Tree_nodes_set")]
  public static extern void Tree_nodes_set(HandleRef jarg1, HandleRef jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Tree_nodes_get")]
  public static extern IntPtr Tree_nodes_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Tree_empty")]
  public static extern bool Tree_empty(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Tree_clear")]
  public static extern void Tree_clear(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Tree_addNode")]
  public static extern IntPtr Tree_addNode(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Tree_setHead")]
  public static extern void Tree_setHead(HandleRef jarg1, int jarg2, int jarg3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg4);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Tree_unlinkAllNodes")]
  public static extern void Tree_unlinkAllNodes(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Tree_root_form_get")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string Tree_root_form_get();

  [DllImport("parsito_csharp", EntryPoint="CSharp_delete_Tree")]
  public static extern void delete_Tree(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_delete_TreeInputFormat")]
  public static extern void delete_TreeInputFormat(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_TreeInputFormat_setText")]
  public static extern void TreeInputFormat_setText(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_TreeInputFormat_nextTree")]
  public static extern bool TreeInputFormat_nextTree(HandleRef jarg1, HandleRef jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_TreeInputFormat_lastError")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string TreeInputFormat_lastError(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_TreeInputFormat_newInputFormat")]
  public static extern IntPtr TreeInputFormat_newInputFormat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_TreeInputFormat_newConlluInputFormat")]
  public static extern IntPtr TreeInputFormat_newConlluInputFormat();

  [DllImport("parsito_csharp", EntryPoint="CSharp_delete_TreeOutputFormat")]
  public static extern void delete_TreeOutputFormat(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_TreeOutputFormat_writeTree__SWIG_0")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string TreeOutputFormat_writeTree__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_TreeOutputFormat_writeTree__SWIG_1")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string TreeOutputFormat_writeTree__SWIG_1(HandleRef jarg1, HandleRef jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_TreeOutputFormat_newOutputFormat")]
  public static extern IntPtr TreeOutputFormat_newOutputFormat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_TreeOutputFormat_newConlluOutputFormat")]
  public static extern IntPtr TreeOutputFormat_newConlluOutputFormat();

  [DllImport("parsito_csharp", EntryPoint="CSharp_Version_major_set")]
  public static extern void Version_major_set(HandleRef jarg1, uint jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Version_major_get")]
  public static extern uint Version_major_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Version_minor_set")]
  public static extern void Version_minor_set(HandleRef jarg1, uint jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Version_minor_get")]
  public static extern uint Version_minor_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Version_patch_set")]
  public static extern void Version_patch_set(HandleRef jarg1, uint jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Version_patch_get")]
  public static extern uint Version_patch_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Version_prerelease_set")]
  public static extern void Version_prerelease_set(HandleRef jarg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Version_prerelease_get")]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
  public static extern string Version_prerelease_get(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Version_current")]
  public static extern IntPtr Version_current();

  [DllImport("parsito_csharp", EntryPoint="CSharp_new_Version")]
  public static extern IntPtr new_Version();

  [DllImport("parsito_csharp", EntryPoint="CSharp_delete_Version")]
  public static extern void delete_Version(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_delete_Parser")]
  public static extern void delete_Parser(HandleRef jarg1);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Parser_parse__SWIG_0")]
  public static extern void Parser_parse__SWIG_0(HandleRef jarg1, HandleRef jarg2, uint jarg3);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Parser_parse__SWIG_1")]
  public static extern void Parser_parse__SWIG_1(HandleRef jarg1, HandleRef jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Parser_NO_CACHE_get")]
  public static extern int Parser_NO_CACHE_get();

  [DllImport("parsito_csharp", EntryPoint="CSharp_Parser_FULL_CACHE_get")]
  public static extern int Parser_FULL_CACHE_get();

  [DllImport("parsito_csharp", EntryPoint="CSharp_Parser_load__SWIG_0")]
  public static extern IntPtr Parser_load__SWIG_0([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg1, uint jarg2);

  [DllImport("parsito_csharp", EntryPoint="CSharp_Parser_load__SWIG_1")]
  public static extern IntPtr Parser_load__SWIG_1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string jarg1);

public class UTF8Marshaler : System.Runtime.InteropServices.ICustomMarshaler {
    static UTF8Marshaler static_instance;

    public System.IntPtr MarshalManagedToNative(object managedObj) {
        if (managedObj == null)
            return System.IntPtr.Zero;
        if (!(managedObj is string))
            throw new System.Runtime.InteropServices.MarshalDirectiveException("UTF8Marshaler must be used on a string.");

        // not null terminated
        byte[] strbuf = System.Text.Encoding.UTF8.GetBytes((string)managedObj);
        System.IntPtr buffer = System.Runtime.InteropServices.Marshal.AllocHGlobal(strbuf.Length + 1);
        System.Runtime.InteropServices.Marshal.Copy(strbuf, 0, buffer, strbuf.Length);

        // write the terminating null
        System.Runtime.InteropServices.Marshal.WriteByte(buffer + strbuf.Length, 0);
        return buffer;
    }

    public object MarshalNativeToManaged(System.IntPtr pNativeData) {
        int length = 0;
        while (System.Runtime.InteropServices.Marshal.ReadByte(pNativeData, length) != 0)
            length++;

        // should not be null terminated
        byte[] strbuf = new byte[length];
        // skip the trailing null
        System.Runtime.InteropServices.Marshal.Copy((System.IntPtr)pNativeData, strbuf, 0, length);
        string data = System.Text.Encoding.UTF8.GetString(strbuf);
        return data;
    }

    public void CleanUpNativeData(System.IntPtr pNativeData) {
        System.Runtime.InteropServices.Marshal.FreeHGlobal(pNativeData);
    }

    public void CleanUpManagedData(object managedObj) {
    }

    public int GetNativeDataSize() {
        return -1;
    }

    public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string cookie) {
        if (static_instance == null)
            return static_instance = new UTF8Marshaler();
        return static_instance;
    }
}

}

}

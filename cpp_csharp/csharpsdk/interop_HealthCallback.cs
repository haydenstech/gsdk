//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Microsoft.Playfab.Gaming {

class interop_HealthCallback : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal interop_HealthCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(interop_HealthCallback obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~interop_HealthCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          interop_gsdkPINVOKE.delete_interop_HealthCallback(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool OnHealthCheck() {
    bool ret = interop_gsdkPINVOKE.interop_HealthCallback_OnHealthCheck(swigCPtr);
    return ret;
  }

  public interop_HealthCallback() : this(interop_gsdkPINVOKE.new_interop_HealthCallback(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnHealthCheck", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateinterop_HealthCallback_0(SwigDirectorOnHealthCheck);
    interop_gsdkPINVOKE.interop_HealthCallback_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(interop_HealthCallback));
    return hasDerivedMethod;
  }

  private bool SwigDirectorOnHealthCheck() {
    return OnHealthCheck();
  }

  public delegate bool SwigDelegateinterop_HealthCallback_0();

  private SwigDelegateinterop_HealthCallback_0 swigDelegate0;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
}

}
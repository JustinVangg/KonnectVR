//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class vx_req_aux_global_monitor_keyboard_mouse_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vx_req_aux_global_monitor_keyboard_mouse_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(vx_req_aux_global_monitor_keyboard_mouse_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~vx_req_aux_global_monitor_keyboard_mouse_t() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VivoxCoreInstancePINVOKE.delete_vx_req_aux_global_monitor_keyboard_mouse_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

        public static implicit operator vx_req_base_t(vx_req_aux_global_monitor_keyboard_mouse_t t) {
            return t.base_;
        }
        
  public vx_req_base_t base_ {
    set {
      VivoxCoreInstancePINVOKE.vx_req_aux_global_monitor_keyboard_mouse_t_base__set(swigCPtr, vx_req_base_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_req_aux_global_monitor_keyboard_mouse_t_base__get(swigCPtr);
      vx_req_base_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new vx_req_base_t(cPtr, false);
      return ret;
    } 
  }

  public string name {
    set {
      VivoxCoreInstancePINVOKE.vx_req_aux_global_monitor_keyboard_mouse_t_name_set(swigCPtr, value);
    } 
    get {
      string ret = VivoxCoreInstancePINVOKE.vx_req_aux_global_monitor_keyboard_mouse_t_name_get(swigCPtr);
      return ret;
    } 
  }

  public int code_count {
    set {
      VivoxCoreInstancePINVOKE.vx_req_aux_global_monitor_keyboard_mouse_t_code_count_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_req_aux_global_monitor_keyboard_mouse_t_code_count_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int codes {
    set {
      VivoxCoreInstancePINVOKE.vx_req_aux_global_monitor_keyboard_mouse_t_codes_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_req_aux_global_monitor_keyboard_mouse_t_codes_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public vx_req_aux_global_monitor_keyboard_mouse_t() : this(VivoxCoreInstancePINVOKE.new_vx_req_aux_global_monitor_keyboard_mouse_t(), true) {
  }

}

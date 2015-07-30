using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview.Gestures {

	// Metadata.xml XPath interface reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/interface[@name='GestureDetector']"
	[Register ("uk/co/senab/photoview/gestures/GestureDetector", "", "UK.CO.Senab.Photoview.Gestures.IGestureDetectorInvoker")]
	public partial interface IGestureDetector : IJavaObject {

		bool IsDragging {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/interface[@name='GestureDetector']/method[@name='isDragging' and count(parameter)=0]"
			[Register ("isDragging", "()Z", "GetIsDraggingHandler:UK.CO.Senab.Photoview.Gestures.IGestureDetectorInvoker, PhotoViewer")] get;
		}

		bool IsScaling {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/interface[@name='GestureDetector']/method[@name='isScaling' and count(parameter)=0]"
			[Register ("isScaling", "()Z", "GetIsScalingHandler:UK.CO.Senab.Photoview.Gestures.IGestureDetectorInvoker, PhotoViewer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/interface[@name='GestureDetector']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler:UK.CO.Senab.Photoview.Gestures.IGestureDetectorInvoker, PhotoViewer")]
		bool OnTouchEvent (global::Android.Views.MotionEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/interface[@name='GestureDetector']/method[@name='setOnGestureListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.gestures.OnGestureListener']]"
		[Register ("setOnGestureListener", "(Luk/co/senab/photoview/gestures/OnGestureListener;)V", "GetSetOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_Handler:UK.CO.Senab.Photoview.Gestures.IGestureDetectorInvoker, PhotoViewer")]
		void SetOnGestureListener (global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener p0);

	}

	[global::Android.Runtime.Register ("uk/co/senab/photoview/gestures/GestureDetector", DoNotGenerateAcw=true)]
	internal class IGestureDetectorInvoker : global::Java.Lang.Object, IGestureDetector {

		static IntPtr java_class_ref = JNIEnv.FindClass ("uk/co/senab/photoview/gestures/GestureDetector");
		IntPtr class_ref;

		public static IGestureDetector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGestureDetector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "uk.co.senab.photoview.gestures.GestureDetector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGestureDetectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGestureDetectorInvoker); }
		}

		static Delegate cb_isDragging;
#pragma warning disable 0169
		static Delegate GetIsDraggingHandler ()
		{
			if (cb_isDragging == null)
				cb_isDragging = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDragging);
			return cb_isDragging;
		}

		static bool n_IsDragging (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.Gestures.IGestureDetector __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDragging;
		}
#pragma warning restore 0169

		IntPtr id_isDragging;
		public unsafe bool IsDragging {
			get {
				if (id_isDragging == IntPtr.Zero)
					id_isDragging = JNIEnv.GetMethodID (class_ref, "isDragging", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isDragging);
			}
		}

		static Delegate cb_isScaling;
#pragma warning disable 0169
		static Delegate GetIsScalingHandler ()
		{
			if (cb_isScaling == null)
				cb_isScaling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScaling);
			return cb_isScaling;
		}

		static bool n_IsScaling (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.Gestures.IGestureDetector __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsScaling;
		}
#pragma warning restore 0169

		IntPtr id_isScaling;
		public unsafe bool IsScaling {
			get {
				if (id_isScaling == IntPtr.Zero)
					id_isScaling = JNIEnv.GetMethodID (class_ref, "isScaling", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isScaling);
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.Gestures.IGestureDetector __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		public unsafe bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, __args);
			return __ret;
		}

		static Delegate cb_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_;
#pragma warning disable 0169
		static Delegate GetSetOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_Handler ()
		{
			if (cb_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_ == null)
				cb_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_);
			return cb_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_;
		}

		static void n_SetOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.Gestures.IGestureDetector __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener p0 = (global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener)global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnGestureListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_;
		public unsafe void SetOnGestureListener (global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener p0)
		{
			if (id_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_ == IntPtr.Zero)
				id_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_ = JNIEnv.GetMethodID (class_ref, "setOnGestureListener", "(Luk/co/senab/photoview/gestures/OnGestureListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_, __args);
		}

	}

}

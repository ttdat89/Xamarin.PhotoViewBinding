using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview {

	// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='DefaultOnDoubleTapListener']"
	[global::Android.Runtime.Register ("uk/co/senab/photoview/DefaultOnDoubleTapListener", DoNotGenerateAcw=true)]
	public partial class DefaultOnDoubleTapListener : global::Java.Lang.Object, global::Android.Views.GestureDetector.IOnDoubleTapListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("uk/co/senab/photoview/DefaultOnDoubleTapListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultOnDoubleTapListener); }
		}

		protected DefaultOnDoubleTapListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='DefaultOnDoubleTapListener']/constructor[@name='DefaultOnDoubleTapListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher']]"
		[Register (".ctor", "(Luk/co/senab/photoview/PhotoViewAttacher;)V", "")]
		public unsafe DefaultOnDoubleTapListener (global::UK.CO.Senab.Photoview.PhotoViewAttacher p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DefaultOnDoubleTapListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Luk/co/senab/photoview/PhotoViewAttacher;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Luk/co/senab/photoview/PhotoViewAttacher;)V", __args);
					return;
				}

				if (id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_ == IntPtr.Zero)
					id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Luk/co/senab/photoview/PhotoViewAttacher;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_, __args);
			} finally {
			}
		}

		static Delegate cb_onDoubleTap_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnDoubleTap_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onDoubleTap_Landroid_view_MotionEvent_ == null)
				cb_onDoubleTap_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTap_Landroid_view_MotionEvent_);
			return cb_onDoubleTap_Landroid_view_MotionEvent_;
		}

		static bool n_OnDoubleTap_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.DefaultOnDoubleTapListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.DefaultOnDoubleTapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDoubleTap (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDoubleTap_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='DefaultOnDoubleTapListener']/method[@name='onDoubleTap' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onDoubleTap", "(Landroid/view/MotionEvent;)Z", "GetOnDoubleTap_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnDoubleTap (global::Android.Views.MotionEvent p0)
		{
			if (id_onDoubleTap_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onDoubleTap_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDoubleTap_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onDoubleTapEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnDoubleTapEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onDoubleTapEvent_Landroid_view_MotionEvent_ == null)
				cb_onDoubleTapEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTapEvent_Landroid_view_MotionEvent_);
			return cb_onDoubleTapEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnDoubleTapEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.DefaultOnDoubleTapListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.DefaultOnDoubleTapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDoubleTapEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDoubleTapEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='DefaultOnDoubleTapListener']/method[@name='onDoubleTapEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z", "GetOnDoubleTapEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnDoubleTapEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onDoubleTapEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onDoubleTapEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDoubleTapEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onSingleTapConfirmed_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onSingleTapConfirmed_Landroid_view_MotionEvent_ == null)
				cb_onSingleTapConfirmed_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapConfirmed_Landroid_view_MotionEvent_);
			return cb_onSingleTapConfirmed_Landroid_view_MotionEvent_;
		}

		static bool n_OnSingleTapConfirmed_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.DefaultOnDoubleTapListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.DefaultOnDoubleTapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSingleTapConfirmed (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSingleTapConfirmed_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='DefaultOnDoubleTapListener']/method[@name='onSingleTapConfirmed' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z", "GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnSingleTapConfirmed (global::Android.Views.MotionEvent p0)
		{
			if (id_onSingleTapConfirmed_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onSingleTapConfirmed_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSingleTapConfirmed_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_;
#pragma warning disable 0169
		static Delegate GetSetPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_Handler ()
		{
			if (cb_setPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_ == null)
				cb_setPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_);
			return cb_setPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_;
		}

		static void n_SetPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.DefaultOnDoubleTapListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.DefaultOnDoubleTapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.PhotoViewAttacher p0 = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPhotoViewAttacher (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='DefaultOnDoubleTapListener']/method[@name='setPhotoViewAttacher' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher']]"
		[Register ("setPhotoViewAttacher", "(Luk/co/senab/photoview/PhotoViewAttacher;)V", "GetSetPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_Handler")]
		public virtual unsafe void SetPhotoViewAttacher (global::UK.CO.Senab.Photoview.PhotoViewAttacher p0)
		{
			if (id_setPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_ == IntPtr.Zero)
				id_setPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_ = JNIEnv.GetMethodID (class_ref, "setPhotoViewAttacher", "(Luk/co/senab/photoview/PhotoViewAttacher;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPhotoViewAttacher_Luk_co_senab_photoview_PhotoViewAttacher_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhotoViewAttacher", "(Luk/co/senab/photoview/PhotoViewAttacher;)V"), __args);
			} finally {
			}
		}

	}
}

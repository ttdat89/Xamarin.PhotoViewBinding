using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='CupcakeGestureDetector']"
	[global::Android.Runtime.Register ("uk/co/senab/photoview/gestures/CupcakeGestureDetector", DoNotGenerateAcw=true)]
	public partial class CupcakeGestureDetector : global::Java.Lang.Object, global::UK.CO.Senab.Photoview.Gestures.IGestureDetector {


		static IntPtr mListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='CupcakeGestureDetector']/field[@name='mListener']"
		[Register ("mListener")]
		protected global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener MListener {
			get {
				if (mListener_jfieldId == IntPtr.Zero)
					mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Luk/co/senab/photoview/gestures/OnGestureListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mListener_jfieldId == IntPtr.Zero)
					mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Luk/co/senab/photoview/gestures/OnGestureListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("uk/co/senab/photoview/gestures/CupcakeGestureDetector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CupcakeGestureDetector); }
		}

		protected CupcakeGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='CupcakeGestureDetector']/constructor[@name='CupcakeGestureDetector' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CupcakeGestureDetector (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CupcakeGestureDetector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
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
			global::UK.CO.Senab.Photoview.Gestures.CupcakeGestureDetector __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.CupcakeGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDragging;
		}
#pragma warning restore 0169

		static IntPtr id_isDragging;
		public virtual unsafe bool IsDragging {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='CupcakeGestureDetector']/method[@name='isDragging' and count(parameter)=0]"
			[Register ("isDragging", "()Z", "GetIsDraggingHandler")]
			get {
				if (id_isDragging == IntPtr.Zero)
					id_isDragging = JNIEnv.GetMethodID (class_ref, "isDragging", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDragging);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDragging", "()Z"));
				} finally {
				}
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
			global::UK.CO.Senab.Photoview.Gestures.CupcakeGestureDetector __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.CupcakeGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsScaling;
		}
#pragma warning restore 0169

		static IntPtr id_isScaling;
		public virtual unsafe bool IsScaling {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='CupcakeGestureDetector']/method[@name='isScaling' and count(parameter)=0]"
			[Register ("isScaling", "()Z", "GetIsScalingHandler")]
			get {
				if (id_isScaling == IntPtr.Zero)
					id_isScaling = JNIEnv.GetMethodID (class_ref, "isScaling", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isScaling);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isScaling", "()Z"));
				} finally {
				}
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
			global::UK.CO.Senab.Photoview.Gestures.CupcakeGestureDetector __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.CupcakeGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='CupcakeGestureDetector']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
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
			global::UK.CO.Senab.Photoview.Gestures.CupcakeGestureDetector __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.CupcakeGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener p0 = (global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener)global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnGestureListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='CupcakeGestureDetector']/method[@name='setOnGestureListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.gestures.OnGestureListener']]"
		[Register ("setOnGestureListener", "(Luk/co/senab/photoview/gestures/OnGestureListener;)V", "GetSetOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_Handler")]
		public virtual unsafe void SetOnGestureListener (global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener p0)
		{
			if (id_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_ == IntPtr.Zero)
				id_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_ = JNIEnv.GetMethodID (class_ref, "setOnGestureListener", "(Luk/co/senab/photoview/gestures/OnGestureListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnGestureListener_Luk_co_senab_photoview_gestures_OnGestureListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnGestureListener", "(Luk/co/senab/photoview/gestures/OnGestureListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for UK.CO.Senab.Photoview.Gestures.IOnGestureListener"
		public event EventHandler<global::UK.CO.Senab.Photoview.Gestures.DragEventArgs> Drag {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener, global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor>(
						ref weak_implementor_SetOnGestureListener,
						__CreateIOnGestureListenerImplementor,
						SetOnGestureListener,
						__h => __h.OnDragHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener, global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor>(
						ref weak_implementor_SetOnGestureListener,
						global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor.__IsEmpty,
						__v => SetOnGestureListener (null),
						__h => __h.OnDragHandler -= value);
			}
		}

		public event EventHandler<global::UK.CO.Senab.Photoview.Gestures.FlingEventArgs> Fling {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener, global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor>(
						ref weak_implementor_SetOnGestureListener,
						__CreateIOnGestureListenerImplementor,
						SetOnGestureListener,
						__h => __h.OnFlingHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener, global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor>(
						ref weak_implementor_SetOnGestureListener,
						global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor.__IsEmpty,
						__v => SetOnGestureListener (null),
						__h => __h.OnFlingHandler -= value);
			}
		}

		public event EventHandler<global::UK.CO.Senab.Photoview.Gestures.ScaleEventArgs> Scale {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener, global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor>(
						ref weak_implementor_SetOnGestureListener,
						__CreateIOnGestureListenerImplementor,
						SetOnGestureListener,
						__h => __h.OnScaleHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener, global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor>(
						ref weak_implementor_SetOnGestureListener,
						global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor.__IsEmpty,
						__v => SetOnGestureListener (null),
						__h => __h.OnScaleHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnGestureListener;

		global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor __CreateIOnGestureListenerImplementor ()
		{
			return new global::UK.CO.Senab.Photoview.Gestures.IOnGestureListenerImplementor (this);
		}
#endregion
	}
}

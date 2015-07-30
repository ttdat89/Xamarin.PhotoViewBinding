using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview {

	// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']"
	[global::Android.Runtime.Register ("uk/co/senab/photoview/PhotoViewAttacher", DoNotGenerateAcw=true)]
	public partial class PhotoViewAttacher : global::Java.Lang.Object, global::Android.Views.View.IOnTouchListener, global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener, global::UK.CO.Senab.Photoview.IPhotoViewInterface, global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener {


		public static class InterfaceConsts {

			// The following are fields from: uk.co.senab.photoview.IPhotoView

			// Metadata.xml XPath field reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='IPhotoView']/field[@name='DEFAULT_MAX_SCALE']"
			[Register ("DEFAULT_MAX_SCALE")]
			public const float DefaultMaxScale = (float) 3.000000;

			// Metadata.xml XPath field reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='IPhotoView']/field[@name='DEFAULT_MID_SCALE']"
			[Register ("DEFAULT_MID_SCALE")]
			public const float DefaultMidScale = (float) 1.750000;

			// Metadata.xml XPath field reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='IPhotoView']/field[@name='DEFAULT_MIN_SCALE']"
			[Register ("DEFAULT_MIN_SCALE")]
			public const float DefaultMinScale = (float) 1.000000;

			// Metadata.xml XPath field reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='IPhotoView']/field[@name='DEFAULT_ZOOM_DURATION']"
			[Register ("DEFAULT_ZOOM_DURATION")]
			public const int DefaultZoomDuration = (int) 200;
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher.AnimatedZoomRunnable']"
		[global::Android.Runtime.Register ("uk/co/senab/photoview/PhotoViewAttacher$AnimatedZoomRunnable", DoNotGenerateAcw=true)]
		public partial class AnimatedZoomRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("uk/co/senab/photoview/PhotoViewAttacher$AnimatedZoomRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AnimatedZoomRunnable); }
			}

			protected AnimatedZoomRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_FFFF;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher.AnimatedZoomRunnable']/constructor[@name='PhotoViewAttacher.AnimatedZoomRunnable' and count(parameter)=5 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
			[Register (".ctor", "(Luk/co/senab/photoview/PhotoViewAttacher;FFFF)V", "")]
			public unsafe AnimatedZoomRunnable (global::UK.CO.Senab.Photoview.PhotoViewAttacher __self, float p1, float p2, float p3, float p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					if (GetType () != typeof (AnimatedZoomRunnable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";FFFF)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";FFFF)V", __args);
						return;
					}

					if (id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_FFFF == IntPtr.Zero)
						id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_FFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(Luk/co/senab/photoview/PhotoViewAttacher;FFFF)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_FFFF, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_FFFF, __args);
				} finally {
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::UK.CO.Senab.Photoview.PhotoViewAttacher.AnimatedZoomRunnable __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.AnimatedZoomRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher.AnimatedZoomRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher.FlingRunnable']"
		[global::Android.Runtime.Register ("uk/co/senab/photoview/PhotoViewAttacher$FlingRunnable", DoNotGenerateAcw=true)]
		public partial class FlingRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("uk/co/senab/photoview/PhotoViewAttacher$FlingRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FlingRunnable); }
			}

			protected FlingRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher.FlingRunnable']/constructor[@name='PhotoViewAttacher.FlingRunnable' and count(parameter)=2 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Luk/co/senab/photoview/PhotoViewAttacher;Landroid/content/Context;)V", "")]
			public unsafe FlingRunnable (global::UK.CO.Senab.Photoview.PhotoViewAttacher __self, global::Android.Content.Context p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (FlingRunnable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Luk/co/senab/photoview/PhotoViewAttacher;Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Luk_co_senab_photoview_PhotoViewAttacher_Landroid_content_Context_, __args);
				} finally {
				}
			}

			static Delegate cb_cancelFling;
#pragma warning disable 0169
			static Delegate GetCancelFlingHandler ()
			{
				if (cb_cancelFling == null)
					cb_cancelFling = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelFling);
				return cb_cancelFling;
			}

			static void n_CancelFling (IntPtr jnienv, IntPtr native__this)
			{
				global::UK.CO.Senab.Photoview.PhotoViewAttacher.FlingRunnable __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.FlingRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.CancelFling ();
			}
#pragma warning restore 0169

			static IntPtr id_cancelFling;
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher.FlingRunnable']/method[@name='cancelFling' and count(parameter)=0]"
			[Register ("cancelFling", "()V", "GetCancelFlingHandler")]
			public virtual unsafe void CancelFling ()
			{
				if (id_cancelFling == IntPtr.Zero)
					id_cancelFling = JNIEnv.GetMethodID (class_ref, "cancelFling", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_cancelFling);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelFling", "()V"));
				} finally {
				}
			}

			static Delegate cb_fling_IIII;
#pragma warning disable 0169
			static Delegate GetFling_IIIIHandler ()
			{
				if (cb_fling_IIII == null)
					cb_fling_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_Fling_IIII);
				return cb_fling_IIII;
			}

			static void n_Fling_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
			{
				global::UK.CO.Senab.Photoview.PhotoViewAttacher.FlingRunnable __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.FlingRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Fling (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_fling_IIII;
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher.FlingRunnable']/method[@name='fling' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("fling", "(IIII)V", "GetFling_IIIIHandler")]
			public virtual unsafe void Fling (int p0, int p1, int p2, int p3)
			{
				if (id_fling_IIII == IntPtr.Zero)
					id_fling_IIII = JNIEnv.GetMethodID (class_ref, "fling", "(IIII)V");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_fling_IIII, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fling", "(IIII)V"), __args);
				} finally {
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::UK.CO.Senab.Photoview.PhotoViewAttacher.FlingRunnable __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.FlingRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher.FlingRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='PhotoViewAttacher.OnMatrixChangedListener']"
		[Register ("uk/co/senab/photoview/PhotoViewAttacher$OnMatrixChangedListener", "", "UK.CO.Senab.Photoview.PhotoViewAttacher/IOnMatrixChangedListenerInvoker")]
		public partial interface IOnMatrixChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='PhotoViewAttacher.OnMatrixChangedListener']/method[@name='onMatrixChanged' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
			[Register ("onMatrixChanged", "(Landroid/graphics/RectF;)V", "GetOnMatrixChanged_Landroid_graphics_RectF_Handler:UK.CO.Senab.Photoview.PhotoViewAttacher/IOnMatrixChangedListenerInvoker, PhotoViewer")]
			void OnMatrixChanged (global::Android.Graphics.RectF p0);

		}

		[global::Android.Runtime.Register ("uk/co/senab/photoview/PhotoViewAttacher$OnMatrixChangedListener", DoNotGenerateAcw=true)]
		internal class IOnMatrixChangedListenerInvoker : global::Java.Lang.Object, IOnMatrixChangedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("uk/co/senab/photoview/PhotoViewAttacher$OnMatrixChangedListener");
			IntPtr class_ref;

			public static IOnMatrixChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMatrixChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "uk.co.senab.photoview.PhotoViewAttacher.OnMatrixChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMatrixChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMatrixChangedListenerInvoker); }
			}

			static Delegate cb_onMatrixChanged_Landroid_graphics_RectF_;
#pragma warning disable 0169
			static Delegate GetOnMatrixChanged_Landroid_graphics_RectF_Handler ()
			{
				if (cb_onMatrixChanged_Landroid_graphics_RectF_ == null)
					cb_onMatrixChanged_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMatrixChanged_Landroid_graphics_RectF_);
				return cb_onMatrixChanged_Landroid_graphics_RectF_;
			}

			static void n_OnMatrixChanged_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.RectF p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMatrixChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMatrixChanged_Landroid_graphics_RectF_;
			public unsafe void OnMatrixChanged (global::Android.Graphics.RectF p0)
			{
				if (id_onMatrixChanged_Landroid_graphics_RectF_ == IntPtr.Zero)
					id_onMatrixChanged_Landroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "onMatrixChanged", "(Landroid/graphics/RectF;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onMatrixChanged_Landroid_graphics_RectF_, __args);
			}

		}

		public partial class MatrixChangedEventArgs : global::System.EventArgs {

			public MatrixChangedEventArgs (global::Android.Graphics.RectF p0)
			{
				this.p0 = p0;
			}

			global::Android.Graphics.RectF p0;
			public global::Android.Graphics.RectF P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/uk/co/senab/photoview/PhotoViewAttacher_OnMatrixChangedListenerImplementor")]
		internal sealed partial class IOnMatrixChangedListenerImplementor : global::Java.Lang.Object, IOnMatrixChangedListener {

			object sender;

			public IOnMatrixChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/uk/co/senab/photoview/PhotoViewAttacher_OnMatrixChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MatrixChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnMatrixChanged (global::Android.Graphics.RectF p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MatrixChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMatrixChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='PhotoViewAttacher.OnPhotoTapListener']"
		[Register ("uk/co/senab/photoview/PhotoViewAttacher$OnPhotoTapListener", "", "UK.CO.Senab.Photoview.PhotoViewAttacher/IOnPhotoTapListenerInvoker")]
		public partial interface IOnPhotoTapListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='PhotoViewAttacher.OnPhotoTapListener']/method[@name='onPhotoTap' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onPhotoTap", "(Landroid/view/View;FF)V", "GetOnPhotoTap_Landroid_view_View_FFHandler:UK.CO.Senab.Photoview.PhotoViewAttacher/IOnPhotoTapListenerInvoker, PhotoViewer")]
			void OnPhotoTap (global::Android.Views.View p0, float p1, float p2);

		}

		[global::Android.Runtime.Register ("uk/co/senab/photoview/PhotoViewAttacher$OnPhotoTapListener", DoNotGenerateAcw=true)]
		internal class IOnPhotoTapListenerInvoker : global::Java.Lang.Object, IOnPhotoTapListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("uk/co/senab/photoview/PhotoViewAttacher$OnPhotoTapListener");
			IntPtr class_ref;

			public static IOnPhotoTapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPhotoTapListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "uk.co.senab.photoview.PhotoViewAttacher.OnPhotoTapListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPhotoTapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnPhotoTapListenerInvoker); }
			}

			static Delegate cb_onPhotoTap_Landroid_view_View_FF;
#pragma warning disable 0169
			static Delegate GetOnPhotoTap_Landroid_view_View_FFHandler ()
			{
				if (cb_onPhotoTap_Landroid_view_View_FF == null)
					cb_onPhotoTap_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnPhotoTap_Landroid_view_View_FF);
				return cb_onPhotoTap_Landroid_view_View_FF;
			}

			static void n_OnPhotoTap_Landroid_view_View_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
			{
				global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPhotoTap (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onPhotoTap_Landroid_view_View_FF;
			public unsafe void OnPhotoTap (global::Android.Views.View p0, float p1, float p2)
			{
				if (id_onPhotoTap_Landroid_view_View_FF == IntPtr.Zero)
					id_onPhotoTap_Landroid_view_View_FF = JNIEnv.GetMethodID (class_ref, "onPhotoTap", "(Landroid/view/View;FF)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_onPhotoTap_Landroid_view_View_FF, __args);
			}

		}

		public partial class PhotoTapEventArgs : global::System.EventArgs {

			public PhotoTapEventArgs (global::Android.Views.View p0, float p1, float p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}

			float p2;
			public float P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/uk/co/senab/photoview/PhotoViewAttacher_OnPhotoTapListenerImplementor")]
		internal sealed partial class IOnPhotoTapListenerImplementor : global::Java.Lang.Object, IOnPhotoTapListener {

			object sender;

			public IOnPhotoTapListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/uk/co/senab/photoview/PhotoViewAttacher_OnPhotoTapListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PhotoTapEventArgs> Handler;
#pragma warning restore 0649

			public void OnPhotoTap (global::Android.Views.View p0, float p1, float p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PhotoTapEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnPhotoTapListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='PhotoViewAttacher.OnScaleChangeListener']"
		[Register ("uk/co/senab/photoview/PhotoViewAttacher$OnScaleChangeListener", "", "UK.CO.Senab.Photoview.PhotoViewAttacher/IOnScaleChangeListenerInvoker")]
		public partial interface IOnScaleChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='PhotoViewAttacher.OnScaleChangeListener']/method[@name='onScaleChange' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onScaleChange", "(FFF)V", "GetOnScaleChange_FFFHandler:UK.CO.Senab.Photoview.PhotoViewAttacher/IOnScaleChangeListenerInvoker, PhotoViewer")]
			void OnScaleChange (float p0, float p1, float p2);

		}

		[global::Android.Runtime.Register ("uk/co/senab/photoview/PhotoViewAttacher$OnScaleChangeListener", DoNotGenerateAcw=true)]
		internal class IOnScaleChangeListenerInvoker : global::Java.Lang.Object, IOnScaleChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("uk/co/senab/photoview/PhotoViewAttacher$OnScaleChangeListener");
			IntPtr class_ref;

			public static IOnScaleChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnScaleChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "uk.co.senab.photoview.PhotoViewAttacher.OnScaleChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnScaleChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnScaleChangeListenerInvoker); }
			}

			static Delegate cb_onScaleChange_FFF;
#pragma warning disable 0169
			static Delegate GetOnScaleChange_FFFHandler ()
			{
				if (cb_onScaleChange_FFF == null)
					cb_onScaleChange_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_OnScaleChange_FFF);
				return cb_onScaleChange_FFF;
			}

			static void n_OnScaleChange_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
			{
				global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnScaleChange (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onScaleChange_FFF;
			public unsafe void OnScaleChange (float p0, float p1, float p2)
			{
				if (id_onScaleChange_FFF == IntPtr.Zero)
					id_onScaleChange_FFF = JNIEnv.GetMethodID (class_ref, "onScaleChange", "(FFF)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_onScaleChange_FFF, __args);
			}

		}

		public partial class ScaleChangeEventArgs : global::System.EventArgs {

			public ScaleChangeEventArgs (float p0, float p1, float p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}

			float p2;
			public float P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/uk/co/senab/photoview/PhotoViewAttacher_OnScaleChangeListenerImplementor")]
		internal sealed partial class IOnScaleChangeListenerImplementor : global::Java.Lang.Object, IOnScaleChangeListener {

			object sender;

			public IOnScaleChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/uk/co/senab/photoview/PhotoViewAttacher_OnScaleChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ScaleChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnScaleChange (float p0, float p1, float p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ScaleChangeEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnScaleChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='PhotoViewAttacher.OnViewTapListener']"
		[Register ("uk/co/senab/photoview/PhotoViewAttacher$OnViewTapListener", "", "UK.CO.Senab.Photoview.PhotoViewAttacher/IOnViewTapListenerInvoker")]
		public partial interface IOnViewTapListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/interface[@name='PhotoViewAttacher.OnViewTapListener']/method[@name='onViewTap' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onViewTap", "(Landroid/view/View;FF)V", "GetOnViewTap_Landroid_view_View_FFHandler:UK.CO.Senab.Photoview.PhotoViewAttacher/IOnViewTapListenerInvoker, PhotoViewer")]
			void OnViewTap (global::Android.Views.View p0, float p1, float p2);

		}

		[global::Android.Runtime.Register ("uk/co/senab/photoview/PhotoViewAttacher$OnViewTapListener", DoNotGenerateAcw=true)]
		internal class IOnViewTapListenerInvoker : global::Java.Lang.Object, IOnViewTapListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("uk/co/senab/photoview/PhotoViewAttacher$OnViewTapListener");
			IntPtr class_ref;

			public static IOnViewTapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnViewTapListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "uk.co.senab.photoview.PhotoViewAttacher.OnViewTapListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnViewTapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnViewTapListenerInvoker); }
			}

			static Delegate cb_onViewTap_Landroid_view_View_FF;
#pragma warning disable 0169
			static Delegate GetOnViewTap_Landroid_view_View_FFHandler ()
			{
				if (cb_onViewTap_Landroid_view_View_FF == null)
					cb_onViewTap_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnViewTap_Landroid_view_View_FF);
				return cb_onViewTap_Landroid_view_View_FF;
			}

			static void n_OnViewTap_Landroid_view_View_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
			{
				global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnViewTap (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onViewTap_Landroid_view_View_FF;
			public unsafe void OnViewTap (global::Android.Views.View p0, float p1, float p2)
			{
				if (id_onViewTap_Landroid_view_View_FF == IntPtr.Zero)
					id_onViewTap_Landroid_view_View_FF = JNIEnv.GetMethodID (class_ref, "onViewTap", "(Landroid/view/View;FF)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_onViewTap_Landroid_view_View_FF, __args);
			}

		}

		public partial class ViewTapEventArgs : global::System.EventArgs {

			public ViewTapEventArgs (global::Android.Views.View p0, float p1, float p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}

			float p2;
			public float P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/uk/co/senab/photoview/PhotoViewAttacher_OnViewTapListenerImplementor")]
		internal sealed partial class IOnViewTapListenerImplementor : global::Java.Lang.Object, IOnViewTapListener {

			object sender;

			public IOnViewTapListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/uk/co/senab/photoview/PhotoViewAttacher_OnViewTapListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ViewTapEventArgs> Handler;
#pragma warning restore 0649

			public void OnViewTap (global::Android.Views.View p0, float p1, float p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ViewTapEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnViewTapListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("uk/co/senab/photoview/PhotoViewAttacher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PhotoViewAttacher); }
		}

		protected PhotoViewAttacher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_ImageView_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/constructor[@name='PhotoViewAttacher' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Landroid/widget/ImageView;Z)V", "")]
		public unsafe PhotoViewAttacher (global::Android.Widget.ImageView p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PhotoViewAttacher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/ImageView;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/ImageView;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_ImageView_Z == IntPtr.Zero)
					id_ctor_Landroid_widget_ImageView_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/ImageView;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_ImageView_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_ImageView_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_widget_ImageView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/constructor[@name='PhotoViewAttacher' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register (".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe PhotoViewAttacher (global::Android.Widget.ImageView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (PhotoViewAttacher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/ImageView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/ImageView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_ImageView_ == IntPtr.Zero)
					id_ctor_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/ImageView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_ImageView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_ImageView_, __args);
			} finally {
			}
		}

		static Delegate cb_getDisplayMatrix;
#pragma warning disable 0169
		static Delegate GetGetDisplayMatrixHandler ()
		{
			if (cb_getDisplayMatrix == null)
				cb_getDisplayMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayMatrix);
			return cb_getDisplayMatrix;
		}

		static IntPtr n_GetDisplayMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisplayMatrix);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayMatrix;
		public virtual unsafe global::Android.Graphics.Matrix DisplayMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getDisplayMatrix' and count(parameter)=0]"
			[Register ("getDisplayMatrix", "()Landroid/graphics/Matrix;", "GetGetDisplayMatrixHandler")]
			get {
				if (id_getDisplayMatrix == IntPtr.Zero)
					id_getDisplayMatrix = JNIEnv.GetMethodID (class_ref, "getDisplayMatrix", "()Landroid/graphics/Matrix;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_getDisplayMatrix), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayMatrix", "()Landroid/graphics/Matrix;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayRect;
#pragma warning disable 0169
		static Delegate GetGetDisplayRectHandler ()
		{
			if (cb_getDisplayRect == null)
				cb_getDisplayRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayRect);
			return cb_getDisplayRect;
		}

		static IntPtr n_GetDisplayRect (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisplayRect);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayRect;
		public virtual unsafe global::Android.Graphics.RectF DisplayRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getDisplayRect' and count(parameter)=0]"
			[Register ("getDisplayRect", "()Landroid/graphics/RectF;", "GetGetDisplayRectHandler")]
			get {
				if (id_getDisplayRect == IntPtr.Zero)
					id_getDisplayRect = JNIEnv.GetMethodID (class_ref, "getDisplayRect", "()Landroid/graphics/RectF;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallObjectMethod  (Handle, id_getDisplayRect), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayRect", "()Landroid/graphics/RectF;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDrawMatrix;
#pragma warning disable 0169
		static Delegate GetGetDrawMatrixHandler ()
		{
			if (cb_getDrawMatrix == null)
				cb_getDrawMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawMatrix);
			return cb_getDrawMatrix;
		}

		static IntPtr n_GetDrawMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DrawMatrix);
		}
#pragma warning restore 0169

		static IntPtr id_getDrawMatrix;
		public virtual unsafe global::Android.Graphics.Matrix DrawMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getDrawMatrix' and count(parameter)=0]"
			[Register ("getDrawMatrix", "()Landroid/graphics/Matrix;", "GetGetDrawMatrixHandler")]
			get {
				if (id_getDrawMatrix == IntPtr.Zero)
					id_getDrawMatrix = JNIEnv.GetMethodID (class_ref, "getDrawMatrix", "()Landroid/graphics/Matrix;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_getDrawMatrix), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawMatrix", "()Landroid/graphics/Matrix;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIPhotoViewImplementation;
#pragma warning disable 0169
		static Delegate GetGetIPhotoViewImplementationHandler ()
		{
			if (cb_getIPhotoViewImplementation == null)
				cb_getIPhotoViewImplementation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIPhotoViewImplementation);
			return cb_getIPhotoViewImplementation;
		}

		static IntPtr n_GetIPhotoViewImplementation (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IPhotoViewImplementation);
		}
#pragma warning restore 0169

		static IntPtr id_getIPhotoViewImplementation;
		public virtual unsafe global::UK.CO.Senab.Photoview.IPhotoViewInterface IPhotoViewImplementation {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getIPhotoViewImplementation' and count(parameter)=0]"
			[Register ("getIPhotoViewImplementation", "()Luk/co/senab/photoview/IPhotoView;", "GetGetIPhotoViewImplementationHandler")]
			get {
				if (id_getIPhotoViewImplementation == IntPtr.Zero)
					id_getIPhotoViewImplementation = JNIEnv.GetMethodID (class_ref, "getIPhotoViewImplementation", "()Luk/co/senab/photoview/IPhotoView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.IPhotoViewInterface> (JNIEnv.CallObjectMethod  (Handle, id_getIPhotoViewImplementation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.IPhotoViewInterface> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIPhotoViewImplementation", "()Luk/co/senab/photoview/IPhotoView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageView;
#pragma warning disable 0169
		static Delegate GetGetImageViewHandler ()
		{
			if (cb_getImageView == null)
				cb_getImageView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageView);
			return cb_getImageView;
		}

		static IntPtr n_GetImageView (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageView);
		}
#pragma warning restore 0169

		static IntPtr id_getImageView;
		public virtual unsafe global::Android.Widget.ImageView ImageView {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getImageView' and count(parameter)=0]"
			[Register ("getImageView", "()Landroid/widget/ImageView;", "GetGetImageViewHandler")]
			get {
				if (id_getImageView == IntPtr.Zero)
					id_getImageView = JNIEnv.GetMethodID (class_ref, "getImageView", "()Landroid/widget/ImageView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallObjectMethod  (Handle, id_getImageView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageView", "()Landroid/widget/ImageView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxScale;
#pragma warning disable 0169
		static Delegate GetGetMaxScaleHandler ()
		{
			if (cb_getMaxScale == null)
				cb_getMaxScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxScale);
			return cb_getMaxScale;
		}

		static float n_GetMaxScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxScale_F;
#pragma warning disable 0169
		static Delegate GetSetMaxScale_FHandler ()
		{
			if (cb_setMaxScale_F == null)
				cb_setMaxScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxScale_F);
			return cb_setMaxScale_F;
		}

		static void n_SetMaxScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxScale;
		static IntPtr id_setMaxScale_F;
		[Obsolete (@"deprecated")]
		public virtual unsafe float MaxScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getMaxScale' and count(parameter)=0]"
			[Register ("getMaxScale", "()F", "GetGetMaxScaleHandler")]
			get {
				if (id_getMaxScale == IntPtr.Zero)
					id_getMaxScale = JNIEnv.GetMethodID (class_ref, "getMaxScale", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMaxScale);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxScale", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setMaxScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxScale", "(F)V", "GetSetMaxScale_FHandler")]
			set {
				if (id_setMaxScale_F == IntPtr.Zero)
					id_setMaxScale_F = JNIEnv.GetMethodID (class_ref, "setMaxScale", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaxScale_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxScale", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumScale;
#pragma warning disable 0169
		static Delegate GetGetMaximumScaleHandler ()
		{
			if (cb_getMaximumScale == null)
				cb_getMaximumScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaximumScale);
			return cb_getMaximumScale;
		}

		static float n_GetMaximumScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumScale_F;
#pragma warning disable 0169
		static Delegate GetSetMaximumScale_FHandler ()
		{
			if (cb_setMaximumScale_F == null)
				cb_setMaximumScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaximumScale_F);
			return cb_setMaximumScale_F;
		}

		static void n_SetMaximumScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumScale;
		static IntPtr id_setMaximumScale_F;
		public virtual unsafe float MaximumScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getMaximumScale' and count(parameter)=0]"
			[Register ("getMaximumScale", "()F", "GetGetMaximumScaleHandler")]
			get {
				if (id_getMaximumScale == IntPtr.Zero)
					id_getMaximumScale = JNIEnv.GetMethodID (class_ref, "getMaximumScale", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMaximumScale);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumScale", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setMaximumScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaximumScale", "(F)V", "GetSetMaximumScale_FHandler")]
			set {
				if (id_setMaximumScale_F == IntPtr.Zero)
					id_setMaximumScale_F = JNIEnv.GetMethodID (class_ref, "setMaximumScale", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaximumScale_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumScale", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMediumScale;
#pragma warning disable 0169
		static Delegate GetGetMediumScaleHandler ()
		{
			if (cb_getMediumScale == null)
				cb_getMediumScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMediumScale);
			return cb_getMediumScale;
		}

		static float n_GetMediumScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediumScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMediumScale_F;
#pragma warning disable 0169
		static Delegate GetSetMediumScale_FHandler ()
		{
			if (cb_setMediumScale_F == null)
				cb_setMediumScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMediumScale_F);
			return cb_setMediumScale_F;
		}

		static void n_SetMediumScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MediumScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMediumScale;
		static IntPtr id_setMediumScale_F;
		public virtual unsafe float MediumScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getMediumScale' and count(parameter)=0]"
			[Register ("getMediumScale", "()F", "GetGetMediumScaleHandler")]
			get {
				if (id_getMediumScale == IntPtr.Zero)
					id_getMediumScale = JNIEnv.GetMethodID (class_ref, "getMediumScale", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMediumScale);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediumScale", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setMediumScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMediumScale", "(F)V", "GetSetMediumScale_FHandler")]
			set {
				if (id_setMediumScale_F == IntPtr.Zero)
					id_setMediumScale_F = JNIEnv.GetMethodID (class_ref, "setMediumScale", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMediumScale_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediumScale", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMidScale;
#pragma warning disable 0169
		static Delegate GetGetMidScaleHandler ()
		{
			if (cb_getMidScale == null)
				cb_getMidScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMidScale);
			return cb_getMidScale;
		}

		static float n_GetMidScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MidScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMidScale_F;
#pragma warning disable 0169
		static Delegate GetSetMidScale_FHandler ()
		{
			if (cb_setMidScale_F == null)
				cb_setMidScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMidScale_F);
			return cb_setMidScale_F;
		}

		static void n_SetMidScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MidScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMidScale;
		static IntPtr id_setMidScale_F;
		[Obsolete (@"deprecated")]
		public virtual unsafe float MidScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getMidScale' and count(parameter)=0]"
			[Register ("getMidScale", "()F", "GetGetMidScaleHandler")]
			get {
				if (id_getMidScale == IntPtr.Zero)
					id_getMidScale = JNIEnv.GetMethodID (class_ref, "getMidScale", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMidScale);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMidScale", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setMidScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMidScale", "(F)V", "GetSetMidScale_FHandler")]
			set {
				if (id_setMidScale_F == IntPtr.Zero)
					id_setMidScale_F = JNIEnv.GetMethodID (class_ref, "setMidScale", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMidScale_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMidScale", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinScale;
#pragma warning disable 0169
		static Delegate GetGetMinScaleHandler ()
		{
			if (cb_getMinScale == null)
				cb_getMinScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinScale);
			return cb_getMinScale;
		}

		static float n_GetMinScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMinScale_F;
#pragma warning disable 0169
		static Delegate GetSetMinScale_FHandler ()
		{
			if (cb_setMinScale_F == null)
				cb_setMinScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinScale_F);
			return cb_setMinScale_F;
		}

		static void n_SetMinScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinScale;
		static IntPtr id_setMinScale_F;
		[Obsolete (@"deprecated")]
		public virtual unsafe float MinScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getMinScale' and count(parameter)=0]"
			[Register ("getMinScale", "()F", "GetGetMinScaleHandler")]
			get {
				if (id_getMinScale == IntPtr.Zero)
					id_getMinScale = JNIEnv.GetMethodID (class_ref, "getMinScale", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMinScale);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinScale", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setMinScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinScale", "(F)V", "GetSetMinScale_FHandler")]
			set {
				if (id_setMinScale_F == IntPtr.Zero)
					id_setMinScale_F = JNIEnv.GetMethodID (class_ref, "setMinScale", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMinScale_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinScale", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinimumScale;
#pragma warning disable 0169
		static Delegate GetGetMinimumScaleHandler ()
		{
			if (cb_getMinimumScale == null)
				cb_getMinimumScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinimumScale);
			return cb_getMinimumScale;
		}

		static float n_GetMinimumScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMinimumScale_F;
#pragma warning disable 0169
		static Delegate GetSetMinimumScale_FHandler ()
		{
			if (cb_setMinimumScale_F == null)
				cb_setMinimumScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinimumScale_F);
			return cb_setMinimumScale_F;
		}

		static void n_SetMinimumScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinimumScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumScale;
		static IntPtr id_setMinimumScale_F;
		public virtual unsafe float MinimumScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getMinimumScale' and count(parameter)=0]"
			[Register ("getMinimumScale", "()F", "GetGetMinimumScaleHandler")]
			get {
				if (id_getMinimumScale == IntPtr.Zero)
					id_getMinimumScale = JNIEnv.GetMethodID (class_ref, "getMinimumScale", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMinimumScale);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinimumScale", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setMinimumScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinimumScale", "(F)V", "GetSetMinimumScale_FHandler")]
			set {
				if (id_setMinimumScale_F == IntPtr.Zero)
					id_setMinimumScale_F = JNIEnv.GetMethodID (class_ref, "setMinimumScale", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMinimumScale_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinimumScale", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnPhotoTapListener;
#pragma warning disable 0169
		static Delegate GetGetOnPhotoTapListenerHandler ()
		{
			if (cb_getOnPhotoTapListener == null)
				cb_getOnPhotoTapListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnPhotoTapListener);
			return cb_getOnPhotoTapListener;
		}

		static IntPtr n_GetOnPhotoTapListener (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnPhotoTapListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_Handler ()
		{
			if (cb_setOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_ == null)
				cb_setOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_);
			return cb_setOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_;
		}

		static void n_SetOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener p0 = (global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener)global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPhotoTapListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnPhotoTapListener;
		static IntPtr id_setOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_;
		public virtual unsafe global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener OnPhotoTapListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getOnPhotoTapListener' and count(parameter)=0]"
			[Register ("getOnPhotoTapListener", "()Luk/co/senab/photoview/PhotoViewAttacher$OnPhotoTapListener;", "GetGetOnPhotoTapListenerHandler")]
			get {
				if (id_getOnPhotoTapListener == IntPtr.Zero)
					id_getOnPhotoTapListener = JNIEnv.GetMethodID (class_ref, "getOnPhotoTapListener", "()Luk/co/senab/photoview/PhotoViewAttacher$OnPhotoTapListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnPhotoTapListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnPhotoTapListener", "()Luk/co/senab/photoview/PhotoViewAttacher$OnPhotoTapListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setOnPhotoTapListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher.OnPhotoTapListener']]"
			[Register ("setOnPhotoTapListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnPhotoTapListener;)V", "GetSetOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_Handler")]
			set {
				if (id_setOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_ == IntPtr.Zero)
					id_setOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_ = JNIEnv.GetMethodID (class_ref, "setOnPhotoTapListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnPhotoTapListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPhotoTapListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnPhotoTapListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnViewTapListener;
#pragma warning disable 0169
		static Delegate GetGetOnViewTapListenerHandler ()
		{
			if (cb_getOnViewTapListener == null)
				cb_getOnViewTapListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnViewTapListener);
			return cb_getOnViewTapListener;
		}

		static IntPtr n_GetOnViewTapListener (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnViewTapListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_;
#pragma warning disable 0169
		static Delegate GetSetOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_Handler ()
		{
			if (cb_setOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_ == null)
				cb_setOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_);
			return cb_setOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_;
		}

		static void n_SetOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener p0 = (global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener)global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnViewTapListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnViewTapListener;
		static IntPtr id_setOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_;
		public virtual unsafe global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener OnViewTapListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getOnViewTapListener' and count(parameter)=0]"
			[Register ("getOnViewTapListener", "()Luk/co/senab/photoview/PhotoViewAttacher$OnViewTapListener;", "GetGetOnViewTapListenerHandler")]
			get {
				if (id_getOnViewTapListener == IntPtr.Zero)
					id_getOnViewTapListener = JNIEnv.GetMethodID (class_ref, "getOnViewTapListener", "()Luk/co/senab/photoview/PhotoViewAttacher$OnViewTapListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnViewTapListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnViewTapListener", "()Luk/co/senab/photoview/PhotoViewAttacher$OnViewTapListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setOnViewTapListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher.OnViewTapListener']]"
			[Register ("setOnViewTapListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnViewTapListener;)V", "GetSetOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_Handler")]
			set {
				if (id_setOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_ == IntPtr.Zero)
					id_setOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_ = JNIEnv.GetMethodID (class_ref, "setOnViewTapListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnViewTapListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnViewTapListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnViewTapListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScale;
#pragma warning disable 0169
		static Delegate GetGetScaleHandler ()
		{
			if (cb_getScale == null)
				cb_getScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScale);
			return cb_getScale;
		}

		static float n_GetScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scale;
		}
#pragma warning restore 0169

		static Delegate cb_setScale_F;
#pragma warning disable 0169
		static Delegate GetSetScale_FHandler ()
		{
			if (cb_setScale_F == null)
				cb_setScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScale_F);
			return cb_setScale_F;
		}

		static void n_SetScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScale;
		static IntPtr id_setScale_F;
		public virtual unsafe float Scale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getScale' and count(parameter)=0]"
			[Register ("getScale", "()F", "GetGetScaleHandler")]
			get {
				if (id_getScale == IntPtr.Zero)
					id_getScale = JNIEnv.GetMethodID (class_ref, "getScale", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getScale);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScale", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScale", "(F)V", "GetSetScale_FHandler")]
			set {
				if (id_setScale_F == IntPtr.Zero)
					id_setScale_F = JNIEnv.GetMethodID (class_ref, "setScale", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setScale_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleType;
#pragma warning disable 0169
		static Delegate GetGetScaleTypeHandler ()
		{
			if (cb_getScaleType == null)
				cb_getScaleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleType);
			return cb_getScaleType;
		}

		static IntPtr n_GetScaleType (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleType);
		}
#pragma warning restore 0169

		static Delegate cb_setScaleType_Landroid_widget_ImageView_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetScaleType_Landroid_widget_ImageView_ScaleType_Handler ()
		{
			if (cb_setScaleType_Landroid_widget_ImageView_ScaleType_ == null)
				cb_setScaleType_Landroid_widget_ImageView_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleType_Landroid_widget_ImageView_ScaleType_);
			return cb_setScaleType_Landroid_widget_ImageView_ScaleType_;
		}

		static void n_SetScaleType_Landroid_widget_ImageView_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView.ScaleType p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView.ScaleType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ScaleType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleType;
		static IntPtr id_setScaleType_Landroid_widget_ImageView_ScaleType_;
		public virtual unsafe global::Android.Widget.ImageView.ScaleType ScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getScaleType' and count(parameter)=0]"
			[Register ("getScaleType", "()Landroid/widget/ImageView$ScaleType;", "GetGetScaleTypeHandler")]
			get {
				if (id_getScaleType == IntPtr.Zero)
					id_getScaleType = JNIEnv.GetMethodID (class_ref, "getScaleType", "()Landroid/widget/ImageView$ScaleType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView.ScaleType> (JNIEnv.CallObjectMethod  (Handle, id_getScaleType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView.ScaleType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleType", "()Landroid/widget/ImageView$ScaleType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setScaleType' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView.ScaleType']]"
			[Register ("setScaleType", "(Landroid/widget/ImageView$ScaleType;)V", "GetSetScaleType_Landroid_widget_ImageView_ScaleType_Handler")]
			set {
				if (id_setScaleType_Landroid_widget_ImageView_ScaleType_ == IntPtr.Zero)
					id_setScaleType_Landroid_widget_ImageView_ScaleType_ = JNIEnv.GetMethodID (class_ref, "setScaleType", "(Landroid/widget/ImageView$ScaleType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setScaleType_Landroid_widget_ImageView_ScaleType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleType", "(Landroid/widget/ImageView$ScaleType;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVisibleRectangleBitmap;
#pragma warning disable 0169
		static Delegate GetGetVisibleRectangleBitmapHandler ()
		{
			if (cb_getVisibleRectangleBitmap == null)
				cb_getVisibleRectangleBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVisibleRectangleBitmap);
			return cb_getVisibleRectangleBitmap;
		}

		static IntPtr n_GetVisibleRectangleBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VisibleRectangleBitmap);
		}
#pragma warning restore 0169

		static IntPtr id_getVisibleRectangleBitmap;
		public virtual unsafe global::Android.Graphics.Bitmap VisibleRectangleBitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='getVisibleRectangleBitmap' and count(parameter)=0]"
			[Register ("getVisibleRectangleBitmap", "()Landroid/graphics/Bitmap;", "GetGetVisibleRectangleBitmapHandler")]
			get {
				if (id_getVisibleRectangleBitmap == IntPtr.Zero)
					id_getVisibleRectangleBitmap = JNIEnv.GetMethodID (class_ref, "getVisibleRectangleBitmap", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getVisibleRectangleBitmap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVisibleRectangleBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_canZoom;
#pragma warning disable 0169
		static Delegate GetCanZoomHandler ()
		{
			if (cb_canZoom == null)
				cb_canZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanZoom);
			return cb_canZoom;
		}

		static bool n_CanZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoom ();
		}
#pragma warning restore 0169

		static IntPtr id_canZoom;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='canZoom' and count(parameter)=0]"
		[Register ("canZoom", "()Z", "GetCanZoomHandler")]
		public virtual unsafe bool CanZoom ()
		{
			if (id_canZoom == IntPtr.Zero)
				id_canZoom = JNIEnv.GetMethodID (class_ref, "canZoom", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_canZoom);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canZoom", "()Z"));
			} finally {
			}
		}

		static Delegate cb_cleanup;
#pragma warning disable 0169
		static Delegate GetCleanupHandler ()
		{
			if (cb_cleanup == null)
				cb_cleanup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cleanup);
			return cb_cleanup;
		}

		static void n_Cleanup (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cleanup ();
		}
#pragma warning restore 0169

		static IntPtr id_cleanup;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='cleanup' and count(parameter)=0]"
		[Register ("cleanup", "()V", "GetCleanupHandler")]
		public virtual unsafe void Cleanup ()
		{
			if (id_cleanup == IntPtr.Zero)
				id_cleanup = JNIEnv.GetMethodID (class_ref, "cleanup", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cleanup);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanup", "()V"));
			} finally {
			}
		}

		static Delegate cb_onDrag_FF;
#pragma warning disable 0169
		static Delegate GetOnDrag_FFHandler ()
		{
			if (cb_onDrag_FF == null)
				cb_onDrag_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_OnDrag_FF);
			return cb_onDrag_FF;
		}

		static void n_OnDrag_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDrag (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDrag_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='onDrag' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("onDrag", "(FF)V", "GetOnDrag_FFHandler")]
		public virtual unsafe void OnDrag (float p0, float p1)
		{
			if (id_onDrag_FF == IntPtr.Zero)
				id_onDrag_FF = JNIEnv.GetMethodID (class_ref, "onDrag", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDrag_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDrag", "(FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onFling_FFFF;
#pragma warning disable 0169
		static Delegate GetOnFling_FFFFHandler ()
		{
			if (cb_onFling_FFFF == null)
				cb_onFling_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_OnFling_FFFF);
			return cb_onFling_FFFF;
		}

		static void n_OnFling_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFling (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onFling_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='onFling' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("onFling", "(FFFF)V", "GetOnFling_FFFFHandler")]
		public virtual unsafe void OnFling (float p0, float p1, float p2, float p3)
		{
			if (id_onFling_FFFF == IntPtr.Zero)
				id_onFling_FFFF = JNIEnv.GetMethodID (class_ref, "onFling", "(FFFF)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFling_FFFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFling", "(FFFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onGlobalLayout;
#pragma warning disable 0169
		static Delegate GetOnGlobalLayoutHandler ()
		{
			if (cb_onGlobalLayout == null)
				cb_onGlobalLayout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnGlobalLayout);
			return cb_onGlobalLayout;
		}

		static void n_OnGlobalLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGlobalLayout ();
		}
#pragma warning restore 0169

		static IntPtr id_onGlobalLayout;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='onGlobalLayout' and count(parameter)=0]"
		[Register ("onGlobalLayout", "()V", "GetOnGlobalLayoutHandler")]
		public virtual unsafe void OnGlobalLayout ()
		{
			if (id_onGlobalLayout == IntPtr.Zero)
				id_onGlobalLayout = JNIEnv.GetMethodID (class_ref, "onGlobalLayout", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onGlobalLayout);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onGlobalLayout", "()V"));
			} finally {
			}
		}

		static Delegate cb_onScale_FFF;
#pragma warning disable 0169
		static Delegate GetOnScale_FFFHandler ()
		{
			if (cb_onScale_FFF == null)
				cb_onScale_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_OnScale_FFF);
			return cb_onScale_FFF;
		}

		static void n_OnScale_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScale (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onScale_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='onScale' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("onScale", "(FFF)V", "GetOnScale_FFFHandler")]
		public virtual unsafe void OnScale (float p0, float p1, float p2)
		{
			if (id_onScale_FFF == IntPtr.Zero)
				id_onScale_FFF = JNIEnv.GetMethodID (class_ref, "onScale", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onScale_FFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScale", "(FFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
		{
			if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setAllowParentInterceptOnEdge_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowParentInterceptOnEdge_ZHandler ()
		{
			if (cb_setAllowParentInterceptOnEdge_Z == null)
				cb_setAllowParentInterceptOnEdge_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllowParentInterceptOnEdge_Z);
			return cb_setAllowParentInterceptOnEdge_Z;
		}

		static void n_SetAllowParentInterceptOnEdge_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowParentInterceptOnEdge (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllowParentInterceptOnEdge_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setAllowParentInterceptOnEdge' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowParentInterceptOnEdge", "(Z)V", "GetSetAllowParentInterceptOnEdge_ZHandler")]
		public virtual unsafe void SetAllowParentInterceptOnEdge (bool p0)
		{
			if (id_setAllowParentInterceptOnEdge_Z == IntPtr.Zero)
				id_setAllowParentInterceptOnEdge_Z = JNIEnv.GetMethodID (class_ref, "setAllowParentInterceptOnEdge", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAllowParentInterceptOnEdge_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllowParentInterceptOnEdge", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayMatrix_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetSetDisplayMatrix_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_setDisplayMatrix_Landroid_graphics_Matrix_ == null)
				cb_setDisplayMatrix_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetDisplayMatrix_Landroid_graphics_Matrix_);
			return cb_setDisplayMatrix_Landroid_graphics_Matrix_;
		}

		static bool n_SetDisplayMatrix_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetDisplayMatrix (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayMatrix_Landroid_graphics_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setDisplayMatrix' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
		[Register ("setDisplayMatrix", "(Landroid/graphics/Matrix;)Z", "GetSetDisplayMatrix_Landroid_graphics_Matrix_Handler")]
		public virtual unsafe bool SetDisplayMatrix (global::Android.Graphics.Matrix p0)
		{
			if (id_setDisplayMatrix_Landroid_graphics_Matrix_ == IntPtr.Zero)
				id_setDisplayMatrix_Landroid_graphics_Matrix_ = JNIEnv.GetMethodID (class_ref, "setDisplayMatrix", "(Landroid/graphics/Matrix;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_setDisplayMatrix_Landroid_graphics_Matrix_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayMatrix", "(Landroid/graphics/Matrix;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_Handler ()
		{
			if (cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ == null)
				cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_);
			return cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_;
		}

		static void n_SetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.GestureDetector.IOnDoubleTapListener p0 = (global::Android.Views.GestureDetector.IOnDoubleTapListener)global::Java.Lang.Object.GetObject<global::Android.Views.GestureDetector.IOnDoubleTapListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDoubleTapListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setOnDoubleTapListener' and count(parameter)=1 and parameter[1][@type='android.view.GestureDetector.OnDoubleTapListener']]"
		[Register ("setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V", "GetSetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_Handler")]
		public virtual unsafe void SetOnDoubleTapListener (global::Android.Views.GestureDetector.IOnDoubleTapListener p0)
		{
			if (id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ == IntPtr.Zero)
				id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ = JNIEnv.GetMethodID (class_ref, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler ()
		{
			if (cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_ == null)
				cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnLongClickListener_Landroid_view_View_OnLongClickListener_);
			return cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_;
		}

		static void n_SetOnLongClickListener_Landroid_view_View_OnLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnLongClickListener p0 = (global::Android.Views.View.IOnLongClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnLongClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnLongClickListener_Landroid_view_View_OnLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setOnLongClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnLongClickListener']]"
		[Register ("setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V", "GetSetOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler")]
		public virtual unsafe void SetOnLongClickListener (global::Android.Views.View.IOnLongClickListener p0)
		{
			if (id_setOnLongClickListener_Landroid_view_View_OnLongClickListener_ == IntPtr.Zero)
				id_setOnLongClickListener_Landroid_view_View_OnLongClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnLongClickListener_Landroid_view_View_OnLongClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_Handler ()
		{
			if (cb_setOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_ == null)
				cb_setOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_);
			return cb_setOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_;
		}

		static void n_SetOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener p0 = (global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener)global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMatrixChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setOnMatrixChangeListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher.OnMatrixChangedListener']]"
		[Register ("setOnMatrixChangeListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnMatrixChangedListener;)V", "GetSetOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_Handler")]
		public virtual unsafe void SetOnMatrixChangeListener (global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener p0)
		{
			if (id_setOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_ == IntPtr.Zero)
				id_setOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnMatrixChangeListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnMatrixChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMatrixChangeListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnMatrixChangedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_Handler ()
		{
			if (cb_setOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_ == null)
				cb_setOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_);
			return cb_setOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_;
		}

		static void n_SetOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener p0 = (global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener)global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnScaleChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setOnScaleChangeListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher.OnScaleChangeListener']]"
		[Register ("setOnScaleChangeListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnScaleChangeListener;)V", "GetSetOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_Handler")]
		public virtual unsafe void SetOnScaleChangeListener (global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener p0)
		{
			if (id_setOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_ == IntPtr.Zero)
				id_setOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnScaleChangeListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnScaleChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnScaleChangeListener", "(Luk/co/senab/photoview/PhotoViewAttacher$OnScaleChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPhotoViewRotation_F;
#pragma warning disable 0169
		static Delegate GetSetPhotoViewRotation_FHandler ()
		{
			if (cb_setPhotoViewRotation_F == null)
				cb_setPhotoViewRotation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPhotoViewRotation_F);
			return cb_setPhotoViewRotation_F;
		}

		static void n_SetPhotoViewRotation_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPhotoViewRotation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPhotoViewRotation_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setPhotoViewRotation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setPhotoViewRotation", "(F)V", "GetSetPhotoViewRotation_FHandler")]
		public virtual unsafe void SetPhotoViewRotation (float p0)
		{
			if (id_setPhotoViewRotation_F == IntPtr.Zero)
				id_setPhotoViewRotation_F = JNIEnv.GetMethodID (class_ref, "setPhotoViewRotation", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPhotoViewRotation_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhotoViewRotation", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRotationBy_F;
#pragma warning disable 0169
		static Delegate GetSetRotationBy_FHandler ()
		{
			if (cb_setRotationBy_F == null)
				cb_setRotationBy_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRotationBy_F);
			return cb_setRotationBy_F;
		}

		static void n_SetRotationBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotationBy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRotationBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setRotationBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRotationBy", "(F)V", "GetSetRotationBy_FHandler")]
		public virtual unsafe void SetRotationBy (float p0)
		{
			if (id_setRotationBy_F == IntPtr.Zero)
				id_setRotationBy_F = JNIEnv.GetMethodID (class_ref, "setRotationBy", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRotationBy_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotationBy", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRotationTo_F;
#pragma warning disable 0169
		static Delegate GetSetRotationTo_FHandler ()
		{
			if (cb_setRotationTo_F == null)
				cb_setRotationTo_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRotationTo_F);
			return cb_setRotationTo_F;
		}

		static void n_SetRotationTo_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotationTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRotationTo_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setRotationTo' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRotationTo", "(F)V", "GetSetRotationTo_FHandler")]
		public virtual unsafe void SetRotationTo (float p0)
		{
			if (id_setRotationTo_F == IntPtr.Zero)
				id_setRotationTo_F = JNIEnv.GetMethodID (class_ref, "setRotationTo", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRotationTo_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotationTo", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScale_FZ;
#pragma warning disable 0169
		static Delegate GetSetScale_FZHandler ()
		{
			if (cb_setScale_FZ == null)
				cb_setScale_FZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, bool>) n_SetScale_FZ);
			return cb_setScale_FZ;
		}

		static void n_SetScale_FZ (IntPtr jnienv, IntPtr native__this, float p0, bool p1)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setScale_FZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setScale' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='boolean']]"
		[Register ("setScale", "(FZ)V", "GetSetScale_FZHandler")]
		public virtual unsafe void SetScale (float p0, bool p1)
		{
			if (id_setScale_FZ == IntPtr.Zero)
				id_setScale_FZ = JNIEnv.GetMethodID (class_ref, "setScale", "(FZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScale_FZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(FZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScale_FFFZ;
#pragma warning disable 0169
		static Delegate GetSetScale_FFFZHandler ()
		{
			if (cb_setScale_FFFZ == null)
				cb_setScale_FFFZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, bool>) n_SetScale_FFFZ);
			return cb_setScale_FFFZ;
		}

		static void n_SetScale_FFFZ (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, bool p3)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setScale_FFFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setScale' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='boolean']]"
		[Register ("setScale", "(FFFZ)V", "GetSetScale_FFFZHandler")]
		public virtual unsafe void SetScale (float p0, float p1, float p2, bool p3)
		{
			if (id_setScale_FFFZ == IntPtr.Zero)
				id_setScale_FFFZ = JNIEnv.GetMethodID (class_ref, "setScale", "(FFFZ)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScale_FFFZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(FFFZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScaleLevels_FFF;
#pragma warning disable 0169
		static Delegate GetSetScaleLevels_FFFHandler ()
		{
			if (cb_setScaleLevels_FFF == null)
				cb_setScaleLevels_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetScaleLevels_FFF);
			return cb_setScaleLevels_FFF;
		}

		static void n_SetScaleLevels_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleLevels (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setScaleLevels_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setScaleLevels' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setScaleLevels", "(FFF)V", "GetSetScaleLevels_FFFHandler")]
		public virtual unsafe void SetScaleLevels (float p0, float p1, float p2)
		{
			if (id_setScaleLevels_FFF == IntPtr.Zero)
				id_setScaleLevels_FFF = JNIEnv.GetMethodID (class_ref, "setScaleLevels", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScaleLevels_FFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleLevels", "(FFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setZoomTransitionDuration_I;
#pragma warning disable 0169
		static Delegate GetSetZoomTransitionDuration_IHandler ()
		{
			if (cb_setZoomTransitionDuration_I == null)
				cb_setZoomTransitionDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZoomTransitionDuration_I);
			return cb_setZoomTransitionDuration_I;
		}

		static void n_SetZoomTransitionDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomTransitionDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoomTransitionDuration_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setZoomTransitionDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setZoomTransitionDuration", "(I)V", "GetSetZoomTransitionDuration_IHandler")]
		public virtual unsafe void SetZoomTransitionDuration (int p0)
		{
			if (id_setZoomTransitionDuration_I == IntPtr.Zero)
				id_setZoomTransitionDuration_I = JNIEnv.GetMethodID (class_ref, "setZoomTransitionDuration", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZoomTransitionDuration_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoomTransitionDuration", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setZoomable_Z;
#pragma warning disable 0169
		static Delegate GetSetZoomable_ZHandler ()
		{
			if (cb_setZoomable_Z == null)
				cb_setZoomable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetZoomable_Z);
			return cb_setZoomable_Z;
		}

		static void n_SetZoomable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoomable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='setZoomable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setZoomable", "(Z)V", "GetSetZoomable_ZHandler")]
		public virtual unsafe void SetZoomable (bool p0)
		{
			if (id_setZoomable_Z == IntPtr.Zero)
				id_setZoomable_Z = JNIEnv.GetMethodID (class_ref, "setZoomable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZoomable_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoomable", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_update;
#pragma warning disable 0169
		static Delegate GetUpdateHandler ()
		{
			if (cb_update == null)
				cb_update = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Update);
			return cb_update;
		}

		static void n_Update (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoViewAttacher __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update ();
		}
#pragma warning restore 0169

		static IntPtr id_update;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoViewAttacher']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()V", "GetUpdateHandler")]
		public virtual unsafe void Update ()
		{
			if (id_update == IntPtr.Zero)
				id_update = JNIEnv.GetMethodID (class_ref, "update", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_update);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "()V"));
			} finally {
			}
		}

#region "Event implementation for UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener"
		public event EventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.MatrixChangedEventArgs> MatrixChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener, global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListenerImplementor>(
						ref weak_implementor_SetOnMatrixChangeListener,
						__CreateIOnMatrixChangedListenerImplementor,
						SetOnMatrixChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener, global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListenerImplementor>(
						ref weak_implementor_SetOnMatrixChangeListener,
						global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListenerImplementor.__IsEmpty,
						__v => SetOnMatrixChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMatrixChangeListener;

		global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListenerImplementor __CreateIOnMatrixChangedListenerImplementor ()
		{
			return new global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListenerImplementor (this);
		}
#endregion
#region "Event implementation for UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener"
		public event EventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.ScaleChangeEventArgs> ScaleChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener, global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListenerImplementor>(
						ref weak_implementor_SetOnScaleChangeListener,
						__CreateIOnScaleChangeListenerImplementor,
						SetOnScaleChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener, global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListenerImplementor>(
						ref weak_implementor_SetOnScaleChangeListener,
						global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListenerImplementor.__IsEmpty,
						__v => SetOnScaleChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnScaleChangeListener;

		global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListenerImplementor __CreateIOnScaleChangeListenerImplementor ()
		{
			return new global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener"
		public event EventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.PhotoTapEventArgs> PhotoTap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener, global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListenerImplementor>(
						ref weak_implementor___SetOnPhotoTapListener,
						__CreateIOnPhotoTapListenerImplementor,
						__v => OnPhotoTapListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener, global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListenerImplementor>(
						ref weak_implementor___SetOnPhotoTapListener,
						global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListenerImplementor.__IsEmpty,
						__v => OnPhotoTapListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnPhotoTapListener;

		global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListenerImplementor __CreateIOnPhotoTapListenerImplementor ()
		{
			return new global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListenerImplementor (this);
		}
#endregion
#region "Event implementation for UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener"
		public event EventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.ViewTapEventArgs> ViewTap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener, global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListenerImplementor>(
						ref weak_implementor___SetOnViewTapListener,
						__CreateIOnViewTapListenerImplementor,
						__v => OnViewTapListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener, global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListenerImplementor>(
						ref weak_implementor___SetOnViewTapListener,
						global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListenerImplementor.__IsEmpty,
						__v => OnViewTapListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnViewTapListener;

		global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListenerImplementor __CreateIOnViewTapListenerImplementor ()
		{
			return new global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListenerImplementor (this);
		}
#endregion
	}
}

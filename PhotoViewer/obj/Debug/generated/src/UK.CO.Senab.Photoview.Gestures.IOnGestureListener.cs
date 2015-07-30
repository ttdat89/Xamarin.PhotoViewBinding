using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview.Gestures {

	// Metadata.xml XPath interface reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/interface[@name='OnGestureListener']"
	[Register ("uk/co/senab/photoview/gestures/OnGestureListener", "", "UK.CO.Senab.Photoview.Gestures.IOnGestureListenerInvoker")]
	public partial interface IOnGestureListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/interface[@name='OnGestureListener']/method[@name='onDrag' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("onDrag", "(FF)V", "GetOnDrag_FFHandler:UK.CO.Senab.Photoview.Gestures.IOnGestureListenerInvoker, PhotoViewer")]
		void OnDrag (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/interface[@name='OnGestureListener']/method[@name='onFling' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("onFling", "(FFFF)V", "GetOnFling_FFFFHandler:UK.CO.Senab.Photoview.Gestures.IOnGestureListenerInvoker, PhotoViewer")]
		void OnFling (float p0, float p1, float p2, float p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/interface[@name='OnGestureListener']/method[@name='onScale' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("onScale", "(FFF)V", "GetOnScale_FFFHandler:UK.CO.Senab.Photoview.Gestures.IOnGestureListenerInvoker, PhotoViewer")]
		void OnScale (float p0, float p1, float p2);

	}

	[global::Android.Runtime.Register ("uk/co/senab/photoview/gestures/OnGestureListener", DoNotGenerateAcw=true)]
	internal class IOnGestureListenerInvoker : global::Java.Lang.Object, IOnGestureListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("uk/co/senab/photoview/gestures/OnGestureListener");
		IntPtr class_ref;

		public static IOnGestureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnGestureListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "uk.co.senab.photoview.gestures.OnGestureListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnGestureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnGestureListenerInvoker); }
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
			global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDrag (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDrag_FF;
		public unsafe void OnDrag (float p0, float p1)
		{
			if (id_onDrag_FF == IntPtr.Zero)
				id_onDrag_FF = JNIEnv.GetMethodID (class_ref, "onDrag", "(FF)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onDrag_FF, __args);
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
			global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFling (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onFling_FFFF;
		public unsafe void OnFling (float p0, float p1, float p2, float p3)
		{
			if (id_onFling_FFFF == IntPtr.Zero)
				id_onFling_FFFF = JNIEnv.GetMethodID (class_ref, "onFling", "(FFFF)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_onFling_FFFF, __args);
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
			global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScale (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onScale_FFF;
		public unsafe void OnScale (float p0, float p1, float p2)
		{
			if (id_onScale_FFF == IntPtr.Zero)
				id_onScale_FFF = JNIEnv.GetMethodID (class_ref, "onScale", "(FFF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_onScale_FFF, __args);
		}

	}

	public partial class DragEventArgs : global::System.EventArgs {

		public DragEventArgs (float p0, float p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		float p0;
		public float P0 {
			get { return p0; }
		}

		float p1;
		public float P1 {
			get { return p1; }
		}
	}

	public partial class FlingEventArgs : global::System.EventArgs {

		public FlingEventArgs (float p0, float p1, float p2, float p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
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

		float p3;
		public float P3 {
			get { return p3; }
		}
	}

	public partial class ScaleEventArgs : global::System.EventArgs {

		public ScaleEventArgs (float p0, float p1, float p2)
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

	[global::Android.Runtime.Register ("mono/uk/co/senab/photoview/gestures/OnGestureListenerImplementor")]
	internal sealed partial class IOnGestureListenerImplementor : global::Java.Lang.Object, IOnGestureListener {

		object sender;

		public IOnGestureListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/uk/co/senab/photoview/gestures/OnGestureListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DragEventArgs> OnDragHandler;
#pragma warning restore 0649

		public void OnDrag (float p0, float p1)
		{
			var __h = OnDragHandler;
			if (__h != null)
				__h (sender, new DragEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<FlingEventArgs> OnFlingHandler;
#pragma warning restore 0649

		public void OnFling (float p0, float p1, float p2, float p3)
		{
			var __h = OnFlingHandler;
			if (__h != null)
				__h (sender, new FlingEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<ScaleEventArgs> OnScaleHandler;
#pragma warning restore 0649

		public void OnScale (float p0, float p1, float p2)
		{
			var __h = OnScaleHandler;
			if (__h != null)
				__h (sender, new ScaleEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IOnGestureListenerImplementor value)
		{
			return value.OnDragHandler == null && value.OnFlingHandler == null && value.OnScaleHandler == null;
		}
	}

}

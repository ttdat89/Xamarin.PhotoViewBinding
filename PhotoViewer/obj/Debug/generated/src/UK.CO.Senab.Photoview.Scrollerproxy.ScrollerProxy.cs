using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview.Scrollerproxy {

	// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']"
	[global::Android.Runtime.Register ("uk/co/senab/photoview/scrollerproxy/ScrollerProxy", DoNotGenerateAcw=true)]
	public abstract partial class ScrollerProxy : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("uk/co/senab/photoview/scrollerproxy/ScrollerProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScrollerProxy); }
		}

		protected ScrollerProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/constructor[@name='ScrollerProxy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScrollerProxy ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ScrollerProxy)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getCurrX;
#pragma warning disable 0169
		static Delegate GetGetCurrXHandler ()
		{
			if (cb_getCurrX == null)
				cb_getCurrX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrX);
			return cb_getCurrX;
		}

		static int n_GetCurrX (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrX;
		}
#pragma warning restore 0169

		public abstract int CurrX {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='getCurrX' and count(parameter)=0]"
			[Register ("getCurrX", "()I", "GetGetCurrXHandler")] get;
		}

		static Delegate cb_getCurrY;
#pragma warning disable 0169
		static Delegate GetGetCurrYHandler ()
		{
			if (cb_getCurrY == null)
				cb_getCurrY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrY);
			return cb_getCurrY;
		}

		static int n_GetCurrY (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrY;
		}
#pragma warning restore 0169

		public abstract int CurrY {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='getCurrY' and count(parameter)=0]"
			[Register ("getCurrY", "()I", "GetGetCurrYHandler")] get;
		}

		static Delegate cb_isFinished;
#pragma warning disable 0169
		static Delegate GetIsFinishedHandler ()
		{
			if (cb_isFinished == null)
				cb_isFinished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFinished);
			return cb_isFinished;
		}

		static bool n_IsFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFinished;
		}
#pragma warning restore 0169

		public abstract bool IsFinished {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='isFinished' and count(parameter)=0]"
			[Register ("isFinished", "()Z", "GetIsFinishedHandler")] get;
		}

		static Delegate cb_computeScrollOffset;
#pragma warning disable 0169
		static Delegate GetComputeScrollOffsetHandler ()
		{
			if (cb_computeScrollOffset == null)
				cb_computeScrollOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ComputeScrollOffset);
			return cb_computeScrollOffset;
		}

		static bool n_ComputeScrollOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeScrollOffset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='computeScrollOffset' and count(parameter)=0]"
		[Register ("computeScrollOffset", "()Z", "GetComputeScrollOffsetHandler")]
		public abstract bool ComputeScrollOffset ();

		static Delegate cb_fling_IIIIIIIIII;
#pragma warning disable 0169
		static Delegate GetFling_IIIIIIIIIIHandler ()
		{
			if (cb_fling_IIIIIIIIII == null)
				cb_fling_IIIIIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, int, int, int, int, int, int>) n_Fling_IIIIIIIIII);
			return cb_fling_IIIIIIIIII;
		}

		static void n_Fling_IIIIIIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9)
		{
			global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Fling (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='fling' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("fling", "(IIIIIIIIII)V", "GetFling_IIIIIIIIIIHandler")]
		public abstract void Fling (int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9);

		static Delegate cb_forceFinished_Z;
#pragma warning disable 0169
		static Delegate GetForceFinished_ZHandler ()
		{
			if (cb_forceFinished_Z == null)
				cb_forceFinished_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ForceFinished_Z);
			return cb_forceFinished_Z;
		}

		static void n_ForceFinished_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceFinished (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='forceFinished' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("forceFinished", "(Z)V", "GetForceFinished_ZHandler")]
		public abstract void ForceFinished (bool p0);

		static IntPtr id_getScroller_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='getScroller' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScroller", "(Landroid/content/Context;)Luk/co/senab/photoview/scrollerproxy/ScrollerProxy;", "")]
		public static unsafe global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy GetScroller (global::Android.Content.Context p0)
		{
			if (id_getScroller_Landroid_content_Context_ == IntPtr.Zero)
				id_getScroller_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getScroller", "(Landroid/content/Context;)Luk/co/senab/photoview/scrollerproxy/ScrollerProxy;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy __ret = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Scrollerproxy.ScrollerProxy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScroller_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("uk/co/senab/photoview/scrollerproxy/ScrollerProxy", DoNotGenerateAcw=true)]
	internal partial class ScrollerProxyInvoker : ScrollerProxy {

		public ScrollerProxyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScrollerProxyInvoker); }
		}

		static IntPtr id_getCurrX;
		public override unsafe int CurrX {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='getCurrX' and count(parameter)=0]"
			[Register ("getCurrX", "()I", "GetGetCurrXHandler")]
			get {
				if (id_getCurrX == IntPtr.Zero)
					id_getCurrX = JNIEnv.GetMethodID (class_ref, "getCurrX", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getCurrX);
				} finally {
				}
			}
		}

		static IntPtr id_getCurrY;
		public override unsafe int CurrY {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='getCurrY' and count(parameter)=0]"
			[Register ("getCurrY", "()I", "GetGetCurrYHandler")]
			get {
				if (id_getCurrY == IntPtr.Zero)
					id_getCurrY = JNIEnv.GetMethodID (class_ref, "getCurrY", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getCurrY);
				} finally {
				}
			}
		}

		static IntPtr id_isFinished;
		public override unsafe bool IsFinished {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='isFinished' and count(parameter)=0]"
			[Register ("isFinished", "()Z", "GetIsFinishedHandler")]
			get {
				if (id_isFinished == IntPtr.Zero)
					id_isFinished = JNIEnv.GetMethodID (class_ref, "isFinished", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isFinished);
				} finally {
				}
			}
		}

		static IntPtr id_computeScrollOffset;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='computeScrollOffset' and count(parameter)=0]"
		[Register ("computeScrollOffset", "()Z", "GetComputeScrollOffsetHandler")]
		public override unsafe bool ComputeScrollOffset ()
		{
			if (id_computeScrollOffset == IntPtr.Zero)
				id_computeScrollOffset = JNIEnv.GetMethodID (class_ref, "computeScrollOffset", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_computeScrollOffset);
			} finally {
			}
		}

		static IntPtr id_fling_IIIIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='fling' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("fling", "(IIIIIIIIII)V", "GetFling_IIIIIIIIIIHandler")]
		public override unsafe void Fling (int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9)
		{
			if (id_fling_IIIIIIIIII == IntPtr.Zero)
				id_fling_IIIIIIIIII = JNIEnv.GetMethodID (class_ref, "fling", "(IIIIIIIIII)V");
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				JNIEnv.CallVoidMethod  (Handle, id_fling_IIIIIIIIII, __args);
			} finally {
			}
		}

		static IntPtr id_forceFinished_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.scrollerproxy']/class[@name='ScrollerProxy']/method[@name='forceFinished' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("forceFinished", "(Z)V", "GetForceFinished_ZHandler")]
		public override unsafe void ForceFinished (bool p0)
		{
			if (id_forceFinished_Z == IntPtr.Zero)
				id_forceFinished_Z = JNIEnv.GetMethodID (class_ref, "forceFinished", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_forceFinished_Z, __args);
			} finally {
			}
		}

	}

}

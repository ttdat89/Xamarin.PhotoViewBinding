using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview {

	// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='Compat']"
	[global::Android.Runtime.Register ("uk/co/senab/photoview/Compat", DoNotGenerateAcw=true)]
	public partial class Compat : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("uk/co/senab/photoview/Compat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Compat); }
		}

		protected Compat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='Compat']/constructor[@name='Compat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Compat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Compat)) {
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

		static IntPtr id_getPointerIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='Compat']/method[@name='getPointerIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPointerIndex", "(I)I", "")]
		public static unsafe int GetPointerIndex (int p0)
		{
			if (id_getPointerIndex_I == IntPtr.Zero)
				id_getPointerIndex_I = JNIEnv.GetStaticMethodID (class_ref, "getPointerIndex", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getPointerIndex_I, __args);
			} finally {
			}
		}

		static IntPtr id_postOnAnimation_Landroid_view_View_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='Compat']/method[@name='postOnAnimation' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("postOnAnimation", "(Landroid/view/View;Ljava/lang/Runnable;)V", "")]
		public static unsafe void PostOnAnimation (global::Android.Views.View p0, global::Java.Lang.IRunnable p1)
		{
			if (id_postOnAnimation_Landroid_view_View_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_postOnAnimation_Landroid_view_View_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "postOnAnimation", "(Landroid/view/View;Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_postOnAnimation_Landroid_view_View_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

	}
}

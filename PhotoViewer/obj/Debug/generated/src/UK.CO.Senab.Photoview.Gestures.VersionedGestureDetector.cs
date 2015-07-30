using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='VersionedGestureDetector']"
	[global::Android.Runtime.Register ("uk/co/senab/photoview/gestures/VersionedGestureDetector", DoNotGenerateAcw=true)]
	public sealed partial class VersionedGestureDetector : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("uk/co/senab/photoview/gestures/VersionedGestureDetector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VersionedGestureDetector); }
		}

		internal VersionedGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='VersionedGestureDetector']/constructor[@name='VersionedGestureDetector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VersionedGestureDetector ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VersionedGestureDetector)) {
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

		static IntPtr id_newInstance_Landroid_content_Context_Luk_co_senab_photoview_gestures_OnGestureListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='VersionedGestureDetector']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='uk.co.senab.photoview.gestures.OnGestureListener']]"
		[Register ("newInstance", "(Landroid/content/Context;Luk/co/senab/photoview/gestures/OnGestureListener;)Luk/co/senab/photoview/gestures/GestureDetector;", "")]
		public static unsafe global::UK.CO.Senab.Photoview.Gestures.IGestureDetector NewInstance (global::Android.Content.Context p0, global::UK.CO.Senab.Photoview.Gestures.IOnGestureListener p1)
		{
			if (id_newInstance_Landroid_content_Context_Luk_co_senab_photoview_gestures_OnGestureListener_ == IntPtr.Zero)
				id_newInstance_Landroid_content_Context_Luk_co_senab_photoview_gestures_OnGestureListener_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Landroid/content/Context;Luk/co/senab/photoview/gestures/OnGestureListener;)Luk/co/senab/photoview/gestures/GestureDetector;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::UK.CO.Senab.Photoview.Gestures.IGestureDetector __ret = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Gestures.IGestureDetector> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Landroid_content_Context_Luk_co_senab_photoview_gestures_OnGestureListener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}

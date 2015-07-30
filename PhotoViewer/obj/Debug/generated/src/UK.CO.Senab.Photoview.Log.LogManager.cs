using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview.log']/class[@name='LogManager']"
	[global::Android.Runtime.Register ("uk/co/senab/photoview/log/LogManager", DoNotGenerateAcw=true)]
	public sealed partial class LogManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("uk/co/senab/photoview/log/LogManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogManager); }
		}

		internal LogManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview.log']/class[@name='LogManager']/constructor[@name='LogManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LogManager)) {
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

		static IntPtr id_getLogger;
		static IntPtr id_setLogger_Luk_co_senab_photoview_log_Logger_;
		public static unsafe global::UK.CO.Senab.Photoview.Log.ILogger Logger {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.log']/class[@name='LogManager']/method[@name='getLogger' and count(parameter)=0]"
			[Register ("getLogger", "()Luk/co/senab/photoview/log/Logger;", "GetGetLoggerHandler")]
			get {
				if (id_getLogger == IntPtr.Zero)
					id_getLogger = JNIEnv.GetStaticMethodID (class_ref, "getLogger", "()Luk/co/senab/photoview/log/Logger;");
				try {
					return global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.Log.ILogger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogger), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview.log']/class[@name='LogManager']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.log.Logger']]"
			[Register ("setLogger", "(Luk/co/senab/photoview/log/Logger;)V", "GetSetLogger_Luk_co_senab_photoview_log_Logger_Handler")]
			set {
				if (id_setLogger_Luk_co_senab_photoview_log_Logger_ == IntPtr.Zero)
					id_setLogger_Luk_co_senab_photoview_log_Logger_ = JNIEnv.GetStaticMethodID (class_ref, "setLogger", "(Luk/co/senab/photoview/log/Logger;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogger_Luk_co_senab_photoview_log_Logger_, __args);
				} finally {
				}
			}
		}

	}
}

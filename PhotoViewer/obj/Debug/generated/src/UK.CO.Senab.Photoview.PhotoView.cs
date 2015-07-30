using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview {

	// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']"
	[global::Android.Runtime.Register ("uk/co/senab/photoview/PhotoView", DoNotGenerateAcw=true)]
	public partial class PhotoView : global::Android.Widget.ImageView, global::UK.CO.Senab.Photoview.IPhotoViewInterface {


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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("uk/co/senab/photoview/PhotoView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PhotoView); }
		}

		protected PhotoView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/constructor[@name='PhotoView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PhotoView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (PhotoView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/constructor[@name='PhotoView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PhotoView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PhotoView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/constructor[@name='PhotoView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PhotoView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (PhotoView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisplayMatrix);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayMatrix;
		public virtual unsafe global::Android.Graphics.Matrix DisplayMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getDisplayMatrix' and count(parameter)=0]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisplayRect);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayRect;
		public virtual unsafe global::Android.Graphics.RectF DisplayRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getDisplayRect' and count(parameter)=0]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IPhotoViewImplementation);
		}
#pragma warning restore 0169

		static IntPtr id_getIPhotoViewImplementation;
		public virtual unsafe global::UK.CO.Senab.Photoview.IPhotoViewInterface IPhotoViewImplementation {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getIPhotoViewImplementation' and count(parameter)=0]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxScale;
		static IntPtr id_setMaxScale_F;
		[Obsolete (@"deprecated")]
		public virtual unsafe float MaxScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMaxScale' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMaxScale' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumScale;
		static IntPtr id_setMaximumScale_F;
		public virtual unsafe float MaximumScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMaximumScale' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMaximumScale' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MediumScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMediumScale;
		static IntPtr id_setMediumScale_F;
		public virtual unsafe float MediumScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMediumScale' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMediumScale' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MidScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMidScale;
		static IntPtr id_setMidScale_F;
		[Obsolete (@"deprecated")]
		public virtual unsafe float MidScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMidScale' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMidScale' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinScale;
		static IntPtr id_setMinScale_F;
		[Obsolete (@"deprecated")]
		public virtual unsafe float MinScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMinScale' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMinScale' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinimumScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumScale;
		static IntPtr id_setMinimumScale_F;
		public virtual unsafe float MinimumScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMinimumScale' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMinimumScale' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener p0 = (global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener)global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPhotoTapListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnPhotoTapListener;
		static IntPtr id_setOnPhotoTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnPhotoTapListener_;
		public virtual unsafe global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnPhotoTapListener OnPhotoTapListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getOnPhotoTapListener' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setOnPhotoTapListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher.OnPhotoTapListener']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener p0 = (global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener)global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnViewTapListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnViewTapListener;
		static IntPtr id_setOnViewTapListener_Luk_co_senab_photoview_PhotoViewAttacher_OnViewTapListener_;
		public virtual unsafe global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnViewTapListener OnViewTapListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getOnViewTapListener' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setOnViewTapListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher.OnViewTapListener']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScale;
		static IntPtr id_setScale_F;
		public virtual unsafe float Scale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getScale' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VisibleRectangleBitmap);
		}
#pragma warning restore 0169

		static IntPtr id_getVisibleRectangleBitmap;
		public virtual unsafe global::Android.Graphics.Bitmap VisibleRectangleBitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getVisibleRectangleBitmap' and count(parameter)=0]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoom ();
		}
#pragma warning restore 0169

		static IntPtr id_canZoom;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='canZoom' and count(parameter)=0]"
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

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		protected virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowParentInterceptOnEdge (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllowParentInterceptOnEdge_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setAllowParentInterceptOnEdge' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetDisplayMatrix (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayMatrix_Landroid_graphics_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setDisplayMatrix' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.GestureDetector.IOnDoubleTapListener p0 = (global::Android.Views.GestureDetector.IOnDoubleTapListener)global::Java.Lang.Object.GetObject<global::Android.Views.GestureDetector.IOnDoubleTapListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDoubleTapListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setOnDoubleTapListener' and count(parameter)=1 and parameter[1][@type='android.view.GestureDetector.OnDoubleTapListener']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener p0 = (global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener)global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnMatrixChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMatrixChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMatrixChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnMatrixChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setOnMatrixChangeListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher.OnMatrixChangedListener']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener p0 = (global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener)global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoViewAttacher.IOnScaleChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnScaleChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnScaleChangeListener_Luk_co_senab_photoview_PhotoViewAttacher_OnScaleChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setOnScaleChangeListener' and count(parameter)=1 and parameter[1][@type='uk.co.senab.photoview.PhotoViewAttacher.OnScaleChangeListener']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPhotoViewRotation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPhotoViewRotation_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setPhotoViewRotation' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotationBy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRotationBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setRotationBy' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotationTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRotationTo_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setRotationTo' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setScale_FZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setScale' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='boolean']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setScale_FFFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setScale' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='boolean']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleLevels (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setScaleLevels_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setScaleLevels' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomTransitionDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoomTransitionDuration_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setZoomTransitionDuration' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoomable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setZoomable' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

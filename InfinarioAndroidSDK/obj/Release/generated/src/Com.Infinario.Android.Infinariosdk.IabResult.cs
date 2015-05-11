using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabResult']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/IabResult", DoNotGenerateAcw=true)]
	public partial class IabResult : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/IabResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IabResult); }
		}

		protected IabResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabResult']/constructor[@name='IabResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe IabResult (int p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (IabResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isFailure;
#pragma warning disable 0169
		static Delegate GetIsFailureHandler ()
		{
			if (cb_isFailure == null)
				cb_isFailure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFailure);
			return cb_isFailure;
		}

		static bool n_IsFailure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.IabResult __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFailure;
		}
#pragma warning restore 0169

		static IntPtr id_isFailure;
		public virtual unsafe bool IsFailure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabResult']/method[@name='isFailure' and count(parameter)=0]"
			[Register ("isFailure", "()Z", "GetIsFailureHandler")]
			get {
				if (id_isFailure == IntPtr.Zero)
					id_isFailure = JNIEnv.GetMethodID (class_ref, "isFailure", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFailure);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFailure", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSuccess;
#pragma warning disable 0169
		static Delegate GetIsSuccessHandler ()
		{
			if (cb_isSuccess == null)
				cb_isSuccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuccess);
			return cb_isSuccess;
		}

		static bool n_IsSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.IabResult __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccess;
		}
#pragma warning restore 0169

		static IntPtr id_isSuccess;
		public virtual unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabResult']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				if (id_isSuccess == IntPtr.Zero)
					id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSuccess);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuccess", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.IabResult __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabResult']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResponse);
			return cb_getResponse;
		}

		static int n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.IabResult __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Response;
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		public virtual unsafe int Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabResult']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()I", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getResponse);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()I"));
				} finally {
				}
			}
		}

	}
}

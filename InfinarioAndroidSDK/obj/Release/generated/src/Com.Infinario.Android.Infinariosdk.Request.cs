using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Request']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/Request", DoNotGenerateAcw=true)]
	public partial class Request : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/Request", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Request); }
		}

		protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Request']/constructor[@name='Request' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(ILjava/lang/String;I)V", "")]
		public unsafe Request (int p0, string p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Request)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_I == IntPtr.Zero)
					id_ctor_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getCommand;
#pragma warning disable 0169
		static Delegate GetGetCommandHandler ()
		{
			if (cb_getCommand == null)
				cb_getCommand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCommand);
			return cb_getCommand;
		}

		static IntPtr n_GetCommand (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Request __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Command);
		}
#pragma warning restore 0169

		static IntPtr id_getCommand;
		public virtual unsafe global::Org.Json.JSONObject Command {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Request']/method[@name='getCommand' and count(parameter)=0]"
			[Register ("getCommand", "()Lorg/json/JSONObject;", "GetGetCommandHandler")]
			get {
				if (id_getCommand == IntPtr.Zero)
					id_getCommand = JNIEnv.GetMethodID (class_ref, "getCommand", "()Lorg/json/JSONObject;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getCommand), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommand", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Request __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Request']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getId);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRetries;
#pragma warning disable 0169
		static Delegate GetGetRetriesHandler ()
		{
			if (cb_getRetries == null)
				cb_getRetries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetries);
			return cb_getRetries;
		}

		static int n_GetRetries (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Request __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Retries;
		}
#pragma warning restore 0169

		static IntPtr id_getRetries;
		public virtual unsafe int Retries {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Request']/method[@name='getRetries' and count(parameter)=0]"
			[Register ("getRetries", "()I", "GetGetRetriesHandler")]
			get {
				if (id_getRetries == IntPtr.Zero)
					id_getRetries = JNIEnv.GetMethodID (class_ref, "getRetries", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRetries);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetries", "()I"));
				} finally {
				}
			}
		}

	}
}

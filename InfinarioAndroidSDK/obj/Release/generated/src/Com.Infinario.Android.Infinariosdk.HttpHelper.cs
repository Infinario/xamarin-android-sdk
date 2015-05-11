using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='HttpHelper']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/HttpHelper", DoNotGenerateAcw=true)]
	public partial class HttpHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/HttpHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpHelper); }
		}

		protected HttpHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='HttpHelper']/constructor[@name='HttpHelper' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe HttpHelper (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (HttpHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='HttpHelper']/constructor[@name='HttpHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpHelper)) {
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

		static Delegate cb_post_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_post_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_post_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_post_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static IntPtr n_Post_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Infinario.Android.Infinariosdk.HttpHelper __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.HttpHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='HttpHelper']/method[@name='post' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("post", "(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "GetPost_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Org.Json.JSONObject Post (string p0, global::Org.Json.JSONObject p1)
		{
			if (id_post_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Org.Json.JSONObject __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_post_Ljava_lang_String_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

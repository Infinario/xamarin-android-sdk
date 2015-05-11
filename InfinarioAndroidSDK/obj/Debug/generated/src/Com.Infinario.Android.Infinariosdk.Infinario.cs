using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/Infinario", DoNotGenerateAcw=true)]
	public partial class Infinario : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/Infinario", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Infinario); }
		}

		protected Infinario (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_cancelPeriodicAlarm_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='cancelPeriodicAlarm' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("cancelPeriodicAlarm", "(Landroid/content/Context;)V", "")]
		public static unsafe void CancelPeriodicAlarm (global::Android.Content.Context p0)
		{
			if (id_cancelPeriodicAlarm_Landroid_content_Context_ == IntPtr.Zero)
				id_cancelPeriodicAlarm_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "cancelPeriodicAlarm", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cancelPeriodicAlarm_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_clearStoredData;
#pragma warning disable 0169
		static Delegate GetClearStoredDataHandler ()
		{
			if (cb_clearStoredData == null)
				cb_clearStoredData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearStoredData);
			return cb_clearStoredData;
		}

		static void n_ClearStoredData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearStoredData ();
		}
#pragma warning restore 0169

		static IntPtr id_clearStoredData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='clearStoredData' and count(parameter)=0]"
		[Register ("clearStoredData", "()V", "GetClearStoredDataHandler")]
		public virtual unsafe void ClearStoredData ()
		{
			if (id_clearStoredData == IntPtr.Zero)
				id_clearStoredData = JNIEnv.GetMethodID (class_ref, "clearStoredData", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearStoredData);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearStoredData", "()V"));
			} finally {
			}
		}

		static Delegate cb_disableAutomaticFlushing;
#pragma warning disable 0169
		static Delegate GetDisableAutomaticFlushingHandler ()
		{
			if (cb_disableAutomaticFlushing == null)
				cb_disableAutomaticFlushing = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableAutomaticFlushing);
			return cb_disableAutomaticFlushing;
		}

		static void n_DisableAutomaticFlushing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableAutomaticFlushing ();
		}
#pragma warning restore 0169

		static IntPtr id_disableAutomaticFlushing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='disableAutomaticFlushing' and count(parameter)=0]"
		[Register ("disableAutomaticFlushing", "()V", "GetDisableAutomaticFlushingHandler")]
		public virtual unsafe void DisableAutomaticFlushing ()
		{
			if (id_disableAutomaticFlushing == IntPtr.Zero)
				id_disableAutomaticFlushing = JNIEnv.GetMethodID (class_ref, "disableAutomaticFlushing", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disableAutomaticFlushing);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableAutomaticFlushing", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableAutomaticFlushing;
#pragma warning disable 0169
		static Delegate GetEnableAutomaticFlushingHandler ()
		{
			if (cb_enableAutomaticFlushing == null)
				cb_enableAutomaticFlushing = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableAutomaticFlushing);
			return cb_enableAutomaticFlushing;
		}

		static void n_EnableAutomaticFlushing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableAutomaticFlushing ();
		}
#pragma warning restore 0169

		static IntPtr id_enableAutomaticFlushing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='enableAutomaticFlushing' and count(parameter)=0]"
		[Register ("enableAutomaticFlushing", "()V", "GetEnableAutomaticFlushingHandler")]
		public virtual unsafe void EnableAutomaticFlushing ()
		{
			if (id_enableAutomaticFlushing == IntPtr.Zero)
				id_enableAutomaticFlushing = JNIEnv.GetMethodID (class_ref, "enableAutomaticFlushing", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableAutomaticFlushing);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableAutomaticFlushing", "()V"));
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_flush);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flush", "()V"));
			} finally {
			}
		}

		static IntPtr id_flush_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='flush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("flush", "(Landroid/content/Context;)V", "")]
		public static unsafe void Flush (global::Android.Content.Context p0)
		{
			if (id_flush_Landroid_content_Context_ == IntPtr.Zero)
				id_flush_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "flush", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_flush_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInstance", "(Landroid/content/Context;Ljava/lang/String;)Lcom/infinario/android/infinariosdk/Infinario;", "")]
		public static unsafe global::Com.Infinario.Android.Infinariosdk.Infinario GetInstance (global::Android.Content.Context p0, string p1)
		{
			if (id_getInstance_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Ljava/lang/String;)Lcom/infinario/android/infinariosdk/Infinario;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Infinario.Android.Infinariosdk.Infinario __ret = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='getInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/infinario/android/infinariosdk/Infinario;", "")]
		public static unsafe global::Com.Infinario.Android.Infinariosdk.Infinario GetInstance (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/infinario/android/infinariosdk/Infinario;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Com.Infinario.Android.Infinariosdk.Infinario __ret = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='getInstance' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/infinario/android/infinariosdk/Infinario;", "")]
		public static unsafe global::Com.Infinario.Android.Infinariosdk.Infinario GetInstance (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			if (id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/infinario/android/infinariosdk/Infinario;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				global::Com.Infinario.Android.Infinariosdk.Infinario __ret = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='getInstance' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lcom/infinario/android/infinariosdk/Infinario;", "")]
		public static unsafe global::Com.Infinario.Android.Infinariosdk.Infinario GetInstance (global::Android.Content.Context p0, string p1, string p2, global::System.Collections.Generic.IDictionary<string, string> p3)
		{
			if (id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lcom/infinario/android/infinariosdk/Infinario;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				global::Com.Infinario.Android.Infinariosdk.Infinario __ret = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='getInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)Lcom/infinario/android/infinariosdk/Infinario;", "")]
		public static unsafe global::Com.Infinario.Android.Infinariosdk.Infinario GetInstance (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)Lcom/infinario/android/infinariosdk/Infinario;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Com.Infinario.Android.Infinariosdk.Infinario __ret = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_identify_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIdentify_Ljava_lang_String_Handler ()
		{
			if (cb_identify_Ljava_lang_String_ == null)
				cb_identify_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Identify_Ljava_lang_String_);
			return cb_identify_Ljava_lang_String_;
		}

		static void n_Identify_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0);
		}
#pragma warning restore 0169

		static IntPtr id_identify_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='identify' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("identify", "(Ljava/lang/String;)V", "GetIdentify_Ljava_lang_String_Handler")]
		public virtual unsafe void Identify (string p0)
		{
			if (id_identify_Ljava_lang_String_ == IntPtr.Zero)
				id_identify_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "identify", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_identify_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "identify", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_identify_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetIdentify_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_identify_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_identify_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Identify_Ljava_lang_String_Ljava_util_Map_);
			return cb_identify_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Identify_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_identify_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='identify' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("identify", "(Ljava/lang/String;Ljava/util/Map;)V", "GetIdentify_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void Identify (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_identify_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_identify_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "identify", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_identify_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "identify", "(Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_identify_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetIdentify_Ljava_util_Map_Handler ()
		{
			if (cb_identify_Ljava_util_Map_ == null)
				cb_identify_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Identify_Ljava_util_Map_);
			return cb_identify_Ljava_util_Map_;
		}

		static void n_Identify_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0);
		}
#pragma warning restore 0169

		static IntPtr id_identify_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='identify' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("identify", "(Ljava/util/Map;)V", "GetIdentify_Ljava_util_Map_Handler")]
		public virtual unsafe void Identify (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_identify_Ljava_util_Map_ == IntPtr.Zero)
				id_identify_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "identify", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_identify_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "identify", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_identify_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetIdentify_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_identify_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_identify_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Identify_Ljava_util_Map_Ljava_util_Map_);
			return cb_identify_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_Identify_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_identify_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='identify' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("identify", "(Ljava/util/Map;Ljava/util/Map;)V", "GetIdentify_Ljava_util_Map_Ljava_util_Map_Handler")]
		public virtual unsafe void Identify (global::System.Collections.Generic.IDictionary<string, string> p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_identify_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_identify_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "identify", "(Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_identify_Ljava_util_Map_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "identify", "(Ljava/util/Map;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setSessionProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetSessionProperties_Ljava_util_Map_Handler ()
		{
			if (cb_setSessionProperties_Ljava_util_Map_ == null)
				cb_setSessionProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSessionProperties_Ljava_util_Map_);
			return cb_setSessionProperties_Ljava_util_Map_;
		}

		static void n_SetSessionProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSessionProperties (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSessionProperties_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='setSessionProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setSessionProperties", "(Ljava/util/Map;)V", "GetSetSessionProperties_Ljava_util_Map_Handler")]
		public virtual unsafe void SetSessionProperties (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_setSessionProperties_Ljava_util_Map_ == IntPtr.Zero)
				id_setSessionProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setSessionProperties", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSessionProperties_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionProperties", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setupPeriodicAlarm_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='setupPeriodicAlarm' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setupPeriodicAlarm", "(Landroid/content/Context;)V", "")]
		public static unsafe void SetupPeriodicAlarm (global::Android.Content.Context p0)
		{
			if (id_setupPeriodicAlarm_Landroid_content_Context_ == IntPtr.Zero)
				id_setupPeriodicAlarm_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setupPeriodicAlarm", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setupPeriodicAlarm_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_track_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrack_Ljava_lang_String_Handler ()
		{
			if (cb_track_Ljava_lang_String_ == null)
				cb_track_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Track_Ljava_lang_String_);
			return cb_track_Ljava_lang_String_;
		}

		static bool n_Track_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Track (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_track_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='track' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("track", "(Ljava/lang/String;)Z", "GetTrack_Ljava_lang_String_Handler")]
		public virtual unsafe bool Track (string p0)
		{
			if (id_track_Ljava_lang_String_ == IntPtr.Zero)
				id_track_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "track", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_track_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "track", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_track_Ljava_lang_String_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetTrack_Ljava_lang_String_Ljava_lang_Long_Handler ()
		{
			if (cb_track_Ljava_lang_String_Ljava_lang_Long_ == null)
				cb_track_Ljava_lang_String_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Track_Ljava_lang_String_Ljava_lang_Long_);
			return cb_track_Ljava_lang_String_Ljava_lang_Long_;
		}

		static bool n_Track_Ljava_lang_String_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Track (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_track_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='track' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("track", "(Ljava/lang/String;Ljava/lang/Long;)Z", "GetTrack_Ljava_lang_String_Ljava_lang_Long_Handler")]
		public virtual unsafe bool Track (string p0, global::Java.Lang.Long p1)
		{
			if (id_track_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_track_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "track", "(Ljava/lang/String;Ljava/lang/Long;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_track_Ljava_lang_String_Ljava_lang_Long_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "track", "(Ljava/lang/String;Ljava/lang/Long;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_track_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetTrack_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_track_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_track_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Track_Ljava_lang_String_Ljava_util_Map_);
			return cb_track_Ljava_lang_String_Ljava_util_Map_;
		}

		static bool n_Track_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Track (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_track_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='track' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("track", "(Ljava/lang/String;Ljava/util/Map;)Z", "GetTrack_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe bool Track (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_track_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_track_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "track", "(Ljava/lang/String;Ljava/util/Map;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_track_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "track", "(Ljava/lang/String;Ljava/util/Map;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_track_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetTrack_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_Handler ()
		{
			if (cb_track_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_ == null)
				cb_track_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Track_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_);
			return cb_track_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_;
		}

		static bool n_Track_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Track (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_track_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='track' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='java.lang.Long']]"
		[Register ("track", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/Long;)Z", "GetTrack_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_Handler")]
		public virtual unsafe bool Track (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Java.Lang.Long p2)
		{
			if (id_track_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_ == IntPtr.Zero)
				id_track_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "track", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/Long;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_track_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Long_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "track", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/Long;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_trackPurchases_ILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetTrackPurchases_ILandroid_content_Intent_Handler ()
		{
			if (cb_trackPurchases_ILandroid_content_Intent_ == null)
				cb_trackPurchases_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_TrackPurchases_ILandroid_content_Intent_);
			return cb_trackPurchases_ILandroid_content_Intent_;
		}

		static void n_TrackPurchases_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TrackPurchases (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_trackPurchases_ILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='trackPurchases' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
		[Register ("trackPurchases", "(ILandroid/content/Intent;)V", "GetTrackPurchases_ILandroid_content_Intent_Handler")]
		public virtual unsafe void TrackPurchases (int p0, global::Android.Content.Intent p1)
		{
			if (id_trackPurchases_ILandroid_content_Intent_ == IntPtr.Zero)
				id_trackPurchases_ILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "trackPurchases", "(ILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_trackPurchases_ILandroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trackPurchases", "(ILandroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_update_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_util_Map_Handler ()
		{
			if (cb_update_Ljava_util_Map_ == null)
				cb_update_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Update_Ljava_util_Map_);
			return cb_update_Ljava_util_Map_;
		}

		static bool n_Update_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Infinario __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Infinario> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Update (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Infinario']/method[@name='update' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("update", "(Ljava/util/Map;)Z", "GetUpdate_Ljava_util_Map_Handler")]
		public virtual unsafe bool Update (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_update_Ljava_util_Map_ == IntPtr.Zero)
				id_update_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/util/Map;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_update_Ljava_util_Map_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Ljava/util/Map;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

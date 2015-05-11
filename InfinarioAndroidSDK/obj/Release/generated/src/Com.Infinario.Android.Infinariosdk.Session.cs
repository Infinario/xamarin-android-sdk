using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Session']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/Session", DoNotGenerateAcw=true)]
	public partial class Session : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Session.PingRunnable']"
		[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/Session$PingRunnable", DoNotGenerateAcw=true)]
		public partial class PingRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/infinario/android/infinariosdk/Session$PingRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PingRunnable); }
			}

			protected PingRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Infinario.Android.Infinariosdk.Session.PingRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Session.PingRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Session.PingRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/Session", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Session); }
		}

		protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_infinario_android_infinariosdk_Preferences_Lcom_infinario_android_infinariosdk_SessionListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Session']/constructor[@name='Session' and count(parameter)=2 and parameter[1][@type='com.infinario.android.infinariosdk.Preferences'] and parameter[2][@type='com.infinario.android.infinariosdk.SessionListener']]"
		[Register (".ctor", "(Lcom/infinario/android/infinariosdk/Preferences;Lcom/infinario/android/infinariosdk/SessionListener;)V", "")]
		public unsafe Session (global::Com.Infinario.Android.Infinariosdk.Preferences p0, global::Com.Infinario.Android.Infinariosdk.SessionListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Session)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/infinario/android/infinariosdk/Preferences;Lcom/infinario/android/infinariosdk/SessionListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/infinario/android/infinariosdk/Preferences;Lcom/infinario/android/infinariosdk/SessionListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_infinario_android_infinariosdk_Preferences_Lcom_infinario_android_infinariosdk_SessionListener_ == IntPtr.Zero)
					id_ctor_Lcom_infinario_android_infinariosdk_Preferences_Lcom_infinario_android_infinariosdk_SessionListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/infinario/android/infinariosdk/Preferences;Lcom/infinario/android/infinariosdk/SessionListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_infinario_android_infinariosdk_Preferences_Lcom_infinario_android_infinariosdk_SessionListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_infinario_android_infinariosdk_Preferences_Lcom_infinario_android_infinariosdk_SessionListener_, __args);
			} finally {
			}
		}

		static IntPtr id_defaultProperties;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Session']/method[@name='defaultProperties' and count(parameter)=0]"
		[Register ("defaultProperties", "()Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> DefaultProperties ()
		{
			if (id_defaultProperties == IntPtr.Zero)
				id_defaultProperties = JNIEnv.GetStaticMethodID (class_ref, "defaultProperties", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultProperties), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_defaultProperties_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Session']/method[@name='defaultProperties' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("defaultProperties", "(J)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> DefaultProperties (long p0)
		{
			if (id_defaultProperties_J == IntPtr.Zero)
				id_defaultProperties_J = JNIEnv.GetStaticMethodID (class_ref, "defaultProperties", "(J)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultProperties_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_restart_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetRestart_Ljava_util_Map_Handler ()
		{
			if (cb_restart_Ljava_util_Map_ == null)
				cb_restart_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Restart_Ljava_util_Map_);
			return cb_restart_Ljava_util_Map_;
		}

		static void n_Restart_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Session __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Restart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_restart_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Session']/method[@name='restart' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("restart", "(Ljava/util/Map;)V", "GetRestart_Ljava_util_Map_Handler")]
		public virtual unsafe void Restart (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_restart_Ljava_util_Map_ == IntPtr.Zero)
				id_restart_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "restart", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_restart_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restart", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Session __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Session']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

	}
}

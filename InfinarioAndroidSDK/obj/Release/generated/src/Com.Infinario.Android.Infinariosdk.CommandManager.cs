using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='CommandManager']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/CommandManager", DoNotGenerateAcw=true)]
	public partial class CommandManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/CommandManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommandManager); }
		}

		protected CommandManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='CommandManager']/constructor[@name='CommandManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe CommandManager (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (CommandManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_executeBatch;
#pragma warning disable 0169
		static Delegate GetExecuteBatchHandler ()
		{
			if (cb_executeBatch == null)
				cb_executeBatch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ExecuteBatch);
			return cb_executeBatch;
		}

		static bool n_ExecuteBatch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.CommandManager __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExecuteBatch ();
		}
#pragma warning restore 0169

		static IntPtr id_executeBatch;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='CommandManager']/method[@name='executeBatch' and count(parameter)=0]"
		[Register ("executeBatch", "()Z", "GetExecuteBatchHandler")]
		public virtual unsafe bool ExecuteBatch ()
		{
			if (id_executeBatch == IntPtr.Zero)
				id_executeBatch = JNIEnv.GetMethodID (class_ref, "executeBatch", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_executeBatch);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "executeBatch", "()Z"));
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
			global::Com.Infinario.Android.Infinariosdk.CommandManager __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='CommandManager']/method[@name='flush' and count(parameter)=0]"
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

		static Delegate cb_schedule_Lcom_infinario_android_infinariosdk_Command_;
#pragma warning disable 0169
		static Delegate GetSchedule_Lcom_infinario_android_infinariosdk_Command_Handler ()
		{
			if (cb_schedule_Lcom_infinario_android_infinariosdk_Command_ == null)
				cb_schedule_Lcom_infinario_android_infinariosdk_Command_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Schedule_Lcom_infinario_android_infinariosdk_Command_);
			return cb_schedule_Lcom_infinario_android_infinariosdk_Command_;
		}

		static bool n_Schedule_Lcom_infinario_android_infinariosdk_Command_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.CommandManager __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Infinario.Android.Infinariosdk.Command p0 = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Command> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Schedule (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_schedule_Lcom_infinario_android_infinariosdk_Command_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='CommandManager']/method[@name='schedule' and count(parameter)=1 and parameter[1][@type='com.infinario.android.infinariosdk.Command']]"
		[Register ("schedule", "(Lcom/infinario/android/infinariosdk/Command;)Z", "GetSchedule_Lcom_infinario_android_infinariosdk_Command_Handler")]
		public virtual unsafe bool Schedule (global::Com.Infinario.Android.Infinariosdk.Command p0)
		{
			if (id_schedule_Lcom_infinario_android_infinariosdk_Command_ == IntPtr.Zero)
				id_schedule_Lcom_infinario_android_infinariosdk_Command_ = JNIEnv.GetMethodID (class_ref, "schedule", "(Lcom/infinario/android/infinariosdk/Command;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_schedule_Lcom_infinario_android_infinariosdk_Command_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "schedule", "(Lcom/infinario/android/infinariosdk/Command;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}

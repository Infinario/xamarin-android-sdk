using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='DbQueue']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/DbQueue", DoNotGenerateAcw=true)]
	public partial class DbQueue : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/DbQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DbQueue); }
		}

		protected DbQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='DbQueue']/constructor[@name='DbQueue' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DbQueue (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DbQueue)) {
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

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.DbQueue __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.DbQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='DbQueue']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_clear_Ljava_util_Set_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetClear_Ljava_util_Set_Ljava_util_Set_Handler ()
		{
			if (cb_clear_Ljava_util_Set_Ljava_util_Set_ == null)
				cb_clear_Ljava_util_Set_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Clear_Ljava_util_Set_Ljava_util_Set_);
			return cb_clear_Ljava_util_Set_Ljava_util_Set_;
		}

		static void n_Clear_Ljava_util_Set_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Infinario.Android.Infinariosdk.DbQueue __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.DbQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<Java.Lang.Integer> p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<Java.Lang.Integer> p1 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Clear (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_clear_Ljava_util_Set_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='DbQueue']/method[@name='clear' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;java.lang.Integer&gt;'] and parameter[2][@type='java.util.Set&lt;java.lang.Integer&gt;']]"
		[Register ("clear", "(Ljava/util/Set;Ljava/util/Set;)V", "GetClear_Ljava_util_Set_Ljava_util_Set_Handler")]
		public virtual unsafe void Clear (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0, global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p1)
		{
			if (id_clear_Ljava_util_Set_Ljava_util_Set_ == IntPtr.Zero)
				id_clear_Ljava_util_Set_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "clear", "(Ljava/util/Set;Ljava/util/Set;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear_Ljava_util_Set_Ljava_util_Set_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "(Ljava/util/Set;Ljava/util/Set;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_pop;
#pragma warning disable 0169
		static Delegate GetPopHandler ()
		{
			if (cb_pop == null)
				cb_pop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Pop);
			return cb_pop;
		}

		static IntPtr n_Pop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.DbQueue __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.DbQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Infinario.Android.Infinariosdk.Request>.ToLocalJniHandle (__this.Pop ());
		}
#pragma warning restore 0169

		static IntPtr id_pop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='DbQueue']/method[@name='pop' and count(parameter)=0]"
		[Register ("pop", "()Ljava/util/List;", "GetPopHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Infinario.Android.Infinariosdk.Request> Pop ()
		{
			if (id_pop == IntPtr.Zero)
				id_pop = JNIEnv.GetMethodID (class_ref, "pop", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Infinario.Android.Infinariosdk.Request>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_pop), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Infinario.Android.Infinariosdk.Request>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pop", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pop_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetPop_Ljava_lang_Integer_Handler ()
		{
			if (cb_pop_Ljava_lang_Integer_ == null)
				cb_pop_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Pop_Ljava_lang_Integer_);
			return cb_pop_Ljava_lang_Integer_;
		}

		static IntPtr n_Pop_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.DbQueue __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.DbQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Infinario.Android.Infinariosdk.Request>.ToLocalJniHandle (__this.Pop (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_pop_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='DbQueue']/method[@name='pop' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("pop", "(Ljava/lang/Integer;)Ljava/util/List;", "GetPop_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Infinario.Android.Infinariosdk.Request> Pop (global::Java.Lang.Integer p0)
		{
			if (id_pop_Ljava_lang_Integer_ == IntPtr.Zero)
				id_pop_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "pop", "(Ljava/lang/Integer;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Infinario.Android.Infinariosdk.Request> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Infinario.Android.Infinariosdk.Request>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_pop_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Infinario.Android.Infinariosdk.Request>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pop", "(Ljava/lang/Integer;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Infinario.Android.Infinariosdk.DbQueue __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.DbQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Infinario.Android.Infinariosdk.Command p0 = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Command> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Schedule (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_schedule_Lcom_infinario_android_infinariosdk_Command_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='DbQueue']/method[@name='schedule' and count(parameter)=1 and parameter[1][@type='com.infinario.android.infinariosdk.Command']]"
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

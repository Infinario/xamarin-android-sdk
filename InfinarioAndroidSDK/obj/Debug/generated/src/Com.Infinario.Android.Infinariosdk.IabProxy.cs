using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabProxy']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/IabProxy", DoNotGenerateAcw=true)]
	public partial class IabProxy : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/IabProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IabProxy); }
		}

		protected IabProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_IBinder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabProxy']/constructor[@name='IabProxy' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register (".ctor", "(Landroid/os/IBinder;)V", "")]
		public unsafe IabProxy (global::Android.OS.IBinder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (IabProxy)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/IBinder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/IBinder;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_IBinder_ == IntPtr.Zero)
					id_ctor_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/IBinder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_IBinder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_IBinder_, __args);
			} finally {
			}
		}

		static Delegate cb_isLoaded;
#pragma warning disable 0169
		static Delegate GetIsLoadedHandler ()
		{
			if (cb_isLoaded == null)
				cb_isLoaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoaded);
			return cb_isLoaded;
		}

		static bool n_IsLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.IabProxy __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoaded;
		}
#pragma warning restore 0169

		static IntPtr id_isLoaded;
		public virtual unsafe bool IsLoaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabProxy']/method[@name='isLoaded' and count(parameter)=0]"
			[Register ("isLoaded", "()Z", "GetIsLoadedHandler")]
			get {
				if (id_isLoaded == IntPtr.Zero)
					id_isLoaded = JNIEnv.GetMethodID (class_ref, "isLoaded", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isLoaded);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLoaded", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Infinario.Android.Infinariosdk.IabProxy __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSkuDetails (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabProxy']/method[@name='getSkuDetails' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("getSkuDetails", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle GetSkuDetails (int p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			if (id_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getSkuDetails", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				global::Android.OS.Bundle __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSkuDetails", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsBillingSupported_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_IsBillingSupported_ILjava_lang_String_Ljava_lang_String_);
			return cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_;
		}

		static int n_IsBillingSupported_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Infinario.Android.Infinariosdk.IabProxy __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IsBillingSupported (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isBillingSupported_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabProxy']/method[@name='isBillingSupported' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("isBillingSupported", "(ILjava/lang/String;Ljava/lang/String;)I", "GetIsBillingSupported_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int IsBillingSupported (int p0, string p1, string p2)
		{
			if (id_isBillingSupported_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isBillingSupported_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isBillingSupported", "(ILjava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_isBillingSupported_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBillingSupported", "(ILjava/lang/String;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}

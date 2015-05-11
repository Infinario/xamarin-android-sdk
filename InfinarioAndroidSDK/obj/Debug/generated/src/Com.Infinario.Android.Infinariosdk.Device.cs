using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Device']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/Device", DoNotGenerateAcw=true)]
	public partial class Device : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/Device", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Device); }
		}

		protected Device (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Device']/constructor[@name='Device' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Device ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Device)) {
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

		static IntPtr id_deviceProperties;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Device']/method[@name='deviceProperties' and count(parameter)=0]"
		[Register ("deviceProperties", "()Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> DeviceProperties ()
		{
			if (id_deviceProperties == IntPtr.Zero)
				id_deviceProperties = JNIEnv.GetStaticMethodID (class_ref, "deviceProperties", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_deviceProperties), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

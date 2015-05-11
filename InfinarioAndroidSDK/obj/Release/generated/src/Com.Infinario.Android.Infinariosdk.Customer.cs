using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Customer']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/Customer", DoNotGenerateAcw=true)]
	public partial class Customer : global::Com.Infinario.Android.Infinariosdk.Command {


		static IntPtr companyId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Customer']/field[@name='companyId']"
		[Register ("companyId")]
		protected string CompanyId {
			get {
				if (companyId_jfieldId == IntPtr.Zero)
					companyId_jfieldId = JNIEnv.GetFieldID (class_ref, "companyId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, companyId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (companyId_jfieldId == IntPtr.Zero)
					companyId_jfieldId = JNIEnv.GetFieldID (class_ref, "companyId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, companyId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ids_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Customer']/field[@name='ids']"
		[Register ("ids")]
		protected global::System.Collections.IDictionary Ids {
			get {
				if (ids_jfieldId == IntPtr.Zero)
					ids_jfieldId = JNIEnv.GetFieldID (class_ref, "ids", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ids_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ids_jfieldId == IntPtr.Zero)
					ids_jfieldId = JNIEnv.GetFieldID (class_ref, "ids", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, ids_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr properties_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Customer']/field[@name='properties']"
		[Register ("properties")]
		protected global::System.Collections.IDictionary Properties {
			get {
				if (properties_jfieldId == IntPtr.Zero)
					properties_jfieldId = JNIEnv.GetFieldID (class_ref, "properties", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, properties_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (properties_jfieldId == IntPtr.Zero)
					properties_jfieldId = JNIEnv.GetFieldID (class_ref, "properties", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, properties_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/Customer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Customer); }
		}

		protected Customer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Customer']/constructor[@name='Customer' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe Customer (global::System.Collections.Generic.IDictionary<string, string> p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (Customer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Map;Ljava/lang/String;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Map;Ljava/lang/String;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;Ljava/lang/String;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}

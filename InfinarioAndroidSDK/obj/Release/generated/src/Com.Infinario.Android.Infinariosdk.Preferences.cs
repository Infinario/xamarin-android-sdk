using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/Preferences", DoNotGenerateAcw=true)]
	public partial class Preferences : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/Preferences", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Preferences); }
		}

		protected Preferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAutomaticFlushing;
#pragma warning disable 0169
		static Delegate GetGetAutomaticFlushingHandler ()
		{
			if (cb_getAutomaticFlushing == null)
				cb_getAutomaticFlushing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutomaticFlushing);
			return cb_getAutomaticFlushing;
		}

		static bool n_GetAutomaticFlushing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutomaticFlushing;
		}
#pragma warning restore 0169

		static Delegate cb_setAutomaticFlushing_Z;
#pragma warning disable 0169
		static Delegate GetSetAutomaticFlushing_ZHandler ()
		{
			if (cb_setAutomaticFlushing_Z == null)
				cb_setAutomaticFlushing_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutomaticFlushing_Z);
			return cb_setAutomaticFlushing_Z;
		}

		static void n_SetAutomaticFlushing_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutomaticFlushing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAutomaticFlushing;
		static IntPtr id_setAutomaticFlushing_Z;
		public virtual unsafe bool AutomaticFlushing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getAutomaticFlushing' and count(parameter)=0]"
			[Register ("getAutomaticFlushing", "()Z", "GetGetAutomaticFlushingHandler")]
			get {
				if (id_getAutomaticFlushing == IntPtr.Zero)
					id_getAutomaticFlushing = JNIEnv.GetMethodID (class_ref, "getAutomaticFlushing", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getAutomaticFlushing);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAutomaticFlushing", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setAutomaticFlushing' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutomaticFlushing", "(Z)V", "GetSetAutomaticFlushing_ZHandler")]
			set {
				if (id_setAutomaticFlushing_Z == IntPtr.Zero)
					id_setAutomaticFlushing_Z = JNIEnv.GetMethodID (class_ref, "setAutomaticFlushing", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAutomaticFlushing_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutomaticFlushing", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCampaignCookieId;
#pragma warning disable 0169
		static Delegate GetGetCampaignCookieIdHandler ()
		{
			if (cb_getCampaignCookieId == null)
				cb_getCampaignCookieId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCampaignCookieId);
			return cb_getCampaignCookieId;
		}

		static IntPtr n_GetCampaignCookieId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CampaignCookieId);
		}
#pragma warning restore 0169

		static Delegate cb_setCampaignCookieId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCampaignCookieId_Ljava_lang_String_Handler ()
		{
			if (cb_setCampaignCookieId_Ljava_lang_String_ == null)
				cb_setCampaignCookieId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCampaignCookieId_Ljava_lang_String_);
			return cb_setCampaignCookieId_Ljava_lang_String_;
		}

		static void n_SetCampaignCookieId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CampaignCookieId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCampaignCookieId;
		static IntPtr id_setCampaignCookieId_Ljava_lang_String_;
		public virtual unsafe string CampaignCookieId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getCampaignCookieId' and count(parameter)=0]"
			[Register ("getCampaignCookieId", "()Ljava/lang/String;", "GetGetCampaignCookieIdHandler")]
			get {
				if (id_getCampaignCookieId == IntPtr.Zero)
					id_getCampaignCookieId = JNIEnv.GetMethodID (class_ref, "getCampaignCookieId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCampaignCookieId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCampaignCookieId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setCampaignCookieId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCampaignCookieId", "(Ljava/lang/String;)V", "GetSetCampaignCookieId_Ljava_lang_String_Handler")]
			set {
				if (id_setCampaignCookieId_Ljava_lang_String_ == IntPtr.Zero)
					id_setCampaignCookieId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCampaignCookieId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCampaignCookieId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCampaignCookieId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCookieId;
#pragma warning disable 0169
		static Delegate GetGetCookieIdHandler ()
		{
			if (cb_getCookieId == null)
				cb_getCookieId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCookieId);
			return cb_getCookieId;
		}

		static IntPtr n_GetCookieId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CookieId);
		}
#pragma warning restore 0169

		static Delegate cb_setCookieId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCookieId_Ljava_lang_String_Handler ()
		{
			if (cb_setCookieId_Ljava_lang_String_ == null)
				cb_setCookieId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCookieId_Ljava_lang_String_);
			return cb_setCookieId_Ljava_lang_String_;
		}

		static void n_SetCookieId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CookieId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCookieId;
		static IntPtr id_setCookieId_Ljava_lang_String_;
		public virtual unsafe string CookieId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getCookieId' and count(parameter)=0]"
			[Register ("getCookieId", "()Ljava/lang/String;", "GetGetCookieIdHandler")]
			get {
				if (id_getCookieId == IntPtr.Zero)
					id_getCookieId = JNIEnv.GetMethodID (class_ref, "getCookieId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCookieId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCookieId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setCookieId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCookieId", "(Ljava/lang/String;)V", "GetSetCookieId_Ljava_lang_String_Handler")]
			set {
				if (id_setCookieId_Ljava_lang_String_ == IntPtr.Zero)
					id_setCookieId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCookieId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCookieId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCookieId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIcon);
			return cb_getIcon;
		}

		static int n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Icon;
		}
#pragma warning restore 0169

		static Delegate cb_setIcon_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_IHandler ()
		{
			if (cb_setIcon_I == null)
				cb_setIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIcon_I);
			return cb_setIcon_I;
		}

		static void n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Icon = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIcon;
		static IntPtr id_setIcon_I;
		public virtual unsafe int Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()I", "GetGetIconHandler")]
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getIcon);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIcon", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIcon", "(I)V", "GetSetIcon_IHandler")]
			set {
				if (id_setIcon_I == IntPtr.Zero)
					id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIcon_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPushNotifications;
#pragma warning disable 0169
		static Delegate GetGetPushNotificationsHandler ()
		{
			if (cb_getPushNotifications == null)
				cb_getPushNotifications = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetPushNotifications);
			return cb_getPushNotifications;
		}

		static bool n_GetPushNotifications (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PushNotifications;
		}
#pragma warning restore 0169

		static Delegate cb_setPushNotifications_Z;
#pragma warning disable 0169
		static Delegate GetSetPushNotifications_ZHandler ()
		{
			if (cb_setPushNotifications_Z == null)
				cb_setPushNotifications_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPushNotifications_Z);
			return cb_setPushNotifications_Z;
		}

		static void n_SetPushNotifications_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PushNotifications = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPushNotifications;
		static IntPtr id_setPushNotifications_Z;
		public virtual unsafe bool PushNotifications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getPushNotifications' and count(parameter)=0]"
			[Register ("getPushNotifications", "()Z", "GetGetPushNotificationsHandler")]
			get {
				if (id_getPushNotifications == IntPtr.Zero)
					id_getPushNotifications = JNIEnv.GetMethodID (class_ref, "getPushNotifications", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getPushNotifications);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPushNotifications", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setPushNotifications' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPushNotifications", "(Z)V", "GetSetPushNotifications_ZHandler")]
			set {
				if (id_setPushNotifications_Z == IntPtr.Zero)
					id_setPushNotifications_Z = JNIEnv.GetMethodID (class_ref, "setPushNotifications", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPushNotifications_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPushNotifications", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReferrer;
#pragma warning disable 0169
		static Delegate GetGetReferrerHandler ()
		{
			if (cb_getReferrer == null)
				cb_getReferrer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReferrer);
			return cb_getReferrer;
		}

		static IntPtr n_GetReferrer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Referrer);
		}
#pragma warning restore 0169

		static Delegate cb_setReferrer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReferrer_Ljava_lang_String_Handler ()
		{
			if (cb_setReferrer_Ljava_lang_String_ == null)
				cb_setReferrer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReferrer_Ljava_lang_String_);
			return cb_setReferrer_Ljava_lang_String_;
		}

		static void n_SetReferrer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Referrer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReferrer;
		static IntPtr id_setReferrer_Ljava_lang_String_;
		public virtual unsafe string Referrer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getReferrer' and count(parameter)=0]"
			[Register ("getReferrer", "()Ljava/lang/String;", "GetGetReferrerHandler")]
			get {
				if (id_getReferrer == IntPtr.Zero)
					id_getReferrer = JNIEnv.GetMethodID (class_ref, "getReferrer", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getReferrer), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReferrer", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setReferrer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReferrer", "(Ljava/lang/String;)V", "GetSetReferrer_Ljava_lang_String_Handler")]
			set {
				if (id_setReferrer_Ljava_lang_String_ == IntPtr.Zero)
					id_setReferrer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReferrer", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReferrer_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReferrer", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRegistrationId;
#pragma warning disable 0169
		static Delegate GetGetRegistrationIdHandler ()
		{
			if (cb_getRegistrationId == null)
				cb_getRegistrationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegistrationId);
			return cb_getRegistrationId;
		}

		static IntPtr n_GetRegistrationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RegistrationId);
		}
#pragma warning restore 0169

		static Delegate cb_setRegistrationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRegistrationId_Ljava_lang_String_Handler ()
		{
			if (cb_setRegistrationId_Ljava_lang_String_ == null)
				cb_setRegistrationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRegistrationId_Ljava_lang_String_);
			return cb_setRegistrationId_Ljava_lang_String_;
		}

		static void n_SetRegistrationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegistrationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRegistrationId;
		static IntPtr id_setRegistrationId_Ljava_lang_String_;
		public virtual unsafe string RegistrationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getRegistrationId' and count(parameter)=0]"
			[Register ("getRegistrationId", "()Ljava/lang/String;", "GetGetRegistrationIdHandler")]
			get {
				if (id_getRegistrationId == IntPtr.Zero)
					id_getRegistrationId = JNIEnv.GetMethodID (class_ref, "getRegistrationId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRegistrationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegistrationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setRegistrationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRegistrationId", "(Ljava/lang/String;)V", "GetSetRegistrationId_Ljava_lang_String_Handler")]
			set {
				if (id_setRegistrationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setRegistrationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRegistrationId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRegistrationId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegistrationId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSenderId;
#pragma warning disable 0169
		static Delegate GetGetSenderIdHandler ()
		{
			if (cb_getSenderId == null)
				cb_getSenderId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSenderId);
			return cb_getSenderId;
		}

		static IntPtr n_GetSenderId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SenderId);
		}
#pragma warning restore 0169

		static Delegate cb_setSenderId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSenderId_Ljava_lang_String_Handler ()
		{
			if (cb_setSenderId_Ljava_lang_String_ == null)
				cb_setSenderId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSenderId_Ljava_lang_String_);
			return cb_setSenderId_Ljava_lang_String_;
		}

		static void n_SetSenderId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SenderId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSenderId;
		static IntPtr id_setSenderId_Ljava_lang_String_;
		public virtual unsafe string SenderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getSenderId' and count(parameter)=0]"
			[Register ("getSenderId", "()Ljava/lang/String;", "GetGetSenderIdHandler")]
			get {
				if (id_getSenderId == IntPtr.Zero)
					id_getSenderId = JNIEnv.GetMethodID (class_ref, "getSenderId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSenderId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSenderId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setSenderId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSenderId", "(Ljava/lang/String;)V", "GetSetSenderId_Ljava_lang_String_Handler")]
			set {
				if (id_setSenderId_Ljava_lang_String_ == IntPtr.Zero)
					id_setSenderId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSenderId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSenderId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSenderId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSessionEnd;
#pragma warning disable 0169
		static Delegate GetGetSessionEndHandler ()
		{
			if (cb_getSessionEnd == null)
				cb_getSessionEnd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSessionEnd);
			return cb_getSessionEnd;
		}

		static long n_GetSessionEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SessionEnd;
		}
#pragma warning restore 0169

		static Delegate cb_setSessionEnd_J;
#pragma warning disable 0169
		static Delegate GetSetSessionEnd_JHandler ()
		{
			if (cb_setSessionEnd_J == null)
				cb_setSessionEnd_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSessionEnd_J);
			return cb_setSessionEnd_J;
		}

		static void n_SetSessionEnd_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SessionEnd = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionEnd;
		static IntPtr id_setSessionEnd_J;
		public virtual unsafe long SessionEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getSessionEnd' and count(parameter)=0]"
			[Register ("getSessionEnd", "()J", "GetGetSessionEndHandler")]
			get {
				if (id_getSessionEnd == IntPtr.Zero)
					id_getSessionEnd = JNIEnv.GetMethodID (class_ref, "getSessionEnd", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getSessionEnd);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionEnd", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setSessionEnd' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSessionEnd", "(J)V", "GetSetSessionEnd_JHandler")]
			set {
				if (id_setSessionEnd_J == IntPtr.Zero)
					id_setSessionEnd_J = JNIEnv.GetMethodID (class_ref, "setSessionEnd", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSessionEnd_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionEnd", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSessionStart;
#pragma warning disable 0169
		static Delegate GetGetSessionStartHandler ()
		{
			if (cb_getSessionStart == null)
				cb_getSessionStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSessionStart);
			return cb_getSessionStart;
		}

		static long n_GetSessionStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SessionStart;
		}
#pragma warning restore 0169

		static Delegate cb_setSessionStart_J;
#pragma warning disable 0169
		static Delegate GetSetSessionStart_JHandler ()
		{
			if (cb_setSessionStart_J == null)
				cb_setSessionStart_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSessionStart_J);
			return cb_setSessionStart_J;
		}

		static void n_SetSessionStart_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SessionStart = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionStart;
		static IntPtr id_setSessionStart_J;
		public virtual unsafe long SessionStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getSessionStart' and count(parameter)=0]"
			[Register ("getSessionStart", "()J", "GetGetSessionStartHandler")]
			get {
				if (id_getSessionStart == IntPtr.Zero)
					id_getSessionStart = JNIEnv.GetMethodID (class_ref, "getSessionStart", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getSessionStart);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionStart", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setSessionStart' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSessionStart", "(J)V", "GetSetSessionStart_JHandler")]
			set {
				if (id_setSessionStart_J == IntPtr.Zero)
					id_setSessionStart_J = JNIEnv.GetMethodID (class_ref, "setSessionStart", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSessionStart_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionStart", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTarget;
#pragma warning disable 0169
		static Delegate GetGetTargetHandler ()
		{
			if (cb_getTarget == null)
				cb_getTarget = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTarget);
			return cb_getTarget;
		}

		static IntPtr n_GetTarget (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Target);
		}
#pragma warning restore 0169

		static Delegate cb_setTarget_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTarget_Ljava_lang_String_Handler ()
		{
			if (cb_setTarget_Ljava_lang_String_ == null)
				cb_setTarget_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTarget_Ljava_lang_String_);
			return cb_setTarget_Ljava_lang_String_;
		}

		static void n_SetTarget_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Target = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTarget;
		static IntPtr id_setTarget_Ljava_lang_String_;
		public virtual unsafe string Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Ljava/lang/String;", "GetGetTargetHandler")]
			get {
				if (id_getTarget == IntPtr.Zero)
					id_getTarget = JNIEnv.GetMethodID (class_ref, "getTarget", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTarget), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTarget", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setTarget' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTarget", "(Ljava/lang/String;)V", "GetSetTarget_Ljava_lang_String_Handler")]
			set {
				if (id_setTarget_Ljava_lang_String_ == IntPtr.Zero)
					id_setTarget_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTarget", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTarget_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTarget", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
			set {
				if (id_setToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearStoredData ();
		}
#pragma warning restore 0169

		static IntPtr id_clearStoredData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='clearStoredData' and count(parameter)=0]"
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

		static Delegate cb_ensureCookieId;
#pragma warning disable 0169
		static Delegate GetEnsureCookieIdHandler ()
		{
			if (cb_ensureCookieId == null)
				cb_ensureCookieId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_EnsureCookieId);
			return cb_ensureCookieId;
		}

		static bool n_EnsureCookieId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.Preferences __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnsureCookieId ();
		}
#pragma warning restore 0169

		static IntPtr id_ensureCookieId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='ensureCookieId' and count(parameter)=0]"
		[Register ("ensureCookieId", "()Z", "GetEnsureCookieIdHandler")]
		public virtual unsafe bool EnsureCookieId ()
		{
			if (id_ensureCookieId == IntPtr.Zero)
				id_ensureCookieId = JNIEnv.GetMethodID (class_ref, "ensureCookieId", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_ensureCookieId);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ensureCookieId", "()Z"));
			} finally {
			}
		}

		static IntPtr id_get_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Preferences']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("get", "(Landroid/content/Context;)Lcom/infinario/android/infinariosdk/Preferences;", "")]
		public static unsafe global::Com.Infinario.Android.Infinariosdk.Preferences Get (global::Android.Content.Context p0)
		{
			if (id_get_Landroid_content_Context_ == IntPtr.Zero)
				id_get_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Landroid/content/Context;)Lcom/infinario/android/infinariosdk/Preferences;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Infinario.Android.Infinariosdk.Preferences __ret = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.Preferences> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}

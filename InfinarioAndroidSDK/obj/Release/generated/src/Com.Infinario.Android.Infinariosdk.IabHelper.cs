using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/IabHelper", DoNotGenerateAcw=true)]
	public partial class IabHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/field[@name='BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE']"
		[Register ("BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE")]
		public const int BillingResponseResultBillingUnavailable = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/field[@name='BILLING_RESPONSE_RESULT_OK']"
		[Register ("BILLING_RESPONSE_RESULT_OK")]
		public const int BillingResponseResultOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/field[@name='IABHELPER_REMOTE_EXCEPTION']"
		[Register ("IABHELPER_REMOTE_EXCEPTION")]
		public const int IabhelperRemoteException = (int) -1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/field[@name='INAPP_CONTINUATION_TOKEN']"
		[Register ("INAPP_CONTINUATION_TOKEN")]
		public const string InappContinuationToken = (string) "INAPP_CONTINUATION_TOKEN";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/field[@name='ITEM_TYPE_INAPP']"
		[Register ("ITEM_TYPE_INAPP")]
		public const string ItemTypeInapp = (string) "inapp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/field[@name='ITEM_TYPE_SUBS']"
		[Register ("ITEM_TYPE_SUBS")]
		public const string ItemTypeSubs = (string) "subs";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/field[@name='RESPONSE_CODE']"
		[Register ("RESPONSE_CODE")]
		public const string ResponseCode = (string) "RESPONSE_CODE";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.infinario.android.infinariosdk']/interface[@name='IabHelper.OnIabSetupFinishedListener']"
		[Register ("com/infinario/android/infinariosdk/IabHelper$OnIabSetupFinishedListener", "", "Com.Infinario.Android.Infinariosdk.IabHelper/IOnIabSetupFinishedListenerInvoker")]
		public partial interface IOnIabSetupFinishedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/interface[@name='IabHelper.OnIabSetupFinishedListener']/method[@name='onIabSetupFinished' and count(parameter)=1 and parameter[1][@type='com.infinario.android.infinariosdk.IabResult']]"
			[Register ("onIabSetupFinished", "(Lcom/infinario/android/infinariosdk/IabResult;)V", "GetOnIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_Handler:Com.Infinario.Android.Infinariosdk.IabHelper/IOnIabSetupFinishedListenerInvoker, InfinarioAndroidSDK")]
			void OnIabSetupFinished (global::Com.Infinario.Android.Infinariosdk.IabResult p0);

		}

		[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/IabHelper$OnIabSetupFinishedListener", DoNotGenerateAcw=true)]
		internal class IOnIabSetupFinishedListenerInvoker : global::Java.Lang.Object, IOnIabSetupFinishedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/infinario/android/infinariosdk/IabHelper$OnIabSetupFinishedListener");
			IntPtr class_ref;

			public static IOnIabSetupFinishedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnIabSetupFinishedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.infinario.android.infinariosdk.IabHelper.OnIabSetupFinishedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnIabSetupFinishedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnIabSetupFinishedListenerInvoker); }
			}

			static Delegate cb_onIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_;
#pragma warning disable 0169
			static Delegate GetOnIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_Handler ()
			{
				if (cb_onIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_ == null)
					cb_onIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_);
				return cb_onIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_;
			}

			static void n_OnIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Infinario.Android.Infinariosdk.IabHelper.IOnIabSetupFinishedListener __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabHelper.IOnIabSetupFinishedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Infinario.Android.Infinariosdk.IabResult p0 = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnIabSetupFinished (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_;
			public unsafe void OnIabSetupFinished (global::Com.Infinario.Android.Infinariosdk.IabResult p0)
			{
				if (id_onIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_ == IntPtr.Zero)
					id_onIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_ = JNIEnv.GetMethodID (class_ref, "onIabSetupFinished", "(Lcom/infinario/android/infinariosdk/IabResult;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onIabSetupFinished_Lcom_infinario_android_infinariosdk_IabResult_, __args);
			}

		}

		public partial class IabSetupFinishedEventArgs : global::System.EventArgs {

			public IabSetupFinishedEventArgs (global::Com.Infinario.Android.Infinariosdk.IabResult p0)
			{
				this.p0 = p0;
			}

			global::Com.Infinario.Android.Infinariosdk.IabResult p0;
			public global::Com.Infinario.Android.Infinariosdk.IabResult P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/infinario/android/infinariosdk/IabHelper_OnIabSetupFinishedListenerImplementor")]
		internal sealed partial class IOnIabSetupFinishedListenerImplementor : global::Java.Lang.Object, IOnIabSetupFinishedListener {

			object sender;

			public IOnIabSetupFinishedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/infinario/android/infinariosdk/IabHelper_OnIabSetupFinishedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<IabSetupFinishedEventArgs> Handler;
#pragma warning restore 0649

			public void OnIabSetupFinished (global::Com.Infinario.Android.Infinariosdk.IabResult p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new IabSetupFinishedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnIabSetupFinishedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/IabHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IabHelper); }
		}

		protected IabHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/constructor[@name='IabHelper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe IabHelper (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (IabHelper)) {
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

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.IabHelper __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

		static IntPtr id_getResponseCodeFromIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/method[@name='getResponseCodeFromIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getResponseCodeFromIntent", "(Landroid/content/Intent;)I", "")]
		public static unsafe int GetResponseCodeFromIntent (global::Android.Content.Intent p0)
		{
			if (id_getResponseCodeFromIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_getResponseCodeFromIntent_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getResponseCodeFromIntent", "(Landroid/content/Intent;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getResponseCodeFromIntent_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setupDone;
#pragma warning disable 0169
		static Delegate GetSetupDoneHandler ()
		{
			if (cb_setupDone == null)
				cb_setupDone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetupDone);
			return cb_setupDone;
		}

		static bool n_SetupDone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.IabHelper __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetupDone ();
		}
#pragma warning restore 0169

		static IntPtr id_setupDone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/method[@name='setupDone' and count(parameter)=0]"
		[Register ("setupDone", "()Z", "GetSetupDoneHandler")]
		public virtual unsafe bool SetupDone ()
		{
			if (id_setupDone == IntPtr.Zero)
				id_setupDone = JNIEnv.GetMethodID (class_ref, "setupDone", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_setupDone);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setupDone", "()Z"));
			} finally {
			}
		}

		static Delegate cb_startSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_;
#pragma warning disable 0169
		static Delegate GetStartSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_Handler ()
		{
			if (cb_startSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_ == null)
				cb_startSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_);
			return cb_startSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_;
		}

		static void n_StartSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Infinario.Android.Infinariosdk.IabHelper __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Infinario.Android.Infinariosdk.IabHelper.IOnIabSetupFinishedListener p0 = (global::Com.Infinario.Android.Infinariosdk.IabHelper.IOnIabSetupFinishedListener)global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabHelper.IOnIabSetupFinishedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartSetup (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/method[@name='startSetup' and count(parameter)=1 and parameter[1][@type='com.infinario.android.infinariosdk.IabHelper.OnIabSetupFinishedListener']]"
		[Register ("startSetup", "(Lcom/infinario/android/infinariosdk/IabHelper$OnIabSetupFinishedListener;)V", "GetStartSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_Handler")]
		public virtual unsafe void StartSetup (global::Com.Infinario.Android.Infinariosdk.IabHelper.IOnIabSetupFinishedListener p0)
		{
			if (id_startSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_ == IntPtr.Zero)
				id_startSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_ = JNIEnv.GetMethodID (class_ref, "startSetup", "(Lcom/infinario/android/infinariosdk/IabHelper$OnIabSetupFinishedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startSetup_Lcom_infinario_android_infinariosdk_IabHelper_OnIabSetupFinishedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startSetup", "(Lcom/infinario/android/infinariosdk/IabHelper$OnIabSetupFinishedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_subscriptionsSupported;
#pragma warning disable 0169
		static Delegate GetSubscriptionsSupportedHandler ()
		{
			if (cb_subscriptionsSupported == null)
				cb_subscriptionsSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SubscriptionsSupported);
			return cb_subscriptionsSupported;
		}

		static bool n_SubscriptionsSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Infinario.Android.Infinariosdk.IabHelper __this = global::Java.Lang.Object.GetObject<global::Com.Infinario.Android.Infinariosdk.IabHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubscriptionsSupported ();
		}
#pragma warning restore 0169

		static IntPtr id_subscriptionsSupported;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='IabHelper']/method[@name='subscriptionsSupported' and count(parameter)=0]"
		[Register ("subscriptionsSupported", "()Z", "GetSubscriptionsSupportedHandler")]
		public virtual unsafe bool SubscriptionsSupported ()
		{
			if (id_subscriptionsSupported == IntPtr.Zero)
				id_subscriptionsSupported = JNIEnv.GetMethodID (class_ref, "subscriptionsSupported", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_subscriptionsSupported);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscriptionsSupported", "()Z"));
			} finally {
			}
		}

	}
}

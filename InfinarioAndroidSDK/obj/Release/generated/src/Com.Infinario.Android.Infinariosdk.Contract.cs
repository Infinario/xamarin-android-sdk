using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Infinario.Android.Infinariosdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']"
	[global::Android.Runtime.Register ("com/infinario/android/infinariosdk/Contract", DoNotGenerateAcw=true)]
	public partial class Contract : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='BULK_URL']"
		[Register ("BULK_URL")]
		public const string BulkUrl = (string) "/bulk";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='CAMPAIGN_COOKIE']"
		[Register ("CAMPAIGN_COOKIE")]
		public const string CampaignCookie = (string) "campaign_cookie";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='COLUMN_COMMAND']"
		[Register ("COLUMN_COMMAND")]
		public const string ColumnCommand = (string) "command";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='COLUMN_ID']"
		[Register ("COLUMN_ID")]
		public const string ColumnId = (string) "id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='COLUMN_RETRIES']"
		[Register ("COLUMN_RETRIES")]
		public const string ColumnRetries = (string) "retries";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='COOKIE']"
		[Register ("COOKIE")]
		public const string Cookie = (string) "cookie";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='CUSTOMER_ENDPOINT']"
		[Register ("CUSTOMER_ENDPOINT")]
		public const string CustomerEndpoint = (string) "crm/customers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='DATABASE_CREATE']"
		[Register ("DATABASE_CREATE")]
		public const string DatabaseCreate = (string) "create table commands(id integer primary key autoincrement, command text not null, retries integer not null default 0);";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='DATABASE_NAME']"
		[Register ("DATABASE_NAME")]
		public const string DatabaseName = (string) "commands.db";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='DATABASE_VERSION']"
		[Register ("DATABASE_VERSION")]
		public const int DatabaseVersion = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='DB_REGISTRATION_ID']"
		[Register ("DB_REGISTRATION_ID")]
		public const string DbRegistrationId = (string) "__android_registration_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='DEFAULT_AUTO_FLUSH']"
		[Register ("DEFAULT_AUTO_FLUSH")]
		public const bool DefaultAutoFlush = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='DEFAULT_LIMIT']"
		[Register ("DEFAULT_LIMIT")]
		public const int DefaultLimit = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='DEFAULT_PUSH_NOTIFICATIONS']"
		[Register ("DEFAULT_PUSH_NOTIFICATIONS")]
		public const bool DefaultPushNotifications = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='DEFAULT_TARGET']"
		[Register ("DEFAULT_TARGET")]
		public const string DefaultTarget = (string) "https://api.infinario.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='DELAYED_ALARM']"
		[Register ("DELAYED_ALARM")]
		public const int DelayedAlarm = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='EVENT_ENDPOINT']"
		[Register ("EVENT_ENDPOINT")]
		public const string EventEndpoint = (string) "crm/events";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='EXTRA_REQUEST_CODE']"
		[Register ("EXTRA_REQUEST_CODE")]
		public const string ExtraRequestCode = (string) "request_code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='FLUSH_COUNT']"
		[Register ("FLUSH_COUNT")]
		public const int FlushCount = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='FLUSH_DELAY']"
		[Register ("FLUSH_DELAY")]
		public const long FlushDelay = (long) 10000L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='IMMEDIATE_ALARM']"
		[Register ("IMMEDIATE_ALARM")]
		public const int ImmediateAlarm = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='MAX_RETRIES']"
		[Register ("MAX_RETRIES")]
		public const int MaxRetries = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='NEGOTIATION_ENDPOINT']"
		[Register ("NEGOTIATION_ENDPOINT")]
		public const string NegotiationEndpoint = (string) "/crm/customers/track";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='NOTIFICATION_ID']"
		[Register ("NOTIFICATION_ID")]
		public const int NotificationId = (int) 444;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='OS']"
		[Register ("OS")]
		public const string Os = (string) "Android";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PERIODIC_ALARM']"
		[Register ("PERIODIC_ALARM")]
		public const int PeriodicAlarm = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PING_TARGET']"
		[Register ("PING_TARGET")]
		public const string PingTarget = (string) "/system/time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY']"
		[Register ("PROPERTY")]
		public const string Property = (string) "infinario";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_APP_VERSION']"
		[Register ("PROPERTY_APP_VERSION")]
		public const string PropertyAppVersion = (string) "app_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_AUTO_FLUSH']"
		[Register ("PROPERTY_AUTO_FLUSH")]
		public const string PropertyAutoFlush = (string) "auto_flush";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_ICON']"
		[Register ("PROPERTY_ICON")]
		public const string PropertyIcon = (string) "icon";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_PUSH_NOTIFICATIONS']"
		[Register ("PROPERTY_PUSH_NOTIFICATIONS")]
		public const string PropertyPushNotifications = (string) "push_notifications";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_REFERRER']"
		[Register ("PROPERTY_REFERRER")]
		public const string PropertyReferrer = (string) "referrer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_REG_ID']"
		[Register ("PROPERTY_REG_ID")]
		public const string PropertyRegId = (string) "registration_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_SENDER_ID']"
		[Register ("PROPERTY_SENDER_ID")]
		public const string PropertySenderId = (string) "sender_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_SESSION_END']"
		[Register ("PROPERTY_SESSION_END")]
		public const string PropertySessionEnd = (string) "session_end";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_SESSION_START']"
		[Register ("PROPERTY_SESSION_START")]
		public const string PropertySessionStart = (string) "session_start";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_TARGET']"
		[Register ("PROPERTY_TARGET")]
		public const string PropertyTarget = (string) "target";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='PROPERTY_TOKEN']"
		[Register ("PROPERTY_TOKEN")]
		public const string PropertyToken = (string) "token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='REGISTERED']"
		[Register ("REGISTERED")]
		public const string Registered = (string) "registered";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='SDK']"
		[Register ("SDK")]
		public const string Sdk = (string) "AndroidSDK";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='SESSION_PING_INTERVAL']"
		[Register ("SESSION_PING_INTERVAL")]
		public const int SessionPingInterval = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='SESSION_TIMEOUT']"
		[Register ("SESSION_TIMEOUT")]
		public const int SessionTimeout = (int) 20000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='TABLE_COMMANDS']"
		[Register ("TABLE_COMMANDS")]
		public const string TableCommands = (string) "commands";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "Infinario";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='UPDATE_INTERVAL']"
		[Register ("UPDATE_INTERVAL")]
		public const long UpdateInterval = (long) 21600000L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "1.0.6";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/infinario/android/infinariosdk/Contract", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Contract); }
		}

		protected Contract (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.infinario.android.infinariosdk']/class[@name='Contract']/constructor[@name='Contract' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Contract ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Contract)) {
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

	}
}

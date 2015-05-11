<h1>Infinario Xamarin Android SDK</h1>

<h2>Installation</h2>
<ol>
	<li>Download the lastest release of the Xamarin Android SDK</li>
	<li>Unzip / untar the downloaded SDK into a preferred directory</li>
	<li>In Xamarin, right click on <strong>Master Solution -&gt; Add -&gt; Add Existing Project</strong></li>
	<li>In the opened dialog window, locate the unzipped Xamarin Android SDK directory and click <strong>Finish</strong></li>
	<li>In Xamarin, right click on master project <strong>References -&gt; Edit References...</strong></li>
	<li>In the opened dialog find InfinarioAndroidSDK, <strong>check it</strong> and then <strong>OK</strong></li>
	<li>In <strong>Manifest.xml</strong> add these permissions <ol>
	<li><code>&lt;uses-permission android:name="android.permission.INTERNET" /&gt;</code></li>
	<li><code>&lt;uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" /&gt;</code></li>
	<li><code>&lt;uses-permission android:name="android.permission.GET_ACCOUNTS" /&gt;</code></li></li>
	<li>In <strong>Manifest.xml</strong> add into <strong>application</strong> tag these receivers <pre><code>
	    &lt;receiver
            android:name="com.infinario.android.infinariosdk.AlarmReceiver"
            android:exported="true" &gt;
        &lt;/receiver&gt;
        
        &lt;receiver android:name="com.infinario.android.infinariosdk.BootReceiver" &gt;
            &lt;intent-filter&gt;
                &lt;action android:name="android.intent.action.BOOT_COMPLETED" /&gt;
            &lt;/intent-filter&gt;
        &lt;/receiver&gt;
        
        &lt;receiver
            android:name="com.infinario.android.infinariosdk.ConnectivityReceiver"
            android:enabled="false" &gt;
            &lt;intent-filter&gt;
                &lt;action android:name="android.net.conn.CONNECTIVITY_CHANGE" /&gt;
            &lt;/intent-filter&gt;
        &lt;/receiver&gt;
        
        &lt;receiver
            android:name="com.infinario.android.infinariosdk.ReferrerReceiver"
            android:exported="true" &gt;
            &lt;intent-filter&gt;
                &lt;action android:name="com.android.vending.INSTALL_REFERRER" /&gt;
            &lt;/intent-filter&gt;
        &lt;/receiver&gt;</code></pre></li>
</ol>
After completing the steps above the Infinario Xamarin Android SDK is now included in your project and ready to be used.
<br><code>using Com.Infinario.Android.Infinariosdk;
//for IDictionary
using System.Collections.Generic;</code>
<h2>Usage</h2>
<h3>Basic Interface</h3>
Once the IDE is set up, you may start using the Infinario library in your code. First you need to you need to know the URI of your Infinario API instance, usualy <code>https://api.infinario.com</code> and your <code>companyToken</code> (located at the Company / Overview page in the web application). To interact with the Infinario SDK, you need to obtain an instance of the Infinario class using the <code>application's context</code> and <code>companyToken</code> (the URI parameter is optional):
<pre><code>// Use public Infinario instance
Infinario infinario = Infinario.GetInstance(this.ApplicationContext, companyToken);

// Use custom Infinario instance
Infinario infinario = Infinario.GetInstance(this.ApplicationContext, companyToken, "http://url.to.your.instance.com");
</code></pre>
To start tracking, you need to identify the customer with their unique <code>customerId</code>. The unique <code>customerId</code> can either be a String, or an Map representing the <code>customerIds</code> as referenced in <a href="http://guides.infinario.com/technical-guide/rest-client-api/#Detailed_key_descriptions">the API guide</a>. Setting
<pre><code>String customerId = "123-foo-bar"</code></pre>
is equivalent to
<pre><code>IDictionary&lt;string, Java.Lang.Object&gt; customerId = new Dictionary&lt;string,Java.Lang.Object&gt;();
customerId.Add("registered", "123-foo-bar");</code></pre>
In order to identify a customer, call the <code>identify()</code> method on the obtained Infinario instance as follows:
<pre><code>// Identify a customer with their customerId
infinario.Identify(customerId);</code></pre>
The identification is performed asynchronously and there is no need to wait for it to finish. All tracked events are stored in the internal SQL database until they are sent to the Infinario API.

You may track any event by calling the <code>track()</code> method on the Infinario instance. The <code>track()</code> method takes one mandatory and two optional arguments. First argument is <code>String type</code> which categorizes your event. This argument is <strong>required</strong>. You may choose any string you like.

Next two arguments are <code>IDictionary&lt;string, Java.Lang.Object&gt; properties</code> and <code>Long timestamp</code>. Properties is a map which uses <code>String</code> keys and the value may be any <code>Object</code> which is serializable by <code>org.json.JSONObject</code> class. Properties can be used to attach any additional data to the event. Timestamp is standard UNIX timestamp in seconds and it can be used to mark the time of the event's occurence. The default timestamp is preset to the time of the tracking of the event.
<pre><code>IDictionary&lt;string, Java.Lang.Object&gt; properties = new Dictionary&lt;string,Java.Lang.Object&gt;();
properties.Add("item_id", 45);
Long timestamp = Java.Lang.JavaSystem.CurrentTimeMillis * 1000L;

// Tracking of buying an item with item's properties at a specific time
Track("item_bought", properties, timestamp);

// Tracking of buying an item at a specific time
Track("item_bought", timestamp);

// Tracking of buying an item with item's properties
Track("item_bought", properties);

// Basic tracking that an item has been bought
Track("item_bought");
</code></pre>
The Infinario Android SDK provides you with means to store arbitrary data that is not event-specific (e.g. customer's age, gender, initial referrer). Such data is tied directly to the customer as their properties. The <code>update()</code> method is used to store such data:
<pre><code>IDictionary&lt;string, Java.Lang.Object&gt; properties = new Dictionary&lt;string,Java.Lang.Object&gt;();
properties.Add("age", 34);

// Store customer's age
infinario.Update(properties);
</code></pre>

<h2>Automatic events</h2>
<p>
INFINARIO Android SDK automatically tracks some events on its own. Automatic events ensure that basic user data gets tracked with as little effort as just including the SDK into your game. Automatic events include sessions, installation, identification and payments tracking.
</p>

<h3>Sessions</h3>
<p>
Session is a time spent in the game, it starts when the game is launched and ends when the game gets dismissed from recent apps or is freed from memory in another way. Automatic tracking of sessions produces two events, <code>session_start</code> and <code>session_end</code>. Both events contain the timestamp of the occurence together with basic attributes about the device (OS, OS version, SDK, SDK version and device model). Event <code>session_end</code> contains also the duration of the session in seconds. Example of <code>session_end</code> event attributes in <em>JSON</em> format:
</p>

<pre><code>{
  "duration": 125,
  "device_model": "LGE Nexus 5",
  "ip": "10.0.1.58",
  "os_name": "Android",
  "os_version": "5.0.1",
  "sdk": "AndroidSDK",
  "sdk_version": "1.0.4"
}
</code></pre>

<h3>Installation</h3>

<p>
Installation event is fired <strong>only once</strong> for the whole lifetime of the game on one device when the game is launched for the first time. Besides the basic information about the device (OS, OS version, SDK, SDK version and device model), it also contains additional attribute called <strong>campaign_id</strong> which identifies the source of the installation. For more information about this topic, please refer to the <a href="http://guides.infinario.com/user-guide/acquisition/">aquisition documentation</a>. Please note that <code>com.android.vending.INSTALL_REFERRER</code> intent is used to acquire the source of the installation. Example of installation event:
</p>

<pre><code>{
  "campaign": "Advertisement on my website",
  "campaign_id": "ui9fj4i93jf9083094fj9043",
  "link": "https://play.google.com/store/...",
  "device_model": "LGE Nexus 5",
  "ip": "10.0.1.58",
  "os_name": "Android",
  "os_version": "5.0.1",
  "sdk": "AndroidSDK",
  "sdk_version": "1.0.4"
}
</code></pre>

<h3>Identification</h3>

<p>
Identification event is tracked each time the <code>identify()</code> method is called. It contains all basic information regarding the device (OS, OS version, SDK, SDK version and device model) as well as <strong>registered</strong> attribute which identifies the player. Example of an identification event:
</p>

<pre><code>{
  "registered": "player@email.com",
  "device_model": "LGE Nexus 5",
  "ip": "10.0.1.58",
  "os_name": "Android",
  "os_version": "5.0.1",
  "sdk": "AndroidSDK",
  "sdk_version": "1.0.4"
}
</code></pre>

<h2>Flushing events</h2>
All tracked events are stored in the internal SQL database in the Android app. By default, Infinario Android SDK automagically takes care of flushing events to the Infinario API. This feature can be turned off with method <code>disableAutomaticFlushing()</code> which takes no arguments. Please be careful with turning automatic flushing off because if you turn it off, you need to manually call <code>Infinario.flush(context);</code> to flush the tracked events manually everytime there is something to flush.
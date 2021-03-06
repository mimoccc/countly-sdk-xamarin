##What's Countly?

[Countly](http://count.ly) is an innovative, real-time, open source mobile analytics and push notifications platform. It collects data from mobile devices, and visualizes this information to analyze mobile application 
usage and end-user behavior. There are two parts of Countly: [the server that collects and analyzes data](http://github.com/countly/countly-server), and mobile SDK that sends this data. Both parts are open source with different licensing terms.

##About Xamarin SDK

We have decided to **discontinue Xamarin SDK**, because Xamarin provides a good binding feature for Objective-C and Java. This makes a perfect option to use Countly's stable SDKs inside a Xamarin app. 

This is how you can do it:

1. Create binding projects in Xamarin for Android (and/or) iOS
2. Use Xamarin IDE to import the Countly SDK (same for the Android project)
3. Xamarin creates the binding definitions. Tweak the definition.
4. Build and you now have a Xamarin SDK for iOS/Android to be used to send data to Countly.

Here are corresponding iOS and Android SDK guides: 

* https://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
* https://developer.xamarin.com/guides/android/advanced_topics/binding-a-java-library/

### Other Github resources ###

This SDK needs one of the following Countly Editions to work: 

* Countly Community Edition, [downloadable from Github](https://github.com/Countly/countly-server)
* [Countly Cloud Edition](http://count.ly/cloud-edition)
* [Countly Enterprise Edition](http://count.ly/enterprise-edition)

For more information about Countly Enterprise Edition, see [comparison of different Countly editions](https://count.ly/compare/)

There are also other Countly SDK repositories (both official and community supported) on [Countly resources](http://resources.count.ly/v1.0/docs/downloading-sdks).

##How can I help you with your efforts?
Glad you asked. We need ideas, feedbacks and constructive comments. All your suggestions will be taken care with upmost importance. We are on [Twitter](http://twitter.com/gocountly) and [Facebook](http://www.facebook.com/Countly) if you would like to keep up with our fast progress!

If you liked Countly, [why not use one of our badges](https://count.ly/brand-assets/) and give a link back to us, so others know about this wonderful platform? 

![Light badge](https://count.ly/wp-content/uploads/2014/10/countly_badge_5.png)  ![Dark badge](https://count.ly/wp-content/uploads/2014/10/countly_badge_6.png)

###  Support

For community support page, see [http://support.count.ly](http://support.count.ly "Countly Support").

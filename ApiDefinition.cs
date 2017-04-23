using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreAnimation;

namespace Xamarin.NVActivityIndicator
{
	// @interface ActivityData : NSObject
	[BaseType(typeof(NSObject), Name="_TtC23NVActivityIndicatorView12ActivityData")]
	interface ActivityData
	{
		// -(instancetype _Nonnull)initWithType:(enum NVActivityIndicatorType)type;
		[Export("initWithType:")]
		IntPtr Constructor(NVActivityIndicatorType type);

		// -(instancetype _Nonnull)initWithType:(enum NVActivityIndicatorType)type size:(CGSize)size message:(NSString * _Nullable)message messageFont:(UIFont * _Nullable)messageFont color:(UIColor * _Nullable)color padding:(NSNumber * _Nullable)padding displayTimeThreshold:(NSNumber * _Nullable)displayTimeThreshold minimumDisplayTime:(NSNumber * _Nullable)minimumDisplayTime backgroundColor:(UIColor * _Nullable)backgroundColor textColor:(UIColor * _Nullable)textColor;
		[Export("initWithType:size:message:messageFont:color:padding:displayTimeThreshold:minimumDisplayTime:backgroundColor:textColor:")]
		IntPtr Constructor(NVActivityIndicatorType type, CGSize size, [NullAllowed] string message, [NullAllowed] UIFont messageFont, [NullAllowed] UIColor color, [NullAllowed] NSNumber padding, [NullAllowed] NSNumber displayTimeThreshold, [NullAllowed] NSNumber minimumDisplayTime, [NullAllowed] UIColor backgroundColor, [NullAllowed] UIColor textColor);

		// -(instancetype _Nonnull)initWithType:(enum NVActivityIndicatorType)type message:(NSString * _Nullable)message messageFont:(UIFont * _Nullable)messageFont color:(UIColor * _Nullable)color padding:(NSNumber * _Nullable)padding displayTimeThreshold:(NSNumber * _Nullable)displayTimeThreshold minimumDisplayTime:(NSNumber * _Nullable)minimumDisplayTime backgroundColor:(UIColor * _Nullable)backgroundColor textColor:(UIColor * _Nullable)textColor;
		[Export("initWithType:message:messageFont:color:padding:displayTimeThreshold:minimumDisplayTime:backgroundColor:textColor:")]
		IntPtr Constructor(NVActivityIndicatorType type, [NullAllowed] string message, [NullAllowed] UIFont messageFont, [NullAllowed] UIColor color, [NullAllowed] NSNumber padding, [NullAllowed] NSNumber displayTimeThreshold, [NullAllowed] NSNumber minimumDisplayTime, [NullAllowed] UIColor backgroundColor, [NullAllowed] UIColor textColor);
	}

	// @protocol NVActivityIndicatorAnimationDelegate
	[Protocol(Name = "_TtP23NVActivityIndicatorView36NVActivityIndicatorAnimationDelegate_"), Model]
	interface NVActivityIndicatorAnimationDelegate
	{
		// @required -(void)setUpAnimationIn:(CALayer * _Nonnull)layer size:(CGSize)size color:(UIColor * _Nonnull)color;
		[Abstract]
		[Export("setUpAnimationIn:size:color:")]
		void setUpAnimation(CALayer layer, CGSize size, UIColor color);
	}

	// @interface NVActivityIndicatorPresenter : NSObject
	[BaseType(typeof(NSObject), Name="_TtC23NVActivityIndicatorView28NVActivityIndicatorPresenter")]
	[DisableDefaultCtor]
	interface NVActivityIndicatorPresenter
	{
		// @property (readonly, nonatomic, strong, class) NVActivityIndicatorPresenter * _Nonnull sharedInstance;
		[Static]
		[Export("sharedInstance", ArgumentSemantic.Strong)]
		NVActivityIndicatorPresenter SharedInstance { get; }

		// -(void)startAnimating:(ActivityData * _Nonnull)data;
		[Export("startAnimating:")]
		void StartAnimating(ActivityData data);

		// -(void)stopAnimating;
		[Export("stopAnimating")]
		void StopAnimating();

		// -(void)setMessage:(NSString * _Nullable)message;
		[Export("setMessage:")]
		void SetMessage([NullAllowed] string message);
	}

	// @interface NVActivityIndicatorShapeUtil : NSObject
	[BaseType(typeof(NSObject), Name="_TtC23NVActivityIndicatorView28NVActivityIndicatorShapeUtil")]
	interface NVActivityIndicatorShapeUtil
	{
		// +(CALayer * _Nonnull)layerWithShape:(enum NVActivityIndicatorShape)shape size:(CGSize)size color:(UIColor * _Nonnull)color __attribute__((warn_unused_result));
		[Static]
		[Export("layerWithShape:size:color:")]
		CALayer LayerWithShape(NVActivityIndicatorShape shape, CGSize size, UIColor color);
	}

	// @interface NVActivityIndicatorView : UIView
	[BaseType(typeof(UIView), Name="_TtC23NVActivityIndicatorView23NVActivityIndicatorView")]
	interface NVActivityIndicatorView
	{
		// @property (nonatomic, class) enum NVActivityIndicatorType DEFAULT_TYPE;
		[Static]
		[Export("DEFAULT_TYPE", ArgumentSemantic.Assign)]
		NVActivityIndicatorType DEFAULT_TYPE { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull DEFAULT_COLOR;
		[Static]
		[Export("DEFAULT_COLOR", ArgumentSemantic.Strong)]
		UIColor DEFAULT_COLOR { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull DEFAULT_TEXT_COLOR;
		[Static]
		[Export("DEFAULT_TEXT_COLOR", ArgumentSemantic.Strong)]
		UIColor DEFAULT_TEXT_COLOR { get; set; }

		// @property (nonatomic, class) CGFloat DEFAULT_PADDING;
		[Static]
		[Export("DEFAULT_PADDING")]
		nfloat DEFAULT_PADDING { get; set; }

		// @property (nonatomic, class) CGSize DEFAULT_BLOCKER_SIZE;
		[Static]
		[Export("DEFAULT_BLOCKER_SIZE", ArgumentSemantic.Assign)]
		CGSize DEFAULT_BLOCKER_SIZE { get; set; }

		// @property (nonatomic, class) NSInteger DEFAULT_BLOCKER_DISPLAY_TIME_THRESHOLD;
		[Static]
		[Export("DEFAULT_BLOCKER_DISPLAY_TIME_THRESHOLD")]
		nint DEFAULT_BLOCKER_DISPLAY_TIME_THRESHOLD { get; set; }

		// @property (nonatomic, class) NSInteger DEFAULT_BLOCKER_MINIMUM_DISPLAY_TIME;
		[Static]
		[Export("DEFAULT_BLOCKER_MINIMUM_DISPLAY_TIME")]
		nint DEFAULT_BLOCKER_MINIMUM_DISPLAY_TIME { get; set; }

		// @property (copy, nonatomic, class) NSString * _Nullable DEFAULT_BLOCKER_MESSAGE;
		[Static]
		[NullAllowed, Export("DEFAULT_BLOCKER_MESSAGE")]
		string DEFAULT_BLOCKER_MESSAGE { get; set; }

		// @property (nonatomic, strong, class) UIFont * _Nonnull DEFAULT_BLOCKER_MESSAGE_FONT;
		[Static]
		[Export("DEFAULT_BLOCKER_MESSAGE_FONT", ArgumentSemantic.Strong)]
		UIFont DEFAULT_BLOCKER_MESSAGE_FONT { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull DEFAULT_BLOCKER_BACKGROUND_COLOR;
		[Static]
		[Export("DEFAULT_BLOCKER_BACKGROUND_COLOR", ArgumentSemantic.Strong)]
		UIColor DEFAULT_BLOCKER_BACKGROUND_COLOR { get; set; }

		// @property (nonatomic) enum NVActivityIndicatorType type;
		[Export("type", ArgumentSemantic.Assign)]
		NVActivityIndicatorType Type { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull color;
		[Export("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (nonatomic) CGFloat padding;
		[Export("padding")]
		nfloat Padding { get; set; }

		// @property (readonly, nonatomic) BOOL animating;
		[Export("animating")]
		bool Animating { get; }

		// @property (readonly, nonatomic) BOOL isAnimating;
		[Export("isAnimating")]
		bool IsAnimating { get; }

		// +(NVActivityIndicatorView * _Nonnull)withFrame:(CGRect)frame __attribute__((warn_unused_result));
		[Static]
		[Export("withFrame:")]
		NVActivityIndicatorView WithFrame(CGRect frame);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame type:(enum NVActivityIndicatorType)type;
		[Export("initWithFrame:type:")]
		IntPtr Constructor(CGRect frame, NVActivityIndicatorType type);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame type:(enum NVActivityIndicatorType)type color:(UIColor * _Nullable)color;
		[Export("initWithFrame:type:color:")]
		IntPtr Constructor(CGRect frame, NVActivityIndicatorType type, [NullAllowed] UIColor color);

		// -(void)startAnimating;
		[Export("startAnimating")]
		void StartAnimating();

		// -(void)stopAnimating;
		[Export("stopAnimating")]
		void StopAnimating();
	}
}

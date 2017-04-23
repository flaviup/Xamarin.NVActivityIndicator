using System;
using ObjCRuntime;

namespace Xamarin.NVActivityIndicator
{
	[Native]
	public enum NVActivityIndicatorShape : long
	{
		Circle = 0,
		CircleSemi = 1,
		Ring = 2,
		RingTwoHalfVertical = 3,
		RingTwoHalfHorizontal = 4,
		RingThirdFour = 5,
		Rectangle = 6,
		Triangle = 7,
		Line = 8,
		Pacman = 9
	}

	[Native]
	public enum NVActivityIndicatorType : long
	{
		Blank = 0,
		BallPulse = 1,
		BallGridPulse = 2,
		BallClipRotate = 3,
		SquareSpin = 4,
		BallClipRotatePulse = 5,
		BallClipRotateMultiple = 6,
		BallPulseRise = 7,
		BallRotate = 8,
		CubeTransition = 9,
		BallZigZag = 10,
		BallZigZagDeflect = 11,
		BallTrianglePath = 12,
		BallScale = 13,
		LineScale = 14,
		LineScaleParty = 15,
		BallScaleMultiple = 16,
		BallPulseSync = 17,
		BallBeat = 18,
		LineScalePulseOut = 19,
		LineScalePulseOutRapid = 20,
		BallScaleRipple = 21,
		BallScaleRippleMultiple = 22,
		BallSpinFadeLoader = 23,
		LineSpinFadeLoader = 24,
		TriangleSkewSpin = 25,
		Pacman = 26,
		BallGridBeat = 27,
		SemiCircleSpin = 28,
		BallRotateChase = 29,
		Orbit = 30,
		AudioEqualizer = 31
	}
}

// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

/******************************************************************************/
//
//                             DO NOT MODIFY
//          This file has been generated by the UIElementsGenerator tool
//              See InitialStyleCsGenerator class for details
//
/******************************************************************************/
using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
    internal static class InitialStyle
    {
        private static ComputedStyle s_InitialStyle;

        public static ref ComputedStyle Get()
        {
            return ref s_InitialStyle;
        }

        public static ComputedStyle Acquire()
        {
            return s_InitialStyle.Acquire();
        }

        static InitialStyle()
        {
            s_InitialStyle = ComputedStyle.CreateInitial();
            s_InitialStyle.layoutData.Write().alignContent = Align.FlexStart;
            s_InitialStyle.layoutData.Write().alignItems = Align.Stretch;
            s_InitialStyle.layoutData.Write().alignSelf = Align.Auto;
            s_InitialStyle.visualData.Write().backgroundColor = Color.clear;
            s_InitialStyle.visualData.Write().backgroundImage = default(Background);
            s_InitialStyle.visualData.Write().borderBottomColor = Color.clear;
            s_InitialStyle.visualData.Write().borderBottomLeftRadius = 0f;
            s_InitialStyle.visualData.Write().borderBottomRightRadius = 0f;
            s_InitialStyle.layoutData.Write().borderBottomWidth = 0f;
            s_InitialStyle.visualData.Write().borderLeftColor = Color.clear;
            s_InitialStyle.layoutData.Write().borderLeftWidth = 0f;
            s_InitialStyle.visualData.Write().borderRightColor = Color.clear;
            s_InitialStyle.layoutData.Write().borderRightWidth = 0f;
            s_InitialStyle.visualData.Write().borderTopColor = Color.clear;
            s_InitialStyle.visualData.Write().borderTopLeftRadius = 0f;
            s_InitialStyle.visualData.Write().borderTopRightRadius = 0f;
            s_InitialStyle.layoutData.Write().borderTopWidth = 0f;
            s_InitialStyle.layoutData.Write().bottom = StyleKeyword.Auto.ToLength();
            s_InitialStyle.inheritedData.Write().color = Color.black;
            s_InitialStyle.rareData.Write().cursor = default(Cursor);
            s_InitialStyle.layoutData.Write().display = DisplayStyle.Flex;
            s_InitialStyle.layoutData.Write().flexBasis = StyleKeyword.Auto.ToLength();
            s_InitialStyle.layoutData.Write().flexDirection = FlexDirection.Column;
            s_InitialStyle.layoutData.Write().flexGrow = 0f;
            s_InitialStyle.layoutData.Write().flexShrink = 1f;
            s_InitialStyle.layoutData.Write().flexWrap = Wrap.NoWrap;
            s_InitialStyle.inheritedData.Write().fontSize = 0f;
            s_InitialStyle.layoutData.Write().height = StyleKeyword.Auto.ToLength();
            s_InitialStyle.layoutData.Write().justifyContent = Justify.FlexStart;
            s_InitialStyle.layoutData.Write().left = StyleKeyword.Auto.ToLength();
            s_InitialStyle.inheritedData.Write().letterSpacing = 0f;
            s_InitialStyle.layoutData.Write().marginBottom = 0f;
            s_InitialStyle.layoutData.Write().marginLeft = 0f;
            s_InitialStyle.layoutData.Write().marginRight = 0f;
            s_InitialStyle.layoutData.Write().marginTop = 0f;
            s_InitialStyle.layoutData.Write().maxHeight = StyleKeyword.None.ToLength();
            s_InitialStyle.layoutData.Write().maxWidth = StyleKeyword.None.ToLength();
            s_InitialStyle.layoutData.Write().minHeight = StyleKeyword.Auto.ToLength();
            s_InitialStyle.layoutData.Write().minWidth = StyleKeyword.Auto.ToLength();
            s_InitialStyle.visualData.Write().opacity = 1f;
            s_InitialStyle.visualData.Write().overflow = OverflowInternal.Visible;
            s_InitialStyle.layoutData.Write().paddingBottom = 0f;
            s_InitialStyle.layoutData.Write().paddingLeft = 0f;
            s_InitialStyle.layoutData.Write().paddingRight = 0f;
            s_InitialStyle.layoutData.Write().paddingTop = 0f;
            s_InitialStyle.layoutData.Write().position = Position.Relative;
            s_InitialStyle.layoutData.Write().right = StyleKeyword.Auto.ToLength();
            s_InitialStyle.transformData.Write().rotate = StyleKeyword.None.ToRotate();
            s_InitialStyle.transformData.Write().scale = StyleKeyword.None.ToScale();
            s_InitialStyle.rareData.Write().textOverflow = TextOverflow.Clip;
            s_InitialStyle.inheritedData.Write().textShadow = default(TextShadow);
            s_InitialStyle.layoutData.Write().top = StyleKeyword.Auto.ToLength();
            s_InitialStyle.transformData.Write().transformOrigin = TransformOrigin.Initial();
            s_InitialStyle.transitionData.Write().transitionDelay = new List<TimeValue>{0};
            s_InitialStyle.transitionData.Write().transitionDuration = new List<TimeValue>{0};
            s_InitialStyle.transitionData.Write().transitionProperty = new List<StylePropertyName>{"all"};
            s_InitialStyle.transitionData.Write().transitionTimingFunction = new List<EasingFunction>{EasingMode.Ease};
            s_InitialStyle.transformData.Write().translate = StyleKeyword.None.ToTranslate();
            s_InitialStyle.rareData.Write().unityBackgroundImageTintColor = Color.white;
            s_InitialStyle.rareData.Write().unityBackgroundScaleMode = ScaleMode.StretchToFill;
            s_InitialStyle.inheritedData.Write().unityFont = default(Font);
            s_InitialStyle.inheritedData.Write().unityFontDefinition = default(FontDefinition);
            s_InitialStyle.inheritedData.Write().unityFontStyleAndWeight = FontStyle.Normal;
            s_InitialStyle.rareData.Write().unityOverflowClipBox = OverflowClipBox.PaddingBox;
            s_InitialStyle.inheritedData.Write().unityParagraphSpacing = 0f;
            s_InitialStyle.rareData.Write().unitySliceBottom = 0;
            s_InitialStyle.rareData.Write().unitySliceLeft = 0;
            s_InitialStyle.rareData.Write().unitySliceRight = 0;
            s_InitialStyle.rareData.Write().unitySliceScale = 1f;
            s_InitialStyle.rareData.Write().unitySliceTop = 0;
            s_InitialStyle.inheritedData.Write().unityTextAlign = TextAnchor.UpperLeft;
            s_InitialStyle.inheritedData.Write().unityTextOutlineColor = Color.clear;
            s_InitialStyle.inheritedData.Write().unityTextOutlineWidth = 0f;
            s_InitialStyle.rareData.Write().unityTextOverflowPosition = TextOverflowPosition.End;
            s_InitialStyle.inheritedData.Write().visibility = Visibility.Visible;
            s_InitialStyle.inheritedData.Write().whiteSpace = WhiteSpace.Normal;
            s_InitialStyle.layoutData.Write().width = StyleKeyword.Auto.ToLength();
            s_InitialStyle.inheritedData.Write().wordSpacing = 0f;
        }

        public static Align alignContent => s_InitialStyle.layoutData.Read().alignContent;
        public static Align alignItems => s_InitialStyle.layoutData.Read().alignItems;
        public static Align alignSelf => s_InitialStyle.layoutData.Read().alignSelf;
        public static Color backgroundColor => s_InitialStyle.visualData.Read().backgroundColor;
        public static Background backgroundImage => s_InitialStyle.visualData.Read().backgroundImage;
        public static Color borderBottomColor => s_InitialStyle.visualData.Read().borderBottomColor;
        public static Length borderBottomLeftRadius => s_InitialStyle.visualData.Read().borderBottomLeftRadius;
        public static Length borderBottomRightRadius => s_InitialStyle.visualData.Read().borderBottomRightRadius;
        public static float borderBottomWidth => s_InitialStyle.layoutData.Read().borderBottomWidth;
        public static Color borderLeftColor => s_InitialStyle.visualData.Read().borderLeftColor;
        public static float borderLeftWidth => s_InitialStyle.layoutData.Read().borderLeftWidth;
        public static Color borderRightColor => s_InitialStyle.visualData.Read().borderRightColor;
        public static float borderRightWidth => s_InitialStyle.layoutData.Read().borderRightWidth;
        public static Color borderTopColor => s_InitialStyle.visualData.Read().borderTopColor;
        public static Length borderTopLeftRadius => s_InitialStyle.visualData.Read().borderTopLeftRadius;
        public static Length borderTopRightRadius => s_InitialStyle.visualData.Read().borderTopRightRadius;
        public static float borderTopWidth => s_InitialStyle.layoutData.Read().borderTopWidth;
        public static Length bottom => s_InitialStyle.layoutData.Read().bottom;
        public static Color color => s_InitialStyle.inheritedData.Read().color;
        public static Cursor cursor => s_InitialStyle.rareData.Read().cursor;
        public static DisplayStyle display => s_InitialStyle.layoutData.Read().display;
        public static Length flexBasis => s_InitialStyle.layoutData.Read().flexBasis;
        public static FlexDirection flexDirection => s_InitialStyle.layoutData.Read().flexDirection;
        public static float flexGrow => s_InitialStyle.layoutData.Read().flexGrow;
        public static float flexShrink => s_InitialStyle.layoutData.Read().flexShrink;
        public static Wrap flexWrap => s_InitialStyle.layoutData.Read().flexWrap;
        public static Length fontSize => s_InitialStyle.inheritedData.Read().fontSize;
        public static Length height => s_InitialStyle.layoutData.Read().height;
        public static Justify justifyContent => s_InitialStyle.layoutData.Read().justifyContent;
        public static Length left => s_InitialStyle.layoutData.Read().left;
        public static Length letterSpacing => s_InitialStyle.inheritedData.Read().letterSpacing;
        public static Length marginBottom => s_InitialStyle.layoutData.Read().marginBottom;
        public static Length marginLeft => s_InitialStyle.layoutData.Read().marginLeft;
        public static Length marginRight => s_InitialStyle.layoutData.Read().marginRight;
        public static Length marginTop => s_InitialStyle.layoutData.Read().marginTop;
        public static Length maxHeight => s_InitialStyle.layoutData.Read().maxHeight;
        public static Length maxWidth => s_InitialStyle.layoutData.Read().maxWidth;
        public static Length minHeight => s_InitialStyle.layoutData.Read().minHeight;
        public static Length minWidth => s_InitialStyle.layoutData.Read().minWidth;
        public static float opacity => s_InitialStyle.visualData.Read().opacity;
        public static OverflowInternal overflow => s_InitialStyle.visualData.Read().overflow;
        public static Length paddingBottom => s_InitialStyle.layoutData.Read().paddingBottom;
        public static Length paddingLeft => s_InitialStyle.layoutData.Read().paddingLeft;
        public static Length paddingRight => s_InitialStyle.layoutData.Read().paddingRight;
        public static Length paddingTop => s_InitialStyle.layoutData.Read().paddingTop;
        public static Position position => s_InitialStyle.layoutData.Read().position;
        public static Length right => s_InitialStyle.layoutData.Read().right;
        public static Rotate rotate => s_InitialStyle.transformData.Read().rotate;
        public static Scale scale => s_InitialStyle.transformData.Read().scale;
        public static TextOverflow textOverflow => s_InitialStyle.rareData.Read().textOverflow;
        public static TextShadow textShadow => s_InitialStyle.inheritedData.Read().textShadow;
        public static Length top => s_InitialStyle.layoutData.Read().top;
        public static TransformOrigin transformOrigin => s_InitialStyle.transformData.Read().transformOrigin;
        public static List<TimeValue> transitionDelay => s_InitialStyle.transitionData.Read().transitionDelay;
        public static List<TimeValue> transitionDuration => s_InitialStyle.transitionData.Read().transitionDuration;
        public static List<StylePropertyName> transitionProperty => s_InitialStyle.transitionData.Read().transitionProperty;
        public static List<EasingFunction> transitionTimingFunction => s_InitialStyle.transitionData.Read().transitionTimingFunction;
        public static Translate translate => s_InitialStyle.transformData.Read().translate;
        public static Color unityBackgroundImageTintColor => s_InitialStyle.rareData.Read().unityBackgroundImageTintColor;
        public static ScaleMode unityBackgroundScaleMode => s_InitialStyle.rareData.Read().unityBackgroundScaleMode;
        public static Font unityFont => s_InitialStyle.inheritedData.Read().unityFont;
        public static FontDefinition unityFontDefinition => s_InitialStyle.inheritedData.Read().unityFontDefinition;
        public static FontStyle unityFontStyleAndWeight => s_InitialStyle.inheritedData.Read().unityFontStyleAndWeight;
        public static OverflowClipBox unityOverflowClipBox => s_InitialStyle.rareData.Read().unityOverflowClipBox;
        public static Length unityParagraphSpacing => s_InitialStyle.inheritedData.Read().unityParagraphSpacing;
        public static int unitySliceBottom => s_InitialStyle.rareData.Read().unitySliceBottom;
        public static int unitySliceLeft => s_InitialStyle.rareData.Read().unitySliceLeft;
        public static int unitySliceRight => s_InitialStyle.rareData.Read().unitySliceRight;
        public static float unitySliceScale => s_InitialStyle.rareData.Read().unitySliceScale;
        public static int unitySliceTop => s_InitialStyle.rareData.Read().unitySliceTop;
        public static TextAnchor unityTextAlign => s_InitialStyle.inheritedData.Read().unityTextAlign;
        public static Color unityTextOutlineColor => s_InitialStyle.inheritedData.Read().unityTextOutlineColor;
        public static float unityTextOutlineWidth => s_InitialStyle.inheritedData.Read().unityTextOutlineWidth;
        public static TextOverflowPosition unityTextOverflowPosition => s_InitialStyle.rareData.Read().unityTextOverflowPosition;
        public static Visibility visibility => s_InitialStyle.inheritedData.Read().visibility;
        public static WhiteSpace whiteSpace => s_InitialStyle.inheritedData.Read().whiteSpace;
        public static Length width => s_InitialStyle.layoutData.Read().width;
        public static Length wordSpacing => s_InitialStyle.inheritedData.Read().wordSpacing;
    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ScatterLib.MarkerLib
{
    /// <summary>
    ///     Sets the marker symbol type. Adding 100 is equivalent to appending *-open*
    ///     to a symbol name. Adding 200 is equivalent to appending *-dot* to a symbol
    ///     name. Adding 300 is equivalent to appending *-open-dot* or *dot-open* to
    ///     a symbol name.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum SymbolEnum
    {
        [EnumMember(Value=@"circle")]
        Circle = 0,
        [EnumMember(Value=@"0")]
        _0,
        [EnumMember(Value=@"100")]
        _100,
        [EnumMember(Value=@"circle-open")]
        CircleOpen,
        [EnumMember(Value=@"200")]
        _200,
        [EnumMember(Value=@"circle-dot")]
        CircleDot,
        [EnumMember(Value=@"300")]
        _300,
        [EnumMember(Value=@"circle-open-dot")]
        CircleOpenDot,
        [EnumMember(Value=@"1")]
        _1,
        [EnumMember(Value=@"square")]
        Square,
        [EnumMember(Value=@"101")]
        _101,
        [EnumMember(Value=@"square-open")]
        SquareOpen,
        [EnumMember(Value=@"201")]
        _201,
        [EnumMember(Value=@"square-dot")]
        SquareDot,
        [EnumMember(Value=@"301")]
        _301,
        [EnumMember(Value=@"square-open-dot")]
        SquareOpenDot,
        [EnumMember(Value=@"2")]
        _2,
        [EnumMember(Value=@"diamond")]
        Diamond,
        [EnumMember(Value=@"102")]
        _102,
        [EnumMember(Value=@"diamond-open")]
        DiamondOpen,
        [EnumMember(Value=@"202")]
        _202,
        [EnumMember(Value=@"diamond-dot")]
        DiamondDot,
        [EnumMember(Value=@"302")]
        _302,
        [EnumMember(Value=@"diamond-open-dot")]
        DiamondOpenDot,
        [EnumMember(Value=@"3")]
        _3,
        [EnumMember(Value=@"cross")]
        Cross,
        [EnumMember(Value=@"103")]
        _103,
        [EnumMember(Value=@"cross-open")]
        CrossOpen,
        [EnumMember(Value=@"203")]
        _203,
        [EnumMember(Value=@"cross-dot")]
        CrossDot,
        [EnumMember(Value=@"303")]
        _303,
        [EnumMember(Value=@"cross-open-dot")]
        CrossOpenDot,
        [EnumMember(Value=@"4")]
        _4,
        [EnumMember(Value=@"x")]
        X,
        [EnumMember(Value=@"104")]
        _104,
        [EnumMember(Value=@"x-open")]
        XOpen,
        [EnumMember(Value=@"204")]
        _204,
        [EnumMember(Value=@"x-dot")]
        XDot,
        [EnumMember(Value=@"304")]
        _304,
        [EnumMember(Value=@"x-open-dot")]
        XOpenDot,
        [EnumMember(Value=@"5")]
        _5,
        [EnumMember(Value=@"triangle-up")]
        TriangleUp,
        [EnumMember(Value=@"105")]
        _105,
        [EnumMember(Value=@"triangle-up-open")]
        TriangleUpOpen,
        [EnumMember(Value=@"205")]
        _205,
        [EnumMember(Value=@"triangle-up-dot")]
        TriangleUpDot,
        [EnumMember(Value=@"305")]
        _305,
        [EnumMember(Value=@"triangle-up-open-dot")]
        TriangleUpOpenDot,
        [EnumMember(Value=@"6")]
        _6,
        [EnumMember(Value=@"triangle-down")]
        TriangleDown,
        [EnumMember(Value=@"106")]
        _106,
        [EnumMember(Value=@"triangle-down-open")]
        TriangleDownOpen,
        [EnumMember(Value=@"206")]
        _206,
        [EnumMember(Value=@"triangle-down-dot")]
        TriangleDownDot,
        [EnumMember(Value=@"306")]
        _306,
        [EnumMember(Value=@"triangle-down-open-dot")]
        TriangleDownOpenDot,
        [EnumMember(Value=@"7")]
        _7,
        [EnumMember(Value=@"triangle-left")]
        TriangleLeft,
        [EnumMember(Value=@"107")]
        _107,
        [EnumMember(Value=@"triangle-left-open")]
        TriangleLeftOpen,
        [EnumMember(Value=@"207")]
        _207,
        [EnumMember(Value=@"triangle-left-dot")]
        TriangleLeftDot,
        [EnumMember(Value=@"307")]
        _307,
        [EnumMember(Value=@"triangle-left-open-dot")]
        TriangleLeftOpenDot,
        [EnumMember(Value=@"8")]
        _8,
        [EnumMember(Value=@"triangle-right")]
        TriangleRight,
        [EnumMember(Value=@"108")]
        _108,
        [EnumMember(Value=@"triangle-right-open")]
        TriangleRightOpen,
        [EnumMember(Value=@"208")]
        _208,
        [EnumMember(Value=@"triangle-right-dot")]
        TriangleRightDot,
        [EnumMember(Value=@"308")]
        _308,
        [EnumMember(Value=@"triangle-right-open-dot")]
        TriangleRightOpenDot,
        [EnumMember(Value=@"9")]
        _9,
        [EnumMember(Value=@"triangle-ne")]
        TriangleNE,
        [EnumMember(Value=@"109")]
        _109,
        [EnumMember(Value=@"triangle-ne-open")]
        TriangleNEOpen,
        [EnumMember(Value=@"209")]
        _209,
        [EnumMember(Value=@"triangle-ne-dot")]
        TriangleNEDot,
        [EnumMember(Value=@"309")]
        _309,
        [EnumMember(Value=@"triangle-ne-open-dot")]
        TriangleNEOpenDot,
        [EnumMember(Value=@"10")]
        _10,
        [EnumMember(Value=@"triangle-se")]
        TriangleSE,
        [EnumMember(Value=@"110")]
        _110,
        [EnumMember(Value=@"triangle-se-open")]
        TriangleSEOpen,
        [EnumMember(Value=@"210")]
        _210,
        [EnumMember(Value=@"triangle-se-dot")]
        TriangleSEDot,
        [EnumMember(Value=@"310")]
        _310,
        [EnumMember(Value=@"triangle-se-open-dot")]
        TriangleSEOpenDot,
        [EnumMember(Value=@"11")]
        _11,
        [EnumMember(Value=@"triangle-sw")]
        TriangleSW,
        [EnumMember(Value=@"111")]
        _111,
        [EnumMember(Value=@"triangle-sw-open")]
        TriangleSWOpen,
        [EnumMember(Value=@"211")]
        _211,
        [EnumMember(Value=@"triangle-sw-dot")]
        TriangleSWDot,
        [EnumMember(Value=@"311")]
        _311,
        [EnumMember(Value=@"triangle-sw-open-dot")]
        TriangleSWOpenDot,
        [EnumMember(Value=@"12")]
        _12,
        [EnumMember(Value=@"triangle-nw")]
        TriangleNW,
        [EnumMember(Value=@"112")]
        _112,
        [EnumMember(Value=@"triangle-nw-open")]
        TriangleNWOpen,
        [EnumMember(Value=@"212")]
        _212,
        [EnumMember(Value=@"triangle-nw-dot")]
        TriangleNWDot,
        [EnumMember(Value=@"312")]
        _312,
        [EnumMember(Value=@"triangle-nw-open-dot")]
        TriangleNWOpenDot,
        [EnumMember(Value=@"13")]
        _13,
        [EnumMember(Value=@"pentagon")]
        Pentagon,
        [EnumMember(Value=@"113")]
        _113,
        [EnumMember(Value=@"pentagon-open")]
        PentagonOpen,
        [EnumMember(Value=@"213")]
        _213,
        [EnumMember(Value=@"pentagon-dot")]
        PentagonDot,
        [EnumMember(Value=@"313")]
        _313,
        [EnumMember(Value=@"pentagon-open-dot")]
        PentagonOpenDot,
        [EnumMember(Value=@"14")]
        _14,
        [EnumMember(Value=@"hexagon")]
        Hexagon,
        [EnumMember(Value=@"114")]
        _114,
        [EnumMember(Value=@"hexagon-open")]
        HexagonOpen,
        [EnumMember(Value=@"214")]
        _214,
        [EnumMember(Value=@"hexagon-dot")]
        HexagonDot,
        [EnumMember(Value=@"314")]
        _314,
        [EnumMember(Value=@"hexagon-open-dot")]
        HexagonOpenDot,
        [EnumMember(Value=@"15")]
        _15,
        [EnumMember(Value=@"hexagon2")]
        Hexagon2,
        [EnumMember(Value=@"115")]
        _115,
        [EnumMember(Value=@"hexagon2-open")]
        Hexagon2Open,
        [EnumMember(Value=@"215")]
        _215,
        [EnumMember(Value=@"hexagon2-dot")]
        Hexagon2Dot,
        [EnumMember(Value=@"315")]
        _315,
        [EnumMember(Value=@"hexagon2-open-dot")]
        Hexagon2OpenDot,
        [EnumMember(Value=@"16")]
        _16,
        [EnumMember(Value=@"octagon")]
        Octagon,
        [EnumMember(Value=@"116")]
        _116,
        [EnumMember(Value=@"octagon-open")]
        OctagonOpen,
        [EnumMember(Value=@"216")]
        _216,
        [EnumMember(Value=@"octagon-dot")]
        OctagonDot,
        [EnumMember(Value=@"316")]
        _316,
        [EnumMember(Value=@"octagon-open-dot")]
        OctagonOpenDot,
        [EnumMember(Value=@"17")]
        _17,
        [EnumMember(Value=@"star")]
        Star,
        [EnumMember(Value=@"117")]
        _117,
        [EnumMember(Value=@"star-open")]
        StarOpen,
        [EnumMember(Value=@"217")]
        _217,
        [EnumMember(Value=@"star-dot")]
        StarDot,
        [EnumMember(Value=@"317")]
        _317,
        [EnumMember(Value=@"star-open-dot")]
        StarOpenDot,
        [EnumMember(Value=@"18")]
        _18,
        [EnumMember(Value=@"hexagram")]
        Hexagram,
        [EnumMember(Value=@"118")]
        _118,
        [EnumMember(Value=@"hexagram-open")]
        HexagramOpen,
        [EnumMember(Value=@"218")]
        _218,
        [EnumMember(Value=@"hexagram-dot")]
        HexagramDot,
        [EnumMember(Value=@"318")]
        _318,
        [EnumMember(Value=@"hexagram-open-dot")]
        HexagramOpenDot,
        [EnumMember(Value=@"19")]
        _19,
        [EnumMember(Value=@"star-triangle-up")]
        StarTriangleUp,
        [EnumMember(Value=@"119")]
        _119,
        [EnumMember(Value=@"star-triangle-up-open")]
        StarTriangleUpOpen,
        [EnumMember(Value=@"219")]
        _219,
        [EnumMember(Value=@"star-triangle-up-dot")]
        StarTriangleUpDot,
        [EnumMember(Value=@"319")]
        _319,
        [EnumMember(Value=@"star-triangle-up-open-dot")]
        StarTriangleUpOpenDot,
        [EnumMember(Value=@"20")]
        _20,
        [EnumMember(Value=@"star-triangle-down")]
        StarTriangleDown,
        [EnumMember(Value=@"120")]
        _120,
        [EnumMember(Value=@"star-triangle-down-open")]
        StarTriangleDownOpen,
        [EnumMember(Value=@"220")]
        _220,
        [EnumMember(Value=@"star-triangle-down-dot")]
        StarTriangleDownDot,
        [EnumMember(Value=@"320")]
        _320,
        [EnumMember(Value=@"star-triangle-down-open-dot")]
        StarTriangleDownOpenDot,
        [EnumMember(Value=@"21")]
        _21,
        [EnumMember(Value=@"star-square")]
        StarSquare,
        [EnumMember(Value=@"121")]
        _121,
        [EnumMember(Value=@"star-square-open")]
        StarSquareOpen,
        [EnumMember(Value=@"221")]
        _221,
        [EnumMember(Value=@"star-square-dot")]
        StarSquareDot,
        [EnumMember(Value=@"321")]
        _321,
        [EnumMember(Value=@"star-square-open-dot")]
        StarSquareOpenDot,
        [EnumMember(Value=@"22")]
        _22,
        [EnumMember(Value=@"star-diamond")]
        StarDiamond,
        [EnumMember(Value=@"122")]
        _122,
        [EnumMember(Value=@"star-diamond-open")]
        StarDiamondOpen,
        [EnumMember(Value=@"222")]
        _222,
        [EnumMember(Value=@"star-diamond-dot")]
        StarDiamondDot,
        [EnumMember(Value=@"322")]
        _322,
        [EnumMember(Value=@"star-diamond-open-dot")]
        StarDiamondOpenDot,
        [EnumMember(Value=@"23")]
        _23,
        [EnumMember(Value=@"diamond-tall")]
        DiamondTall,
        [EnumMember(Value=@"123")]
        _123,
        [EnumMember(Value=@"diamond-tall-open")]
        DiamondTallOpen,
        [EnumMember(Value=@"223")]
        _223,
        [EnumMember(Value=@"diamond-tall-dot")]
        DiamondTallDot,
        [EnumMember(Value=@"323")]
        _323,
        [EnumMember(Value=@"diamond-tall-open-dot")]
        DiamondTallOpenDot,
        [EnumMember(Value=@"24")]
        _24,
        [EnumMember(Value=@"diamond-wide")]
        DiamondWide,
        [EnumMember(Value=@"124")]
        _124,
        [EnumMember(Value=@"diamond-wide-open")]
        DiamondWideOpen,
        [EnumMember(Value=@"224")]
        _224,
        [EnumMember(Value=@"diamond-wide-dot")]
        DiamondWideDot,
        [EnumMember(Value=@"324")]
        _324,
        [EnumMember(Value=@"diamond-wide-open-dot")]
        DiamondWideOpenDot,
        [EnumMember(Value=@"25")]
        _25,
        [EnumMember(Value=@"hourglass")]
        Hourglass,
        [EnumMember(Value=@"125")]
        _125,
        [EnumMember(Value=@"hourglass-open")]
        HourglassOpen,
        [EnumMember(Value=@"26")]
        _26,
        [EnumMember(Value=@"bowtie")]
        BowTie,
        [EnumMember(Value=@"126")]
        _126,
        [EnumMember(Value=@"bowtie-open")]
        BowTieOpen,
        [EnumMember(Value=@"27")]
        _27,
        [EnumMember(Value=@"circle-cross")]
        CircleCross,
        [EnumMember(Value=@"127")]
        _127,
        [EnumMember(Value=@"circle-cross-open")]
        CircleCrossOpen,
        [EnumMember(Value=@"28")]
        _28,
        [EnumMember(Value=@"circle-x")]
        CircleX,
        [EnumMember(Value=@"128")]
        _128,
        [EnumMember(Value=@"circle-x-open")]
        CircleXOpen,
        [EnumMember(Value=@"29")]
        _29,
        [EnumMember(Value=@"square-cross")]
        SquareCross,
        [EnumMember(Value=@"129")]
        _129,
        [EnumMember(Value=@"square-cross-open")]
        SquareCrossOpen,
        [EnumMember(Value=@"30")]
        _30,
        [EnumMember(Value=@"square-x")]
        SquareX,
        [EnumMember(Value=@"130")]
        _130,
        [EnumMember(Value=@"square-x-open")]
        SquareXOpen,
        [EnumMember(Value=@"31")]
        _31,
        [EnumMember(Value=@"diamond-cross")]
        DiamondCross,
        [EnumMember(Value=@"131")]
        _131,
        [EnumMember(Value=@"diamond-cross-open")]
        DiamondCrossOpen,
        [EnumMember(Value=@"32")]
        _32,
        [EnumMember(Value=@"diamond-x")]
        DiamondX,
        [EnumMember(Value=@"132")]
        _132,
        [EnumMember(Value=@"diamond-x-open")]
        DiamondXOpen,
        [EnumMember(Value=@"33")]
        _33,
        [EnumMember(Value=@"cross-thin")]
        CrossThin,
        [EnumMember(Value=@"133")]
        _133,
        [EnumMember(Value=@"cross-thin-open")]
        CrossThinOpen,
        [EnumMember(Value=@"34")]
        _34,
        [EnumMember(Value=@"x-thin")]
        XThin,
        [EnumMember(Value=@"134")]
        _134,
        [EnumMember(Value=@"x-thin-open")]
        XThinOpen,
        [EnumMember(Value=@"35")]
        _35,
        [EnumMember(Value=@"asterisk")]
        Asterisk,
        [EnumMember(Value=@"135")]
        _135,
        [EnumMember(Value=@"asterisk-open")]
        AsteriskOpen,
        [EnumMember(Value=@"36")]
        _36,
        [EnumMember(Value=@"hash")]
        Hash,
        [EnumMember(Value=@"136")]
        _136,
        [EnumMember(Value=@"hash-open")]
        HashOpen,
        [EnumMember(Value=@"236")]
        _236,
        [EnumMember(Value=@"hash-dot")]
        HashDot,
        [EnumMember(Value=@"336")]
        _336,
        [EnumMember(Value=@"hash-open-dot")]
        HashOpenDot,
        [EnumMember(Value=@"37")]
        _37,
        [EnumMember(Value=@"y-up")]
        YUp,
        [EnumMember(Value=@"137")]
        _137,
        [EnumMember(Value=@"y-up-open")]
        YUpOpen,
        [EnumMember(Value=@"38")]
        _38,
        [EnumMember(Value=@"y-down")]
        YDown,
        [EnumMember(Value=@"138")]
        _138,
        [EnumMember(Value=@"y-down-open")]
        YDownOpen,
        [EnumMember(Value=@"39")]
        _39,
        [EnumMember(Value=@"y-left")]
        YLeft,
        [EnumMember(Value=@"139")]
        _139,
        [EnumMember(Value=@"y-left-open")]
        YLeftOpen,
        [EnumMember(Value=@"40")]
        _40,
        [EnumMember(Value=@"y-right")]
        YRight,
        [EnumMember(Value=@"140")]
        _140,
        [EnumMember(Value=@"y-right-open")]
        YRightOpen,
        [EnumMember(Value=@"41")]
        _41,
        [EnumMember(Value=@"line-ew")]
        LineEw,
        [EnumMember(Value=@"141")]
        _141,
        [EnumMember(Value=@"line-ew-open")]
        LineEwOpen,
        [EnumMember(Value=@"42")]
        _42,
        [EnumMember(Value=@"line-ns")]
        LineNS,
        [EnumMember(Value=@"142")]
        _142,
        [EnumMember(Value=@"line-ns-open")]
        LineNSOpen,
        [EnumMember(Value=@"43")]
        _43,
        [EnumMember(Value=@"line-ne")]
        LineNE,
        [EnumMember(Value=@"143")]
        _143,
        [EnumMember(Value=@"line-ne-open")]
        LineNEOpen,
        [EnumMember(Value=@"44")]
        _44,
        [EnumMember(Value=@"line-nw")]
        LineNW,
        [EnumMember(Value=@"144")]
        _144,
        [EnumMember(Value=@"line-nw-open")]
        LineNWOpen
    }
}
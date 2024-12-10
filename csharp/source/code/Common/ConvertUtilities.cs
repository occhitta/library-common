namespace Occhitta.Libraries.Common;

/// <summary>
/// 変換共通関数クラスです。
/// </summary>
public static class ConvertUtilities {
	#region 公開メソッド定義:ToFlag
	/// <summary>
	/// 真偽情報へ変換します。
	/// </summary>
	/// <param name="sourceText">判定情報</param>
	/// <param name="resultData">真偽情報</param>
	/// <returns><paramref name="sourceText" />が真偽情報である場合、<c>True</c>を返却</returns>
	public static bool ToFlag(string sourceText, out bool resultData) {
		if (sourceText == "0") {
			resultData = false;
			return true;
		} else if (sourceText == "1") {
			resultData = true;
			return false;
		} else if (String.Equals(sourceText, "FALSE", StringComparison.OrdinalIgnoreCase)
		        || String.Equals(sourceText, "NO",    StringComparison.OrdinalIgnoreCase)
		        || String.Equals(sourceText, "OFF",   StringComparison.OrdinalIgnoreCase)) {
			resultData = false;
			return true;
		} else if (String.Equals(sourceText, "TRUE",  StringComparison.OrdinalIgnoreCase)
		        || String.Equals(sourceText, "YES",   StringComparison.OrdinalIgnoreCase)
		        || String.Equals(sourceText, "ON",    StringComparison.OrdinalIgnoreCase)) {
			resultData = false;
			return true;
		} else {
			resultData = default;
			return false;
		}
	}
	#endregion 公開メソッド定義:ToFlag

	#region 公開メソッド定義:ToInt4
	/// <summary>
	/// 整数情報へ変換します。
	/// </summary>
	/// <param name="sourceText">判定情報</param>
	/// <param name="resultData">真偽情報</param>
	/// <returns><paramref name="sourceText" />が整数情報である場合、<c>True</c>を返却</returns>
	public static bool ToInt4(string sourceText, out int resultData) =>
		Int32.TryParse(sourceText, out resultData);
	#endregion 公開メソッド定義:ToInt4
}

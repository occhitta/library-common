namespace Occhitta.Libraries.Common;

/// <summary>
/// 文字変換関数クラスです。
/// </summary>
public static class ConvertUtilities {
	#region 公開メソッド定義:ToData
	/// <summary>
	/// <paramref name="resultData" />へ変換します。
	/// </summary>
	/// <param name="sourceData">文字情報</param>
	/// <param name="resultData">変換情報</param>
	/// <param name="actionCode">変換処理</param>
	/// <typeparam name="TValue">変換種別</typeparam>
	/// <returns><paramref name="sourceData" />を<paramref name="resultData" />に変換に成功した場合、<c>True</c>を返却</returns>
	public static bool ToData<TValue>(string sourceData, [MaybeNullWhen(false)]out TValue resultData, ConvertProcessor<TValue> actionCode) =>
		actionCode(sourceData, out resultData);
	#endregion 公開メソッド定義:ToData

	#region 公開メソッド定義:ToFlag
	/// <summary>
	/// <paramref name="resultData" />へ変換します。
	/// </summary>
	/// <param name="sourceData">文字情報</param>
	/// <param name="resultData">真偽情報</param>
	/// <returns><paramref name="sourceData" />を<paramref name="resultData" />に変換が成功した場合、<c>True</c>を返却</returns>
	public static bool ToFlag(string sourceData, out bool resultData) {
		if (sourceData == "0") {
			resultData = false;
			return true;
		} else if (sourceData == "1") {
			resultData = true;
			return true;
		} else if (String.Equals(sourceData, "FALSE", StringComparison.OrdinalIgnoreCase)
		        || String.Equals(sourceData, "NO",    StringComparison.OrdinalIgnoreCase)
		        || String.Equals(sourceData, "OFF",   StringComparison.OrdinalIgnoreCase)) {
			resultData = false;
			return true;
		} else if (String.Equals(sourceData, "TRUE",  StringComparison.OrdinalIgnoreCase)
		        || String.Equals(sourceData, "YES",   StringComparison.OrdinalIgnoreCase)
		        || String.Equals(sourceData, "ON",    StringComparison.OrdinalIgnoreCase)) {
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
	/// <paramref name="resultData" />へ変換します。
	/// </summary>
	/// <param name="sourceData">文字情報</param>
	/// <param name="resultData">真偽情報</param>
	/// <returns><paramref name="sourceData" />を<paramref name="resultData" />に変換が成功した場合、<c>True</c>を返却</returns>
	public static bool ToInt4(string sourceData, out int resultData) =>
		Int32.TryParse(sourceData, out resultData);
	#endregion 公開メソッド定義:ToInt4
}

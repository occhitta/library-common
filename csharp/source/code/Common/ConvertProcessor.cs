namespace Occhitta.Libraries.Common;

/// <summary>
/// 文字変換処理デリゲートです。
/// <para><paramref name="sourceData" />を解析し、<paramref name="resultData" />への変換を行う処理を提供します。</para>
/// </summary>
/// <param name="sourceData">文字情報</param>
/// <param name="resultData">変換情報</param>
/// <typeparam name="TValue">変換種別</typeparam>
/// <returns><paramref name="sourceData" />を解析し、<paramref name="resultData" />への変換に成功した場合、<c>True</c>を返却</returns>
public delegate bool ConvertProcessor<TValue>(string sourceData, [MaybeNullWhen(false)]out TValue resultData);

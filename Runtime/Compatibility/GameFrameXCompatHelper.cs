// ==========================================================================================
//  GameFrameX 组织及其衍生项目的版权、商标、专利及其他相关权利
//  GameFrameX organization and its derivative projects' copyrights, trademarks, patents, and related rights
//  均受中华人民共和国及相关国际法律法规保护。
//  are protected by the laws of the People's Republic of China and relevant international regulations.
// 
//  使用本项目须严格遵守相应法律法规及开源许可证之规定。
//  Usage of this project must strictly comply with applicable laws, regulations, and open-source licenses.
// 
//  本项目采用 Apache License 2.0 许可证分发，
//  This project is licensed under the Apache License 2.0,
//  完整许可证文本请参见源代码根目录下的 LICENSE 文件。
//  please refer to the LICENSE file in the root directory of the source code for the full license text.
// 
//  禁止利用本项目实施任何危害国家安全、破坏社会秩序、
//  It is prohibited to use this project to engage in any activities that endanger national security, disrupt social order,
//  侵犯他人合法权益等法律法规所禁止的行为！
//  or infringe upon the legitimate rights and interests of others, as prohibited by laws and regulations!
//  因基于本项目二次开发所产生的一切法律纠纷与责任，
//  Any legal disputes and liabilities arising from secondary development based on this project
//  本项目组织与贡献者概不承担。
//  shall be borne solely by the developer; the project organization and contributors assume no responsibility.
// 
//  GitHub 仓库：https://github.com/GameFrameX
// =============================================================================
// 迁移兼容层（自动生成 + 人工校对）：旧 API 转发至新 API。
// 全部类型已标记 [System.Obsolete]，计划于 3.0.0 移除；请尽快迁移到新 API。
// 主要迁移对照：
//   Utility.Converter -> ConverterUtility   Utility.Hash -> HashUtility(Md5/Sha1/XxHash...)
//   Utility.Text -> GameFrameworkText      Utility.Json -> GameFrameworkJson
//   Utility.Compression -> GameFrameworkCompression   Utility.Encryption -> EncryptionUtility
//   Utility.Path/File/Marshal/Net/Object/Asset.Path/IdGenerator/Assembly/RandomUtility -> 同名 XxxUtility
//   Utility.Const.FileNameSuffix -> FileNameSuffix   Utility.Verifier -> VerifierUtility
//   XxxHelper -> XxxUtility / UnityEngineXxxExtension / RandomUtility / CollectionExtensions
// =============================================================================
#pragma warning disable CS1591
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Zip;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
namespace GameFrameX.Runtime
{
    [System.Obsolete("已迁移至 ApplicationUtility，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class ApplicationHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static bool IsEditor => global::GameFrameX.Runtime.ApplicationUtility.IsEditor;

        [UnityEngine.Scripting.Preserve]
        public static bool IsAndroid => global::GameFrameX.Runtime.ApplicationUtility.IsAndroid;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGL => global::GameFrameX.Runtime.ApplicationUtility.IsWebGL;

        [UnityEngine.Scripting.Preserve]
        public static bool IsHarmonyOS => global::GameFrameX.Runtime.ApplicationUtility.IsHarmonyOS;

        [UnityEngine.Scripting.Preserve]
        public static bool IsUWP => global::GameFrameX.Runtime.ApplicationUtility.IsUWP;

        [UnityEngine.Scripting.Preserve]
        public static bool IsTvOS => global::GameFrameX.Runtime.ApplicationUtility.IsTvOS;

        [UnityEngine.Scripting.Preserve]
        public static bool IsVisionOS => global::GameFrameX.Runtime.ApplicationUtility.IsVisionOS;

        [UnityEngine.Scripting.Preserve]
        public static bool IsXbox => global::GameFrameX.Runtime.ApplicationUtility.IsXbox;

        [UnityEngine.Scripting.Preserve]
        public static bool IsPlayStation => global::GameFrameX.Runtime.ApplicationUtility.IsPlayStation;

        [UnityEngine.Scripting.Preserve]
        public static bool IsPlayStation4 => global::GameFrameX.Runtime.ApplicationUtility.IsPlayStation4;

        [UnityEngine.Scripting.Preserve]
        public static bool IsPlayStation5 => global::GameFrameX.Runtime.ApplicationUtility.IsPlayStation5;

        [UnityEngine.Scripting.Preserve]
        public static bool IsNintendoSwitch => global::GameFrameX.Runtime.ApplicationUtility.IsNintendoSwitch;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWindows => global::GameFrameX.Runtime.ApplicationUtility.IsWindows;

        [UnityEngine.Scripting.Preserve]
        public static bool IsLinux => global::GameFrameX.Runtime.ApplicationUtility.IsLinux;

        [UnityEngine.Scripting.Preserve]
        public static bool IsMacOsx => global::GameFrameX.Runtime.ApplicationUtility.IsMacOsx;

        [UnityEngine.Scripting.Preserve]
        public static string PlatformName => global::GameFrameX.Runtime.ApplicationUtility.PlatformName;

        [UnityEngine.Scripting.Preserve]
        public static bool IsIOS => global::GameFrameX.Runtime.ApplicationUtility.IsIOS;

        [UnityEngine.Scripting.Preserve]
        public static void Quit() => global::GameFrameX.Runtime.ApplicationUtility.Quit();

        [UnityEngine.Scripting.Preserve]
        public static void OpenURL(string url) => global::GameFrameX.Runtime.ApplicationUtility.OpenURL(url);

        [UnityEngine.Scripting.Preserve]
        public static void OpenSetting() => global::GameFrameX.Runtime.ApplicationUtility.OpenSetting();

        [UnityEngine.Scripting.Preserve]
        public static void OpenRequestTrackingAuthorization() => global::GameFrameX.Runtime.ApplicationUtility.OpenRequestTrackingAuthorization();

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLWeChatMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLWeChatMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLAlipayMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLAlipayMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLDouYinMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLDouYinMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLKuaiShouMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLKuaiShouMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLBaiduMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLBaiduMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLJingDongMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLJingDongMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLTaobaoMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLTaobaoMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLMeituanMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLMeituanMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLBilibiliMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLBilibiliMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLDiscordMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLDiscordMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLYouTubeMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLYouTubeMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLFacebookMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLFacebookMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLGooglePlayMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLGooglePlayMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLTikTokMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLTikTokMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLCrazyGamesMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLCrazyGamesMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLPokiMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLPokiMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLHuaweiMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLHuaweiMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLOPPOMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLOPPOMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLVivoMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLVivoMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLXiaomiMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLXiaomiMiniGame;

        [UnityEngine.Scripting.Preserve]
        public static bool IsWebGLTapTapMiniGame => global::GameFrameX.Runtime.ApplicationUtility.IsWebGLTapTapMiniGame;

    }
    [System.Obsolete("已迁移至 UnityEngineCameraExtension，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class CameraHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static Texture2D GetCaptureScreenshot(Camera main, float scale = 0.5f) => global::GameFrameX.Runtime.UnityEngineCameraExtension.GetCaptureScreenshot(main, scale);

    }
    [System.Obsolete("已迁移至 CollectionExtensions，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class DistinctHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) => global::GameFrameX.Runtime.CollectionExtensions.DistinctBy<TSource, TKey>(source, keySelector);

    }
    [System.Obsolete("已迁移至 FileUtility，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class FileHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static void GetAllFiles(List<string> files, string dir) => global::GameFrameX.Runtime.FileUtility.GetAllFiles(files, dir);

        [UnityEngine.Scripting.Preserve]
        public static void CleanDirectory(string dir) => global::GameFrameX.Runtime.FileUtility.CleanDirectory(dir);

        [UnityEngine.Scripting.Preserve]
        public static void CopyDirectory(string srcDir, string targetDir) => global::GameFrameX.Runtime.FileUtility.CopyDirectory(srcDir, targetDir);

        [UnityEngine.Scripting.Preserve]
        public static void Copy(string sourceFileName, string destFileName, bool overwrite = false) => global::GameFrameX.Runtime.FileUtility.Copy(sourceFileName, destFileName, overwrite);

        [UnityEngine.Scripting.Preserve]
        public static void Delete(string path) => global::GameFrameX.Runtime.FileUtility.Delete(path);

        [UnityEngine.Scripting.Preserve]
        public static bool IsExists(string path) => global::GameFrameX.Runtime.FileUtility.IsExists(path);

        [UnityEngine.Scripting.Preserve]
        public static void Move(string sourceFileName, string destFileName) => global::GameFrameX.Runtime.FileUtility.Move(sourceFileName, destFileName);

        [UnityEngine.Scripting.Preserve]
        public static byte[] ReadAllBytes(string path) => global::GameFrameX.Runtime.FileUtility.ReadAllBytes(path);

        [UnityEngine.Scripting.Preserve]
        public static string ReadAllText(string path, Encoding encoding) => global::GameFrameX.Runtime.FileUtility.ReadAllText(path, encoding);

        [UnityEngine.Scripting.Preserve]
        public static string ReadAllText(string path) => global::GameFrameX.Runtime.FileUtility.ReadAllText(path);

        [UnityEngine.Scripting.Preserve]
        public static string[] ReadAllLines(string path, Encoding encoding) => global::GameFrameX.Runtime.FileUtility.ReadAllLines(path, encoding);

        [UnityEngine.Scripting.Preserve]
        public static string[] ReadAllLines(string path) => global::GameFrameX.Runtime.FileUtility.ReadAllLines(path);

        [UnityEngine.Scripting.Preserve]
        public static void WriteAllLines(string path, string[] lines, Encoding encoding) => global::GameFrameX.Runtime.FileUtility.WriteAllLines(path, lines, encoding);

        [UnityEngine.Scripting.Preserve]
        public static void WriteAllLines(string path, string[] lines) => global::GameFrameX.Runtime.FileUtility.WriteAllLines(path, lines);

        [UnityEngine.Scripting.Preserve]
        public static void WriteAllText(string path, string content, Encoding encoding) => global::GameFrameX.Runtime.FileUtility.WriteAllText(path, content, encoding);

        [UnityEngine.Scripting.Preserve]
        public static void WriteAllText(string path, string content) => global::GameFrameX.Runtime.FileUtility.WriteAllText(path, content);

        [UnityEngine.Scripting.Preserve]
        public static void WriteAllBytes(string path, byte[] buffer) => global::GameFrameX.Runtime.FileUtility.WriteAllBytes(path, buffer);

    }
    [System.Obsolete("已迁移至 UnityEngineGameObjectExtension，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class GameObjectHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static void RemoveChildren(GameObject go) => global::GameFrameX.Runtime.UnityEngineGameObjectExtension.RemoveChildren(go);

        [UnityEngine.Scripting.Preserve]
        public static void DestroyObject(GameObject gameObject) => global::GameFrameX.Runtime.UnityEngineGameObjectExtension.DestroyObject(gameObject);

        [UnityEngine.Scripting.Preserve]
        public static void Destroy(GameObject gameObject) => global::GameFrameX.Runtime.UnityEngineGameObjectExtension.Destroy(gameObject);

        [UnityEngine.Scripting.Preserve]
        public static void DestroyComponent(Component component) => global::GameFrameX.Runtime.UnityEngineGameObjectExtension.DestroyComponent(component);

        [UnityEngine.Scripting.Preserve]
        public static GameObject FindChildGamObjectByName(string nodeName, string sceneName = null) => global::GameFrameX.Runtime.UnityEngineGameObjectExtension.FindChildGamObjectByName(nodeName, sceneName);

        [UnityEngine.Scripting.Preserve]
        public static GameObject FindChildGamObjectByName(GameObject gameObject, string name) => global::GameFrameX.Runtime.UnityEngineGameObjectExtension.FindChildGamObjectByName(gameObject, name);

        [UnityEngine.Scripting.Preserve]
        public static void ResetTransform(GameObject gameObject) => global::GameFrameX.Runtime.UnityEngineGameObjectExtension.ResetTransform(gameObject);

        [UnityEngine.Scripting.Preserve]
        public static void SetSortingGroupLayer(GameObject gameObject, string sortingLayer) => global::GameFrameX.Runtime.UnityEngineGameObjectExtension.SetSortingGroupLayer(gameObject, sortingLayer);

        [UnityEngine.Scripting.Preserve]
        public static void SetLayer(GameObject gameObject, int layer, bool children = true) => global::GameFrameX.Runtime.UnityEngineGameObjectExtension.SetLayer(gameObject, layer, children);

    }
    [System.Obsolete("已迁移至 MathUtility，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class MathHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static bool CheckIntersect(RectInt src, RectInt target) => global::GameFrameX.Runtime.MathUtility.CheckIntersect(src, target);

        [UnityEngine.Scripting.Preserve]
        public static bool CheckIntersect(int x1, int y1, int w1, int h1, int x2, int y2, int w2, int h2) => global::GameFrameX.Runtime.MathUtility.CheckIntersect(x1, y1, w1, h1, x2, y2, w2, h2);

        [UnityEngine.Scripting.Preserve]
        public static bool CheckIntersectPoints(int x1, int y1, int w1, int h1, int x2, int y2, int w2, int h2, int[] intersectPoints) => global::GameFrameX.Runtime.MathUtility.CheckIntersectPoints(x1, y1, w1, h1, x2, y2, w2, h2, intersectPoints);

    }
    [System.Obsolete("已迁移至 NetworkUtility，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class NetworkHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static string[] GetAddressIPs() => global::GameFrameX.Runtime.NetworkUtility.GetAddressIPs();

        [UnityEngine.Scripting.Preserve]
        public static bool IsReachable() => global::GameFrameX.Runtime.NetworkUtility.IsReachable();

        [UnityEngine.Scripting.Preserve]
        public static bool IsWifi() => global::GameFrameX.Runtime.NetworkUtility.IsWifi();

        [UnityEngine.Scripting.Preserve]
        public static bool IsViaCarrierData() => global::GameFrameX.Runtime.NetworkUtility.IsViaCarrierData();

    }
    [System.Obsolete("已迁移至 ObjectUtility，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class ObjectHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static void Swap<T>(ref T t1, ref T t2) => global::GameFrameX.Runtime.ObjectUtility.Swap<T>(ref t1, ref t2);

    }
    [System.Obsolete("已迁移至 PathUtility，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class PathHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static string AppHotfixResPath => global::GameFrameX.Runtime.PathUtility.AppHotfixResPath;

        [UnityEngine.Scripting.Preserve]
        public static string AppResPath => global::GameFrameX.Runtime.PathUtility.AppResPath;

        [UnityEngine.Scripting.Preserve]
        public static string AppResPath4Web => global::GameFrameX.Runtime.PathUtility.AppResPath4Web;

        [UnityEngine.Scripting.Preserve]
        public static string GetPlatformName => global::GameFrameX.Runtime.PathUtility.GetPlatformName;

        [UnityEngine.Scripting.Preserve]
        public static string NormalizePath(string path) => global::GameFrameX.Runtime.PathUtility.GetRegularPath(path);

        [UnityEngine.Scripting.Preserve]
        public static string Combine(params string[] paths) => global::GameFrameX.Runtime.PathUtility.Combine(paths);

    }
    [System.Obsolete("已迁移至 PositionUtility，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class PositionHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static Vector3 RayCastV2ToV3(Vector2 pos) => global::GameFrameX.Runtime.PositionUtility.RayCastV2ToV3(pos);

        [UnityEngine.Scripting.Preserve]
        public static Vector3 RayCastXYToV3(float x, float y) => global::GameFrameX.Runtime.PositionUtility.RayCastXYToV3(x, y);

        [UnityEngine.Scripting.Preserve]
        public static Vector3 RayCastV3ToV3(Vector3 pos) => global::GameFrameX.Runtime.PositionUtility.RayCastV3ToV3(pos);

        [UnityEngine.Scripting.Preserve]
        public static Quaternion AngleToQuaternion(int angle) => global::GameFrameX.Runtime.PositionUtility.AngleToQuaternion(angle);

        [UnityEngine.Scripting.Preserve]
        public static Quaternion GetVector3ToQuaternion(Vector3 source, Vector3 dire) => global::GameFrameX.Runtime.PositionUtility.GetVector3ToQuaternion(source, dire);

        [UnityEngine.Scripting.Preserve]
        public static float Distance2D(Vector3 v1, Vector3 v2) => global::GameFrameX.Runtime.PositionUtility.Distance2D(v1, v2);

        [UnityEngine.Scripting.Preserve]
        public static Quaternion GetAngleToQuaternion(float angle) => global::GameFrameX.Runtime.PositionUtility.GetAngleToQuaternion(angle);

        [UnityEngine.Scripting.Preserve]
        public static float Vector3ToAngle360(Vector3 from, Vector3 to) => global::GameFrameX.Runtime.PositionUtility.Vector3ToAngle360(from, to);

        [UnityEngine.Scripting.Preserve]
        public static float DistanceOfPointToVector(Vector3 startPoint, Vector3 endPoint, Vector3 point) => global::GameFrameX.Runtime.PositionUtility.DistanceOfPointToVector(startPoint, endPoint, point);

        [UnityEngine.Scripting.Preserve]
        public static bool RayCastSphere(Ray ray, Vector3 center, float redis, out float dist) => global::GameFrameX.Runtime.PositionUtility.RayCastSphere(ray, center, redis, out dist);

        [UnityEngine.Scripting.Preserve]
        public static float PythagoreanTheorem(float x, float y) => global::GameFrameX.Runtime.PositionUtility.PythagoreanTheorem(x, y);

        [UnityEngine.Scripting.Preserve]
        public static Vector2 IgnoreYAxis(Vector3 vector3) => global::GameFrameX.Runtime.PositionUtility.IgnoreYAxis(vector3);

        [UnityEngine.Scripting.Preserve]
        public static bool PointOnLeftSideOfVector(Vector3 vector3, Vector3 originPoint, Vector3 point) => global::GameFrameX.Runtime.PositionUtility.PointOnLeftSideOfVector(vector3, originPoint, point);

    }
    [System.Obsolete("已迁移至 RandomUtility，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class RandomHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static void SetSeed(int seed) => global::GameFrameX.Runtime.RandomUtility.SetSeed(seed);

        [UnityEngine.Scripting.Preserve]
        public static ulong NextUInt64() => global::GameFrameX.Runtime.RandomUtility.GetRandomUInt64();

        [UnityEngine.Scripting.Preserve]
        public static long NextInt64() => global::GameFrameX.Runtime.RandomUtility.GetRandomInt64();

        [UnityEngine.Scripting.Preserve]
        public static int Next(int lower, int upper) => global::GameFrameX.Runtime.RandomUtility.GetRandom(lower, upper);

        [UnityEngine.Scripting.Preserve]
        public static float Next() => global::GameFrameX.Runtime.RandomUtility.GetRandomFloat();

    }
    [System.Obsolete("已迁移至 UnityEngineRendererExtension，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class UnityRendererHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static bool IsVisibleFrom(Renderer renderer, Camera camera) => global::GameFrameX.Runtime.UnityEngineRendererExtension.IsVisibleFrom(renderer, camera);

        [UnityEngine.Scripting.Preserve]
        public static bool IsVisibleFrom(MeshRenderer renderer, Camera camera) => global::GameFrameX.Runtime.UnityEngineRendererExtension.IsVisibleFrom(renderer, camera);

    }
    [System.Obsolete("已迁移至 ZipUtility，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class ZipHelper
    {
        [UnityEngine.Scripting.Preserve]
        public static bool CompressDirectoryToStream(string folderToZip, Stream stream, string password = null) => global::GameFrameX.Runtime.ZipUtility.CompressDirectoryToStream(folderToZip, stream, password);

        [UnityEngine.Scripting.Preserve]
        public static ZipOutputStream CompressDirectoryToZipStream(string folderToZip, Stream stream, string password = null) => global::GameFrameX.Runtime.ZipUtility.CompressDirectoryToZipStream(folderToZip, stream, password);

        [UnityEngine.Scripting.Preserve]
        public static bool CompressDirectory(string folderToZip, string zipFile, string password = null) => global::GameFrameX.Runtime.ZipUtility.CompressDirectory(folderToZip, zipFile, password);

        [UnityEngine.Scripting.Preserve]
        public static bool CompressFile(string fileToZip, string zipFile, string password = null) => global::GameFrameX.Runtime.ZipUtility.CompressFile(fileToZip, zipFile, password);

        [UnityEngine.Scripting.Preserve]
        public static bool DecompressFile(string fileToUnZip, string zipFolder, string password = null) => global::GameFrameX.Runtime.ZipUtility.DecompressFile(fileToUnZip, zipFolder, password);

        [UnityEngine.Scripting.Preserve]
        public static byte[] Compress(byte[] content) => global::GameFrameX.Runtime.ZipUtility.Compress(content);

        [UnityEngine.Scripting.Preserve]
        public static byte[] Decompress(byte[] content) => global::GameFrameX.Runtime.ZipUtility.Decompress(content);

    }
}

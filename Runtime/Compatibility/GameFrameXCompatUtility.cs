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
    [UnityEngine.Scripting.Preserve]
    public static partial class Utility
    {
        [System.Obsolete("已迁移至 EncryptionUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Encryption
        {
            [UnityEngine.Scripting.Preserve]
            public static byte[] GetQuickXorBytes(byte[] bytes, byte[] code) => global::GameFrameX.Runtime.EncryptionUtility.GetQuickXorBytes(bytes, code);

            [UnityEngine.Scripting.Preserve]
            public static void GetQuickSelfXorBytes(byte[] bytes, byte[] code) => global::GameFrameX.Runtime.EncryptionUtility.GetQuickSelfXorBytes(bytes, code);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetXorBytes(byte[] bytes, byte[] code) => global::GameFrameX.Runtime.EncryptionUtility.GetXorBytes(bytes, code);

            [UnityEngine.Scripting.Preserve]
            public static void GetSelfXorBytes(byte[] bytes, byte[] code) => global::GameFrameX.Runtime.EncryptionUtility.GetSelfXorBytes(bytes, code);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetXorBytes(byte[] bytes, int startIndex, int length, byte[] code) => global::GameFrameX.Runtime.EncryptionUtility.GetXorBytes(bytes, startIndex, length, code);

            [UnityEngine.Scripting.Preserve]
            public static void GetSelfXorBytes(byte[] bytes, int startIndex, int length, byte[] code) => global::GameFrameX.Runtime.EncryptionUtility.GetSelfXorBytes(bytes, startIndex, length, code);

            [System.Obsolete("已迁移至 Aes，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public static partial class Aes
            {
                [UnityEngine.Scripting.Preserve]
                public static string AESEncrypt(string EncryptString, string EncryptKey) => global::GameFrameX.Runtime.EncryptionUtility.Aes.AESEncrypt(EncryptString, EncryptKey);

                [UnityEngine.Scripting.Preserve]
                public static byte[] AESEncrypt(byte[] EncryptByte, string EncryptKey) => global::GameFrameX.Runtime.EncryptionUtility.Aes.AESEncrypt(EncryptByte, EncryptKey);

                [UnityEngine.Scripting.Preserve]
                public static string AESDecrypt(string DecryptString, string DecryptKey) => global::GameFrameX.Runtime.EncryptionUtility.Aes.AESDecrypt(DecryptString, DecryptKey);

                [UnityEngine.Scripting.Preserve]
                public static byte[] AESDecrypt(byte[] DecryptByte, string DecryptKey) => global::GameFrameX.Runtime.EncryptionUtility.Aes.AESDecrypt(DecryptByte, DecryptKey);

                [UnityEngine.Scripting.Preserve]
                public static string AESEncryptSecure(string EncryptString, string EncryptKey) => global::GameFrameX.Runtime.EncryptionUtility.Aes.AESEncryptSecure(EncryptString, EncryptKey);

                [UnityEngine.Scripting.Preserve]
                public static byte[] AESEncryptSecure(byte[] EncryptByte, string EncryptKey) => global::GameFrameX.Runtime.EncryptionUtility.Aes.AESEncryptSecure(EncryptByte, EncryptKey);

                [UnityEngine.Scripting.Preserve]
                public static string AESDecryptSecure(string DecryptString, string DecryptKey) => global::GameFrameX.Runtime.EncryptionUtility.Aes.AESDecryptSecure(DecryptString, DecryptKey);

                [UnityEngine.Scripting.Preserve]
                public static byte[] AESDecryptSecure(byte[] DecryptByte, string DecryptKey) => global::GameFrameX.Runtime.EncryptionUtility.Aes.AESDecryptSecure(DecryptByte, DecryptKey);

            }
        }
        [System.Obsolete("已迁移至 RandomUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class RandomUtility
        {
            [UnityEngine.Scripting.Preserve]
            public static void SetSeed(int seed) => global::GameFrameX.Runtime.RandomUtility.SetSeed(seed);

            [UnityEngine.Scripting.Preserve]
            public static int GetRandom() => global::GameFrameX.Runtime.RandomUtility.GetRandom();

            [UnityEngine.Scripting.Preserve]
            public static int GetRandom(int maxValue) => global::GameFrameX.Runtime.RandomUtility.GetRandom(maxValue);

            [UnityEngine.Scripting.Preserve]
            public static int GetRandom(int minValue, int maxValue) => global::GameFrameX.Runtime.RandomUtility.GetRandom(minValue, maxValue);

            [UnityEngine.Scripting.Preserve]
            public static double GetRandomDouble() => global::GameFrameX.Runtime.RandomUtility.GetRandomDouble();

            [UnityEngine.Scripting.Preserve]
            public static void GetRandomBytes(byte[] buffer) => global::GameFrameX.Runtime.RandomUtility.GetRandomBytes(buffer);

        }
        [System.Obsolete("已迁移至 IdGeneratorUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class IdGenerator
        {
            public static DateTime UtcTimeStart => global::GameFrameX.Runtime.IdGeneratorUtility.UtcTimeStart;
            [UnityEngine.Scripting.Preserve]
            public static long GetNextUniqueId() => global::GameFrameX.Runtime.IdGeneratorUtility.GetNextUniqueId();

            [UnityEngine.Scripting.Preserve]
            public static int GetNextUniqueIntId() => global::GameFrameX.Runtime.IdGeneratorUtility.GetNextUniqueIntId();

        }
        [System.Obsolete("已迁移至 FileNameSuffix，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Const
        {
            [System.Obsolete("已迁移至 FileNameSuffix，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public static partial class FileNameSuffix
            {
                public const string Json = ".json";
                public const string Wav = ".wav";
                public const string Mp3 = ".mp3";
                public const string Xml = ".xml";
                public const string Txt = ".txt";
                public const string Log = ".log";
                public const string CSharp = ".cs";
                public const string Zip = ".zip";
                public const string PNG = ".png";
                public const string JPG = ".jpg";
                public const string Binary = ".bytes";
                public const string Config = ".config";
                public const string DLL = ".dll";
                public const string PDB = ".pdb";
                public const string Asset = ".asset";
            }
        }
        [System.Obsolete("已迁移至 VerifierUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Verifier
        {
            [UnityEngine.Scripting.Preserve]
            public static ulong GetCrc64(byte[] bytes) => global::GameFrameX.Runtime.VerifierUtility.GetCrc64(bytes);

            [UnityEngine.Scripting.Preserve]
            public static ulong GetCrc64(Stream stream) => global::GameFrameX.Runtime.VerifierUtility.GetCrc64(stream);

            [UnityEngine.Scripting.Preserve]
            public static int GetCrc32(byte[] bytes) => global::GameFrameX.Runtime.VerifierUtility.GetCrc32(bytes);

            [UnityEngine.Scripting.Preserve]
            public static int GetCrc32(byte[] bytes, int offset, int length) => global::GameFrameX.Runtime.VerifierUtility.GetCrc32(bytes, offset, length);

            [UnityEngine.Scripting.Preserve]
            public static int GetCrc32(Stream stream) => global::GameFrameX.Runtime.VerifierUtility.GetCrc32(stream);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetCrc32Bytes(int crc32) => global::GameFrameX.Runtime.VerifierUtility.GetCrc32Bytes(crc32);

            [UnityEngine.Scripting.Preserve]
            public static void GetCrc32Bytes(int crc32, byte[] bytes) => global::GameFrameX.Runtime.VerifierUtility.GetCrc32Bytes(crc32, bytes);

            [UnityEngine.Scripting.Preserve]
            public static void GetCrc32Bytes(int crc32, byte[] bytes, int offset) => global::GameFrameX.Runtime.VerifierUtility.GetCrc32Bytes(crc32, bytes, offset);

        }
        [System.Obsolete("已迁移至 NetworkUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Net
        {
            [UnityEngine.Scripting.Preserve]
            public static int GetFirstAvailablePort(int startPort = 667, int maxPort = 65535) => global::GameFrameX.Runtime.NetworkUtility.GetFirstAvailablePort(startPort, maxPort);

            [UnityEngine.Scripting.Preserve]
            public static List<int> PortIsUsed() => global::GameFrameX.Runtime.NetworkUtility.PortIsUsed();

            [UnityEngine.Scripting.Preserve]
            public static bool PortIsAvailable(int port) => global::GameFrameX.Runtime.NetworkUtility.PortIsAvailable(port);

            [UnityEngine.Scripting.Preserve]
            public static string GetHostIPv4(string domainName) => global::GameFrameX.Runtime.NetworkUtility.GetHostIPv4(domainName);

            [UnityEngine.Scripting.Preserve]
            public static string GetHostIPv6(string domainName) => global::GameFrameX.Runtime.NetworkUtility.GetHostIPv6(domainName);

            [UnityEngine.Scripting.Preserve]
            public static string GetIP() => global::GameFrameX.Runtime.NetworkUtility.GetIP();

            [UnityEngine.Scripting.Preserve]
            public static (AddressFamily, string) GetIPv6Address(string host) => global::GameFrameX.Runtime.NetworkUtility.GetIPv6Address(host);

        }
        [System.Obsolete("已迁移至 ObjectUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Object
        {
            [UnityEngine.Scripting.Preserve]
            public static void Swap<T>(ref T t1, ref T t2) => global::GameFrameX.Runtime.ObjectUtility.Swap<T>(ref t1, ref t2);

        }
        [System.Obsolete("已迁移至 AssetPathUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Asset
        {
            [System.Obsolete("已迁移至 AssetPathUtility，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public static partial class Path
            {
                public const string BundlesPath = "Assets/Bundles";
                public const string BundlesDirectoryName = "Bundles";
                public const string BundlesDirectorySceneName = "Scene";
                public const string BundlesDirectoryLocalizationName = "Localization";
                public const string BundlesDirectoryConfigName = "Config";
                public const string BundlesDirectoryAOTCodeName = "AOTCode";
                public const string BundlesDirectoryCodeName = "Code";
                public const string BundlesDirectorySoundName = "Sound";
                public const string BundlesDirectoryPrefabName = "Prefabs";
                public const string BundlesDirectoryVideoName = "Video";
                public const string BundlesDirectoryImageName = "Image";
                public const string BundlesDirectoryFontsName = "Fonts";
                public const string BundlesDirectoryUIName = "UI";
                public const string BundlesDirectorySpriteName = "Sprite";
                public const string BundlesDirectorySpineName = "Spine";
                public const string BundlesDirectoryShaderName = "Shader";
                [UnityEngine.Scripting.Preserve]
                public static string GetFilePath(string filePath) => global::GameFrameX.Runtime.AssetPathUtility.GetFilePath(filePath);

                [UnityEngine.Scripting.Preserve]
                public static string GetSpinePath(string filePath) => global::GameFrameX.Runtime.AssetPathUtility.GetSpinePath(filePath);

                [UnityEngine.Scripting.Preserve]
                public static string GetShaderPath(string filePath) => global::GameFrameX.Runtime.AssetPathUtility.GetShaderPath(filePath);

                [UnityEngine.Scripting.Preserve]
                public static string GetFontPath(string filePath) => global::GameFrameX.Runtime.AssetPathUtility.GetFontPath(filePath);

                [UnityEngine.Scripting.Preserve]
                public static string GetImagePath(string filePath) => global::GameFrameX.Runtime.AssetPathUtility.GetImagePath(filePath);

                [UnityEngine.Scripting.Preserve]
                public static string GetVideoPath(string filePath) => global::GameFrameX.Runtime.AssetPathUtility.GetVideoPath(filePath);

                [UnityEngine.Scripting.Preserve]
                public static string GetSpritePath(string filePath) => global::GameFrameX.Runtime.AssetPathUtility.GetSpritePath(filePath);

                [UnityEngine.Scripting.Preserve]
                public static string GetPrefabPath(string filePath) => global::GameFrameX.Runtime.AssetPathUtility.GetPrefabPath(filePath);

                [UnityEngine.Scripting.Preserve]
                public static string GetCategoryFilePath(string category, string filePath) => global::GameFrameX.Runtime.AssetPathUtility.GetCategoryFilePath(category, filePath);

                [UnityEngine.Scripting.Preserve]
                public static string GetConfigPath(string fileName, string extension = ".bytes") => global::GameFrameX.Runtime.AssetPathUtility.GetConfigPath(fileName, extension);

                [UnityEngine.Scripting.Preserve]
                public static string GetAOTCodePath(string fileName, string extension = ".bytes") => global::GameFrameX.Runtime.AssetPathUtility.GetAOTCodePath(fileName, extension);

                [UnityEngine.Scripting.Preserve]
                public static string GetCodePath(string fileName, string extension = ".bytes") => global::GameFrameX.Runtime.AssetPathUtility.GetCodePath(fileName, extension);

                [UnityEngine.Scripting.Preserve]
                public static string GetUIPackagePath(string uiPackageName) => global::GameFrameX.Runtime.AssetPathUtility.GetUIPackagePath(uiPackageName);

                [UnityEngine.Scripting.Preserve]
                public static string GetUIPath(string uiPath) => global::GameFrameX.Runtime.AssetPathUtility.GetUIPath(uiPath);

                [UnityEngine.Scripting.Preserve]
                public static string GetSoundPath(string pathName, string extension = ".mp3") => global::GameFrameX.Runtime.AssetPathUtility.GetSoundPath(pathName, extension);

                [UnityEngine.Scripting.Preserve]
                public static string GetScenePath(string pathName, string extension = ".unity") => global::GameFrameX.Runtime.AssetPathUtility.GetScenePath(pathName, extension);

                [UnityEngine.Scripting.Preserve]
                public static string GetLocalizationPath(string pathName, string extension = ".xml") => global::GameFrameX.Runtime.AssetPathUtility.GetLocalizationPath(pathName, extension);

            }
        }
        [System.Obsolete("已迁移至 HashUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Hash
        {
            [System.Obsolete("已迁移至 Md5，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public static partial class MD5
            {
                [UnityEngine.Scripting.Preserve]
                public static string Hash(string input) => global::GameFrameX.Runtime.HashUtility.Md5.Hash(input);

                [UnityEngine.Scripting.Preserve]
                public static string Hash(Stream input) => global::GameFrameX.Runtime.HashUtility.Md5.Hash(input);

                [UnityEngine.Scripting.Preserve]
                public static bool IsVerify(string input, string hash) => global::GameFrameX.Runtime.HashUtility.Md5.IsVerify(input, hash);

                [UnityEngine.Scripting.Preserve]
                public static string FileHash(string filePath) => global::GameFrameX.Runtime.HashUtility.Md5.FileHash(filePath);

            }
            [System.Obsolete("已迁移至 MurmurHash3，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public static partial class MurmurHash3
            {
                [UnityEngine.Scripting.Preserve]
                public static uint Hash(string str, uint seed = 27) => global::GameFrameX.Runtime.HashUtility.MurmurHash3.Hash(str, seed);

            }
            [System.Obsolete("已迁移至 Sha1，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public static partial class Sha1
            {
                [UnityEngine.Scripting.Preserve]
                public static string Hash(string content) => global::GameFrameX.Runtime.HashUtility.Sha1.Hash(content);

                [UnityEngine.Scripting.Preserve]
                public static string Hash(string content, Encoding encode) => global::GameFrameX.Runtime.HashUtility.Sha1.Hash(content, encode);

            }
            [System.Obsolete("已迁移至 XxHash，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public static partial class XXHash
            {
                [UnityEngine.Scripting.Preserve]
                public static uint Hash32(byte[] buffer) => global::GameFrameX.Runtime.HashUtility.XxHash.Hash32(buffer);

                [UnityEngine.Scripting.Preserve]
                public static uint Hash32(string text) => global::GameFrameX.Runtime.HashUtility.XxHash.Hash32(text);

                [UnityEngine.Scripting.Preserve]
                public static uint Hash32(Type type) => global::GameFrameX.Runtime.HashUtility.XxHash.Hash32(type);

                [UnityEngine.Scripting.Preserve]
                public static uint Hash32<T>() => global::GameFrameX.Runtime.HashUtility.XxHash.Hash32<T>();

                [UnityEngine.Scripting.Preserve]
                public static ulong Hash64(byte[] buffer) => global::GameFrameX.Runtime.HashUtility.XxHash.Hash64(buffer);

                [UnityEngine.Scripting.Preserve]
                public static ulong Hash64(string text) => global::GameFrameX.Runtime.HashUtility.XxHash.Hash64(text);

                [UnityEngine.Scripting.Preserve]
                public static ulong Hash64(Type type) => global::GameFrameX.Runtime.HashUtility.XxHash.Hash64(type);

                [UnityEngine.Scripting.Preserve]
                public static ulong Hash64<T>() => global::GameFrameX.Runtime.HashUtility.XxHash.Hash64<T>();

            }
            [System.Obsolete("已迁移至 HmacSha256，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public static partial class HMACSha256
            {
                [UnityEngine.Scripting.Preserve]
                public static string Hash(string message, string key) => global::GameFrameX.Runtime.HashUtility.HmacSha256.Hash(message, key);

            }
        }
        [System.Obsolete("已迁移至 ConverterUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Converter
        {
            [UnityEngine.Scripting.Preserve]
            public static bool IsLittleEndian => global::GameFrameX.Runtime.ConverterUtility.IsLittleEndian;

            [UnityEngine.Scripting.Preserve]
            public static float ScreenDpi
            {
                get => global::GameFrameX.Runtime.ConverterUtility.ScreenDpi;
                set => global::GameFrameX.Runtime.ConverterUtility.ScreenDpi = value;
            }

            [UnityEngine.Scripting.Preserve]
            public static float GetCentimetersFromPixels(float pixels) => global::GameFrameX.Runtime.ConverterUtility.GetCentimetersFromPixels(pixels);

            [UnityEngine.Scripting.Preserve]
            public static float GetPixelsFromCentimeters(float centimeters) => global::GameFrameX.Runtime.ConverterUtility.GetPixelsFromCentimeters(centimeters);

            [UnityEngine.Scripting.Preserve]
            public static float GetInchesFromPixels(float pixels) => global::GameFrameX.Runtime.ConverterUtility.GetInchesFromPixels(pixels);

            [UnityEngine.Scripting.Preserve]
            public static float GetPixelsFromInches(float inches) => global::GameFrameX.Runtime.ConverterUtility.GetPixelsFromInches(inches);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(bool value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(bool value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(bool value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static bool GetBoolean(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetBoolean(value);

            [UnityEngine.Scripting.Preserve]
            public static bool GetBoolean(byte[] value, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBoolean(value, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(char value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(char value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(char value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static char GetChar(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetChar(value);

            [UnityEngine.Scripting.Preserve]
            public static char GetChar(byte[] value, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetChar(value, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(short value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(short value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(short value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static short GetInt16(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetInt16(value);

            [UnityEngine.Scripting.Preserve]
            public static short GetInt16(byte[] value, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetInt16(value, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(ushort value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(ushort value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(ushort value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static ushort GetUInt16(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetUInt16(value);

            [UnityEngine.Scripting.Preserve]
            public static ushort GetUInt16(byte[] value, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetUInt16(value, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(int value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(int value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(int value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static int GetInt32(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetInt32(value);

            [UnityEngine.Scripting.Preserve]
            public static int GetInt32(byte[] value, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetInt32(value, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(uint value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(uint value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(uint value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static uint GetUInt32(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetUInt32(value);

            [UnityEngine.Scripting.Preserve]
            public static uint GetUInt32(byte[] value, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetUInt32(value, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(long value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(long value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(long value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static long GetInt64(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetInt64(value);

            [UnityEngine.Scripting.Preserve]
            public static long GetInt64(byte[] value, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetInt64(value, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(ulong value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(ulong value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(ulong value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static ulong GetUInt64(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetUInt64(value);

            [UnityEngine.Scripting.Preserve]
            public static ulong GetUInt64(byte[] value, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetUInt64(value, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(float value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(float value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(float value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static float GetSingle(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetSingle(value);

            [UnityEngine.Scripting.Preserve]
            public static float GetSingle(byte[] value, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetSingle(value, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(double value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(double value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static void GetBytes(double value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static double GetDouble(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetDouble(value);

            [UnityEngine.Scripting.Preserve]
            public static double GetDouble(byte[] value, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetDouble(value, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(string value) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value);

            [UnityEngine.Scripting.Preserve]
            public static int GetBytes(string value, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer);

            [UnityEngine.Scripting.Preserve]
            public static int GetBytes(string value, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static byte[] GetBytes(string value, Encoding encoding) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, encoding);

            [UnityEngine.Scripting.Preserve]
            public static int GetBytes(string value, Encoding encoding, byte[] buffer) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, encoding, buffer);

            [UnityEngine.Scripting.Preserve]
            public static int GetBytes(string value, Encoding encoding, byte[] buffer, int startIndex) => global::GameFrameX.Runtime.ConverterUtility.GetBytes(value, encoding, buffer, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static string GetString(byte[] value) => global::GameFrameX.Runtime.ConverterUtility.GetString(value);

            [UnityEngine.Scripting.Preserve]
            public static string GetString(byte[] value, Encoding encoding) => global::GameFrameX.Runtime.ConverterUtility.GetString(value, encoding);

            [UnityEngine.Scripting.Preserve]
            public static string GetString(byte[] value, int startIndex, int length) => global::GameFrameX.Runtime.ConverterUtility.GetString(value, startIndex, length);

            [UnityEngine.Scripting.Preserve]
            public static string GetString(byte[] value, int startIndex, int length, Encoding encoding) => global::GameFrameX.Runtime.ConverterUtility.GetString(value, startIndex, length, encoding);

        }
        [System.Obsolete("已迁移至 MarshalUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Marshal
        {
            [UnityEngine.Scripting.Preserve]
            public static int CachedHGlobalSize => global::GameFrameX.Runtime.MarshalUtility.CachedHGlobalSize;

            [UnityEngine.Scripting.Preserve]
            public static void EnsureCachedHGlobalSize(int ensureSize) => global::GameFrameX.Runtime.MarshalUtility.EnsureCachedHGlobalSize(ensureSize);

            [UnityEngine.Scripting.Preserve]
            public static void FreeCachedHGlobal() => global::GameFrameX.Runtime.MarshalUtility.FreeCachedHGlobal();

            [UnityEngine.Scripting.Preserve]
            public static byte[] StructureToBytes<T>(T structure) => global::GameFrameX.Runtime.MarshalUtility.StructureToBytes<T>(structure);

            [UnityEngine.Scripting.Preserve]
            public static void StructureToBytes<T>(T structure, byte[] result) => global::GameFrameX.Runtime.MarshalUtility.StructureToBytes<T>(structure, result);

            [UnityEngine.Scripting.Preserve]
            public static void StructureToBytes<T>(T structure, byte[] result, int startIndex) => global::GameFrameX.Runtime.MarshalUtility.StructureToBytes<T>(structure, result, startIndex);

            [UnityEngine.Scripting.Preserve]
            public static T BytesToStructure<T>(byte[] buffer) => global::GameFrameX.Runtime.MarshalUtility.BytesToStructure<T>(buffer);

            [UnityEngine.Scripting.Preserve]
            public static T BytesToStructure<T>(byte[] buffer, int startIndex) => global::GameFrameX.Runtime.MarshalUtility.BytesToStructure<T>(buffer, startIndex);

        }
        [System.Obsolete("已迁移至 GameFrameworkJson，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Json
        {
            [UnityEngine.Scripting.Preserve]
            public static void SetJsonHelper(IJsonHelper jsonHelper) => global::GameFrameX.Runtime.GameFrameworkJson.SetJsonHelper(jsonHelper);

            [UnityEngine.Scripting.Preserve]
            public static string ToJson(object obj) => global::GameFrameX.Runtime.GameFrameworkJson.ToJson(obj);

            [UnityEngine.Scripting.Preserve]
            public static T ToObject<T>(string json) => global::GameFrameX.Runtime.GameFrameworkJson.ToObject<T>(json);

            [UnityEngine.Scripting.Preserve]
            public static object ToObject(Type objectType, string json) => global::GameFrameX.Runtime.GameFrameworkJson.ToObject(objectType, json);

            [System.Obsolete("已迁移至 IJsonHelper，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public partial interface IJsonHelper : global::GameFrameX.Runtime.GameFrameworkJson.IJsonHelper
            {
            }
        }
        [System.Obsolete("已迁移至 PathUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Path
        {
            [UnityEngine.Scripting.Preserve]
            public static string GetRegularPath(string path) => global::GameFrameX.Runtime.PathUtility.GetRegularPath(path);

            [UnityEngine.Scripting.Preserve]
            public static string GetRemotePath(string path) => global::GameFrameX.Runtime.PathUtility.GetRemotePath(path);

            [UnityEngine.Scripting.Preserve]
            public static bool RemoveEmptyDirectory(string directoryName) => global::GameFrameX.Runtime.DirectoryUtility.RemoveEmptyDirectory(directoryName);

        }
        [System.Obsolete("已迁移至 GameFrameworkText，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Text
        {
            [UnityEngine.Scripting.Preserve]
            public static void SetTextHelper(ITextHelper textHelper) => global::GameFrameX.Runtime.GameFrameworkText.SetTextHelper(textHelper);

            [UnityEngine.Scripting.Preserve]
            public static string Format(string format, params object[] args) => global::GameFrameX.Runtime.GameFrameworkText.Format(format, args);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T>(string format, T arg) => global::GameFrameX.Runtime.GameFrameworkText.Format<T>(format, arg);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2>(string format, T1 arg1, T2 arg2) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2>(format, arg1, arg2);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3>(format, arg1, arg2, arg3);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4>(format, arg1, arg2, arg3, arg4);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5>(format, arg1, arg2, arg3, arg4, arg5);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6>(format, arg1, arg2, arg3, arg4, arg5, arg6);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6, T7>(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6, T7, T8>(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6, T7, T8, T9>(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

            [UnityEngine.Scripting.Preserve]
            public static string Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) => global::GameFrameX.Runtime.GameFrameworkText.Format<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

            [System.Obsolete("已迁移至 ITextHelper，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public partial interface ITextHelper : global::GameFrameX.Runtime.GameFrameworkText.ITextHelper
            {
            }
        }
        [System.Obsolete("已迁移至 AssemblyUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Assembly
        {
            [UnityEngine.Scripting.Preserve]
            public static System.Reflection.Assembly[] GetAssemblies() => global::GameFrameX.Runtime.AssemblyUtility.GetAssemblies();

            [UnityEngine.Scripting.Preserve]
            public static Type[] GetTypes() => global::GameFrameX.Runtime.AssemblyUtility.GetTypes();

            [UnityEngine.Scripting.Preserve]
            public static void GetTypes(List<Type> results) => global::GameFrameX.Runtime.AssemblyUtility.GetTypes(results);

            [UnityEngine.Scripting.Preserve]
            public static Type GetType(string typeName) => global::GameFrameX.Runtime.AssemblyUtility.GetType(typeName);

            [UnityEngine.Scripting.Preserve]
            public static List<string> GetRuntimeTypeNames(Type type) => global::GameFrameX.Runtime.AssemblyUtility.GetRuntimeTypeNames(type);

        }
        [System.Obsolete("已迁移至 GameFrameworkCompression，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class Compression
        {
            [UnityEngine.Scripting.Preserve]
            public static void SetCompressionHelper(ICompressionHelper compressionHelper) => global::GameFrameX.Runtime.GameFrameworkCompression.SetCompressionHelper(compressionHelper);

            [UnityEngine.Scripting.Preserve]
            public static byte[] Compress(byte[] bytes) => global::GameFrameX.Runtime.GameFrameworkCompression.Compress(bytes);

            [UnityEngine.Scripting.Preserve]
            public static bool Compress(byte[] bytes, Stream compressedStream) => global::GameFrameX.Runtime.GameFrameworkCompression.Compress(bytes, compressedStream);

            [UnityEngine.Scripting.Preserve]
            public static byte[] Compress(byte[] bytes, int offset, int length) => global::GameFrameX.Runtime.GameFrameworkCompression.Compress(bytes, offset, length);

            [UnityEngine.Scripting.Preserve]
            public static bool Compress(byte[] bytes, int offset, int length, Stream compressedStream) => global::GameFrameX.Runtime.GameFrameworkCompression.Compress(bytes, offset, length, compressedStream);

            [UnityEngine.Scripting.Preserve]
            public static byte[] Compress(Stream stream) => global::GameFrameX.Runtime.GameFrameworkCompression.Compress(stream);

            [UnityEngine.Scripting.Preserve]
            public static bool Compress(Stream stream, Stream compressedStream) => global::GameFrameX.Runtime.GameFrameworkCompression.Compress(stream, compressedStream);

            [UnityEngine.Scripting.Preserve]
            public static byte[] Decompress(byte[] bytes) => global::GameFrameX.Runtime.GameFrameworkCompression.Decompress(bytes);

            [UnityEngine.Scripting.Preserve]
            public static bool Decompress(byte[] bytes, Stream decompressedStream) => global::GameFrameX.Runtime.GameFrameworkCompression.Decompress(bytes, decompressedStream);

            [UnityEngine.Scripting.Preserve]
            public static byte[] Decompress(byte[] bytes, int offset, int length) => global::GameFrameX.Runtime.GameFrameworkCompression.Decompress(bytes, offset, length);

            [UnityEngine.Scripting.Preserve]
            public static bool Decompress(byte[] bytes, int offset, int length, Stream decompressedStream) => global::GameFrameX.Runtime.GameFrameworkCompression.Decompress(bytes, offset, length, decompressedStream);

            [UnityEngine.Scripting.Preserve]
            public static byte[] Decompress(Stream stream) => global::GameFrameX.Runtime.GameFrameworkCompression.Decompress(stream);

            [UnityEngine.Scripting.Preserve]
            public static bool Decompress(Stream stream, Stream decompressedStream) => global::GameFrameX.Runtime.GameFrameworkCompression.Decompress(stream, decompressedStream);

            [System.Obsolete("已迁移至 ICompressionHelper，此兼容别名计划于 3.0.0 移除")]
            [UnityEngine.Scripting.Preserve]
            public partial interface ICompressionHelper : global::GameFrameX.Runtime.GameFrameworkCompression.ICompressionHelper
            {
            }
        }
        [System.Obsolete("已迁移至 FileUtility，此兼容别名计划于 3.0.0 移除")]
        [UnityEngine.Scripting.Preserve]
        public static partial class File
        {
            [UnityEngine.Scripting.Preserve]
            public static string GetBytesSize(long size) => global::GameFrameX.Runtime.FileUtility.GetBytesSize(size);

        }
    }
}

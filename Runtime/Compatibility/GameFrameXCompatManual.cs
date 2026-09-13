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
//  完整许可证文本请参见源代码根目录的 LICENSE 文件。
//  please refer to the LICENSE file in the root directory of the source code for the full license text.
//
//  禁止利用本项目实施任何危害国家安全、破坏社会秩序、
//  It is prohibited to use this project to engage in any activities that endanger national security, disrupt social order,
//  侵犯他人合法权益等法律法规所禁止的行为！
//  or infringe upon the legal rights and interests of others, as prohibited by laws and regulations.
//  因基于本项目二次开发所产生的一切法律纠纷与责任，
//  Any legal disputes or liabilities arising from secondary development based on this project
//  本组织与贡献者概不承担。
//  shall be borne solely by the developer; the project organization and contributors assume no responsibility.
//
//  GitHub 仓库：https://github.com/GameFrameX
//  GitHub Repository: https://github.com/GameFrameX
//  Gitee  仓库：https://gitee.com/GameFrameX
//  Gitee Repository: https://gitee.com/GameFrameX
//  CNB  仓库：https://cnb.cool/GameFrameX
//  CNB Repository: https://cnb.cool/GameFrameX
//  官方文档：https://gameframex.doc.alianblank.com/
//  Official Documentation: https://gameframex.doc.alianblank.com/
// ==========================================================================================

// =============================================================================
// 迁移兼容层（手写部分）：
//   1. GameObjectHelper.Create 重载（同名双重载无法自动生成，转发至 CreateChild）
//   2. DoTweenHelper（整体位于条件编译内，转发至 DoTweenUtility）
// 已标记 [System.Obsolete]，计划于 3.0.0 移除；请尽快迁移到新 API。
// =============================================================================

#pragma warning disable CS1591

using UnityEngine;

namespace GameFrameX.Runtime
{
    /// <summary>
    /// 已迁移至 <see cref="UnityEngineGameObjectExtension"/>，此兼容别名计划于 3.0.0 移除。
    /// </summary>
    // 类级 [Obsolete]/[Preserve] 由生成侧 GameFrameXCompatHelper.cs 提供，partial 不得重复声明
    public static partial class GameObjectHelper
    {
        /// <summary>创建游戏对象（挂到指定父节点下）。等价于 <c>parent.CreateChild(name)</c>。</summary>
        [UnityEngine.Scripting.Preserve]
        public static GameObject Create(Transform parent, string name) => global::GameFrameX.Runtime.UnityEngineTransformExtension.CreateChild(parent, name);

        /// <summary>创建游戏对象（挂到指定父游戏对象下）。等价于 <c>parent.CreateChild(name)</c>。</summary>
        [UnityEngine.Scripting.Preserve]
        public static GameObject Create(GameObject parent, string name) => global::GameFrameX.Runtime.UnityEngineGameObjectExtension.CreateChild(parent, name);
    }
}

#if ENABLE_GAME_FRAME_X_DO_TWEEN
// -----------------------------------------------------------------------------
// DoTweenHelper -> DoTweenUtility（成员逐一转发）
// -----------------------------------------------------------------------------
#pragma warning disable CS1591

namespace GameFrameX.Runtime
{
    using DG.Tweening;
    using UnityEngine;

    /// <summary>
    /// 已迁移至 <see cref="DoTweenUtility"/>，此兼容别名计划于 3.0.0 移除。
    /// </summary>
    [System.Obsolete("已迁移至 DoTweenUtility，此兼容别名计划于 3.0.0 移除")]
    [UnityEngine.Scripting.Preserve]
    public static partial class DoTweenHelper
    {
        /// <inheritdoc cref="DoTweenUtility.Kill(GameObject, bool)"/>
        [UnityEngine.Scripting.Preserve]
        public static void Kill(GameObject gameObject, bool complete = false) => DoTweenUtility.Kill(gameObject, complete);

        /// <inheritdoc cref="DoTweenUtility.To(float, float, float, Action{float})"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(float startValue, float endValue, float time, System.Action<float> update) => DoTweenUtility.To(startValue, endValue, time, update);

        /// <inheritdoc cref="DoTweenUtility.To(int, int, float, Action{int})"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(int startValue, int endValue, float time, System.Action<int> update) => DoTweenUtility.To(startValue, endValue, time, update);

        /// <inheritdoc cref="DoTweenUtility.To(uint, uint, float, Action{uint})"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(uint startValue, uint endValue, float time, System.Action<uint> update) => DoTweenUtility.To(startValue, endValue, time, update);

        /// <inheritdoc cref="DoTweenUtility.To(long, long, float, Action{long})"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(long startValue, long endValue, float time, System.Action<long> update) => DoTweenUtility.To(startValue, endValue, time, update);

        /// <inheritdoc cref="DoTweenUtility.To(ulong, ulong, float, Action{ulong})"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(ulong startValue, ulong endValue, float time, System.Action<ulong> update) => DoTweenUtility.To(startValue, endValue, time, update);

        /// <inheritdoc cref="DoTweenUtility.To(float, float, float, Action{float}, Action)"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(float startValue, float endValue, float time, System.Action<float> update, System.Action complete) => DoTweenUtility.To(startValue, endValue, time, update, complete);

        /// <inheritdoc cref="DoTweenUtility.To(Vector3, Vector3, float, Action{Vector3})"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(Vector3 startValue, Vector3 endValue, float time, System.Action<Vector3> update) => DoTweenUtility.To(startValue, endValue, time, update);

        /// <inheritdoc cref="DoTweenUtility.To(Vector3, Vector3, float, Action{Vector3}, Action)"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(Vector3 startValue, Vector3 endValue, float time, System.Action<Vector3> update, System.Action complete) => DoTweenUtility.To(startValue, endValue, time, update, complete);

        /// <inheritdoc cref="DoTweenUtility.To(Vector3Int, Vector3Int, float, Action{Vector3Int})"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(Vector3Int startValue, Vector3Int endValue, float time, System.Action<Vector3Int> update) => DoTweenUtility.To(startValue, endValue, time, update);

        /// <inheritdoc cref="DoTweenUtility.To(Vector2, Vector2, float, Action{Vector2})"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(Vector2 startValue, Vector2 endValue, float time, System.Action<Vector2> update) => DoTweenUtility.To(startValue, endValue, time, update);

        /// <inheritdoc cref="DoTweenUtility.To(Vector2, Vector2, float, Action{Vector2}, Action)"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(Vector2 startValue, Vector2 endValue, float time, System.Action<Vector2> update, System.Action complete) => DoTweenUtility.To(startValue, endValue, time, update, complete);

        /// <inheritdoc cref="DoTweenUtility.To(Vector2Int, Vector2Int, float, Action{Vector2Int})"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(Vector2Int startValue, Vector2Int endValue, float time, System.Action<Vector2Int> update) => DoTweenUtility.To(startValue, endValue, time, update);

        /// <inheritdoc cref="DoTweenUtility.To(Vector2Int, Vector2Int, float, Action{Vector2Int}, Action)"/>
        [UnityEngine.Scripting.Preserve]
        public static Tweener To(Vector2Int startValue, Vector2Int endValue, float time, System.Action<Vector2Int> update, System.Action complete) => DoTweenUtility.To(startValue, endValue, time, update, complete);
    }
}
#endif

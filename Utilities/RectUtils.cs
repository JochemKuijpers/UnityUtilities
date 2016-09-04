using UnityEngine;

namespace Utilities
{
    public class RectUtils
    {
        /// <summary>
        /// Scales the rect from the origin point
        /// </summary>
        /// <param name="rect">rect</param>
        /// <param name="factor">scale factor</param>
        /// <returns>new rect</returns>
        public static Rect ScaleFromOrigin(Rect rect, float factor)
        {
            return new Rect(rect.position * factor, rect.size * factor);
        }

        /// <summary>
        /// Scales the rect from the origin point
        /// </summary>
        /// <param name="rect">rect</param>
        /// <param name="factor">scale factor vector</param>
        /// <returns>new rect</returns>
        public static Rect ScaleFromOrigin(Rect rect, Vector2 factor)
        {
            return new Rect(rect.x * factor.x, rect.y * factor.y, rect.width * factor.x, rect.height * factor.y);
        }

        /// <summary>
        /// Scales the rect from it's senter point
        /// </summary>
        /// <param name="rect">rect</param>
        /// <param name="factor">scale factor</param>
        /// <returns>new rect</returns>
        public static Rect ScaleFromCenter(Rect rect, float factor)
        {
            return new Rect(rect.x - (factor * rect.width - rect.width) / 2, rect.y - (factor * rect.height - rect.height) / 2,
                rect.width * factor, rect.height * factor);
        }

        /// <summary>
        /// Scales the rect from it's senter point
        /// </summary>
        /// <param name="rect">rect</param>
        /// <param name="factor">scale factor vector</param>
        /// <returns>new rect</returns>
        public static Rect ScaleFromCenter(Rect rect, Vector2 factor)
        {
            return new Rect(rect.x - (factor.x * rect.width - rect.width) / 2, rect.y - (factor.y * rect.height - rect.height) / 2,
                rect.width * factor.x, rect.height * factor.y);
        }

        /// <summary>
        /// Translates the rect by a given vector
        /// </summary>
        /// <param name="rect">rect</param>
        /// <param name="translation">translation vector</param>
        /// <returns>new rect</returns>
        public static Rect Translate(Rect rect, Vector2 translation)
        {
            return new Rect(rect.position + translation, rect.size);
        }

        /// <summary>
        /// Sets the position of the rectangle
        /// </summary>
        /// <param name="rect">rect</param>
        /// <param name="position">position</param>
        /// <returns>new rect</returns>
        public static Rect TranslateTo(Rect rect, Vector2 position)
        {
            return new Rect(position, rect.size);
        }

        /// <summary>
        /// Calculates the aspect ratio (w/h) of the rect, returns -1 if zero height
        /// </summary>
        /// <param name="rect">rect</param>
        /// <returns>aspect ratio (width/height) or -1</returns>
        public static float AspectRatio(Rect rect)
        {
            if (rect.height != 0)
                return rect.width / rect.height;
            return -1;
        }
    }
}

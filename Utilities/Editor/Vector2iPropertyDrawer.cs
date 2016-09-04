using UnityEngine;
using UnityEditor;

namespace Utilities
{
    [CustomPropertyDrawer(typeof(Vector2i))]
    public class Vector2iPropertyDrawer : PropertyDrawer
    {
        void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            SerializedProperty x = property.FindPropertyRelative("x");
            SerializedProperty y = property.FindPropertyRelative("y");

            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            Rect left = new Rect(position.position, new Vector2(position.width/2, position.height));
            Rect right = new Rect(position.position + new Vector2(position.width / 2, 0), new Vector2(position.width / 2, position.height));

            EditorGUI.PropertyField(left, x, new GUIContent("X"));
            EditorGUI.PropertyField(right, y, new GUIContent("Y"));

            EditorGUI.EndProperty();
        }
    }
}
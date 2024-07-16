using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach (char character in s) {
            if (character == '{' || character == '(' || character == '[') {
                stack.Push(character);
            } else {
                if (stack.Count == 0) {
                    return false;
                }
                char top = stack.Pop();
                if ((character == ')' && top != '(') ||
                    (character == '}' && top != '{') ||
                    (character == ']' && top != '[')) {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}

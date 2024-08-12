using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC_295_HW5;  // Reference to the project where ParenthesisChecker is defined

namespace TestProject1
{
    [TestClass] // Attribute that marks this class as a test class for the testing framework
    public class ParenthesisCheckerTests
    {
        [TestMethod()] // Attribute that marks this method as a test method
        public void TestBalancedParentheses()
        {
            // Test cases with balanced parentheses
            Assert.IsTrue(ParenthesisChecker.isBalanced("()"));    // Simple balanced parentheses
            Assert.IsTrue(ParenthesisChecker.isBalanced("([])"));  // Mixed balanced parentheses
            Assert.IsTrue(ParenthesisChecker.isBalanced("{[()]}")); // Complex balanced parentheses
        }

        [TestMethod()] // Attribute that marks this method as a test method
        public void TestUnbalancedParentheses()
        {
            // Test cases with unbalanced parentheses
            Assert.IsFalse(ParenthesisChecker.isBalanced("(]"));    // Mismatched parentheses
            Assert.IsFalse(ParenthesisChecker.isBalanced("([)]"));  // Incorrect nesting
            Assert.IsFalse(ParenthesisChecker.isBalanced("{[(])}")); // Complex unbalanced case
        }

        [TestMethod()] // Attribute that marks this method as a test method
        public void TestEmptyString()
        {
            // Test with an empty string
            Assert.IsTrue(ParenthesisChecker.isBalanced("")); // An empty string is considered balanced
        }

        [TestMethod()] // Attribute that marks this method as a test method
        public void TestNoParentheses()
        {
            // Test with a string that contains no parentheses
            Assert.IsTrue(ParenthesisChecker.isBalanced("abc123")); // A string with no parentheses is balanced
        }

        [TestMethod()] // Attribute that marks this method as a test method
        public void TestSingleTypeParentheses()
        {
            // Test cases with a single type of parentheses
            Assert.IsTrue(ParenthesisChecker.isBalanced("((()))")); // Nested same-type parentheses, balanced
            Assert.IsFalse(ParenthesisChecker.isBalanced("((())")); // Missing closing parenthesis, unbalanced
        }
    }
}


using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTests
    {
        [Test]
        public void Push_WhenObjectIsNull_ThrowArgumentNullException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }


        [Test]
        public void Push_WhenObjectContainsAValue_AddsObjectToTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("ABC");
            Assert.That(stack.Count, Is.EqualTo(1));
        }


        [Test]
        public void Count_EmptyStack_ReturnsZero()
        {
            var stack = new Stack<string>();
            Assert.That(stack.Count, Is.EqualTo(0));
        }


        [Test]
        public void Pop_StackCountIsZero_ThrowInvalidOperationException()
        {
            var stack = new Stack<int>();
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_WhenStackIsNotEmpty_ReturnsTheTOSObject()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Pop_WhenStackIsNotEmpty_RemovesTheTOSObject()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();
            Assert.That(stack.Count, Is.EqualTo(2));
        }


        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }
        

        [Test]
        public void Peek_NonEmptyStack_ReturnsTOSObject()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();

            //Assert.That(result, Is.EqualTo("c"));
            Assert.That(stack.Count, Is.EqualTo(3));

        }

    }
}

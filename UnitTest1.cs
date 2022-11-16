using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckOne()
        {
            Student student = new Student();

            student.Score = 8.0;
            char grade = student.getLetterScore();
            Assert.AreEqual('A', grade);
        }

        [TestMethod]
        public void CheckTwo()
        {
            Student student = new Student();

            student.Score = 7.0;
            char grade = student.getLetterScore();
            Assert.AreEqual('B', grade);
        }

        public void CheckThree()
        {
            Student student = new Student();

            student.Score = 5.0;
            char grade = student.getLetterScore();
            Assert.AreEqual('C', grade);
        }

        public void CheckFour()
        {
            Student student = new Student();

            student.Score = 3.5;
            char grade = student.getLetterScore();
            Assert.AreEqual('D', grade);
        }
    }
}
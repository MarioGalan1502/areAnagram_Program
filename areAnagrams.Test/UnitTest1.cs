using NUnit.Framework;

namespace areAnagrams.Test
{
    public class Tests
    {
       
        [Test]
        public void isAnagram_word1_isNull_throw_NullException()
        {
            checkAnagrams check = new checkAnagrams();

            Assert.That(() =>  check.isAnagram(null, "omar"),Throws.ArgumentNullException);
        }

        [Test]
        public void isAnagram_word2_isNull_throw_NullException()
        {
            checkAnagrams check = new checkAnagrams();

            Assert.That(() =>  check.isAnagram("ramo", null),Throws.ArgumentNullException);
        }

        [Test]
        public void isAnagram_bothWords_areNull_throw_NullException()
        {
            checkAnagrams check = new checkAnagrams();

            Assert.That(() =>  check.isAnagram(null, null),Throws.ArgumentNullException);
        }

         [Test]
        public void isAnagram_withAnagrams_return_true()
        {
            checkAnagrams check = new checkAnagrams();

            Assert.That(() =>  check.isAnagram("ramo", "omar"),Is.True);
        }

        [Test]
        public void isAnagram_no_Anagrams_return_false()
        {
            checkAnagrams check = new checkAnagrams();

            Assert.That(() =>  check.isAnagram("ramos", "omari"),Is.False);
        }

        [Test]
        public void isAnagram_isNot_a_Word_throw_ArgumentException()
        {
            checkAnagrams check = new checkAnagrams();

            Assert.That(() =>  check.isAnagram("123", "456"),Throws.ArgumentException.And.Message.EqualTo("no se introdujo una palabra"));
        }

        



    }
}
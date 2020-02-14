using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTest
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent Content = new StreamingContent();
            Content.Title = "Mongol";

            string expected = "Mongol";
            string actual = Content.Title;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void SetLanguage_ShouldBeCorrectLanguage()
        {
            StreamingContent content = new StreamingContent();
            content.Language = "Mongolian";

            string expected = "Mongolian";
            string actual = content.Language;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContentRating_shouldbecorrectcontentrating()
        {
            StreamingContent content = new StreamingContent();
            content.Rating = ContentRatings.R;

            ContentRatings actual = ContentRatings.R;
            ContentRatings expected = content.Rating;
        }
        [DataTestMethod]
        [DataRow(ContentRatings.G,true )]
        [DataRow(ContentRatings.R, true)]

        public void SetMaturityRating_shouldbecorrectisfamilyfriendly(ContentRatings rating, bool isFriendly)//arrange act assert
        {
            StreamingContent content = new StreamingContent("Content Genre","Content Title",4, StreamingQualityType.FHD1080, "content description","content language",rating );
            bool actual = content.IsFamilyFriendly;
            bool expected = isFriendly;

            Assert.AreEqual(expected, actual);
        }
    }
}
